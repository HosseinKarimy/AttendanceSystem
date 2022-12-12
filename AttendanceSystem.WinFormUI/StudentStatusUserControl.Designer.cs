namespace AttendanceSystem.WinFormUI
{
    partial class StudentStatusUserControl
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.DescriptionCheckBox = new System.Windows.Forms.CheckBox();
            this.ShowStudentDetailsButton = new System.Windows.Forms.Button();
            this.PresentCheckBox = new System.Windows.Forms.CheckBox();
            this.StudentIdTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.MainPanel.Controls.Add(this.DescriptionCheckBox);
            this.MainPanel.Controls.Add(this.ShowStudentDetailsButton);
            this.MainPanel.Controls.Add(this.PresentCheckBox);
            this.MainPanel.Controls.Add(this.StudentIdTextBox);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.DescriptionTextBox);
            this.MainPanel.Controls.Add(this.NameTextBox);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(1, 1);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(691, 30);
            this.MainPanel.TabIndex = 0;
            // 
            // DescriptionCheckBox
            // 
            this.DescriptionCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionCheckBox.AutoSize = true;
            this.DescriptionCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DescriptionCheckBox.Location = new System.Drawing.Point(466, 6);
            this.DescriptionCheckBox.Name = "DescriptionCheckBox";
            this.DescriptionCheckBox.Size = new System.Drawing.Size(83, 19);
            this.DescriptionCheckBox.TabIndex = 4;
            this.DescriptionCheckBox.Text = "Description";
            this.DescriptionCheckBox.UseVisualStyleBackColor = true;
            this.DescriptionCheckBox.CheckedChanged += new System.EventHandler(this.DescriptionCheckBox_CheckedChanged);
            // 
            // ShowStudentDetailsButton
            // 
            this.ShowStudentDetailsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowStudentDetailsButton.Location = new System.Drawing.Point(555, 4);
            this.ShowStudentDetailsButton.Name = "ShowStudentDetailsButton";
            this.ShowStudentDetailsButton.Size = new System.Drawing.Size(128, 23);
            this.ShowStudentDetailsButton.TabIndex = 3;
            this.ShowStudentDetailsButton.Text = "Show Student Status";
            this.ShowStudentDetailsButton.UseVisualStyleBackColor = true;
            this.ShowStudentDetailsButton.Click += new System.EventHandler(this.ShowStudentDetailsButton_Click);
            // 
            // PresentCheckBox
            // 
            this.PresentCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PresentCheckBox.AutoSize = true;
            this.PresentCheckBox.Checked = true;
            this.PresentCheckBox.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.PresentCheckBox.FlatAppearance.BorderSize = 2;
            this.PresentCheckBox.Location = new System.Drawing.Point(392, 6);
            this.PresentCheckBox.Name = "PresentCheckBox";
            this.PresentCheckBox.Size = new System.Drawing.Size(65, 19);
            this.PresentCheckBox.TabIndex = 2;
            this.PresentCheckBox.Text = "Present";
            this.PresentCheckBox.UseVisualStyleBackColor = true;
            this.PresentCheckBox.CheckedChanged += new System.EventHandler(this.PresentCheckBox_CheckedChanged);
            // 
            // StudentIdTextBox
            // 
            this.StudentIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentIdTextBox.Location = new System.Drawing.Point(262, 4);
            this.StudentIdTextBox.Name = "StudentIdTextBox";
            this.StudentIdTextBox.ReadOnly = true;
            this.StudentIdTextBox.Size = new System.Drawing.Size(124, 23);
            this.StudentIdTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "StudentID:";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionTextBox.Location = new System.Drawing.Point(76, 31);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(609, 23);
            this.DescriptionTextBox.TabIndex = 1;
            this.DescriptionTextBox.Leave += new System.EventHandler(this.DescriptionTextBox_Leave);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Location = new System.Drawing.Point(51, 4);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.ReadOnly = true;
            this.NameTextBox.Size = new System.Drawing.Size(137, 23);
            this.NameTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // StudentStatusUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainPanel);
            this.Name = "StudentStatusUserControl";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Size = new System.Drawing.Size(693, 32);
            this.Load += new System.EventHandler(this.StudentStatusUserControl_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel MainPanel;
        private Button ShowStudentDetailsButton;
        private CheckBox PresentCheckBox;
        private TextBox StudentIdTextBox;
        private Label label2;
        private TextBox DescriptionTextBox;
        private TextBox NameTextBox;
        private Label label3;
        private Label label1;
        private CheckBox DescriptionCheckBox;
    }
}
