/* LinkedListCell.cs
 * Author: Rod Howell
 */

namespace Ksu.Cis300.TaskScheduler
{
    /// <summary>
    /// A single cell of a generic linked list.
    /// </summary>
    /// <typeparam name="T">The type of the data element in this cell.</typeparam>
    public class LinkedListCell<T>
    {
        /// <summary>
        /// Gets or sets the data element.
        /// </summary>
        public T Data
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the next cell in the list.
        /// </summary>
        public LinkedListCell<T> Next
        {
            get;
            set;
        }
    }
}
