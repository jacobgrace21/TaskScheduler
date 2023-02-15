/*
 * Worker.cs
 * Jacob Grace
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.TaskScheduler
{
    /// <summary>
    /// Class for the worker
    /// </summary>
    public class Worker
    {
        /// <summary>
        /// Boolean array stating if the worker can work the specified task
        /// </summary>
        private bool[] _qualified;
        /// <summary>
        /// Public property for the worker's name
        /// </summary>
        public string Name;
        /// <summary>
        /// Public int for the amount of times the worker has been scheduled
        /// </summary>
        public int numScheduled;

        /// <summary>
        /// Constructor for the worker class
        /// </summary>
        public Worker(string[] workers)
        {
            for(int i = 0; i < workers.Length; i++)
            {
                if(i == 0)
                {
                    Name = workers[i];
                }
                else
                {
                    if(workers[i].Length > 0)
                    {
                        _qualified[i - 1] = true;
                    }
                    else
                    {
                        _qualified[i - 1] = false;
                    }
                }
            }
        }
        /// <summary>
        /// Determines if a worker is qualified for the task
        /// </summary>
        /// <param name="loc">Location to check for the task in the array of booleans</param>
        /// <returns>Boolean determining if the worker is qualified for the task</returns>
        public bool IsQualified(int loc)
        {
            if(_qualified[loc])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
