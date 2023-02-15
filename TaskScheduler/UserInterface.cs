/*
 * UserInterface.cs
 * Author: Jacob Grace
 */

using System;
using System.IO;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Ksu.Cis300.TaskScheduler
{

    public partial class UserInterface : Form
    {
     
        /// <summary>
        /// Constructs the GUI.
        /// </summary>
        public UserInterface()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Private scheduler for info to be stored
        /// </summary>
        private Scheduler _scheduler;

        /// <summary>
        /// Index for the raw schedule data
        /// </summary>
        private const int _index = 0;

        /// <summary>
        /// Private constant for the computed index 
        /// </summary>
        private const int _computedIndex = 1;

        /// <summary>
        /// Updates the stats shown on the scheduler
        /// </summary>
        private void UpdateStatsMessage()
        {
            double avg = _scheduler.AvgAssigned;
            int high = _scheduler.HighestAssigned;
            int notSch = _scheduler.UnScheduled;

            uxStatsTextBox.Text = "Each worker was scheduled an average of " + avg + " task(s) and at most " + high + " tasks. " + notSch + " worker(s) were not scheduled.";
        }

        private void uxStatsTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Writes the computed schedule to a file that is being saved to
        /// </summary>
        private void WriteComputedScheduleToFile()
        {
            using (StreamWriter writer = new StreamWriter(uxSaveDialog.FileName))
            {
                writer.WriteLine("The highest number of tasks assigned was: " + _scheduler.HighestAssigned + ". The average was "
                    + _scheduler.AvgAssigned + ". The number of workers left unassigned is " + _scheduler.UnScheduled);

                string[] names = new string[_scheduler.Workers.NumElements];
                Worker worker;
                for(int i = 0; i < _scheduler.Workers.NumElements; i++)
                {
                    worker = _scheduler.Workers.Dequeue();
                    names[i] = worker.Name;
                    _scheduler.Workers.Enqueue(worker);
                }

                writer.WriteLine(names);

                DataGridView dataGrid = new DataGridView();
                dataGrid.DataSource = _scheduler.GetRawScheduleData();

                for(int i = 0; i < dataGrid.RowCount; i++)
                {
                    writer.WriteLine(dataGrid.Rows);
                }
                
            }
            
        }
        /// <summary>
        /// Event handler for the GetInputFile button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxGetInputFile_Click(object sender, EventArgs e)
        {
            try
            {
                Scheduler scheduler = new Scheduler(uxOpenDialog.FileName);
                _scheduler = scheduler;
                uxInputFileName.Text = uxOpenDialog.FileName;
                uxInputFileName.SelectionStart = uxInputFileName.Text.Length;

              
                uxScheduleDataGrid.DataSource = _scheduler.GetRawScheduleData();
                uxScheduleView.SelectTab(0);
                uxComputeSchedule.Enabled = true;


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

        }

        private void uxInputFileName_TextChanged(object sender, EventArgs e)
        {

        }

        private void uxComputeSchedule_Click(object sender, EventArgs e)
        {
            try
            {
                uxScheduleDataGrid.DataSource =  _scheduler.ComputeSchedule((int)uxLength.Value);
                Update();
                WriteComputedScheduleToFile();
                uxScheduleView.SelectTab(1);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
