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
            this.ResultPanel = new System.Windows.Forms.Panel();
            this.FilterGroupBox = new System.Windows.Forms.GroupBox();
            this.AllRadioButton = new System.Windows.Forms.RadioButton();
            this.AttendeesRadioButton = new System.Windows.Forms.RadioButton();
            this.FilterTreeView = new System.Windows.Forms.TreeView();
            this.AbsenteesRadioButton = new System.Windows.Forms.RadioButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.FilterGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResultPanel
            // 
            this.ResultPanel.AutoScroll = true;
            this.ResultPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.ResultPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultPanel.Location = new System.Drawing.Point(0, 0);
            this.ResultPanel.Name = "ResultPanel";
            this.ResultPanel.Size = new System.Drawing.Size(514, 426);
            this.ResultPanel.TabIndex = 6;
            // 
            // FilterGroupBox
            // 
            this.FilterGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.FilterGroupBox.Controls.Add(this.AllRadioButton);
            this.FilterGroupBox.Controls.Add(this.AttendeesRadioButton);
            this.FilterGroupBox.Controls.Add(this.FilterTreeView);
            this.FilterGroupBox.Controls.Add(this.AbsenteesRadioButton);
            this.FilterGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilterGroupBox.Location = new System.Drawing.Point(0, 0);
            this.FilterGroupBox.Name = "FilterGroupBox";
            this.FilterGroupBox.Size = new System.Drawing.Size(258, 426);
            this.FilterGroupBox.TabIndex = 5;
            this.FilterGroupBox.TabStop = false;
            this.FilterGroupBox.Text = "Filters";
            // 
            // AllRadioButton
            // 
            this.AllRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AllRadioButton.AutoSize = true;
            this.AllRadioButton.Checked = true;
            this.AllRadioButton.Location = new System.Drawing.Point(6, 401);
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
            this.AttendeesRadioButton.Location = new System.Drawing.Point(142, 401);
            this.AttendeesRadioButton.Name = "AttendeesRadioButton";
            this.AttendeesRadioButton.Size = new System.Drawing.Size(78, 19);
            this.AttendeesRadioButton.TabIndex = 7;
            this.AttendeesRadioButton.Text = "Attendees";
            this.AttendeesRadioButton.UseVisualStyleBackColor = true;
            this.AttendeesRadioButton.CheckedChanged += new System.EventHandler(this.AllRadioButton_CheckedChanged);
            // 
            // FilterTreeView
            // 
            this.FilterTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterTreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.FilterTreeView.FullRowSelect = true;
            this.FilterTreeView.Location = new System.Drawing.Point(6, 18);
            this.FilterTreeView.Name = "FilterTreeView";
            this.FilterTreeView.Size = new System.Drawing.Size(246, 377);
            this.FilterTreeView.TabIndex = 8;
            this.FilterTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.FilterTreeView_AfterSelect);
            // 
            // AbsenteesRadioButton
            // 
            this.AbsenteesRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AbsenteesRadioButton.AutoSize = true;
            this.AbsenteesRadioButton.Location = new System.Drawing.Point(52, 401);
            this.AbsenteesRadioButton.Name = "AbsenteesRadioButton";
            this.AbsenteesRadioButton.Size = new System.Drawing.Size(79, 19);
            this.AbsenteesRadioButton.TabIndex = 6;
            this.AbsenteesRadioButton.Text = "Absentees";
            this.AbsenteesRadioButton.UseVisualStyleBackColor = true;
            this.AbsenteesRadioButton.CheckedChanged += new System.EventHandler(this.AllRadioButton_CheckedChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(201)))), ((int)(((byte)(202)))));
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.FilterGroupBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ResultPanel);
            this.splitContainer1.Size = new System.Drawing.Size(776, 426);
            this.splitContainer1.SplitterDistance = 258;
            this.splitContainer1.TabIndex = 1;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(91)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchForm";
            this.Text = "DisplayDataForm";
            this.Load += new System.EventHandler(this.SearchForm_Enter);
            this.Enter += new System.EventHandler(this.SearchForm_Enter);
            this.FilterGroupBox.ResumeLayout(false);
            this.FilterGroupBox.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel ResultPanel;
        private GroupBox FilterGroupBox;
        private RadioButton AllRadioButton;
        private RadioButton AttendeesRadioButton;
        private TreeView FilterTreeView;
        private RadioButton AbsenteesRadioButton;
        private SplitContainer splitContainer1;
    }
}