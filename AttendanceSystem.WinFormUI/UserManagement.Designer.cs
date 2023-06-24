namespace AttendanceSystem.WinFormUI
{
    partial class UserManagement
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
            splitContainer1 = new SplitContainer();
            StudentFormResetLinkLabel = new LinkLabel();
            StudentCreateSaveButton = new Button();
            StudentBODDateTimePicker = new DateTimePicker();
            StudentGradeComboBox = new ComboBox();
            StudentMajorComboBox = new ComboBox();
            StudentIdTextBox = new TextBox();
            StudentFatherNameTextBox = new TextBox();
            StudentLastNameTextBox = new TextBox();
            StudentFirstNameTextBox = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            StudentsListView = new ListView();
            StudentDeleteButton = new Button();
            label1 = new Label();
            StudentSearchTextBox = new TextBox();
            MainPanel = new Panel();
            UserTabControl = new TabControl();
            StudentTabPage = new TabPage();
            TeacherTabPage = new TabPage();
            panel2 = new Panel();
            splitContainer2 = new SplitContainer();
            TeacherFormResetLinkLabel = new LinkLabel();
            TeacherCreateSaveButton = new Button();
            TeacherBODDateTimePicker = new DateTimePicker();
            TeacherIdTextBox = new TextBox();
            TeacherFatherNameTextBox = new TextBox();
            TeacherLastNameTextBox = new TextBox();
            TeacherFirstNameTextBox = new TextBox();
            label10 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            TeachersListView = new ListView();
            TeacherDeleteButton = new Button();
            TeacherSearchTextBox = new TextBox();
            label16 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            MainPanel.SuspendLayout();
            UserTabControl.SuspendLayout();
            StudentTabPage.SuspendLayout();
            TeacherTabPage.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = Color.FromArgb(165, 201, 202);
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.FromArgb(165, 201, 202);
            splitContainer1.Panel1.Controls.Add(StudentFormResetLinkLabel);
            splitContainer1.Panel1.Controls.Add(StudentCreateSaveButton);
            splitContainer1.Panel1.Controls.Add(StudentBODDateTimePicker);
            splitContainer1.Panel1.Controls.Add(StudentGradeComboBox);
            splitContainer1.Panel1.Controls.Add(StudentMajorComboBox);
            splitContainer1.Panel1.Controls.Add(StudentIdTextBox);
            splitContainer1.Panel1.Controls.Add(StudentFatherNameTextBox);
            splitContainer1.Panel1.Controls.Add(StudentLastNameTextBox);
            splitContainer1.Panel1.Controls.Add(StudentFirstNameTextBox);
            splitContainer1.Panel1.Controls.Add(label8);
            splitContainer1.Panel1.Controls.Add(label9);
            splitContainer1.Panel1.Controls.Add(label7);
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.FromArgb(165, 201, 202);
            splitContainer1.Panel2.Controls.Add(StudentsListView);
            splitContainer1.Panel2.Controls.Add(StudentDeleteButton);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(StudentSearchTextBox);
            splitContainer1.Size = new Size(812, 421);
            splitContainer1.SplitterDistance = 512;
            splitContainer1.TabIndex = 0;
            // 
            // StudentFormResetLinkLabel
            // 
            StudentFormResetLinkLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            StudentFormResetLinkLabel.AutoSize = true;
            StudentFormResetLinkLabel.Location = new Point(3, 347);
            StudentFormResetLinkLabel.Name = "StudentFormResetLinkLabel";
            StudentFormResetLinkLabel.Size = new Size(35, 15);
            StudentFormResetLinkLabel.TabIndex = 6;
            StudentFormResetLinkLabel.TabStop = true;
            StudentFormResetLinkLabel.Text = "Reset";
            StudentFormResetLinkLabel.VisitedLinkColor = Color.Blue;
            StudentFormResetLinkLabel.LinkClicked += ResetLinkLabel_LinkClicked;
            // 
            // StudentCreateSaveButton
            // 
            StudentCreateSaveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            StudentCreateSaveButton.BackColor = Color.FromArgb(231, 246, 242);
            StudentCreateSaveButton.Location = new Point(3, 365);
            StudentCreateSaveButton.Name = "StudentCreateSaveButton";
            StudentCreateSaveButton.Size = new Size(506, 53);
            StudentCreateSaveButton.TabIndex = 4;
            StudentCreateSaveButton.Text = "Save/Create";
            StudentCreateSaveButton.UseVisualStyleBackColor = false;
            StudentCreateSaveButton.Click += StudentCreateSaveButton_Click;
            // 
            // StudentBODDateTimePicker
            // 
            StudentBODDateTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            StudentBODDateTimePicker.Location = new Point(328, 103);
            StudentBODDateTimePicker.Name = "StudentBODDateTimePicker";
            StudentBODDateTimePicker.Size = new Size(168, 23);
            StudentBODDateTimePicker.TabIndex = 6;
            // 
            // StudentGradeComboBox
            // 
            StudentGradeComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            StudentGradeComboBox.BackColor = Color.FromArgb(231, 246, 242);
            StudentGradeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            StudentGradeComboBox.FormattingEnabled = true;
            StudentGradeComboBox.Location = new Point(328, 133);
            StudentGradeComboBox.Name = "StudentGradeComboBox";
            StudentGradeComboBox.Size = new Size(168, 23);
            StudentGradeComboBox.TabIndex = 7;
            // 
            // StudentMajorComboBox
            // 
            StudentMajorComboBox.BackColor = Color.FromArgb(231, 246, 242);
            StudentMajorComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            StudentMajorComboBox.FormattingEnabled = true;
            StudentMajorComboBox.Location = new Point(94, 133);
            StudentMajorComboBox.Name = "StudentMajorComboBox";
            StudentMajorComboBox.Size = new Size(162, 23);
            StudentMajorComboBox.TabIndex = 4;
            // 
            // StudentIdTextBox
            // 
            StudentIdTextBox.BackColor = Color.FromArgb(231, 246, 242);
            StudentIdTextBox.Location = new Point(94, 102);
            StudentIdTextBox.Name = "StudentIdTextBox";
            StudentIdTextBox.Size = new Size(162, 23);
            StudentIdTextBox.TabIndex = 3;
            // 
            // StudentFatherNameTextBox
            // 
            StudentFatherNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            StudentFatherNameTextBox.BackColor = Color.FromArgb(231, 246, 242);
            StudentFatherNameTextBox.Location = new Point(94, 73);
            StudentFatherNameTextBox.Name = "StudentFatherNameTextBox";
            StudentFatherNameTextBox.Size = new Size(402, 23);
            StudentFatherNameTextBox.TabIndex = 2;
            // 
            // StudentLastNameTextBox
            // 
            StudentLastNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            StudentLastNameTextBox.BackColor = Color.FromArgb(231, 246, 242);
            StudentLastNameTextBox.Location = new Point(94, 43);
            StudentLastNameTextBox.Name = "StudentLastNameTextBox";
            StudentLastNameTextBox.Size = new Size(402, 23);
            StudentLastNameTextBox.TabIndex = 1;
            // 
            // StudentFirstNameTextBox
            // 
            StudentFirstNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            StudentFirstNameTextBox.BackColor = Color.FromArgb(231, 246, 242);
            StudentFirstNameTextBox.Location = new Point(94, 13);
            StudentFirstNameTextBox.Name = "StudentFirstNameTextBox";
            StudentFirstNameTextBox.Size = new Size(402, 23);
            StudentFirstNameTextBox.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(265, 136);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 0;
            label8.Text = "Grade:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(263, 109);
            label9.Name = "label9";
            label9.Size = new Size(62, 15);
            label9.TabIndex = 0;
            label9.Text = "Birth Date:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 134);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 0;
            label7.Text = "Major:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 105);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 0;
            label5.Text = "StudentID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 76);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 0;
            label4.Text = "Father Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 46);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 0;
            label3.Text = "Last Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 21);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 0;
            label2.Text = "First Name:";
            // 
            // StudentsListView
            // 
            StudentsListView.AllowColumnReorder = true;
            StudentsListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            StudentsListView.BackColor = Color.FromArgb(231, 246, 242);
            StudentsListView.FullRowSelect = true;
            StudentsListView.Location = new Point(3, 3);
            StudentsListView.MultiSelect = false;
            StudentsListView.Name = "StudentsListView";
            StudentsListView.ShowItemToolTips = true;
            StudentsListView.Size = new Size(290, 382);
            StudentsListView.TabIndex = 4;
            StudentsListView.UseCompatibleStateImageBehavior = false;
            StudentsListView.View = View.Details;
            StudentsListView.ItemActivate += StudentsListView_ItemActivate;
            // 
            // StudentDeleteButton
            // 
            StudentDeleteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            StudentDeleteButton.Location = new Point(228, 391);
            StudentDeleteButton.Name = "StudentDeleteButton";
            StudentDeleteButton.Size = new Size(65, 23);
            StudentDeleteButton.TabIndex = 3;
            StudentDeleteButton.Text = "Delete";
            StudentDeleteButton.UseVisualStyleBackColor = true;
            StudentDeleteButton.Click += StudentDeleteButton_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(3, 394);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 2;
            label1.Text = "Search:";
            // 
            // StudentSearchTextBox
            // 
            StudentSearchTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            StudentSearchTextBox.BackColor = Color.FromArgb(231, 246, 242);
            StudentSearchTextBox.Location = new Point(47, 391);
            StudentSearchTextBox.Name = "StudentSearchTextBox";
            StudentSearchTextBox.Size = new Size(173, 23);
            StudentSearchTextBox.TabIndex = 1;
            StudentSearchTextBox.TextChanged += StudentSearchTextBox_TextChanged;
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(splitContainer1);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(3, 3);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(812, 421);
            MainPanel.TabIndex = 0;
            // 
            // UserTabControl
            // 
            UserTabControl.Controls.Add(StudentTabPage);
            UserTabControl.Controls.Add(TeacherTabPage);
            UserTabControl.Dock = DockStyle.Fill;
            UserTabControl.Location = new Point(0, 0);
            UserTabControl.Margin = new Padding(0);
            UserTabControl.Name = "UserTabControl";
            UserTabControl.Padding = new Point(0, 0);
            UserTabControl.SelectedIndex = 0;
            UserTabControl.Size = new Size(826, 455);
            UserTabControl.SizeMode = TabSizeMode.Fixed;
            UserTabControl.TabIndex = 1;
            // 
            // StudentTabPage
            // 
            StudentTabPage.BackColor = Color.FromArgb(165, 201, 202);
            StudentTabPage.Controls.Add(MainPanel);
            StudentTabPage.Location = new Point(4, 24);
            StudentTabPage.Name = "StudentTabPage";
            StudentTabPage.Padding = new Padding(3);
            StudentTabPage.Size = new Size(818, 427);
            StudentTabPage.TabIndex = 0;
            StudentTabPage.Text = "Students";
            // 
            // TeacherTabPage
            // 
            TeacherTabPage.BackColor = Color.Turquoise;
            TeacherTabPage.Controls.Add(panel2);
            TeacherTabPage.Location = new Point(4, 24);
            TeacherTabPage.Name = "TeacherTabPage";
            TeacherTabPage.Padding = new Padding(3);
            TeacherTabPage.Size = new Size(818, 427);
            TeacherTabPage.TabIndex = 1;
            TeacherTabPage.Text = "Teachers";
            // 
            // panel2
            // 
            panel2.Controls.Add(splitContainer2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(812, 421);
            panel2.TabIndex = 1;
            // 
            // splitContainer2
            // 
            splitContainer2.BackColor = Color.FromArgb(165, 201, 202);
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Margin = new Padding(0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.BackColor = Color.FromArgb(165, 201, 202);
            splitContainer2.Panel1.Controls.Add(TeacherFormResetLinkLabel);
            splitContainer2.Panel1.Controls.Add(TeacherCreateSaveButton);
            splitContainer2.Panel1.Controls.Add(TeacherBODDateTimePicker);
            splitContainer2.Panel1.Controls.Add(TeacherIdTextBox);
            splitContainer2.Panel1.Controls.Add(TeacherFatherNameTextBox);
            splitContainer2.Panel1.Controls.Add(TeacherLastNameTextBox);
            splitContainer2.Panel1.Controls.Add(TeacherFirstNameTextBox);
            splitContainer2.Panel1.Controls.Add(label10);
            splitContainer2.Panel1.Controls.Add(label12);
            splitContainer2.Panel1.Controls.Add(label13);
            splitContainer2.Panel1.Controls.Add(label14);
            splitContainer2.Panel1.Controls.Add(label15);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.BackColor = Color.FromArgb(165, 201, 202);
            splitContainer2.Panel2.Controls.Add(TeachersListView);
            splitContainer2.Panel2.Controls.Add(TeacherDeleteButton);
            splitContainer2.Panel2.Controls.Add(TeacherSearchTextBox);
            splitContainer2.Panel2.Controls.Add(label16);
            splitContainer2.Size = new Size(812, 421);
            splitContainer2.SplitterDistance = 512;
            splitContainer2.TabIndex = 0;
            // 
            // TeacherFormResetLinkLabel
            // 
            TeacherFormResetLinkLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            TeacherFormResetLinkLabel.AutoSize = true;
            TeacherFormResetLinkLabel.Location = new Point(3, 347);
            TeacherFormResetLinkLabel.Name = "TeacherFormResetLinkLabel";
            TeacherFormResetLinkLabel.Size = new Size(35, 15);
            TeacherFormResetLinkLabel.TabIndex = 7;
            TeacherFormResetLinkLabel.TabStop = true;
            TeacherFormResetLinkLabel.Text = "Reset";
            TeacherFormResetLinkLabel.VisitedLinkColor = Color.Blue;
            TeacherFormResetLinkLabel.LinkClicked += TeacherFormResetLinkLabel_LinkClicked;
            // 
            // TeacherCreateSaveButton
            // 
            TeacherCreateSaveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TeacherCreateSaveButton.BackColor = Color.FromArgb(231, 246, 242);
            TeacherCreateSaveButton.Location = new Point(3, 365);
            TeacherCreateSaveButton.Name = "TeacherCreateSaveButton";
            TeacherCreateSaveButton.Size = new Size(506, 53);
            TeacherCreateSaveButton.TabIndex = 5;
            TeacherCreateSaveButton.Text = "Save/Create";
            TeacherCreateSaveButton.UseVisualStyleBackColor = false;
            TeacherCreateSaveButton.Click += TeacherCreateSaveButton_Click;
            // 
            // TeacherBODDateTimePicker
            // 
            TeacherBODDateTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TeacherBODDateTimePicker.Location = new Point(328, 103);
            TeacherBODDateTimePicker.Name = "TeacherBODDateTimePicker";
            TeacherBODDateTimePicker.Size = new Size(167, 23);
            TeacherBODDateTimePicker.TabIndex = 4;
            // 
            // TeacherIdTextBox
            // 
            TeacherIdTextBox.BackColor = Color.FromArgb(231, 246, 242);
            TeacherIdTextBox.Location = new Point(94, 102);
            TeacherIdTextBox.Name = "TeacherIdTextBox";
            TeacherIdTextBox.Size = new Size(162, 23);
            TeacherIdTextBox.TabIndex = 3;
            // 
            // TeacherFatherNameTextBox
            // 
            TeacherFatherNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TeacherFatherNameTextBox.BackColor = Color.FromArgb(231, 246, 242);
            TeacherFatherNameTextBox.Location = new Point(94, 73);
            TeacherFatherNameTextBox.Name = "TeacherFatherNameTextBox";
            TeacherFatherNameTextBox.Size = new Size(401, 23);
            TeacherFatherNameTextBox.TabIndex = 2;
            // 
            // TeacherLastNameTextBox
            // 
            TeacherLastNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TeacherLastNameTextBox.BackColor = Color.FromArgb(231, 246, 242);
            TeacherLastNameTextBox.Location = new Point(94, 43);
            TeacherLastNameTextBox.Name = "TeacherLastNameTextBox";
            TeacherLastNameTextBox.Size = new Size(401, 23);
            TeacherLastNameTextBox.TabIndex = 1;
            // 
            // TeacherFirstNameTextBox
            // 
            TeacherFirstNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TeacherFirstNameTextBox.BackColor = Color.FromArgb(231, 246, 242);
            TeacherFirstNameTextBox.Location = new Point(94, 13);
            TeacherFirstNameTextBox.Name = "TeacherFirstNameTextBox";
            TeacherFirstNameTextBox.Size = new Size(401, 23);
            TeacherFirstNameTextBox.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(263, 109);
            label10.Name = "label10";
            label10.Size = new Size(62, 15);
            label10.TabIndex = 0;
            label10.Text = "Birth Date:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(12, 105);
            label12.Name = "label12";
            label12.Size = new Size(61, 15);
            label12.TabIndex = 0;
            label12.Text = "TeacherID:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(12, 76);
            label13.Name = "label13";
            label13.Size = new Size(78, 15);
            label13.TabIndex = 0;
            label13.Text = "Father Name:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(12, 46);
            label14.Name = "label14";
            label14.Size = new Size(66, 15);
            label14.TabIndex = 0;
            label14.Text = "Last Name:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(12, 21);
            label15.Name = "label15";
            label15.Size = new Size(67, 15);
            label15.TabIndex = 0;
            label15.Text = "First Name:";
            // 
            // TeachersListView
            // 
            TeachersListView.AllowColumnReorder = true;
            TeachersListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TeachersListView.BackColor = Color.FromArgb(231, 246, 242);
            TeachersListView.FullRowSelect = true;
            TeachersListView.Location = new Point(3, 3);
            TeachersListView.MultiSelect = false;
            TeachersListView.Name = "TeachersListView";
            TeachersListView.ShowItemToolTips = true;
            TeachersListView.Size = new Size(290, 382);
            TeachersListView.TabIndex = 6;
            TeachersListView.UseCompatibleStateImageBehavior = false;
            TeachersListView.View = View.Details;
            TeachersListView.ItemActivate += TeachersListView_ItemActivate;
            // 
            // TeacherDeleteButton
            // 
            TeacherDeleteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            TeacherDeleteButton.Location = new Point(226, 391);
            TeacherDeleteButton.Name = "TeacherDeleteButton";
            TeacherDeleteButton.Size = new Size(65, 23);
            TeacherDeleteButton.TabIndex = 5;
            TeacherDeleteButton.Text = "Delete";
            TeacherDeleteButton.UseVisualStyleBackColor = true;
            TeacherDeleteButton.Click += TeacherDeleteButton_Click;
            // 
            // TeacherSearchTextBox
            // 
            TeacherSearchTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TeacherSearchTextBox.BackColor = Color.FromArgb(231, 246, 242);
            TeacherSearchTextBox.Location = new Point(45, 391);
            TeacherSearchTextBox.Name = "TeacherSearchTextBox";
            TeacherSearchTextBox.Size = new Size(173, 23);
            TeacherSearchTextBox.TabIndex = 4;
            TeacherSearchTextBox.TextChanged += TeacherSearchTextBox_TextChanged;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label16.AutoSize = true;
            label16.Location = new Point(3, 394);
            label16.Name = "label16";
            label16.Size = new Size(45, 15);
            label16.TabIndex = 2;
            label16.Text = "Search:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(UserTabControl);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(826, 455);
            panel1.TabIndex = 2;
            // 
            // UserManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 91, 100);
            ClientSize = new Size(850, 479);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserManagement";
            Text = "Managment";
            Load += StudentsManagement_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            MainPanel.ResumeLayout(false);
            UserTabControl.ResumeLayout(false);
            StudentTabPage.ResumeLayout(false);
            TeacherTabPage.ResumeLayout(false);
            panel2.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button StudentCreateSaveButton;
        private DateTimePicker StudentBODDateTimePicker;
        private ComboBox StudentGradeComboBox;
        private ComboBox StudentMajorComboBox;
        private TextBox StudentIdTextBox;
        private TextBox StudentFatherNameTextBox;
        private TextBox StudentLastNameTextBox;
        private TextBox StudentFirstNameTextBox;
        private Label label8;
        private Label label9;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox StudentSearchTextBox;
        private Panel MainPanel;
        private TabControl UserTabControl;
        private TabPage StudentTabPage;
        private TabPage TeacherTabPage;
        private Panel panel1;
        private Panel panel2;
        private SplitContainer splitContainer2;
        private Button TeacherCreateSaveButton;
        private DateTimePicker TeacherBODDateTimePicker;
        private TextBox TeacherIdTextBox;
        private TextBox TeacherFatherNameTextBox;
        private TextBox TeacherLastNameTextBox;
        private TextBox TeacherFirstNameTextBox;
        private Label label10;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Button StudentDeleteButton;
        private Button TeacherDeleteButton;
        private TextBox TeacherSearchTextBox;
        private ListView StudentsListView;
        private LinkLabel StudentFormResetLinkLabel;
        private ListView TeachersListView;
        private LinkLabel TeacherFormResetLinkLabel;
    }
}