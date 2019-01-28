using System.Collections.Generic;
using System.Text;
using HomeworkTracker.Main;

namespace HomeworkTracker.View.Output
{
    /// <summary>
    /// Handles building the output for the homework tracker.
    /// </summary>
    public class OutputBuilder
    {
        private const string LowPriorityHeader = "Low priority class(es):";
        private const string MediumPriorityHeader = "Medium priority class(es):";
        private const string HighPriorityHeader = "High priority class(es):";
        private const string SectionSeparator = "--------------------";
        private readonly StringBuilder outputStringBuilder = new StringBuilder();
        private readonly StringBuilder lowPriorityStringBuilder = new StringBuilder();
        private readonly StringBuilder mediumPriorityStringBuilder = new StringBuilder();
        private readonly StringBuilder highPriorityStringBuilder = new StringBuilder();


        /// <summary>
        /// Builds the full output.
        /// </summary>
        /// <param name="tabTasks">The tab tasks.</param>
        /// <returns>
        /// A string containing the full text output ready to be used.
        /// </returns>
        public string BuildFullOutput(List<TaskKeeper> tabTasks)
        {
            this.buildBasicOutput();

            foreach (var currentKeeper in tabTasks)
            {
                this.buildPriorityOutput(currentKeeper);
            }

            if (this.highPriorityStringBuilder.Length != 48)
            {
                this.outputStringBuilder.AppendLine(this.highPriorityStringBuilder.ToString());
            }

            if (this.mediumPriorityStringBuilder.Length != 50)
            {
                this.outputStringBuilder.AppendLine(this.mediumPriorityStringBuilder.ToString());
            }

            if (this.lowPriorityStringBuilder.Length != 47)
            {
                this.outputStringBuilder.AppendLine(this.lowPriorityStringBuilder.ToString());
            }

            
            
            

            return this.outputStringBuilder.ToString();

        }

        private void buildBasicOutput()
        {

            this.highPriorityStringBuilder.AppendLine(HighPriorityHeader);
            this.highPriorityStringBuilder.AppendLine(SectionSeparator);

            this.mediumPriorityStringBuilder.AppendLine(MediumPriorityHeader);
            this.mediumPriorityStringBuilder.AppendLine(SectionSeparator);

            this.lowPriorityStringBuilder.AppendLine(LowPriorityHeader);
            this.lowPriorityStringBuilder.AppendLine(SectionSeparator);
        }

        private void buildPriorityOutput(TaskKeeper currentTaskKeeper)
        {
            RadioState classPriority = currentTaskKeeper.TaskPriority;
            var classString = "Class: " + currentTaskKeeper.ClassName;

            if (classPriority == RadioState.Low)
            {
                this.lowPriorityStringBuilder.AppendLine(classString);
                foreach (var currentString in currentTaskKeeper.TaskCollection)
                {
                    this.lowPriorityStringBuilder.AppendLine(currentString);
                }

            }

            if (classPriority == RadioState.Medium)
            {
                this.mediumPriorityStringBuilder.AppendLine(classString);
                foreach (var currentString in currentTaskKeeper.TaskCollection)
                {
                    this.mediumPriorityStringBuilder.AppendLine(currentString);
                }

            }

            if (classPriority == RadioState.High)
            {
                this.highPriorityStringBuilder.AppendLine(classString);
                foreach (var currentString in currentTaskKeeper.TaskCollection)
                {
                    this.highPriorityStringBuilder.AppendLine(currentString);
                }

            }
        }


    }
}