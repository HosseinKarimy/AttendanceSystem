namespace AttendanceSystem.WinFormUI
{
    partial class StudentDetailsForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.CourseNameTextBox = new System.Windows.Forms.TextBox();
            this.PresentCountLabel = new System.Windows.Forms.Label();
            this.AbsentCountLabel = new System.Windows.Forms.Label();
            this.SectionCountLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SectionsListView = new System.Windows.Forms.ListView();
            this.StudentCoursesGroupBox = new System.Windows.Forms.GroupBox();
            this.CoursesComboBox = new System.Windows.Forms.ComboBox();
            this.StudentDatailsGroupBox = new System.Windows.Forms.GroupBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.GradeTextBox = new System.Windows.Forms.TextBox();
            this.BirthDateTextBox = new System.Windows.Forms.TextBox();
            this.MajorTextBox = new System.Windows.Forms.TextBox();
            this.StudentIdTextBox = new System.Windows.Forms.TextBox();
            this.FatherNameTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.StudentCoursesGroupBox.SuspendLayout();
            this.StudentDatailsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(91)))), ((int)(((byte)(100)))));
            this.MainPanel.Controls.Add(this.groupBox1);
            this.MainPanel.Controls.Add(this.StudentCoursesGroupBox);
            this.MainPanel.Controls.Add(this.StudentDatailsGroupBox);
            this.MainPanel.Location = new System.Drawing.Point(12, 12);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(520, 432);
            this.MainPanel.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.splitContainer1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(215, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 300);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student\'s Course Details";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 19);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.CourseNameTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.PresentCountLabel);
            this.splitContainer1.Panel1.Controls.Add(this.AbsentCountLabel);
            this.splitContainer1.Panel1.Controls.Add(this.SectionCountLabel);
            this.splitContainer1.Panel1.Controls.Add(this.label14);
            this.splitContainer1.Panel1.Controls.Add(this.label12);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.SectionsListView);
            this.splitContainer1.Size = new System.Drawing.Size(299, 278);
            this.splitContainer1.SplitterDistance = 53;
            this.splitContainer1.TabIndex = 2;
            // 
            // CourseNameTextBox
            // 
            this.CourseNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.CourseNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CourseNameTextBox.Location = new System.Drawing.Point(94, 6);
            this.CourseNameTextBox.Name = "CourseNameTextBox";
            this.CourseNameTextBox.ReadOnly = true;
            this.CourseNameTextBox.Size = new System.Drawing.Size(121, 16);
            this.CourseNameTextBox.TabIndex = 1;
            // 
            // PresentCountLabel
            // 
            this.PresentCountLabel.AutoSize = true;
            this.PresentCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(201)))), ((int)(((byte)(202)))));
            this.PresentCountLabel.Location = new System.Drawing.Point(270, 30);
            this.PresentCountLabel.Name = "PresentCountLabel";
            this.PresentCountLabel.Size = new System.Drawing.Size(13, 15);
            this.PresentCountLabel.TabIndex = 0;
            this.PresentCountLabel.Text = "0";
            // 
            // AbsentCountLabel
            // 
            this.AbsentCountLabel.AutoSize = true;
            this.AbsentCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(201)))), ((int)(((byte)(202)))));
            this.AbsentCountLabel.Location = new System.Drawing.Point(188, 30);
            this.AbsentCountLabel.Name = "AbsentCountLabel";
            this.AbsentCountLabel.Size = new System.Drawing.Size(13, 15);
            this.AbsentCountLabel.TabIndex = 0;
            this.AbsentCountLabel.Text = "0";
            // 
            // SectionCountLabel
            // 
            this.SectionCountLabel.AutoSize = true;
            this.SectionCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(201)))), ((int)(((byte)(202)))));
            this.SectionCountLabel.Location = new System.Drawing.Point(94, 30);
            this.SectionCountLabel.Name = "SectionCountLabel";
            this.SectionCountLabel.Size = new System.Drawing.Size(13, 15);
            this.SectionCountLabel.TabIndex = 0;
            this.SectionCountLabel.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(201)))), ((int)(((byte)(202)))));
            this.label14.Location = new System.Drawing.Point(217, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 15);
            this.label14.TabIndex = 0;
            this.label14.Text = "Present:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(201)))), ((int)(((byte)(202)))));
            this.label12.Location = new System.Drawing.Point(135, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Absent:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(201)))), ((int)(((byte)(202)))));
            this.label10.Location = new System.Drawing.Point(6, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Sections Count:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(201)))), ((int)(((byte)(202)))));
            this.label9.Location = new System.Drawing.Point(6, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Course Name:";
            // 
            // SectionsListView
            // 
            this.SectionsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SectionsListView.Location = new System.Drawing.Point(0, 0);
            this.SectionsListView.Name = "SectionsListView";
            this.SectionsListView.Size = new System.Drawing.Size(299, 221);
            this.SectionsListView.TabIndex = 0;
            this.SectionsListView.UseCompatibleStateImageBehavior = false;
            // 
            // StudentCoursesGroupBox
            // 
            this.StudentCoursesGroupBox.Controls.Add(this.CoursesComboBox);
            this.StudentCoursesGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.StudentCoursesGroupBox.Location = new System.Drawing.Point(0, 132);
            this.StudentCoursesGroupBox.Name = "StudentCoursesGroupBox";
            this.StudentCoursesGroupBox.Size = new System.Drawing.Size(215, 300);
            this.StudentCoursesGroupBox.TabIndex = 1;
            this.StudentCoursesGroupBox.TabStop = false;
            this.StudentCoursesGroupBox.Text = "Student\'s Courses";
            // 
            // CoursesComboBox
            // 
            this.CoursesComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CoursesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.CoursesComboBox.FormattingEnabled = true;
            this.CoursesComboBox.Location = new System.Drawing.Point(3, 19);
            this.CoursesComboBox.Name = "CoursesComboBox";
            this.CoursesComboBox.Size = new System.Drawing.Size(209, 278);
            this.CoursesComboBox.TabIndex = 0;
            this.CoursesComboBox.SelectedIndexChanged += new System.EventHandler(this.CoursesComboBox_SelectedIndexChanged);
            // 
            // StudentDatailsGroupBox
            // 
            this.StudentDatailsGroupBox.Controls.Add(this.LastNameTextBox);
            this.StudentDatailsGroupBox.Controls.Add(this.GradeTextBox);
            this.StudentDatailsGroupBox.Controls.Add(this.BirthDateTextBox);
            this.StudentDatailsGroupBox.Controls.Add(this.MajorTextBox);
            this.StudentDatailsGroupBox.Controls.Add(this.StudentIdTextBox);
            this.StudentDatailsGroupBox.Controls.Add(this.FatherNameTextBox);
            this.StudentDatailsGroupBox.Controls.Add(this.NameTextBox);
            this.StudentDatailsGroupBox.Controls.Add(this.label8);
            this.StudentDatailsGroupBox.Controls.Add(this.label7);
            this.StudentDatailsGroupBox.Controls.Add(this.label6);
            this.StudentDatailsGroupBox.Controls.Add(this.label4);
            this.StudentDatailsGroupBox.Controls.Add(this.label5);
            this.StudentDatailsGroupBox.Controls.Add(this.label2);
            this.StudentDatailsGroupBox.Controls.Add(this.label3);
            this.StudentDatailsGroupBox.Controls.Add(this.label1);
            this.StudentDatailsGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.StudentDatailsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.StudentDatailsGroupBox.Name = "StudentDatailsGroupBox";
            this.StudentDatailsGroupBox.Size = new System.Drawing.Size(520, 132);
            this.StudentDatailsGroupBox.TabIndex = 0;
            this.StudentDatailsGroupBox.TabStop = false;
            this.StudentDatailsGroupBox.Text = "Student Details";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.LastNameTextBox.Location = new System.Drawing.Point(353, 16);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.ReadOnly = true;
            this.LastNameTextBox.Size = new System.Drawing.Size(148, 23);
            this.LastNameTextBox.TabIndex = 1;
            // 
            // GradeTextBox
            // 
            this.GradeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.GradeTextBox.Location = new System.Drawing.Point(353, 73);
            this.GradeTextBox.Name = "GradeTextBox";
            this.GradeTextBox.ReadOnly = true;
            this.GradeTextBox.Size = new System.Drawing.Size(148, 23);
            this.GradeTextBox.TabIndex = 1;
            // 
            // BirthDateTextBox
            // 
            this.BirthDateTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.BirthDateTextBox.Location = new System.Drawing.Point(93, 102);
            this.BirthDateTextBox.Name = "BirthDateTextBox";
            this.BirthDateTextBox.ReadOnly = true;
            this.BirthDateTextBox.Size = new System.Drawing.Size(148, 23);
            this.BirthDateTextBox.TabIndex = 1;
            // 
            // MajorTextBox
            // 
            this.MajorTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.MajorTextBox.Location = new System.Drawing.Point(93, 73);
            this.MajorTextBox.Name = "MajorTextBox";
            this.MajorTextBox.ReadOnly = true;
            this.MajorTextBox.Size = new System.Drawing.Size(148, 23);
            this.MajorTextBox.TabIndex = 1;
            // 
            // StudentIdTextBox
            // 
            this.StudentIdTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.StudentIdTextBox.Location = new System.Drawing.Point(353, 45);
            this.StudentIdTextBox.Name = "StudentIdTextBox";
            this.StudentIdTextBox.ReadOnly = true;
            this.StudentIdTextBox.Size = new System.Drawing.Size(148, 23);
            this.StudentIdTextBox.TabIndex = 1;
            // 
            // FatherNameTextBox
            // 
            this.FatherNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.FatherNameTextBox.Location = new System.Drawing.Point(93, 44);
            this.FatherNameTextBox.Name = "FatherNameTextBox";
            this.FatherNameTextBox.ReadOnly = true;
            this.FatherNameTextBox.Size = new System.Drawing.Size(148, 23);
            this.FatherNameTextBox.TabIndex = 1;
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.NameTextBox.Location = new System.Drawing.Point(93, 16);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.ReadOnly = true;
            this.NameTextBox.Size = new System.Drawing.Size(148, 23);
            this.NameTextBox.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Khaki;
            this.label8.Location = new System.Drawing.Point(247, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(262, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "*You Can Edit Students in User Manegement Tab";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(201)))), ((int)(((byte)(202)))));
            this.label7.Location = new System.Drawing.Point(6, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Birth Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(201)))), ((int)(((byte)(202)))));
            this.label6.Location = new System.Drawing.Point(281, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Grade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(201)))), ((int)(((byte)(202)))));
            this.label4.Location = new System.Drawing.Point(6, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Major:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(201)))), ((int)(((byte)(202)))));
            this.label5.Location = new System.Drawing.Point(281, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "StudentId:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(201)))), ((int)(((byte)(202)))));
            this.label2.Location = new System.Drawing.Point(281, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(201)))), ((int)(((byte)(202)))));
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Father Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(201)))), ((int)(((byte)(202)))));
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // StudentDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(544, 456);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StudentDetailsForm";
            this.Text = "StudentDetailsForm";
            this.Load += new System.EventHandler(this.StudentDetailsForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.StudentCoursesGroupBox.ResumeLayout(false);
            this.StudentDatailsGroupBox.ResumeLayout(false);
            this.StudentDatailsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel MainPanel;
        private GroupBox StudentCoursesGroupBox;
        private GroupBox StudentDatailsGroupBox;
        private TextBox LastNameTextBox;
        private TextBox GradeTextBox;
        private TextBox BirthDateTextBox;
        private TextBox MajorTextBox;
        private TextBox StudentIdTextBox;
        private TextBox FatherNameTextBox;
        private TextBox NameTextBox;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label5;
        private Label label2;
        private Label label3;
        private Label label1;
        private ComboBox CoursesComboBox;
        private GroupBox groupBox1;
        private SplitContainer splitContainer1;
        private TextBox CourseNameTextBox;
        private Label PresentCountLabel;
        private Label AbsentCountLabel;
        private Label SectionCountLabel;
        private Label label14;
        private Label label12;
        private Label label10;
        private Label label9;
        private ListView SectionsListView;
    }
}