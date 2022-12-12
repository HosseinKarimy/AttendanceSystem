namespace AttendanceSystem.WinFormUI
{
    partial class ClassManagementForm
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
            this.components = new System.ComponentModel.Container();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CreateCourseTabPage = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.CreateCourseButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NumberOfSectionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SelectStudentsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CourseStartDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.CourseNameTextBox = new System.Windows.Forms.TextBox();
            this.FinaExamDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.MidTermDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SectionDaySpliterContainer = new System.Windows.Forms.SplitContainer();
            this.DayOfWeekComboBox = new System.Windows.Forms.ComboBox();
            this.SectionTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AddSectionButton = new System.Windows.Forms.Button();
            this.SelectedSectionPanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.ClassDurationTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SearchTeacherTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TeachersListView = new System.Windows.Forms.ListView();
            this.SelectedTeacherTextBox = new System.Windows.Forms.TextBox();
            this.StudentTabPage = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AddStudnetsButton = new System.Windows.Forms.Button();
            this.AllStudentsListView = new System.Windows.Forms.ListView();
            this.NameHeader = new System.Windows.Forms.ColumnHeader();
            this.StudentIdHeader = new System.Windows.Forms.ColumnHeader();
            this.MajorHeader = new System.Windows.Forms.ColumnHeader();
            this.EntryYearHeader = new System.Windows.Forms.ColumnHeader();
            this.panel2 = new System.Windows.Forms.Panel();
            this.EntryYearCheckBox = new System.Windows.Forms.CheckBox();
            this.EntryYearNumric = new System.Windows.Forms.NumericUpDown();
            this.GradeComboBox = new System.Windows.Forms.ComboBox();
            this.MajorComboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SearchStudentTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.RemoveCheckedStudentsFromSelectedStudentsButton = new System.Windows.Forms.Button();
            this.SelectedStudentsListView = new System.Windows.Forms.ListView();
            this.RemoveFromSelectedStudentsToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.MainPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.CreateCourseTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfSectionNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SectionDaySpliterContainer)).BeginInit();
            this.SectionDaySpliterContainer.Panel1.SuspendLayout();
            this.SectionDaySpliterContainer.Panel2.SuspendLayout();
            this.SectionDaySpliterContainer.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.StudentTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EntryYearNumric)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.Controls.Add(this.tabControl1);
            this.MainPanel.Location = new System.Drawing.Point(12, 12);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(776, 426);
            this.MainPanel.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.CreateCourseTabPage);
            this.tabControl1.Controls.Add(this.StudentTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // CreateCourseTabPage
            // 
            this.CreateCourseTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(201)))), ((int)(((byte)(202)))));
            this.CreateCourseTabPage.Controls.Add(this.splitContainer1);
            this.CreateCourseTabPage.Location = new System.Drawing.Point(4, 24);
            this.CreateCourseTabPage.Name = "CreateCourseTabPage";
            this.CreateCourseTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CreateCourseTabPage.Size = new System.Drawing.Size(768, 398);
            this.CreateCourseTabPage.TabIndex = 0;
            this.CreateCourseTabPage.Text = "Create Course";
            this.CreateCourseTabPage.Enter += new System.EventHandler(this.CreateCourseTabPage_Enter);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.CreateCourseButton);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(762, 392);
            this.splitContainer1.SplitterDistance = 263;
            this.splitContainer1.TabIndex = 0;
            // 
            // CreateCourseButton
            // 
            this.CreateCourseButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateCourseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.CreateCourseButton.Location = new System.Drawing.Point(4, 343);
            this.CreateCourseButton.Name = "CreateCourseButton";
            this.CreateCourseButton.Size = new System.Drawing.Size(256, 46);
            this.CreateCourseButton.TabIndex = 5;
            this.CreateCourseButton.Text = "Create Course";
            this.CreateCourseButton.UseVisualStyleBackColor = false;
            this.CreateCourseButton.Click += new System.EventHandler(this.CreateCourseButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.NumberOfSectionNumericUpDown);
            this.groupBox4.Controls.Add(this.SelectStudentsLinkLabel);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.CourseStartDate);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.CourseNameTextBox);
            this.groupBox4.Controls.Add(this.FinaExamDateTimePicker);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.MidTermDateTimePicker);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(263, 392);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Step1 : Details Form";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(12, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "*For add or remove students go to ";
            // 
            // NumberOfSectionNumericUpDown
            // 
            this.NumberOfSectionNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberOfSectionNumericUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.NumberOfSectionNumericUpDown.Location = new System.Drawing.Point(9, 234);
            this.NumberOfSectionNumericUpDown.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.NumberOfSectionNumericUpDown.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.NumberOfSectionNumericUpDown.Name = "NumberOfSectionNumericUpDown";
            this.NumberOfSectionNumericUpDown.Size = new System.Drawing.Size(243, 23);
            this.NumberOfSectionNumericUpDown.TabIndex = 8;
            this.NumberOfSectionNumericUpDown.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // SelectStudentsLinkLabel
            // 
            this.SelectStudentsLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SelectStudentsLinkLabel.AutoSize = true;
            this.SelectStudentsLinkLabel.Location = new System.Drawing.Point(62, 317);
            this.SelectStudentsLinkLabel.Name = "SelectStudentsLinkLabel";
            this.SelectStudentsLinkLabel.Size = new System.Drawing.Size(137, 15);
            this.SelectStudentsLinkLabel.TabIndex = 10;
            this.SelectStudentsLinkLabel.TabStop = true;
            this.SelectStudentsLinkLabel.Text = "Select Students Tab Page";
            this.SelectStudentsLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SelectStudentsLinkLabel_LinkClicked);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 216);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 15);
            this.label14.TabIndex = 0;
            this.label14.Text = "Number Of Sections:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "MidTerm Exam:";
            // 
            // CourseStartDate
            // 
            this.CourseStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CourseStartDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.CourseStartDate.Location = new System.Drawing.Point(8, 181);
            this.CourseStartDate.Name = "CourseStartDate";
            this.CourseStartDate.Size = new System.Drawing.Size(244, 23);
            this.CourseStartDate.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 163);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(203, 15);
            this.label13.TabIndex = 0;
            this.label13.Text = "Course Start Date: (First Section Date)";
            // 
            // CourseNameTextBox
            // 
            this.CourseNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CourseNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.CourseNameTextBox.Location = new System.Drawing.Point(8, 39);
            this.CourseNameTextBox.Name = "CourseNameTextBox";
            this.CourseNameTextBox.Size = new System.Drawing.Size(242, 23);
            this.CourseNameTextBox.TabIndex = 1;
            // 
            // FinaExamDateTimePicker
            // 
            this.FinaExamDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FinaExamDateTimePicker.Location = new System.Drawing.Point(9, 131);
            this.FinaExamDateTimePicker.Name = "FinaExamDateTimePicker";
            this.FinaExamDateTimePicker.ShowCheckBox = true;
            this.FinaExamDateTimePicker.Size = new System.Drawing.Size(243, 23);
            this.FinaExamDateTimePicker.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Final Exam:";
            // 
            // MidTermDateTimePicker
            // 
            this.MidTermDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MidTermDateTimePicker.Location = new System.Drawing.Point(8, 87);
            this.MidTermDateTimePicker.Name = "MidTermDateTimePicker";
            this.MidTermDateTimePicker.ShowCheckBox = true;
            this.MidTermDateTimePicker.Size = new System.Drawing.Size(244, 23);
            this.MidTermDateTimePicker.TabIndex = 2;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer3.Size = new System.Drawing.Size(495, 392);
            this.splitContainer3.SplitterDistance = 241;
            this.splitContainer3.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SectionDaySpliterContainer);
            this.groupBox1.Controls.Add(this.AddSectionButton);
            this.groupBox1.Controls.Add(this.SelectedSectionPanel);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.ClassDurationTimePicker);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 392);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Step2: Section Per Week";
            // 
            // SectionDaySpliterContainer
            // 
            this.SectionDaySpliterContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SectionDaySpliterContainer.Location = new System.Drawing.Point(7, 81);
            this.SectionDaySpliterContainer.Name = "SectionDaySpliterContainer";
            // 
            // SectionDaySpliterContainer.Panel1
            // 
            this.SectionDaySpliterContainer.Panel1.Controls.Add(this.DayOfWeekComboBox);
            // 
            // SectionDaySpliterContainer.Panel2
            // 
            this.SectionDaySpliterContainer.Panel2.Controls.Add(this.SectionTimePicker);
            this.SectionDaySpliterContainer.Size = new System.Drawing.Size(231, 23);
            this.SectionDaySpliterContainer.SplitterDistance = 113;
            this.SectionDaySpliterContainer.TabIndex = 7;
            // 
            // DayOfWeekComboBox
            // 
            this.DayOfWeekComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.DayOfWeekComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DayOfWeekComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DayOfWeekComboBox.FormattingEnabled = true;
            this.DayOfWeekComboBox.Location = new System.Drawing.Point(0, 0);
            this.DayOfWeekComboBox.Name = "DayOfWeekComboBox";
            this.DayOfWeekComboBox.Size = new System.Drawing.Size(113, 23);
            this.DayOfWeekComboBox.TabIndex = 2;
            // 
            // SectionTimePicker
            // 
            this.SectionTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SectionTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.SectionTimePicker.Location = new System.Drawing.Point(0, 0);
            this.SectionTimePicker.Name = "SectionTimePicker";
            this.SectionTimePicker.ShowUpDown = true;
            this.SectionTimePicker.Size = new System.Drawing.Size(114, 23);
            this.SectionTimePicker.TabIndex = 1;
            // 
            // AddSectionButton
            // 
            this.AddSectionButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddSectionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.AddSectionButton.Location = new System.Drawing.Point(7, 110);
            this.AddSectionButton.Name = "AddSectionButton";
            this.AddSectionButton.Size = new System.Drawing.Size(232, 24);
            this.AddSectionButton.TabIndex = 3;
            this.AddSectionButton.Text = "Add Section To Course";
            this.AddSectionButton.UseVisualStyleBackColor = false;
            this.AddSectionButton.Click += new System.EventHandler(this.AddSectionButton_Click);
            // 
            // SelectedSectionPanel
            // 
            this.SelectedSectionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedSectionPanel.AutoScroll = true;
            this.SelectedSectionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.SelectedSectionPanel.Location = new System.Drawing.Point(6, 155);
            this.SelectedSectionPanel.Name = "SelectedSectionPanel";
            this.SelectedSectionPanel.Size = new System.Drawing.Size(232, 231);
            this.SelectedSectionPanel.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Section Day and Time:";
            // 
            // ClassDurationTimePicker
            // 
            this.ClassDurationTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClassDurationTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ClassDurationTimePicker.Location = new System.Drawing.Point(6, 37);
            this.ClassDurationTimePicker.Name = "ClassDurationTimePicker";
            this.ClassDurationTimePicker.ShowUpDown = true;
            this.ClassDurationTimePicker.Size = new System.Drawing.Size(232, 23);
            this.ClassDurationTimePicker.TabIndex = 1;
            this.ClassDurationTimePicker.Value = new System.DateTime(2022, 11, 19, 14, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sections:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Section Duration:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SearchTeacherTextBox);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.TeachersListView);
            this.groupBox3.Controls.Add(this.SelectedTeacherTextBox);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 392);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Step 3: Select Teacher";
            // 
            // SearchTeacherTextBox
            // 
            this.SearchTeacherTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTeacherTextBox.Location = new System.Drawing.Point(55, 363);
            this.SearchTeacherTextBox.Name = "SearchTeacherTextBox";
            this.SearchTeacherTextBox.Size = new System.Drawing.Size(189, 23);
            this.SearchTeacherTextBox.TabIndex = 3;
            this.SearchTeacherTextBox.TextChanged += new System.EventHandler(this.SearchTeacherTextBox_TextChanged);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 366);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 15);
            this.label12.TabIndex = 1;
            this.label12.Text = "Search:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Selected Teacher:";
            // 
            // TeachersListView
            // 
            this.TeachersListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TeachersListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.TeachersListView.FullRowSelect = true;
            this.TeachersListView.Location = new System.Drawing.Point(3, 37);
            this.TeachersListView.Name = "TeachersListView";
            this.TeachersListView.Size = new System.Drawing.Size(244, 320);
            this.TeachersListView.TabIndex = 0;
            this.TeachersListView.UseCompatibleStateImageBehavior = false;
            this.TeachersListView.ItemActivate += new System.EventHandler(this.TeachersListView_ItemActivate);
            // 
            // SelectedTeacherTextBox
            // 
            this.SelectedTeacherTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedTeacherTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SelectedTeacherTextBox.Location = new System.Drawing.Point(112, 19);
            this.SelectedTeacherTextBox.Name = "SelectedTeacherTextBox";
            this.SelectedTeacherTextBox.ReadOnly = true;
            this.SelectedTeacherTextBox.Size = new System.Drawing.Size(132, 16);
            this.SelectedTeacherTextBox.TabIndex = 2;
            this.SelectedTeacherTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StudentTabPage
            // 
            this.StudentTabPage.Controls.Add(this.splitContainer2);
            this.StudentTabPage.Location = new System.Drawing.Point(4, 24);
            this.StudentTabPage.Name = "StudentTabPage";
            this.StudentTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.StudentTabPage.Size = new System.Drawing.Size(768, 398);
            this.StudentTabPage.TabIndex = 1;
            this.StudentTabPage.Text = "Select Student";
            this.StudentTabPage.UseVisualStyleBackColor = true;
            this.StudentTabPage.Enter += new System.EventHandler(this.StudentSectionTabPage_Enter);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(201)))), ((int)(((byte)(202)))));
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox5);
            this.splitContainer2.Size = new System.Drawing.Size(762, 392);
            this.splitContainer2.SplitterDistance = 504;
            this.splitContainer2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AddStudnetsButton);
            this.groupBox2.Controls.Add(this.AllStudentsListView);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(504, 392);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Step4: Select students";
            // 
            // AddStudnetsButton
            // 
            this.AddStudnetsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddStudnetsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.AddStudnetsButton.Location = new System.Drawing.Point(197, 363);
            this.AddStudnetsButton.Name = "AddStudnetsButton";
            this.AddStudnetsButton.Size = new System.Drawing.Size(301, 23);
            this.AddStudnetsButton.TabIndex = 3;
            this.AddStudnetsButton.Text = "Add Students To Course";
            this.AddStudnetsButton.UseVisualStyleBackColor = false;
            this.AddStudnetsButton.Click += new System.EventHandler(this.AddStudnetsButton_Click);
            // 
            // AllStudentsListView
            // 
            this.AllStudentsListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AllStudentsListView.CheckBoxes = true;
            this.AllStudentsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameHeader,
            this.StudentIdHeader,
            this.MajorHeader,
            this.EntryYearHeader});
            this.AllStudentsListView.FullRowSelect = true;
            this.AllStudentsListView.HoverSelection = true;
            this.AllStudentsListView.Location = new System.Drawing.Point(197, 22);
            this.AllStudentsListView.Name = "AllStudentsListView";
            this.AllStudentsListView.Size = new System.Drawing.Size(301, 337);
            this.AllStudentsListView.TabIndex = 1;
            this.AllStudentsListView.UseCompatibleStateImageBehavior = false;
            // 
            // NameHeader
            // 
            this.NameHeader.Text = "Name";
            // 
            // StudentIdHeader
            // 
            this.StudentIdHeader.Text = "Student ID";
            this.StudentIdHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MajorHeader
            // 
            this.MajorHeader.Text = "Major";
            this.MajorHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EntryYearHeader
            // 
            this.EntryYearHeader.Text = "Entry year";
            this.EntryYearHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.EntryYearCheckBox);
            this.panel2.Controls.Add(this.EntryYearNumric);
            this.panel2.Controls.Add(this.GradeComboBox);
            this.panel2.Controls.Add(this.MajorComboBox);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.SearchStudentTextBox);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(6, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 203);
            this.panel2.TabIndex = 0;
            // 
            // EntryYearCheckBox
            // 
            this.EntryYearCheckBox.AutoSize = true;
            this.EntryYearCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EntryYearCheckBox.Location = new System.Drawing.Point(3, 142);
            this.EntryYearCheckBox.Name = "EntryYearCheckBox";
            this.EntryYearCheckBox.Size = new System.Drawing.Size(78, 19);
            this.EntryYearCheckBox.TabIndex = 4;
            this.EntryYearCheckBox.Text = "Entry Year:";
            this.EntryYearCheckBox.UseVisualStyleBackColor = true;
            this.EntryYearCheckBox.CheckedChanged += new System.EventHandler(this.EntryYearCheckBox_CheckedChanged);
            // 
            // EntryYearNumric
            // 
            this.EntryYearNumric.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EntryYearNumric.Enabled = false;
            this.EntryYearNumric.Location = new System.Drawing.Point(3, 162);
            this.EntryYearNumric.Maximum = new decimal(new int[] {
            1395,
            0,
            0,
            0});
            this.EntryYearNumric.Name = "EntryYearNumric";
            this.EntryYearNumric.Size = new System.Drawing.Size(182, 23);
            this.EntryYearNumric.TabIndex = 3;
            // 
            // GradeComboBox
            // 
            this.GradeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GradeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GradeComboBox.FormattingEnabled = true;
            this.GradeComboBox.Location = new System.Drawing.Point(3, 113);
            this.GradeComboBox.Name = "GradeComboBox";
            this.GradeComboBox.Size = new System.Drawing.Size(182, 23);
            this.GradeComboBox.TabIndex = 2;
            // 
            // MajorComboBox
            // 
            this.MajorComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MajorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MajorComboBox.FormattingEnabled = true;
            this.MajorComboBox.Location = new System.Drawing.Point(3, 69);
            this.MajorComboBox.Name = "MajorComboBox";
            this.MajorComboBox.Size = new System.Drawing.Size(182, 23);
            this.MajorComboBox.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Grade:";
            // 
            // SearchStudentTextBox
            // 
            this.SearchStudentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchStudentTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.SearchStudentTextBox.Location = new System.Drawing.Point(3, 25);
            this.SearchStudentTextBox.Name = "SearchStudentTextBox";
            this.SearchStudentTextBox.Size = new System.Drawing.Size(182, 23);
            this.SearchStudentTextBox.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Major:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Search Student:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.RemoveCheckedStudentsFromSelectedStudentsButton);
            this.groupBox5.Controls.Add(this.SelectedStudentsListView);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(254, 392);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Selected Students";
            // 
            // RemoveCheckedStudentsFromSelectedStudentsButton
            // 
            this.RemoveCheckedStudentsFromSelectedStudentsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveCheckedStudentsFromSelectedStudentsButton.Location = new System.Drawing.Point(6, 363);
            this.RemoveCheckedStudentsFromSelectedStudentsButton.Name = "RemoveCheckedStudentsFromSelectedStudentsButton";
            this.RemoveCheckedStudentsFromSelectedStudentsButton.Size = new System.Drawing.Size(242, 23);
            this.RemoveCheckedStudentsFromSelectedStudentsButton.TabIndex = 1;
            this.RemoveCheckedStudentsFromSelectedStudentsButton.Text = "Remove From Course";
            this.RemoveCheckedStudentsFromSelectedStudentsButton.UseVisualStyleBackColor = true;
            this.RemoveCheckedStudentsFromSelectedStudentsButton.Click += new System.EventHandler(this.RemoveCheckedStudentsFromSelectedStudentsButton_Click);
            // 
            // SelectedStudentsListView
            // 
            this.SelectedStudentsListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedStudentsListView.CheckBoxes = true;
            this.SelectedStudentsListView.Location = new System.Drawing.Point(6, 22);
            this.SelectedStudentsListView.Name = "SelectedStudentsListView";
            this.SelectedStudentsListView.Size = new System.Drawing.Size(242, 335);
            this.SelectedStudentsListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.SelectedStudentsListView.TabIndex = 0;
            this.SelectedStudentsListView.UseCompatibleStateImageBehavior = false;
            // 
            // RemoveFromSelectedStudentsToolTip
            // 
            this.RemoveFromSelectedStudentsToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // ClassManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(91)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClassManagementForm";
            this.Text = "ClassManagementForm";
            this.Load += new System.EventHandler(this.ClassManagementForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.CreateCourseTabPage.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfSectionNumericUpDown)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.SectionDaySpliterContainer.Panel1.ResumeLayout(false);
            this.SectionDaySpliterContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SectionDaySpliterContainer)).EndInit();
            this.SectionDaySpliterContainer.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.StudentTabPage.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EntryYearNumric)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel MainPanel;
        private TabControl tabControl1;
        private TabPage CreateCourseTabPage;
        private SplitContainer splitContainer1;
        private TextBox CourseNameTextBox;
        private Label label1;
        private TabPage StudentTabPage;
        private Button CreateCourseButton;
        private DateTimePicker FinaExamDateTimePicker;
        private DateTimePicker MidTermDateTimePicker;
        private Label label5;
        private Label label4;
        private SplitContainer splitContainer2;
        private GroupBox groupBox2;
        private Panel panel2;
        private TextBox SearchStudentTextBox;
        private Label label9;
        private NumericUpDown EntryYearNumric;
        private ComboBox GradeComboBox;
        private ComboBox MajorComboBox;
        private Label label11;
        private Label label10;
        private ListView AllStudentsListView;
        private ColumnHeader NameHeader;
        private ColumnHeader StudentIdHeader;
        private ColumnHeader MajorHeader;
        private ColumnHeader EntryYearHeader;
        private CheckBox EntryYearCheckBox;
        private Button AddStudnetsButton;
        private Panel SelectedSectionPanel;
        private Label label3;
        private SplitContainer splitContainer3;
        private ListView TeachersListView;
        private TextBox SearchTeacherTextBox;
        private TextBox SelectedTeacherTextBox;
        private Label label12;
        private Label label6;
        private ToolTip RemoveFromSelectedStudentsToolTip;
        private NumericUpDown NumberOfSectionNumericUpDown;
        private DateTimePicker CourseStartDate;
        private Label label13;
        private Label label14;
        private GroupBox groupBox1;
        private Button AddSectionButton;
        private ComboBox DayOfWeekComboBox;
        private DateTimePicker SectionTimePicker;
        private Label label8;
        private DateTimePicker ClassDurationTimePicker;
        private Label label7;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private GroupBox groupBox5;
        private ListView SelectedStudentsListView;
        private Button RemoveCheckedStudentsFromSelectedStudentsButton;
        private SplitContainer SectionDaySpliterContainer;
        private Label label2;
        private LinkLabel SelectStudentsLinkLabel;
    }
}