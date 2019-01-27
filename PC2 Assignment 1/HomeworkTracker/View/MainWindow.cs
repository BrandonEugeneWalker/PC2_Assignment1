using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeworkTracker
{
    public partial class homeworkTrackerForm : Form
    {

        private Rectangle tabArea;
        private RectangleF tabTextArea;

        private enum RadioState
        {
            Low = 1,
            Medium = 2,
            High = 3
        };

        private RadioState firstTabState = RadioState.Low;
        private RadioState secondTabState = RadioState.Low;
        private RadioState thirdTabState = RadioState.Low;

        public homeworkTrackerForm()
        {
            this.InitializeComponent();
            this.firstTabHomeworkTracker.ControlChanged += this.processControlChange;
            this.secondTabHomeworkTracker.ControlChanged += this.processControlChange;
            this.thirdTabHomeworkTracker.ControlChanged += this.processControlChange;
            this.classTabControl.DrawItem += this.classTabControl_DrawItem;
        }

        private void processControlChange(object sender, EventArgs e)
        {
            this.determineHomeworkTrackerTagValues();
            this.determineTabStates();
            this.classTabControl.Invalidate();
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

    }
}
