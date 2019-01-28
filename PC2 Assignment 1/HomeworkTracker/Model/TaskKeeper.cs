using System;
using System.Collections.Generic;
using HomeworkTracker.View;

namespace HomeworkTracker.Model
{
    /// <summary>
    ///     Keeps track of some of the homework tracker data to make it more portable.
    /// </summary>
    public class TaskKeeper
    {
        #region Properties

        /// <summary>
        ///     Gets the name of the class.
        /// </summary>
        /// <value>
        ///     The name of the class.
        /// </value>
        public string ClassName { get; }

        /// <summary>
        ///     Gets the task priority.
        /// </summary>
        /// <value>
        ///     The task priority.
        /// </value>
        public RadioState TaskPriority { get; }

        /// <summary>
        ///     A collection of checked items.
        /// </summary>
        /// <value>
        ///     The task collection.
        /// </value>
        public List<string> TaskCollection { get; }

        #endregion

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="TaskKeeper" /> class.
        /// </summary>
        /// <param name="className">Name of the class.</param>
        /// <param name="taskPriority">The task priority.</param>
        /// <param name="taskCollection">The task collection.</param>
        /// <exception cref="ArgumentNullException">
        /// </exception>
        public TaskKeeper(string className, RadioState taskPriority, List<string> taskCollection)
        {
            this.ClassName = className ?? throw new ArgumentNullException();
            this.TaskPriority = taskPriority;
            this.TaskCollection = taskCollection ?? throw new ArgumentNullException();
        }

        #endregion
    }
}