using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ContentTracker;
using HomeworkTracker.Main;
using HomeworkTracker.View.Output;

namespace HomeworkTracker.View
{
    public partial class HomeworkTrackerForm : Form
    {
        private RadioState firstTabState = RadioState.Low;
        private RadioState secondTabState = RadioState.Low;
        private RadioState thirdTabState = RadioState.Low;

        private Dictionary<string, PriorityHomeworkTracker> tabControlDictionary = new Dictionary<string, PriorityHomeworkTracker>();

        private List<TaskKeeper> taskCollection = new List<TaskKeeper>();


        public HomeworkTrackerForm()
        {
            this.InitializeComponent();
            this.firstTabHomeworkTracker.ControlChanged += this.processControlChange;
            this.secondTabHomeworkTracker.ControlChanged += this.processControlChange;
            this.thirdTabHomeworkTracker.ControlChanged += this.processControlChange;
            this.classTabControl.DrawItem += this.classTabControl_DrawItem;
            this.populateTabDictionary();
            this.updateOutput();
        }

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


            TabPage page = this.classTabControl.TabPages[e.Index];

            e.Graphics.FillRectangle(new SolidBrush(currentTabColor), e.Bounds);

            Rectangle paddedBounds = e.Bounds;
            int yOffset = (e.State == DrawItemState.Selected) ? -2 : 1;
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
            RadioState returnState = RadioState.Low;
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
                RadioState currentTrackerState = (RadioState) currentTrackerTagValue;
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
            OutputBuilder newOutput = new OutputBuilder();
            var outPutString = newOutput.BuildFullOutput(this.taskCollection);
            this.outputTextBox.Text = outPutString;
        }

    }
}
