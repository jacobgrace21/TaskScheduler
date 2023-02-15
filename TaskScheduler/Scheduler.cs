/*
 * Scheduler.cs
 * Author: Jacob Grace
 */

 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Data;

namespace Ksu.Cis300.TaskScheduler
{
    public class Scheduler
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UserInterface());
        }
        /// <summary>
        /// Property to keep track of the workers in the queue
        /// </summary>
        public WorkerQueue Workers;

        /// <summary>
        /// Array of strings to keep track of the tasks
        /// </summary>
        public String[] TaskNames;

        /// <summary>
        /// int to keep track of the amount of workers left unscheduled
        /// </summary>
        public int UnScheduled;

        /// <summary>
        /// Int to keep track of the most tasks scheduled to one worker
        /// </summary>
        public int HighestAssigned;

        /// <summary>
        /// Double to keep track of the average tasks assigned to workers
        /// </summary>
        public double AvgAssigned;

        /// <summary>
        /// Reads the inputs of the schedule data and updates the workers
        /// </summary>
        /// <param name="fn">File to read from</param>
        private void ReadInput(string fn)
        {
            try
            {
                using (StreamReader reader = new StreamReader(fn))
                {
                    string line;
                    String[] firstField;
                    int num = 0;
                    while ((line = reader.ReadLine()) != null)
                    {
                        
                        firstField = line.Split(',');
                        string[] info = new string[firstField.Length - 1];
                        if(firstField == null)
                        {
                            throw new IOException("Invalid File Format: The file input is empty.");
                        }
                        if(firstField.Length < 2)
                        {
                            throw new IOException("Invalid File Format: The input file must contain at least one task.");
                        }
                        if(num != 0 && num == firstField.Length )
                        {
                            throw new IOException("Invalid File Format: Not all lines have the same number of fields.");
                        }

                        for (int i =1; i < firstField.Length; i ++)
                        {
                            info[i - 1] = firstField[i];
                            Worker worker = new Worker(info);

                            Workers.Enqueue(worker);
                        }

                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        /// <summary>
        /// Computes the stats of the schedule
        /// </summary>
        private void ComputeScheduleStats()
        {
            int highestNum = 0;
            double avgCount = 0;
            double tasksScheduled = 0;
            int unScheduled = 0;
            Worker worker;
            for(int i = 0; i < Workers.NumElements; i++)
            {
                worker = Workers.Dequeue();
                if(worker.numScheduled == 0)
                {
                    unScheduled += 1;
                }
                else if(worker.numScheduled > 0)
                {
                    tasksScheduled += worker.numScheduled;
                    if( worker.numScheduled > highestNum)
                    {
                        highestNum = worker.numScheduled;
                    }
                }
                Workers.Enqueue(worker);
            }
            avgCount = Math.Round((tasksScheduled / Workers.NumElements));
            UnScheduled = unScheduled;
            HighestAssigned = highestNum;
            AvgAssigned = avgCount;
        }
        /// <summary>
        /// Constructor for the scheduler class
        /// </summary>
        /// <param name="fn">File name to read from</param>
        public Scheduler(String fn)
        {
            ReadInput(fn);
        }
        /// <summary>
        /// Gets a raw schedule to be used 
        /// </summary>
        /// <returns>Raw Schedule</returns>
        public DataTable GetRawScheduleData()
        {
            DataTable data = new DataTable();
            data.Columns.Add("Name");
            WorkerQueue tempQueue = Workers;
            Worker worker;
            for(int i = 0; i < TaskNames.Length; i++)
            {
                data.Columns.Add(TaskNames[i]);
            }
            for(int j = 0; j < Workers.NumElements; j++)
            {
                worker = tempQueue.Dequeue();
                string[] info = new string[TaskNames.Length + 1];
                info[0] = worker.Name;
                for(int i = 0; i < TaskNames.Length; i++)
                {

                    if (worker.IsQualified(i))
                    {
                        info[i + 1] = "X";
                    }
                    else
                    {
                        info[i + 1] = ("");
                    }
                }
                data.Rows.Add(info);
                tempQueue.Enqueue(worker);
            }
            return data;
        }
        /// <summary>
        /// Computes a schedule with assigned workers
        /// </summary>
        /// <param name="days">Days for the schedule to be used</param>
        /// <returns>Filled out schedule</returns>
        public DataTable ComputeSchedule(int days)
        {
            UnScheduled = 0;
            HighestAssigned = 0;
            AvgAssigned = 0;
            for(int i = 0; i < Workers.NumElements; i ++)
            {
                Worker temp;
                temp = Workers.Dequeue();
                temp.numScheduled = 0;
                Workers.Enqueue(temp);
            }
            DataTable data = new DataTable();
            data.Columns.Add("Day");
            Worker worker;
            for (int i = 0; i < TaskNames.Length; i++)
            {
                data.Columns.Add(TaskNames[i]);
            }

            for (int i = 0; i < days; i++)
            {
                
                string[] info = new string[TaskNames.Length + 1];
                info[0] = "Day" + (i + 1);

                for (int j = 0; j < TaskNames.Length; j++)
                {
                    worker = Workers.GetFirstQualified(j);
                    if (worker != null)
                    {
                        info[j + 1] = worker.Name;
                        worker.numScheduled++;
                        Workers.Enqueue(worker);
                    }

                    else
                    {
                        info[j + 1] = "NONE";
                    }
                }
                data.Rows.Add(info);
            }
            ComputeScheduleStats();
            return data;
        }

    }
}
