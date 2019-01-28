using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ContentTracker
{
    /// <summary>
    ///     This control allows a user to specify a homework priority and create a check list of things for them to do.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class PriorityHomeworkTracker : UserControl
    {
        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="PriorityHomeworkTracker" /> class.
        /// </summary>
        public PriorityHomeworkTracker()
        {
            this.InitializeComponent();
        }

        #endregion

        #region Methods

        /// <summary>
        ///     Occurs when [control changed].
        /// </summary>
        public event EventHandler ControlChanged;

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
                var cell = (DataGridViewCheckBoxCell) dataGridRow.Cells[0];
                cell.Value = true;
            }
        }

        private void uncheckAllTaskBoxes()
        {
            foreach (DataGridViewRow dataGridRow in this.TaskGridView.Rows)
            {
                var cell = (DataGridViewCheckBoxCell) dataGridRow.Cells[0];
                cell.Value = false;
            }
        }

        /// <summary>
        ///     Determines the tag value of the control which changed depending on which radio button is selected.
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

            Tag = tagValue;
        }

        /// <summary>
        ///     Gets the checked items in the homework tracker.
        /// </summary>
        /// <returns>
        ///     A list containing all of the checked items.
        /// </returns>
        public List<string> GetCheckedItems()
        {
            var checkBoxIndex = 0;
            var textBoxIndex = 1;
            var returnList = new List<string>();

            foreach (DataGridViewRow currentRow in this.TaskGridView.Rows)
            {
                var currentCells = currentRow.Cells;
                var checkBoxCell = (DataGridViewCheckBoxCell) currentCells[checkBoxIndex];
                var textCell = (DataGridViewTextBoxCell) currentCells[textBoxIndex];

                var isChecked = checkBoxCell.FormattedValue != null &&
                                bool.Parse(checkBoxCell.FormattedValue.ToString());
                var textValue = string.Empty;
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

        /// <summary>
        ///     Creates new row in the homework tracker.
        /// </summary>
        /// <param name="isChecked">if set to <c>true</c> [is checked].</param>
        /// <param name="textValue">The text value.</param>
        public void InsertNewRow(bool isChecked, string textValue)
        {
            var newRow = (DataGridViewRow) this.TaskGridView.Rows[0].Clone();
            newRow.Cells[0].Value = isChecked;
            newRow.Cells[1].Value = textValue;

            this.TaskGridView.Rows.Add(newRow);
        }

        /// <summary>
        ///     Clears the rows in the homework tracker.
        /// </summary>
        public void ClearRows()
        {
            this.TaskGridView.Rows.Clear();
        }

        #endregion
    }
}