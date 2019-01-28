namespace HomeworkTracker.View
{
    partial class HomeworkTrackerForm
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.classTabControl = new System.Windows.Forms.TabControl();
            this.firstClassTab = new System.Windows.Forms.TabPage();
            this.firstTabHomeworkTracker = new ContentTracker.PriorityHomeworkTracker();
            this.secondClassTab = new System.Windows.Forms.TabPage();
            this.secondTabHomeworkTracker = new ContentTracker.PriorityHomeworkTracker();
            this.thirdClassTab = new System.Windows.Forms.TabPage();
            this.thirdTabHomeworkTracker = new ContentTracker.PriorityHomeworkTracker();
            this.readOnlyTextBox = new System.Windows.Forms.TextBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classTabControl.SuspendLayout();
            this.firstClassTab.SuspendLayout();
            this.secondClassTab.SuspendLayout();
            this.thirdClassTab.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // classTabControl
            // 
            this.classTabControl.Controls.Add(this.firstClassTab);
            this.classTabControl.Controls.Add(this.secondClassTab);
            this.classTabControl.Controls.Add(this.thirdClassTab);
            this.classTabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.classTabControl.Location = new System.Drawing.Point(12, 37);
            this.classTabControl.Name = "classTabControl";
            this.classTabControl.SelectedIndex = 0;
            this.classTabControl.Size = new System.Drawing.Size(559, 343);
            this.classTabControl.TabIndex = 0;
            this.classTabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.classTabControl_DrawItem);
            // 
            // firstClassTab
            // 
            this.firstClassTab.BackColor = System.Drawing.Color.White;
            this.firstClassTab.Controls.Add(this.firstTabHomeworkTracker);
            this.firstClassTab.Location = new System.Drawing.Point(4, 22);
            this.firstClassTab.Name = "firstClassTab";
            this.firstClassTab.Padding = new System.Windows.Forms.Padding(3);
            this.firstClassTab.Size = new System.Drawing.Size(551, 317);
            this.firstClassTab.TabIndex = 0;
            this.firstClassTab.Text = "CS 1301";
            // 
            // firstTabHomeworkTracker
            // 
            this.firstTabHomeworkTracker.BackColor = System.Drawing.Color.Transparent;
            this.firstTabHomeworkTracker.Location = new System.Drawing.Point(6, 6);
            this.firstTabHomeworkTracker.Name = "firstTabHomeworkTracker";
            this.firstTabHomeworkTracker.Size = new System.Drawing.Size(539, 297);
            this.firstTabHomeworkTracker.TabIndex = 0;
            this.firstTabHomeworkTracker.Tag = "1";
            // 
            // secondClassTab
            // 
            this.secondClassTab.BackColor = System.Drawing.Color.White;
            this.secondClassTab.Controls.Add(this.secondTabHomeworkTracker);
            this.secondClassTab.Location = new System.Drawing.Point(4, 22);
            this.secondClassTab.Name = "secondClassTab";
            this.secondClassTab.Padding = new System.Windows.Forms.Padding(3);
            this.secondClassTab.Size = new System.Drawing.Size(551, 317);
            this.secondClassTab.TabIndex = 1;
            this.secondClassTab.Text = "CS 2100";
            // 
            // secondTabHomeworkTracker
            // 
            this.secondTabHomeworkTracker.Location = new System.Drawing.Point(6, 6);
            this.secondTabHomeworkTracker.Name = "secondTabHomeworkTracker";
            this.secondTabHomeworkTracker.Size = new System.Drawing.Size(530, 290);
            this.secondTabHomeworkTracker.TabIndex = 0;
            this.secondTabHomeworkTracker.Tag = "1";
            // 
            // thirdClassTab
            // 
            this.thirdClassTab.BackColor = System.Drawing.Color.White;
            this.thirdClassTab.Controls.Add(this.thirdTabHomeworkTracker);
            this.thirdClassTab.Location = new System.Drawing.Point(4, 22);
            this.thirdClassTab.Name = "thirdClassTab";
            this.thirdClassTab.Padding = new System.Windows.Forms.Padding(3);
            this.thirdClassTab.Size = new System.Drawing.Size(551, 317);
            this.thirdClassTab.TabIndex = 2;
            this.thirdClassTab.Text = "ENGL 3405";
            // 
            // thirdTabHomeworkTracker
            // 
            this.thirdTabHomeworkTracker.Location = new System.Drawing.Point(6, 6);
            this.thirdTabHomeworkTracker.Name = "thirdTabHomeworkTracker";
            this.thirdTabHomeworkTracker.Size = new System.Drawing.Size(539, 297);
            this.thirdTabHomeworkTracker.TabIndex = 0;
            this.thirdTabHomeworkTracker.Tag = "1";
            // 
            // readOnlyTextBox
            // 
            this.readOnlyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readOnlyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readOnlyTextBox.Location = new System.Drawing.Point(12, 396);
            this.readOnlyTextBox.Name = "readOnlyTextBox";
            this.readOnlyTextBox.ReadOnly = true;
            this.readOnlyTextBox.Size = new System.Drawing.Size(100, 17);
            this.readOnlyTextBox.TabIndex = 1;
            this.readOnlyTextBox.Text = "Output";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTextBox.Location = new System.Drawing.Point(10, 419);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputTextBox.Size = new System.Drawing.Size(551, 267);
            this.outputTextBox.TabIndex = 2;
            this.outputTextBox.Text = "Output will be here.";
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(585, 27);
            this.mainMenuStrip.TabIndex = 3;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveMenuItem,
            this.loadMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(41, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveMenuItem.Size = new System.Drawing.Size(164, 24);
            this.saveMenuItem.Text = "Save";
            this.saveMenuItem.Click += new System.EventHandler(this.saveHomeworkData);
            // 
            // loadMenuItem
            // 
            this.loadMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.loadMenuItem.Name = "loadMenuItem";
            this.loadMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.loadMenuItem.Size = new System.Drawing.Size(164, 24);
            this.loadMenuItem.Text = "Open";
            this.loadMenuItem.Click += new System.EventHandler(this.loadHomeworkData);
            // 
            // HomeworkTrackerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 698);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.readOnlyTextBox);
            this.Controls.Add(this.classTabControl);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "HomeworkTrackerForm";
            this.Text = "Homework Tracker by Brandon Walker";
            this.classTabControl.ResumeLayout(false);
            this.firstClassTab.ResumeLayout(false);
            this.secondClassTab.ResumeLayout(false);
            this.thirdClassTab.ResumeLayout(false);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl classTabControl;
        private System.Windows.Forms.TabPage firstClassTab;
        private ContentTracker.PriorityHomeworkTracker firstTabHomeworkTracker;
        private System.Windows.Forms.TabPage secondClassTab;
        private ContentTracker.PriorityHomeworkTracker secondTabHomeworkTracker;
        private System.Windows.Forms.TabPage thirdClassTab;
        private ContentTracker.PriorityHomeworkTracker thirdTabHomeworkTracker;
        private System.Windows.Forms.TextBox readOnlyTextBox;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadMenuItem;
    }
}

