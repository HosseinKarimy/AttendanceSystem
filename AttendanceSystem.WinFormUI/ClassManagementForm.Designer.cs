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
            components = new System.ComponentModel.Container();
            MainPanel = new Panel();
            tabControl1 = new TabControl();
            CreateCourseTabPage = new TabPage();
            splitContainer1 = new SplitContainer();
            CreateCourseButton = new Button();
            groupBox4 = new GroupBox();
            SelectTermComboBox = new ComboBox();
            SelectCourseComboBox = new ComboBox();
            label2 = new Label();
            NumberOfSectionNumericUpDown = new NumericUpDown();
            SelectStudentsLinkLabel = new LinkLabel();
            label14 = new Label();
            label1 = new Label();
            label4 = new Label();
            label13 = new Label();
            FinaExamDateTimePicker = new DateTimePicker();
            label5 = new Label();
            MidTermDateTimePicker = new DateTimePicker();
            splitContainer3 = new SplitContainer();
            groupBox1 = new GroupBox();
            SectionDaySpliterContainer = new SplitContainer();
            DayOfWeekComboBox = new ComboBox();
            SectionTimePicker = new DateTimePicker();
            AddSectionButton = new Button();
            SelectedSectionPanel = new Panel();
            label8 = new Label();
            ClassDurationTimePicker = new DateTimePicker();
            label3 = new Label();
            label7 = new Label();
            groupBox3 = new GroupBox();
            SearchTeacherTextBox = new TextBox();
            label12 = new Label();
            label6 = new Label();
            TeachersListView = new ListView();
            SelectedTeacherTextBox = new TextBox();
            StudentTabPage = new TabPage();
            splitContainer2 = new SplitContainer();
            SelectStudentGPBox = new GroupBox();
            AddStudentsButton = new Button();
            AllStudentsListView = new ListView();
            NameHeader = new ColumnHeader();
            StudentIdHeader = new ColumnHeader();
            MajorHeader = new ColumnHeader();
            EntryYearHeader = new ColumnHeader();
            panel2 = new Panel();
            StudentIDCheckBox = new CheckBox();
            StudentIDNumric = new NumericUpDown();
            DegreeComboBox = new ComboBox();
            MajorComboBox = new ComboBox();
            label11 = new Label();
            SearchFullNameStudentTextBox = new TextBox();
            label10 = new Label();
            label9 = new Label();
            SelectedStudentGPBox = new GroupBox();
            RemoveCheckedStudentsFromSelectedStudentsButton = new Button();
            SelectedStudentsListView = new ListView();
            RemoveFromSelectedStudentsToolTip = new ToolTip(components);
            MainPanel.SuspendLayout();
            tabControl1.SuspendLayout();
            CreateCourseTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumberOfSectionNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SectionDaySpliterContainer).BeginInit();
            SectionDaySpliterContainer.Panel1.SuspendLayout();
            SectionDaySpliterContainer.Panel2.SuspendLayout();
            SectionDaySpliterContainer.SuspendLayout();
            groupBox3.SuspendLayout();
            StudentTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            SelectStudentGPBox.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StudentIDNumric).BeginInit();
            SelectedStudentGPBox.SuspendLayout();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MainPanel.Controls.Add(tabControl1);
            MainPanel.Location = new Point(12, 12);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(776, 426);
            MainPanel.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(CreateCourseTabPage);
            tabControl1.Controls.Add(StudentTabPage);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(0);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(0, 0);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 426);
            tabControl1.TabIndex = 0;
            // 
            // CreateCourseTabPage
            // 
            CreateCourseTabPage.BackColor = Color.FromArgb(165, 201, 202);
            CreateCourseTabPage.Controls.Add(splitContainer1);
            CreateCourseTabPage.Location = new Point(4, 24);
            CreateCourseTabPage.Name = "CreateCourseTabPage";
            CreateCourseTabPage.Padding = new Padding(3);
            CreateCourseTabPage.Size = new Size(768, 398);
            CreateCourseTabPage.TabIndex = 0;
            CreateCourseTabPage.Text = "Create Course";
            CreateCourseTabPage.Enter += CreateCourseTabPage_Enter;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(CreateCourseButton);
            splitContainer1.Panel1.Controls.Add(groupBox4);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer3);
            splitContainer1.Size = new Size(762, 392);
            splitContainer1.SplitterDistance = 263;
            splitContainer1.TabIndex = 0;
            // 
            // CreateCourseButton
            // 
            CreateCourseButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CreateCourseButton.BackColor = Color.FromArgb(231, 246, 242);
            CreateCourseButton.Location = new Point(4, 343);
            CreateCourseButton.Name = "CreateCourseButton";
            CreateCourseButton.Size = new Size(256, 46);
            CreateCourseButton.TabIndex = 5;
            CreateCourseButton.Text = "Create Course";
            CreateCourseButton.UseVisualStyleBackColor = false;
            CreateCourseButton.Click += CreateCourseButton_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(SelectTermComboBox);
            groupBox4.Controls.Add(SelectCourseComboBox);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(NumberOfSectionNumericUpDown);
            groupBox4.Controls.Add(SelectStudentsLinkLabel);
            groupBox4.Controls.Add(label14);
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(FinaExamDateTimePicker);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(MidTermDateTimePicker);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(0, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(263, 392);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Text = "Step1 : Details Form";
            // 
            // SelectTermComboBox
            // 
            SelectTermComboBox.FormattingEnabled = true;
            SelectTermComboBox.Location = new Point(9, 181);
            SelectTermComboBox.Name = "SelectTermComboBox";
            SelectTermComboBox.Size = new Size(244, 23);
            SelectTermComboBox.TabIndex = 11;
            // 
            // SelectCourseComboBox
            // 
            SelectCourseComboBox.FormattingEnabled = true;
            SelectCourseComboBox.Location = new Point(9, 39);
            SelectCourseComboBox.Name = "SelectCourseComboBox";
            SelectCourseComboBox.Size = new Size(244, 23);
            SelectCourseComboBox.TabIndex = 11;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(12, 297);
            label2.Name = "label2";
            label2.Size = new Size(241, 20);
            label2.TabIndex = 9;
            label2.Text = "*For add or remove students go to ";
            // 
            // NumberOfSectionNumericUpDown
            // 
            NumberOfSectionNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NumberOfSectionNumericUpDown.BackColor = Color.FromArgb(231, 246, 242);
            NumberOfSectionNumericUpDown.Location = new Point(9, 234);
            NumberOfSectionNumericUpDown.Maximum = new decimal(new int[] { 32, 0, 0, 0 });
            NumberOfSectionNumericUpDown.Minimum = new decimal(new int[] { 16, 0, 0, 0 });
            NumberOfSectionNumericUpDown.Name = "NumberOfSectionNumericUpDown";
            NumberOfSectionNumericUpDown.Size = new Size(243, 23);
            NumberOfSectionNumericUpDown.TabIndex = 8;
            NumberOfSectionNumericUpDown.Value = new decimal(new int[] { 16, 0, 0, 0 });
            // 
            // SelectStudentsLinkLabel
            // 
            SelectStudentsLinkLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SelectStudentsLinkLabel.AutoSize = true;
            SelectStudentsLinkLabel.Location = new Point(62, 317);
            SelectStudentsLinkLabel.Name = "SelectStudentsLinkLabel";
            SelectStudentsLinkLabel.Size = new Size(137, 15);
            SelectStudentsLinkLabel.TabIndex = 10;
            SelectStudentsLinkLabel.TabStop = true;
            SelectStudentsLinkLabel.Text = "Select Students Tab Page";
            SelectStudentsLinkLabel.LinkClicked += SelectStudentsLinkLabel_LinkClicked;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(8, 216);
            label14.Name = "label14";
            label14.Size = new Size(117, 15);
            label14.TabIndex = 0;
            label14.Text = "Number Of Sections:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 21);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 0;
            label1.Text = "Course Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 69);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 0;
            label4.Text = "MidTerm Exam:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(7, 163);
            label13.Name = "label13";
            label13.Size = new Size(36, 15);
            label13.TabIndex = 0;
            label13.Text = "Term:";
            // 
            // FinaExamDateTimePicker
            // 
            FinaExamDateTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FinaExamDateTimePicker.Location = new Point(9, 131);
            FinaExamDateTimePicker.Name = "FinaExamDateTimePicker";
            FinaExamDateTimePicker.ShowCheckBox = true;
            FinaExamDateTimePicker.Size = new Size(243, 23);
            FinaExamDateTimePicker.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 113);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 0;
            label5.Text = "Final Exam:";
            // 
            // MidTermDateTimePicker
            // 
            MidTermDateTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            MidTermDateTimePicker.Location = new Point(8, 87);
            MidTermDateTimePicker.Name = "MidTermDateTimePicker";
            MidTermDateTimePicker.ShowCheckBox = true;
            MidTermDateTimePicker.Size = new Size(244, 23);
            MidTermDateTimePicker.TabIndex = 2;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(groupBox1);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(groupBox3);
            splitContainer3.Size = new Size(495, 392);
            splitContainer3.SplitterDistance = 241;
            splitContainer3.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(SectionDaySpliterContainer);
            groupBox1.Controls.Add(AddSectionButton);
            groupBox1.Controls.Add(SelectedSectionPanel);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(ClassDurationTimePicker);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label7);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(241, 392);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Step2: Section Per Week";
            // 
            // SectionDaySpliterContainer
            // 
            SectionDaySpliterContainer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SectionDaySpliterContainer.Location = new Point(7, 81);
            SectionDaySpliterContainer.Name = "SectionDaySpliterContainer";
            // 
            // SectionDaySpliterContainer.Panel1
            // 
            SectionDaySpliterContainer.Panel1.Controls.Add(DayOfWeekComboBox);
            // 
            // SectionDaySpliterContainer.Panel2
            // 
            SectionDaySpliterContainer.Panel2.Controls.Add(SectionTimePicker);
            SectionDaySpliterContainer.Size = new Size(231, 23);
            SectionDaySpliterContainer.SplitterDistance = 113;
            SectionDaySpliterContainer.TabIndex = 7;
            // 
            // DayOfWeekComboBox
            // 
            DayOfWeekComboBox.BackColor = Color.FromArgb(231, 246, 242);
            DayOfWeekComboBox.Dock = DockStyle.Fill;
            DayOfWeekComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DayOfWeekComboBox.FormattingEnabled = true;
            DayOfWeekComboBox.Location = new Point(0, 0);
            DayOfWeekComboBox.Name = "DayOfWeekComboBox";
            DayOfWeekComboBox.Size = new Size(113, 23);
            DayOfWeekComboBox.TabIndex = 2;
            // 
            // SectionTimePicker
            // 
            SectionTimePicker.Dock = DockStyle.Fill;
            SectionTimePicker.Format = DateTimePickerFormat.Time;
            SectionTimePicker.Location = new Point(0, 0);
            SectionTimePicker.Name = "SectionTimePicker";
            SectionTimePicker.ShowUpDown = true;
            SectionTimePicker.Size = new Size(114, 23);
            SectionTimePicker.TabIndex = 1;
            // 
            // AddSectionButton
            // 
            AddSectionButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddSectionButton.BackColor = Color.FromArgb(231, 246, 242);
            AddSectionButton.Location = new Point(7, 110);
            AddSectionButton.Name = "AddSectionButton";
            AddSectionButton.Size = new Size(232, 24);
            AddSectionButton.TabIndex = 3;
            AddSectionButton.Text = "Add Section To Course";
            AddSectionButton.UseVisualStyleBackColor = false;
            AddSectionButton.Click += AddSectionButton_Click;
            // 
            // SelectedSectionPanel
            // 
            SelectedSectionPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SelectedSectionPanel.AutoScroll = true;
            SelectedSectionPanel.BackColor = Color.FromArgb(231, 246, 242);
            SelectedSectionPanel.Location = new Point(6, 155);
            SelectedSectionPanel.Name = "SelectedSectionPanel";
            SelectedSectionPanel.Size = new Size(232, 231);
            SelectedSectionPanel.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 63);
            label8.Name = "label8";
            label8.Size = new Size(124, 15);
            label8.TabIndex = 0;
            label8.Text = "Section Day and Time:";
            // 
            // ClassDurationTimePicker
            // 
            ClassDurationTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ClassDurationTimePicker.Format = DateTimePickerFormat.Custom;
            ClassDurationTimePicker.Location = new Point(6, 37);
            ClassDurationTimePicker.Name = "ClassDurationTimePicker";
            ClassDurationTimePicker.ShowUpDown = true;
            ClassDurationTimePicker.Size = new Size(232, 23);
            ClassDurationTimePicker.TabIndex = 1;
            ClassDurationTimePicker.Value = new DateTime(2022, 11, 19, 14, 0, 0, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 137);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 0;
            label3.Text = "Sections:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 19);
            label7.Name = "label7";
            label7.Size = new Size(98, 15);
            label7.TabIndex = 0;
            label7.Text = "Section Duration:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(SearchTeacherTextBox);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(TeachersListView);
            groupBox3.Controls.Add(SelectedTeacherTextBox);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(250, 392);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Step 3: Select Teacher";
            // 
            // SearchTeacherTextBox
            // 
            SearchTeacherTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SearchTeacherTextBox.Location = new Point(55, 363);
            SearchTeacherTextBox.Name = "SearchTeacherTextBox";
            SearchTeacherTextBox.Size = new Size(189, 23);
            SearchTeacherTextBox.TabIndex = 3;
            SearchTeacherTextBox.TextChanged += SearchTeacherTextBox_TextChanged;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label12.AutoSize = true;
            label12.Location = new Point(6, 366);
            label12.Name = "label12";
            label12.Size = new Size(45, 15);
            label12.TabIndex = 1;
            label12.Text = "Search:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 19);
            label6.Name = "label6";
            label6.Size = new Size(97, 15);
            label6.TabIndex = 1;
            label6.Text = "Selected Teacher:";
            // 
            // TeachersListView
            // 
            TeachersListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TeachersListView.BackColor = Color.FromArgb(231, 246, 242);
            TeachersListView.FullRowSelect = true;
            TeachersListView.Location = new Point(3, 37);
            TeachersListView.Name = "TeachersListView";
            TeachersListView.Size = new Size(244, 320);
            TeachersListView.TabIndex = 0;
            TeachersListView.UseCompatibleStateImageBehavior = false;
            TeachersListView.ItemActivate += TeachersListView_ItemActivate;
            // 
            // SelectedTeacherTextBox
            // 
            SelectedTeacherTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SelectedTeacherTextBox.BorderStyle = BorderStyle.None;
            SelectedTeacherTextBox.Location = new Point(112, 19);
            SelectedTeacherTextBox.Name = "SelectedTeacherTextBox";
            SelectedTeacherTextBox.ReadOnly = true;
            SelectedTeacherTextBox.Size = new Size(132, 16);
            SelectedTeacherTextBox.TabIndex = 2;
            SelectedTeacherTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // StudentTabPage
            // 
            StudentTabPage.Controls.Add(splitContainer2);
            StudentTabPage.Location = new Point(4, 24);
            StudentTabPage.Name = "StudentTabPage";
            StudentTabPage.Size = new Size(768, 398);
            StudentTabPage.TabIndex = 1;
            StudentTabPage.Text = "Select Student";
            StudentTabPage.UseVisualStyleBackColor = true;
            StudentTabPage.Enter += StudentSectionTabPage_Enter;
            // 
            // splitContainer2
            // 
            splitContainer2.BackColor = Color.FromArgb(165, 201, 202);
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(SelectStudentGPBox);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(SelectedStudentGPBox);
            splitContainer2.Size = new Size(768, 398);
            splitContainer2.SplitterDistance = 523;
            splitContainer2.TabIndex = 1;
            // 
            // SelectStudentGPBox
            // 
            SelectStudentGPBox.Controls.Add(AddStudentsButton);
            SelectStudentGPBox.Controls.Add(AllStudentsListView);
            SelectStudentGPBox.Controls.Add(panel2);
            SelectStudentGPBox.Dock = DockStyle.Fill;
            SelectStudentGPBox.Location = new Point(0, 0);
            SelectStudentGPBox.Name = "SelectStudentGPBox";
            SelectStudentGPBox.Size = new Size(523, 398);
            SelectStudentGPBox.TabIndex = 0;
            SelectStudentGPBox.TabStop = false;
            SelectStudentGPBox.Text = "Step4: Select students";
            // 
            // AddStudentsButton
            // 
            AddStudentsButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddStudentsButton.BackColor = Color.FromArgb(231, 246, 242);
            AddStudentsButton.Location = new Point(200, 369);
            AddStudentsButton.Name = "AddStudentsButton";
            AddStudentsButton.Size = new Size(314, 23);
            AddStudentsButton.TabIndex = 3;
            AddStudentsButton.Text = "Add Students To Course";
            AddStudentsButton.UseVisualStyleBackColor = false;
            AddStudentsButton.Click += AddStudentsButton_Click;
            // 
            // AllStudentsListView
            // 
            AllStudentsListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AllStudentsListView.BackColor = Color.FromArgb(231, 246, 242);
            AllStudentsListView.CheckBoxes = true;
            AllStudentsListView.Columns.AddRange(new ColumnHeader[] { NameHeader, StudentIdHeader, MajorHeader, EntryYearHeader });
            AllStudentsListView.FullRowSelect = true;
            AllStudentsListView.HoverSelection = true;
            AllStudentsListView.Location = new Point(200, 22);
            AllStudentsListView.Name = "AllStudentsListView";
            AllStudentsListView.Size = new Size(314, 340);
            AllStudentsListView.TabIndex = 1;
            AllStudentsListView.UseCompatibleStateImageBehavior = false;
            // 
            // NameHeader
            // 
            NameHeader.Text = "Name";
            // 
            // StudentIdHeader
            // 
            StudentIdHeader.Text = "Student ID";
            StudentIdHeader.TextAlign = HorizontalAlignment.Center;
            // 
            // MajorHeader
            // 
            MajorHeader.Text = "Major";
            MajorHeader.TextAlign = HorizontalAlignment.Center;
            // 
            // EntryYearHeader
            // 
            EntryYearHeader.Text = "Entry year";
            EntryYearHeader.TextAlign = HorizontalAlignment.Center;
            // 
            // panel2
            // 
            panel2.Controls.Add(StudentIDCheckBox);
            panel2.Controls.Add(StudentIDNumric);
            panel2.Controls.Add(DegreeComboBox);
            panel2.Controls.Add(MajorComboBox);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(SearchFullNameStudentTextBox);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Location = new Point(6, 22);
            panel2.Name = "panel2";
            panel2.Size = new Size(188, 203);
            panel2.TabIndex = 0;
            // 
            // StudentIDCheckBox
            // 
            StudentIDCheckBox.AutoSize = true;
            StudentIDCheckBox.FlatStyle = FlatStyle.Flat;
            StudentIDCheckBox.Location = new Point(3, 142);
            StudentIDCheckBox.Name = "StudentIDCheckBox";
            StudentIDCheckBox.Size = new Size(78, 19);
            StudentIDCheckBox.TabIndex = 4;
            StudentIDCheckBox.Text = "StudentID:";
            StudentIDCheckBox.UseVisualStyleBackColor = true;
            StudentIDCheckBox.CheckedChanged += StudentIDCheckBox_CheckedChanged;
            // 
            // StudentIDNumric
            // 
            StudentIDNumric.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            StudentIDNumric.Enabled = false;
            StudentIDNumric.Location = new Point(3, 162);
            StudentIDNumric.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            StudentIDNumric.Name = "StudentIDNumric";
            StudentIDNumric.Size = new Size(182, 23);
            StudentIDNumric.TabIndex = 3;
            // 
            // DegreeComboBox
            // 
            DegreeComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DegreeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DegreeComboBox.FormattingEnabled = true;
            DegreeComboBox.Location = new Point(3, 113);
            DegreeComboBox.Name = "DegreeComboBox";
            DegreeComboBox.Size = new Size(182, 23);
            DegreeComboBox.TabIndex = 2;
            // 
            // MajorComboBox
            // 
            MajorComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            MajorComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            MajorComboBox.FormattingEnabled = true;
            MajorComboBox.Location = new Point(3, 69);
            MajorComboBox.Name = "MajorComboBox";
            MajorComboBox.Size = new Size(182, 23);
            MajorComboBox.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 95);
            label11.Name = "label11";
            label11.Size = new Size(41, 15);
            label11.TabIndex = 0;
            label11.Text = "Degre:";
            // 
            // SearchFullNameStudentTextBox
            // 
            SearchFullNameStudentTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SearchFullNameStudentTextBox.BackColor = Color.FromArgb(231, 246, 242);
            SearchFullNameStudentTextBox.Location = new Point(3, 25);
            SearchFullNameStudentTextBox.Name = "SearchFullNameStudentTextBox";
            SearchFullNameStudentTextBox.Size = new Size(182, 23);
            SearchFullNameStudentTextBox.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 51);
            label10.Name = "label10";
            label10.Size = new Size(41, 15);
            label10.TabIndex = 0;
            label10.Text = "Major:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 7);
            label9.Name = "label9";
            label9.Size = new Size(89, 15);
            label9.TabIndex = 0;
            label9.Text = "Search Student:";
            // 
            // SelectedStudentGPBox
            // 
            SelectedStudentGPBox.Controls.Add(RemoveCheckedStudentsFromSelectedStudentsButton);
            SelectedStudentGPBox.Controls.Add(SelectedStudentsListView);
            SelectedStudentGPBox.Dock = DockStyle.Fill;
            SelectedStudentGPBox.Location = new Point(0, 0);
            SelectedStudentGPBox.Name = "SelectedStudentGPBox";
            SelectedStudentGPBox.Size = new Size(241, 398);
            SelectedStudentGPBox.TabIndex = 0;
            SelectedStudentGPBox.TabStop = false;
            SelectedStudentGPBox.Text = "Selected Students";
            // 
            // RemoveCheckedStudentsFromSelectedStudentsButton
            // 
            RemoveCheckedStudentsFromSelectedStudentsButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RemoveCheckedStudentsFromSelectedStudentsButton.BackColor = Color.FromArgb(231, 246, 242);
            RemoveCheckedStudentsFromSelectedStudentsButton.Location = new Point(6, 369);
            RemoveCheckedStudentsFromSelectedStudentsButton.Name = "RemoveCheckedStudentsFromSelectedStudentsButton";
            RemoveCheckedStudentsFromSelectedStudentsButton.Size = new Size(229, 23);
            RemoveCheckedStudentsFromSelectedStudentsButton.TabIndex = 1;
            RemoveCheckedStudentsFromSelectedStudentsButton.Text = "Remove From Course";
            RemoveCheckedStudentsFromSelectedStudentsButton.UseVisualStyleBackColor = false;
            RemoveCheckedStudentsFromSelectedStudentsButton.Click += RemoveCheckedStudentsFromSelectedStudentsButton_Click;
            // 
            // SelectedStudentsListView
            // 
            SelectedStudentsListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SelectedStudentsListView.BackColor = Color.FromArgb(231, 246, 242);
            SelectedStudentsListView.CheckBoxes = true;
            SelectedStudentsListView.FullRowSelect = true;
            SelectedStudentsListView.Location = new Point(6, 22);
            SelectedStudentsListView.Name = "SelectedStudentsListView";
            SelectedStudentsListView.Size = new Size(229, 341);
            SelectedStudentsListView.Sorting = SortOrder.Ascending;
            SelectedStudentsListView.TabIndex = 0;
            SelectedStudentsListView.UseCompatibleStateImageBehavior = false;
            // 
            // RemoveFromSelectedStudentsToolTip
            // 
            RemoveFromSelectedStudentsToolTip.ToolTipIcon = ToolTipIcon.Info;
            // 
            // ClassManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 91, 100);
            ClientSize = new Size(800, 450);
            Controls.Add(MainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ClassManagementForm";
            Text = "ClassManagementForm";
            Load += ClassManagementForm_Load;
            MainPanel.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            CreateCourseTabPage.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumberOfSectionNumericUpDown).EndInit();
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            SectionDaySpliterContainer.Panel1.ResumeLayout(false);
            SectionDaySpliterContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SectionDaySpliterContainer).EndInit();
            SectionDaySpliterContainer.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            StudentTabPage.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            SelectStudentGPBox.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)StudentIDNumric).EndInit();
            SelectedStudentGPBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPanel;
        private TabControl tabControl1;
        private TabPage CreateCourseTabPage;
        private SplitContainer splitContainer1;
        private Label label1;
        private TabPage StudentTabPage;
        private Button CreateCourseButton;
        private DateTimePicker FinaExamDateTimePicker;
        private DateTimePicker MidTermDateTimePicker;
        private Label label5;
        private Label label4;
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
        private SplitContainer SectionDaySpliterContainer;
        private Label label2;
        private LinkLabel SelectStudentsLinkLabel;
        private SplitContainer splitContainer2;
        private GroupBox SelectStudentGPBox;
        private Button AddStudentsButton;
        private ListView AllStudentsListView;
        private ColumnHeader NameHeader;
        private ColumnHeader StudentIdHeader;
        private ColumnHeader MajorHeader;
        private ColumnHeader EntryYearHeader;
        private Panel panel2;
        private CheckBox StudentIDCheckBox;
        private NumericUpDown StudentIDNumric;
        private ComboBox DegreeComboBox;
        private ComboBox MajorComboBox;
        private Label label11;
        private TextBox SearchFullNameStudentTextBox;
        private Label label10;
        private Label label9;
        private GroupBox SelectedStudentGPBox;
        private Button RemoveCheckedStudentsFromSelectedStudentsButton;
        private ListView SelectedStudentsListView;
        private ComboBox SelectTermComboBox;
        private ComboBox SelectCourseComboBox;
    }
}