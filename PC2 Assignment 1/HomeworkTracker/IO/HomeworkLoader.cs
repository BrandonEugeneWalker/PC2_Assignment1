using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace HomeworkTracker.IO
{
    /// <summary>
    ///     Handles loading homework data from a xml file.
    /// </summary>
    public class HomeworkLoader
    {
        #region Methods

        /// <summary>
        ///     Loads the homework tasks from a local xml file.
        /// </summary>
        /// <returns>
        ///     Returns data ready to be used by the program.
        /// </returns>
        /// <exception cref="FileNotFoundException"></exception>
        public List<List<string>> LoadHomeworkTasks()
        {
            var defaultFileName = "UserData.xml";

            var fileExists = File.Exists(defaultFileName);

            if (!fileExists)
            {
                throw new FileNotFoundException();
            }

            var homeworkDeSerializer = new XmlSerializer(typeof(List<List<string>>));

            TextReader reader = new StreamReader(defaultFileName);

            var returnData = (List<List<string>>) homeworkDeSerializer.Deserialize(reader);

            reader.Close();

            return returnData;
        }

        #endregion
    }
}