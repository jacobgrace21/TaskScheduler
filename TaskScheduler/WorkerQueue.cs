/*
 * WorkerQueue.Cs
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
    /// Class for the worker queue
    /// </summary>
    public class WorkerQueue
    {
        /// <summary>
        /// Private field for the front cell of the linkedlist
        /// </summary>
        private LinkedListCell<Worker> _front;

        /// <summary>
        /// Private field for the back cell of the linked list
        /// </summary>
        private LinkedListCell<Worker> _back;

        /// <summary>
        /// Gets or sets the number of elements in the list
        /// </summary>
        public int NumElements
        {
            get;
            set;
        }
        /// <summary>
        /// Constructor for the WorkerQueue class
        /// </summary>
        public WorkerQueue()
        {
            LinkedListCell<Worker> startCell = new LinkedListCell<Worker>();
            _front = startCell;
            _back = startCell;
            NumElements = 0;
        }
        /// <summary>
        /// Removes the next Cell in the linked list
        /// </summary>
        /// <param name="cell">Cell to remove the next cell of</param>
        /// <returns>Worker from the cell that was removed</returns>
        private Worker RemoveNext(LinkedListCell<Worker> cell)
        {
            Worker val = cell.Next.Data;
            cell.Next = cell.Next.Next;
            return val;
        }

        /// <summary>
        /// Adds a cell to the back of the list
        /// </summary>
        /// <param name="cell">Cell to add</param>
        public void Enqueue(Worker worker)
        {
            LinkedListCell<Worker> cell = new LinkedListCell<Worker>();
            cell.Data = worker;
            _back.Next = cell;
            _back = cell;
            NumElements++;
        }
        /// <summary>
        /// Removes an element from the front of the queue
        /// </summary>
        public Worker Dequeue()
        {
            if(NumElements == 0)
            {
                throw new InvalidOperationException();
            }
            else
            {
                NumElements--;
                return RemoveNext(_front);
            }
        }
        /// <summary>
        /// Removes and returns the first worker qualified for a task
        /// </summary>
        /// <param name="n">Task to search for</param>
        /// <returns>Worker qualified for the task</returns>
        public Worker GetFirstQualified(int n)
        {
            LinkedListCell<Worker> tempList = _front;
            tempList = tempList.Next;
            LinkedListCell<Worker> holdList = _front;
            for (int i = 0; i < NumElements; i++)
            {
                if(tempList.Data.IsQualified(n))
                {
                   Worker val = RemoveNext(holdList);
                    return val;
                }
                else
                {
                    tempList = tempList.Next;
                    holdList = holdList.Next;
                }

            }
            return null;
        }
    }
}
