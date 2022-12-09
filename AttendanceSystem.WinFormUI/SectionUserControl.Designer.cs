namespace AttendanceSystem.WinFormUI
{
    partial class SectionUserControl
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
            this.RemoveSectionButton = new System.Windows.Forms.Button();
            this.ClassDayTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ClassDurationMAskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StartTimeTextBox = new System.Windows.Forms.TextBox();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MainPanel.Controls.Add(this.RemoveSectionButton);
            this.MainPanel.Controls.Add(this.StartTimeTextBox);
            this.MainPanel.Controls.Add(this.ClassDayTextBox);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Controls.Add(this.ClassDurationMAskedTextBox);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Location = new System.Drawing.Point(4, 4);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(209, 118);
            this.MainPanel.TabIndex = 0;
            // 
            // RemoveSectionButton
            // 
            this.RemoveSectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveSectionButton.Location = new System.Drawing.Point(3, 3);
            this.RemoveSectionButton.Name = "RemoveSectionButton";
            this.RemoveSectionButton.Size = new System.Drawing.Size(22, 22);
            this.RemoveSectionButton.TabIndex = 3;
            this.RemoveSectionButton.Text = "X";
            this.RemoveSectionButton.UseVisualStyleBackColor = true;
            this.RemoveSectionButton.Click += new System.EventHandler(this.RemoveSectionButton_Click);
            // 
            // ClassDayTextBox
            // 
            this.ClassDayTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClassDayTextBox.Location = new System.Drawing.Point(95, 58);
            this.ClassDayTextBox.Name = "ClassDayTextBox";
            this.ClassDayTextBox.ReadOnly = true;
            this.ClassDayTextBox.Size = new System.Drawing.Size(104, 23);
            this.ClassDayTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Start Time:";
            // 
            // ClassDurationMAskedTextBox
            // 
            this.ClassDurationMAskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClassDurationMAskedTextBox.Location = new System.Drawing.Point(95, 24);
            this.ClassDurationMAskedTextBox.Mask = "90:00";
            this.ClassDurationMAskedTextBox.Name = "ClassDurationMAskedTextBox";
            this.ClassDurationMAskedTextBox.ReadOnly = true;
            this.ClassDurationMAskedTextBox.Size = new System.Drawing.Size(104, 23);
            this.ClassDurationMAskedTextBox.TabIndex = 1;
            this.ClassDurationMAskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Class Day:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class Duration:";
            // 
            // StartTimeTextBox
            // 
            this.StartTimeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StartTimeTextBox.Location = new System.Drawing.Point(95, 87);
            this.StartTimeTextBox.Name = "StartTimeTextBox";
            this.StartTimeTextBox.ReadOnly = true;
            this.StartTimeTextBox.Size = new System.Drawing.Size(104, 23);
            this.StartTimeTextBox.TabIndex = 2;
            // 
            // SectionUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.MainPanel);
            this.Name = "SectionUserControl";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Size = new System.Drawing.Size(217, 126);
            this.Load += new System.EventHandler(this.SectionUserControl_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel MainPanel;
        private TextBox ClassDayTextBox;
        private MaskedTextBox ClassDurationMAskedTextBox;
        private Label label2;
        private Label label1;
        private Button RemoveSectionButton;
        private Label label3;
        private TextBox StartTimeTextBox;
    }
}
