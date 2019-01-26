namespace ContentTracker
{
    partial class PriorityHomeworkTracker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TaskGridView = new System.Windows.Forms.DataGridView();
            this.CheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskGridContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.checkAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uncheckAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priorityGroupBox = new System.Windows.Forms.GroupBox();
            this.lowPriorityRadio = new System.Windows.Forms.RadioButton();
            this.mediumPriorityRadio = new System.Windows.Forms.RadioButton();
            this.highPriorityRadio = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.TaskGridView)).BeginInit();
            this.TaskGridContextMenu.SuspendLayout();
            this.priorityGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TaskGridView
            // 
            this.TaskGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TaskGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckBoxColumn,
            this.TextBoxColumn});
            this.TaskGridView.ContextMenuStrip = this.TaskGridContextMenu;
            this.TaskGridView.Location = new System.Drawing.Point(135, 17);
            this.TaskGridView.Name = "TaskGridView";
            this.TaskGridView.Size = new System.Drawing.Size(379, 256);
            this.TaskGridView.TabIndex = 0;
            this.TaskGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TaskGridView_CellContentClick);
            this.TaskGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.triggerUserAddedRow);
            this.TaskGridView.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.triggerUserDeletedRow);
            // 
            // CheckBoxColumn
            // 
            this.CheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CheckBoxColumn.HeaderText = "Done";
            this.CheckBoxColumn.Name = "CheckBoxColumn";
            this.CheckBoxColumn.Width = 39;
            // 
            // TextBoxColumn
            // 
            this.TextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TextBoxColumn.HeaderText = "Task";
            this.TextBoxColumn.Name = "TextBoxColumn";
            // 
            // TaskGridContextMenu
            // 
            this.TaskGridContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkAllToolStripMenuItem,
            this.uncheckAllToolStripMenuItem});
            this.TaskGridContextMenu.Name = "TaskGridContextMenu";
            this.TaskGridContextMenu.Size = new System.Drawing.Size(138, 48);
            // 
            // checkAllToolStripMenuItem
            // 
            this.checkAllToolStripMenuItem.Name = "checkAllToolStripMenuItem";
            this.checkAllToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.checkAllToolStripMenuItem.Text = "Check All";
            this.checkAllToolStripMenuItem.Click += new System.EventHandler(this.checkAllToolStripMenuItem_Click);
            // 
            // uncheckAllToolStripMenuItem
            // 
            this.uncheckAllToolStripMenuItem.Name = "uncheckAllToolStripMenuItem";
            this.uncheckAllToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.uncheckAllToolStripMenuItem.Text = "Uncheck All";
            this.uncheckAllToolStripMenuItem.Click += new System.EventHandler(this.uncheckAllToolStripMenuItem_Click);
            // 
            // priorityGroupBox
            // 
            this.priorityGroupBox.Controls.Add(this.highPriorityRadio);
            this.priorityGroupBox.Controls.Add(this.mediumPriorityRadio);
            this.priorityGroupBox.Controls.Add(this.lowPriorityRadio);
            this.priorityGroupBox.Location = new System.Drawing.Point(16, 17);
            this.priorityGroupBox.Name = "priorityGroupBox";
            this.priorityGroupBox.Size = new System.Drawing.Size(102, 113);
            this.priorityGroupBox.TabIndex = 1;
            this.priorityGroupBox.TabStop = false;
            this.priorityGroupBox.Text = "Priority";
            // 
            // lowPriorityRadio
            // 
            this.lowPriorityRadio.AutoSize = true;
            this.lowPriorityRadio.Checked = true;
            this.lowPriorityRadio.Location = new System.Drawing.Point(19, 28);
            this.lowPriorityRadio.Name = "lowPriorityRadio";
            this.lowPriorityRadio.Size = new System.Drawing.Size(45, 17);
            this.lowPriorityRadio.TabIndex = 0;
            this.lowPriorityRadio.TabStop = true;
            this.lowPriorityRadio.Text = "Low";
            this.lowPriorityRadio.UseVisualStyleBackColor = true;
            this.lowPriorityRadio.CheckedChanged += new System.EventHandler(this.priorityRadioChanged);
            // 
            // mediumPriorityRadio
            // 
            this.mediumPriorityRadio.AutoSize = true;
            this.mediumPriorityRadio.Location = new System.Drawing.Point(19, 52);
            this.mediumPriorityRadio.Name = "mediumPriorityRadio";
            this.mediumPriorityRadio.Size = new System.Drawing.Size(62, 17);
            this.mediumPriorityRadio.TabIndex = 1;
            this.mediumPriorityRadio.TabStop = true;
            this.mediumPriorityRadio.Text = "Medium";
            this.mediumPriorityRadio.UseVisualStyleBackColor = true;
            this.mediumPriorityRadio.CheckedChanged += new System.EventHandler(this.priorityRadioChanged);
            // 
            // highPriorityRadio
            // 
            this.highPriorityRadio.AutoSize = true;
            this.highPriorityRadio.Location = new System.Drawing.Point(19, 76);
            this.highPriorityRadio.Name = "highPriorityRadio";
            this.highPriorityRadio.Size = new System.Drawing.Size(47, 17);
            this.highPriorityRadio.TabIndex = 2;
            this.highPriorityRadio.TabStop = true;
            this.highPriorityRadio.Text = "High";
            this.highPriorityRadio.UseVisualStyleBackColor = true;
            this.highPriorityRadio.CheckedChanged += new System.EventHandler(this.priorityRadioChanged);
            // 
            // PriorityHomeworkTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.priorityGroupBox);
            this.Controls.Add(this.TaskGridView);
            this.Name = "PriorityHomeworkTracker";
            this.Size = new System.Drawing.Size(539, 297);
            ((System.ComponentModel.ISupportInitialize)(this.TaskGridView)).EndInit();
            this.TaskGridContextMenu.ResumeLayout(false);
            this.priorityGroupBox.ResumeLayout(false);
            this.priorityGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TaskGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip TaskGridContextMenu;
        private System.Windows.Forms.ToolStripMenuItem checkAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uncheckAllToolStripMenuItem;
        private System.Windows.Forms.GroupBox priorityGroupBox;
        private System.Windows.Forms.RadioButton highPriorityRadio;
        private System.Windows.Forms.RadioButton mediumPriorityRadio;
        private System.Windows.Forms.RadioButton lowPriorityRadio;
    }
}
