using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ContentTracker;
using HomeworkTracker.IO;
using HomeworkTracker.Main;
using HomeworkTracker.View.Output;

namespace HomeworkTracker.View
{
    /// <summary>
    ///     Handles the creation and showing of the MainWindow of the application.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class HomeworkTrackerForm : Form
    {
        #region Data members

        private RadioState firstTabState = RadioState.Low;
        private RadioState secondTabState = RadioState.Low;
        private RadioState thirdTabState = RadioState.Low;

        private readonly Dictionary<string, PriorityHomeworkTracker> tabControlDictionary =
            new Dictionary<string, PriorityHomeworkTracker>();

        private List<TaskKeeper> taskCollection = new List<TaskKeeper>();

        #endregion

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="HomeworkTrackerForm" /> class.
        /// </summary>
        public HomeworkTrackerForm()
        {
            this.InitializeComponent();
            this.firstTabHomeworkTracker.ControlChanged += this.processControlChange;
            this.secondTabHomeworkTracker.ControlChanged += this.processControlChange;
            this.thirdTabHomeworkTracker.ControlChanged += this.processControlChange;
            this.classTabControl.DrawItem += this.classTabControl_DrawItem;

            this.populateTabDictionary();
            this.buildDefaultOutput();
            this.updateOutput();
        }

        #endregion

        #region Methods

        private void processControlChange(object sender, EventArgs e)
        {
            this.determineHomeworkTrackerTagValues();
            this.determineTabStates();
            this.classTabControl.Invalidate();
            this.buildTaskKeeperCollection();
            this.updateOutput();
        }

        private void classTabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            var currentTabState = this.getTabRadioState(e.Index);
            var currentTabColor = this.determineTabColor(currentTabState);

            var page = this.classTabControl.TabPages[e.Index];

            e.Graphics.FillRectangle(new SolidBrush(currentTabColor), e.Bounds);

            var paddedBounds = e.Bounds;
            var yOffset = e.State == DrawItemState.Selected ? -2 : 1;
            paddedBounds.Offset(1, yOffset);
            TextRenderer.DrawText(e.Graphics, page.Text, Font, paddedBounds, page.ForeColor);
        }

        private void determineTabStates()
        {
            var firstTabTagValue = int.Parse(this.firstTabHomeworkTracker.Tag.ToString());
            var secondTabTagValue = int.Parse(this.secondTabHomeworkTracker.Tag.ToString());
            var thirdTabTagValue = int.Parse(this.thirdTabHomeworkTracker.Tag.ToString());

            this.firstTabState = (RadioState) firstTabTagValue;
            this.secondTabState = (RadioState) secondTabTagValue;
            this.thirdTabState = (RadioState) thirdTabTagValue;
        }

        private Color determineTabColor(RadioState currentState)
        {
            var returnColor = Color.Gray;
            if (currentState == RadioState.Medium)
            {
                returnColor = Color.Yellow;
            }

            if (currentState == RadioState.High)
            {
                returnColor = Color.Red;
            }

            return returnColor;
        }

        private RadioState getTabRadioState(int index)
        {
            var returnState = RadioState.Low;
            if (index == 0)
            {
                returnState = this.firstTabState;
            }

            if (index == 1)
            {
                returnState = this.secondTabState;
            }

            if (index == 2)
            {
                returnState = this.thirdTabState;
            }

            return returnState;
        }

        private void determineHomeworkTrackerTagValues()
        {
            this.firstTabHomeworkTracker.DetermineTagValue();
            this.secondTabHomeworkTracker.DetermineTagValue();
            this.thirdTabHomeworkTracker.DetermineTagValue();
        }

        private void buildTaskKeeperCollection()
        {
            this.taskCollection = new List<TaskKeeper>();
            foreach (var currentKey in this.tabControlDictionary.Keys)
            {
                var currentHomeworkTracker = this.tabControlDictionary[currentKey];
                var currentlySelectedItems = currentHomeworkTracker.GetCheckedItems();
                var currentTrackerTagValue = int.Parse(currentHomeworkTracker.Tag.ToString());
                var currentTrackerState = (RadioState) currentTrackerTagValue;
                var newKeeper = new TaskKeeper(currentKey, currentTrackerState, currentlySelectedItems);
                this.taskCollection.Add(newKeeper);
            }
        }

        private void populateTabDictionary()
        {
            var firstClassName = this.firstClassTab.Text;
            var secondClassName = this.secondClassTab.Text;
            var thirdClassName = this.thirdClassTab.Text;

            this.tabControlDictionary.Add(firstClassName, this.firstTabHomeworkTracker);
            this.tabControlDictionary.Add(secondClassName, this.secondTabHomeworkTracker);
            this.tabControlDictionary.Add(thirdClassName, this.thirdTabHomeworkTracker);
        }

        private void updateOutput()
        {
            var newOutput = new OutputBuilder();
            var outPutString = newOutput.BuildFullOutput(this.taskCollection);
            this.outputTextBox.Text = outPutString;
        }

        private void buildDefaultOutput()
        {
            var firstClassDefaultTask = "Complete Assignment 1.";
            var secondClassDefaultTask = "Read Chapter 3 In HTML For Beginners.";
            var thirdClassDefaultTask = "Have resume printed and laminated by Thursday.";

            this.firstTabHomeworkTracker.InsertNewRow(false, firstClassDefaultTask);
            this.secondTabHomeworkTracker.InsertNewRow(false, secondClassDefaultTask);
            this.thirdTabHomeworkTracker.InsertNewRow(false, thirdClassDefaultTask);
        }

        private void loadHomeworkData(object sender, EventArgs e)
        {
            try
            {
                var homeworkLoader = new HomeworkLoader();

                var loadedData = homeworkLoader.LoadHomeworkTasks();

                var firstTabData = loadedData[0];
                var secondTabData = loadedData[1];
                var thirdTabData = loadedData[2];

                this.clearAllHomeworkTrackers();

                foreach (var currentString in firstTabData)
                {
                    this.firstTabHomeworkTracker.InsertNewRow(false, currentString);
                }

                foreach (var currentString in secondTabData)
                {
                    this.secondTabHomeworkTracker.InsertNewRow(false, currentString);
                }

                foreach (var currentString in thirdTabData)
                {
                    this.thirdTabHomeworkTracker.InsertNewRow(false, currentString);
                }

                this.showSuccessMessage();
            }
            catch (FileNotFoundException)
            {
                this.showFailureMessage();
            }
        }

        private void clearAllHomeworkTrackers()
        {
            this.firstTabHomeworkTracker.ClearRows();
            this.secondTabHomeworkTracker.ClearRows();
            this.thirdTabHomeworkTracker.ClearRows();
        }

        private void saveHomeworkData(object sender, EventArgs e)
        {
            var dataToSave = new List<List<string>>();

            var firstTrackerData = this.firstTabHomeworkTracker.GetCheckedItems();
            var secondTrackerData = this.secondTabHomeworkTracker.GetCheckedItems();
            var thirdTrackerData = this.thirdTabHomeworkTracker.GetCheckedItems();

            dataToSave.Add(firstTrackerData);
            dataToSave.Add(secondTrackerData);
            dataToSave.Add(thirdTrackerData);

            var homeworkSaver = new HomeworkSaver();
            homeworkSaver.SaveHomeworkTasks(dataToSave);

            this.showSuccessMessage();
        }

        private void showSuccessMessage()
        {
            var buttons = MessageBoxButtons.OK;
            var message = "The operation was successful.";
            var caption = "Save/Open Operation";

            MessageBox.Show(message, caption, buttons);
        }

        private void showFailureMessage()
        {
            var buttons = MessageBoxButtons.OK;
            var message = "There is no existing save data.";
            var caption = "Open Operation";

            MessageBox.Show(message, caption, buttons);
        }

        #endregion
    }
}