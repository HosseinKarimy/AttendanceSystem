namespace AttendanceSystem.WinFormUI
{
    partial class SearchForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ResultPanel = new System.Windows.Forms.Panel();
            this.FilterGroupBox = new System.Windows.Forms.GroupBox();
            this.AllRadioButton = new System.Windows.Forms.RadioButton();
            this.AttendeesRadioButton = new System.Windows.Forms.RadioButton();
            this.FilterTreeView = new System.Windows.Forms.TreeView();
            this.AbsenteesRadioButton = new System.Windows.Forms.RadioButton();
            this.MainPanel.SuspendLayout();
            this.FilterGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(201)))), ((int)(((byte)(202)))));
            this.MainPanel.Controls.Add(this.ResultPanel);
            this.MainPanel.Controls.Add(this.FilterGroupBox);
            this.MainPanel.Location = new System.Drawing.Point(12, 12);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(776, 426);
            this.MainPanel.TabIndex = 0;
            // 
            // ResultPanel
            // 
            this.ResultPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultPanel.AutoScroll = true;
            this.ResultPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.ResultPanel.Location = new System.Drawing.Point(244, 12);
            this.ResultPanel.Name = "ResultPanel";
            this.ResultPanel.Size = new System.Drawing.Size(529, 411);
            this.ResultPanel.TabIndex = 6;
            // 
            // FilterGroupBox
            // 
            this.FilterGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.FilterGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.FilterGroupBox.Controls.Add(this.AllRadioButton);
            this.FilterGroupBox.Controls.Add(this.AttendeesRadioButton);
            this.FilterGroupBox.Controls.Add(this.FilterTreeView);
            this.FilterGroupBox.Controls.Add(this.AbsenteesRadioButton);
            this.FilterGroupBox.Location = new System.Drawing.Point(3, 3);
            this.FilterGroupBox.Name = "FilterGroupBox";
            this.FilterGroupBox.Size = new System.Drawing.Size(235, 420);
            this.FilterGroupBox.TabIndex = 5;
            this.FilterGroupBox.TabStop = false;
            this.FilterGroupBox.Text = "Filters";
            // 
            // AllRadioButton
            // 
            this.AllRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AllRadioButton.AutoSize = true;
            this.AllRadioButton.Checked = true;
            this.AllRadioButton.Location = new System.Drawing.Point(6, 395);
            this.AllRadioButton.Name = "AllRadioButton";
            this.AllRadioButton.Size = new System.Drawing.Size(39, 19);
            this.AllRadioButton.TabIndex = 5;
            this.AllRadioButton.TabStop = true;
            this.AllRadioButton.Text = "All";
            this.AllRadioButton.UseVisualStyleBackColor = true;
            this.AllRadioButton.CheckedChanged += new System.EventHandler(this.AllRadioButton_CheckedChanged);
            // 
            // AttendeesRadioButton
            // 
            this.AttendeesRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AttendeesRadioButton.AutoSize = true;
            this.AttendeesRadioButton.Location = new System.Drawing.Point(142, 395);
            this.AttendeesRadioButton.Name = "AttendeesRadioButton";
            this.AttendeesRadioButton.Size = new System.Drawing.Size(78, 19);
            this.AttendeesRadioButton.TabIndex = 7;
            this.AttendeesRadioButton.Text = "Attendees";
            this.AttendeesRadioButton.UseVisualStyleBackColor = true;
            this.AttendeesRadioButton.CheckedChanged += new System.EventHandler(this.AllRadioButton_CheckedChanged);
            // 
            // FilterTreeView
            // 
            this.FilterTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.FilterTreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.FilterTreeView.FullRowSelect = true;
            this.FilterTreeView.Location = new System.Drawing.Point(6, 18);
            this.FilterTreeView.Name = "FilterTreeView";
            this.FilterTreeView.Size = new System.Drawing.Size(223, 371);
            this.FilterTreeView.TabIndex = 8;
            this.FilterTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.FilterTreeView_AfterSelect);
            // 
            // AbsenteesRadioButton
            // 
            this.AbsenteesRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AbsenteesRadioButton.AutoSize = true;
            this.AbsenteesRadioButton.Location = new System.Drawing.Point(52, 395);
            this.AbsenteesRadioButton.Name = "AbsenteesRadioButton";
            this.AbsenteesRadioButton.Size = new System.Drawing.Size(79, 19);
            this.AbsenteesRadioButton.TabIndex = 6;
            this.AbsenteesRadioButton.Text = "Absentees";
            this.AbsenteesRadioButton.UseVisualStyleBackColor = true;
            this.AbsenteesRadioButton.CheckedChanged += new System.EventHandler(this.AllRadioButton_CheckedChanged);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(91)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchForm";
            this.Text = "DisplayDataForm";
            this.Load += new System.EventHandler(this.SearchForm_Enter);
            this.Enter += new System.EventHandler(this.SearchForm_Enter);
            this.MainPanel.ResumeLayout(false);
            this.FilterGroupBox.ResumeLayout(false);
            this.FilterGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel MainPanel;
        private Panel ResultPanel;
        private GroupBox FilterGroupBox;
        private RadioButton AllRadioButton;
        private RadioButton AttendeesRadioButton;
        private TreeView FilterTreeView;
        private RadioButton AbsenteesRadioButton;
    }
}