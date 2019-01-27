using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ContentTracker
{
    public partial class PriorityHomeworkTracker: UserControl
    {

        public event EventHandler ControlChanged;

        public PriorityHomeworkTracker()
        {
            this.InitializeComponent();
        }

        private void onControlChanged()
        {
            this.DetermineTagValue();
            this.ControlChanged?.Invoke(this, EventArgs.Empty);
        }

        private void checkAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.checkAllTaskBoxes();
        }

        private void uncheckAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.uncheckAllTaskBoxes();
        }

        private void triggerUserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            this.onControlChanged();
        }

        private void triggerUserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            this.onControlChanged();
        }

        private void priorityRadioChanged(object sender, EventArgs e)
        {
            this.onControlChanged();
        }

        private void TaskGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            this.onControlChanged();
        }

        private void checkAllTaskBoxes()
        {
            foreach (DataGridViewRow dataGridRow in this.TaskGridView.Rows)
            {
                DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell) dataGridRow.Cells[0];
                cell.Value = true;
            }
        }

        private void uncheckAllTaskBoxes()
        {
            foreach (DataGridViewRow dataGridRow in this.TaskGridView.Rows)
            {
                DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)dataGridRow.Cells[0];
                cell.Value = false;
            }
        }

        /// <summary>
        /// Determines the tag value of the control which changed depending on which radio button is selected.
        /// </summary>
        public void DetermineTagValue()
        {
            object tagValue = null;
            if (this.lowPriorityRadio.Checked)
            {
                tagValue = this.lowPriorityRadio.Tag;
            }

            if (this.mediumPriorityRadio.Checked)
            {
                tagValue = this.mediumPriorityRadio.Tag;
            }

            if (this.highPriorityRadio.Checked)
            {
                tagValue = this.highPriorityRadio.Tag;
            }

            this.Tag = tagValue;
        }

        public DataGridView GetTaskView()
        {
            return this.TaskGridView;
        }

        public List<string> GetCheckedItems()
        {
            var checkBoxIndex = 0;
            var textBoxIndex = 1;
            List<string> returnList = new List<string>();

            foreach (DataGridViewRow currentRow in this.TaskGridView.Rows)
            {
                var currentCells = currentRow.Cells;
                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell) currentCells[checkBoxIndex];
                DataGridViewTextBoxCell textCell = (DataGridViewTextBoxCell) currentCells[textBoxIndex];

                bool isChecked = checkBoxCell.FormattedValue != null && bool.Parse(checkBoxCell.FormattedValue.ToString());
                string textValue = string.Empty;
                if (textCell.FormattedValue != null)
                {
                    textValue = textCell.FormattedValue.ToString();
                }

                if (!isChecked)
                {
                    returnList.Add(textValue);
                }
            }

            return returnList;
        }


    }
}
