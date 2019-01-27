using System;
using System.Collections.Generic;

namespace HomeworkTracker.Main
{
    public class TaskKeeper
    {
        public string ClassName { get; }

        public RadioState TaskPriority { get; }

        public List<string> TaskCollection { get; }

        public TaskKeeper(string className, RadioState taskPriority, List<string> taskCollection)
        {
            this.ClassName = className ?? throw new ArgumentNullException();
            this.TaskPriority = taskPriority;
            this.TaskCollection = taskCollection ?? throw new ArgumentNullException();
        }


    }
}