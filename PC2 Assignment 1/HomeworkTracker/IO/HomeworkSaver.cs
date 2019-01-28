using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace HomeworkTracker.IO
{
    /// <summary>
    ///     Handles saving the data in the homework tracker to a XML file.
    /// </summary>
    public class HomeworkSaver
    {
        #region Methods

        /// <summary>
        ///     Saves the homework tasks to an xml file.
        /// </summary>
        /// <param name="tasksToSave">The tasks to save.</param>
        public void SaveHomeworkTasks(List<List<string>> tasksToSave)
        {
            var defaultFileName = "UserData.xml";

            var homeworkSerializer = new XmlSerializer(typeof(List<List<string>>));

            TextWriter writer = new StreamWriter(defaultFileName);
            homeworkSerializer.Serialize(writer, tasksToSave);
            writer.Close();
        }

        #endregion
    }
}