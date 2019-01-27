using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void TaskGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
    }
}
