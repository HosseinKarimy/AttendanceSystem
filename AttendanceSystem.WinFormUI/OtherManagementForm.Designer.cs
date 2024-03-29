﻿namespace AttendanceSystem.WinFormUI
{
    partial class OtherManagementForm
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
            OtherManagementTabControl = new TabControl();
            MajorTabPage = new TabPage();
            MainPanel = new Panel();
            splitContainer1 = new SplitContainer();
            MajorFormResetLinkLabel = new LinkLabel();
            MajorCreateSaveButton = new Button();
            MajorNameTextBox = new TextBox();
            label2 = new Label();
            label4 = new Label();
            MajorSearchTextBox = new TextBox();
            MajorListView = new ListView();
            MajorDeleteButton = new Button();
            label1 = new Label();
            DegreeTabPage = new TabPage();
            panel2 = new Panel();
            splitContainer2 = new SplitContainer();
            DegreeResetFormLinkLabel = new LinkLabel();
            DegreeSaveCreateButton = new Button();
            DegreeNameTextBox = new TextBox();
            label3 = new Label();
            DegreeListView = new ListView();
            label5 = new Label();
            DegreeSearchTextBox = new TextBox();
            DegreeDeleteButton = new Button();
            label6 = new Label();
            TermTabPage = new TabPage();
            panel3 = new Panel();
            splitContainer3 = new SplitContainer();
            TermIDNumericUpDown = new NumericUpDown();
            label10 = new Label();
            TermStartDateTimePicker = new DateTimePicker();
            TermResetFormLinkLabel = new LinkLabel();
            TermSaveCreateButton = new Button();
            label7 = new Label();
            TermsListView = new ListView();
            label8 = new Label();
            TermSearchTextBox = new TextBox();
            TermDeleteButton = new Button();
            label9 = new Label();
            CoursesTabPage = new TabPage();
            panel1 = new Panel();
            splitContainer4 = new SplitContainer();
            CourseResetLinkLabel = new LinkLabel();
            CourseSaveCreateButton = new Button();
            CourseNameTextBox = new TextBox();
            label11 = new Label();
            label12 = new Label();
            CourseSearchTextBox = new TextBox();
            CourseListView = new ListView();
            CourseDeleteButton = new Button();
            label13 = new Label();
            OtherManagementTabControl.SuspendLayout();
            MajorTabPage.SuspendLayout();
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            DegreeTabPage.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            TermTabPage.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TermIDNumericUpDown).BeginInit();
            CoursesTabPage.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).BeginInit();
            splitContainer4.Panel1.SuspendLayout();
            splitContainer4.Panel2.SuspendLayout();
            splitContainer4.SuspendLayout();
            SuspendLayout();
            // 
            // OtherManagementTabControl
            // 
            OtherManagementTabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OtherManagementTabControl.Controls.Add(MajorTabPage);
            OtherManagementTabControl.Controls.Add(DegreeTabPage);
            OtherManagementTabControl.Controls.Add(TermTabPage);
            OtherManagementTabControl.Controls.Add(CoursesTabPage);
            OtherManagementTabControl.Location = new Point(9, 9);
            OtherManagementTabControl.Margin = new Padding(0);
            OtherManagementTabControl.Name = "OtherManagementTabControl";
            OtherManagementTabControl.Padding = new Point(0, 0);
            OtherManagementTabControl.SelectedIndex = 0;
            OtherManagementTabControl.Size = new Size(816, 456);
            OtherManagementTabControl.SizeMode = TabSizeMode.Fixed;
            OtherManagementTabControl.TabIndex = 1;
            // 
            // MajorTabPage
            // 
            MajorTabPage.BackColor = Color.FromArgb(165, 201, 202);
            MajorTabPage.Controls.Add(MainPanel);
            MajorTabPage.Location = new Point(4, 24);
            MajorTabPage.Name = "MajorTabPage";
            MajorTabPage.Padding = new Padding(3);
            MajorTabPage.Size = new Size(808, 428);
            MajorTabPage.TabIndex = 0;
            MajorTabPage.Text = "Majors";
            MajorTabPage.Enter += MajorTabPage_Enter;
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(splitContainer1);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(3, 3);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(802, 422);
            MainPanel.TabIndex = 0;
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
            splitContainer1.Panel1.Controls.Add(MajorFormResetLinkLabel);
            splitContainer1.Panel1.Controls.Add(MajorCreateSaveButton);
            splitContainer1.Panel1.Controls.Add(MajorNameTextBox);
            splitContainer1.Panel1.Controls.Add(label2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.FromArgb(165, 201, 202);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(MajorSearchTextBox);
            splitContainer1.Panel2.Controls.Add(MajorListView);
            splitContainer1.Panel2.Controls.Add(MajorDeleteButton);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Size = new Size(802, 422);
            splitContainer1.SplitterDistance = 505;
            splitContainer1.TabIndex = 0;
            // 
            // MajorFormResetLinkLabel
            // 
            MajorFormResetLinkLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            MajorFormResetLinkLabel.AutoSize = true;
            MajorFormResetLinkLabel.Location = new Point(3, 351);
            MajorFormResetLinkLabel.Name = "MajorFormResetLinkLabel";
            MajorFormResetLinkLabel.Size = new Size(35, 15);
            MajorFormResetLinkLabel.TabIndex = 6;
            MajorFormResetLinkLabel.TabStop = true;
            MajorFormResetLinkLabel.Text = "Reset";
            MajorFormResetLinkLabel.VisitedLinkColor = Color.Blue;
            // 
            // MajorCreateSaveButton
            // 
            MajorCreateSaveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MajorCreateSaveButton.BackColor = Color.FromArgb(231, 246, 242);
            MajorCreateSaveButton.Location = new Point(3, 369);
            MajorCreateSaveButton.Name = "MajorCreateSaveButton";
            MajorCreateSaveButton.Size = new Size(499, 50);
            MajorCreateSaveButton.TabIndex = 4;
            MajorCreateSaveButton.Text = "Save/Create";
            MajorCreateSaveButton.UseVisualStyleBackColor = false;
            MajorCreateSaveButton.Click += MajorCreateSaveButton_Click;
            // 
            // MajorNameTextBox
            // 
            MajorNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            MajorNameTextBox.BackColor = Color.FromArgb(231, 246, 242);
            MajorNameTextBox.Location = new Point(85, 13);
            MajorNameTextBox.Name = "MajorNameTextBox";
            MajorNameTextBox.Size = new Size(405, 23);
            MajorNameTextBox.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 16);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 0;
            label2.Text = "Major Name:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(3, 396);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 6;
            label4.Text = "Search:";
            // 
            // MajorSearchTextBox
            // 
            MajorSearchTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MajorSearchTextBox.BackColor = Color.FromArgb(231, 246, 242);
            MajorSearchTextBox.Location = new Point(47, 393);
            MajorSearchTextBox.Name = "MajorSearchTextBox";
            MajorSearchTextBox.Size = new Size(173, 23);
            MajorSearchTextBox.TabIndex = 5;
            // 
            // MajorListView
            // 
            MajorListView.AllowColumnReorder = true;
            MajorListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MajorListView.BackColor = Color.FromArgb(231, 246, 242);
            MajorListView.FullRowSelect = true;
            MajorListView.Location = new Point(3, 3);
            MajorListView.MultiSelect = false;
            MajorListView.Name = "MajorListView";
            MajorListView.ShowItemToolTips = true;
            MajorListView.Size = new Size(287, 378);
            MajorListView.TabIndex = 4;
            MajorListView.UseCompatibleStateImageBehavior = false;
            MajorListView.View = View.Details;
            MajorListView.ItemActivate += MajorListView_ItemActivate;
            // 
            // MajorDeleteButton
            // 
            MajorDeleteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            MajorDeleteButton.Location = new Point(226, 392);
            MajorDeleteButton.Name = "MajorDeleteButton";
            MajorDeleteButton.Size = new Size(64, 24);
            MajorDeleteButton.TabIndex = 3;
            MajorDeleteButton.Text = "Delete";
            MajorDeleteButton.UseVisualStyleBackColor = true;
            MajorDeleteButton.Click += MajorDeleteButton_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(3, 716);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 2;
            label1.Text = "Search:";
            // 
            // DegreeTabPage
            // 
            DegreeTabPage.BackColor = Color.Turquoise;
            DegreeTabPage.Controls.Add(panel2);
            DegreeTabPage.Location = new Point(4, 24);
            DegreeTabPage.Name = "DegreeTabPage";
            DegreeTabPage.Padding = new Padding(3);
            DegreeTabPage.Size = new Size(808, 428);
            DegreeTabPage.TabIndex = 1;
            DegreeTabPage.Text = "Degree";
            DegreeTabPage.Enter += DegreeTabPage_Enter;
            // 
            // panel2
            // 
            panel2.Controls.Add(splitContainer2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(802, 422);
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
            splitContainer2.Panel1.Controls.Add(DegreeResetFormLinkLabel);
            splitContainer2.Panel1.Controls.Add(DegreeSaveCreateButton);
            splitContainer2.Panel1.Controls.Add(DegreeNameTextBox);
            splitContainer2.Panel1.Controls.Add(label3);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.BackColor = Color.FromArgb(165, 201, 202);
            splitContainer2.Panel2.Controls.Add(DegreeListView);
            splitContainer2.Panel2.Controls.Add(label5);
            splitContainer2.Panel2.Controls.Add(DegreeSearchTextBox);
            splitContainer2.Panel2.Controls.Add(DegreeDeleteButton);
            splitContainer2.Panel2.Controls.Add(label6);
            splitContainer2.Size = new Size(802, 422);
            splitContainer2.SplitterDistance = 505;
            splitContainer2.TabIndex = 0;
            // 
            // DegreeResetFormLinkLabel
            // 
            DegreeResetFormLinkLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            DegreeResetFormLinkLabel.AutoSize = true;
            DegreeResetFormLinkLabel.Location = new Point(5, 352);
            DegreeResetFormLinkLabel.Name = "DegreeResetFormLinkLabel";
            DegreeResetFormLinkLabel.Size = new Size(35, 15);
            DegreeResetFormLinkLabel.TabIndex = 6;
            DegreeResetFormLinkLabel.TabStop = true;
            DegreeResetFormLinkLabel.Text = "Reset";
            DegreeResetFormLinkLabel.VisitedLinkColor = Color.Blue;
            // 
            // DegreeSaveCreateButton
            // 
            DegreeSaveCreateButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DegreeSaveCreateButton.BackColor = Color.FromArgb(231, 246, 242);
            DegreeSaveCreateButton.Location = new Point(5, 370);
            DegreeSaveCreateButton.Name = "DegreeSaveCreateButton";
            DegreeSaveCreateButton.Size = new Size(497, 49);
            DegreeSaveCreateButton.TabIndex = 4;
            DegreeSaveCreateButton.Text = "Save/Create";
            DegreeSaveCreateButton.UseVisualStyleBackColor = false;
            DegreeSaveCreateButton.Click += DegreeSaveCreateButton_Click;
            // 
            // DegreeNameTextBox
            // 
            DegreeNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DegreeNameTextBox.BackColor = Color.FromArgb(231, 246, 242);
            DegreeNameTextBox.Location = new Point(85, 13);
            DegreeNameTextBox.Name = "DegreeNameTextBox";
            DegreeNameTextBox.Size = new Size(406, 23);
            DegreeNameTextBox.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 16);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 0;
            label3.Text = "Degree Name:";
            // 
            // DegreeListView
            // 
            DegreeListView.AllowColumnReorder = true;
            DegreeListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DegreeListView.BackColor = Color.FromArgb(231, 246, 242);
            DegreeListView.FullRowSelect = true;
            DegreeListView.Location = new Point(3, 3);
            DegreeListView.MultiSelect = false;
            DegreeListView.Name = "DegreeListView";
            DegreeListView.ShowItemToolTips = true;
            DegreeListView.Size = new Size(287, 378);
            DegreeListView.TabIndex = 7;
            DegreeListView.UseCompatibleStateImageBehavior = false;
            DegreeListView.View = View.Details;
            DegreeListView.ItemActivate += DegreeListView_ItemActivate;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(3, 399);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 6;
            label5.Text = "Search:";
            // 
            // DegreeSearchTextBox
            // 
            DegreeSearchTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DegreeSearchTextBox.BackColor = Color.FromArgb(231, 246, 242);
            DegreeSearchTextBox.Location = new Point(53, 396);
            DegreeSearchTextBox.Name = "DegreeSearchTextBox";
            DegreeSearchTextBox.Size = new Size(170, 23);
            DegreeSearchTextBox.TabIndex = 5;
            // 
            // DegreeDeleteButton
            // 
            DegreeDeleteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DegreeDeleteButton.Location = new Point(226, 396);
            DegreeDeleteButton.Name = "DegreeDeleteButton";
            DegreeDeleteButton.Size = new Size(64, 24);
            DegreeDeleteButton.TabIndex = 3;
            DegreeDeleteButton.Text = "Delete";
            DegreeDeleteButton.UseVisualStyleBackColor = true;
            DegreeDeleteButton.Click += DegreeDeleteButton_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(3, 1038);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 2;
            label6.Text = "Search:";
            // 
            // TermTabPage
            // 
            TermTabPage.Controls.Add(panel3);
            TermTabPage.Location = new Point(4, 24);
            TermTabPage.Name = "TermTabPage";
            TermTabPage.Padding = new Padding(3);
            TermTabPage.Size = new Size(808, 428);
            TermTabPage.TabIndex = 2;
            TermTabPage.Text = "Terms";
            TermTabPage.UseVisualStyleBackColor = true;
            TermTabPage.Enter += TermTabPage_Enter;
            // 
            // panel3
            // 
            panel3.Controls.Add(splitContainer3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(802, 422);
            panel3.TabIndex = 1;
            // 
            // splitContainer3
            // 
            splitContainer3.BackColor = Color.FromArgb(165, 201, 202);
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Margin = new Padding(0);
            splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.BackColor = Color.FromArgb(165, 201, 202);
            splitContainer3.Panel1.Controls.Add(TermIDNumericUpDown);
            splitContainer3.Panel1.Controls.Add(label10);
            splitContainer3.Panel1.Controls.Add(TermStartDateTimePicker);
            splitContainer3.Panel1.Controls.Add(TermResetFormLinkLabel);
            splitContainer3.Panel1.Controls.Add(TermSaveCreateButton);
            splitContainer3.Panel1.Controls.Add(label7);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.BackColor = Color.FromArgb(165, 201, 202);
            splitContainer3.Panel2.Controls.Add(TermsListView);
            splitContainer3.Panel2.Controls.Add(label8);
            splitContainer3.Panel2.Controls.Add(TermSearchTextBox);
            splitContainer3.Panel2.Controls.Add(TermDeleteButton);
            splitContainer3.Panel2.Controls.Add(label9);
            splitContainer3.Size = new Size(802, 422);
            splitContainer3.SplitterDistance = 505;
            splitContainer3.TabIndex = 0;
            // 
            // TermIDNumericUpDown
            // 
            TermIDNumericUpDown.Location = new Point(85, 12);
            TermIDNumericUpDown.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            TermIDNumericUpDown.Name = "TermIDNumericUpDown";
            TermIDNumericUpDown.Size = new Size(406, 23);
            TermIDNumericUpDown.TabIndex = 10;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(5, 15);
            label10.Name = "label10";
            label10.Size = new Size(50, 15);
            label10.TabIndex = 9;
            label10.Text = "Term ID:";
            // 
            // TermStartDateTimePicker
            // 
            TermStartDateTimePicker.Location = new Point(85, 41);
            TermStartDateTimePicker.Name = "TermStartDateTimePicker";
            TermStartDateTimePicker.Size = new Size(406, 23);
            TermStartDateTimePicker.TabIndex = 7;
            // 
            // TermResetFormLinkLabel
            // 
            TermResetFormLinkLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            TermResetFormLinkLabel.AutoSize = true;
            TermResetFormLinkLabel.Location = new Point(5, 361);
            TermResetFormLinkLabel.Name = "TermResetFormLinkLabel";
            TermResetFormLinkLabel.Size = new Size(35, 15);
            TermResetFormLinkLabel.TabIndex = 6;
            TermResetFormLinkLabel.TabStop = true;
            TermResetFormLinkLabel.Text = "Reset";
            TermResetFormLinkLabel.VisitedLinkColor = Color.Blue;
            // 
            // TermSaveCreateButton
            // 
            TermSaveCreateButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TermSaveCreateButton.BackColor = Color.FromArgb(231, 246, 242);
            TermSaveCreateButton.Location = new Point(3, 379);
            TermSaveCreateButton.Name = "TermSaveCreateButton";
            TermSaveCreateButton.Size = new Size(499, 40);
            TermSaveCreateButton.TabIndex = 4;
            TermSaveCreateButton.Text = "Save/Create";
            TermSaveCreateButton.UseVisualStyleBackColor = false;
            TermSaveCreateButton.Click += TermSaveCreateButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(5, 47);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 0;
            label7.Text = "Start Date:";
            // 
            // TermsListView
            // 
            TermsListView.AllowColumnReorder = true;
            TermsListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TermsListView.BackColor = Color.FromArgb(231, 246, 242);
            TermsListView.FullRowSelect = true;
            TermsListView.Location = new Point(3, 3);
            TermsListView.MultiSelect = false;
            TermsListView.Name = "TermsListView";
            TermsListView.ShowItemToolTips = true;
            TermsListView.Size = new Size(287, 387);
            TermsListView.TabIndex = 8;
            TermsListView.UseCompatibleStateImageBehavior = false;
            TermsListView.View = View.Details;
            TermsListView.ItemActivate += TermsListView_ItemActivate;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Location = new Point(7, 399);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 6;
            label8.Text = "Search:";
            // 
            // TermSearchTextBox
            // 
            TermSearchTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TermSearchTextBox.BackColor = Color.FromArgb(231, 246, 242);
            TermSearchTextBox.Location = new Point(58, 396);
            TermSearchTextBox.Name = "TermSearchTextBox";
            TermSearchTextBox.Size = new Size(160, 23);
            TermSearchTextBox.TabIndex = 5;
            // 
            // TermDeleteButton
            // 
            TermDeleteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            TermDeleteButton.Location = new Point(224, 395);
            TermDeleteButton.Name = "TermDeleteButton";
            TermDeleteButton.Size = new Size(64, 24);
            TermDeleteButton.TabIndex = 3;
            TermDeleteButton.Text = "Delete";
            TermDeleteButton.UseVisualStyleBackColor = true;
            TermDeleteButton.Click += TermDeleteButton_Click;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Location = new Point(3, 1038);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 2;
            label9.Text = "Search:";
            // 
            // CoursesTabPage
            // 
            CoursesTabPage.Controls.Add(panel1);
            CoursesTabPage.Location = new Point(4, 24);
            CoursesTabPage.Name = "CoursesTabPage";
            CoursesTabPage.Padding = new Padding(3);
            CoursesTabPage.Size = new Size(808, 428);
            CoursesTabPage.TabIndex = 3;
            CoursesTabPage.Text = "Courses";
            CoursesTabPage.UseVisualStyleBackColor = true;
            CoursesTabPage.Enter += CoursesTabPage_Enter;
            // 
            // panel1
            // 
            panel1.Controls.Add(splitContainer4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 422);
            panel1.TabIndex = 1;
            // 
            // splitContainer4
            // 
            splitContainer4.BackColor = Color.FromArgb(165, 201, 202);
            splitContainer4.Dock = DockStyle.Fill;
            splitContainer4.Location = new Point(0, 0);
            splitContainer4.Margin = new Padding(0);
            splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            splitContainer4.Panel1.BackColor = Color.FromArgb(165, 201, 202);
            splitContainer4.Panel1.Controls.Add(CourseResetLinkLabel);
            splitContainer4.Panel1.Controls.Add(CourseSaveCreateButton);
            splitContainer4.Panel1.Controls.Add(CourseNameTextBox);
            splitContainer4.Panel1.Controls.Add(label11);
            // 
            // splitContainer4.Panel2
            // 
            splitContainer4.Panel2.BackColor = Color.FromArgb(165, 201, 202);
            splitContainer4.Panel2.Controls.Add(label12);
            splitContainer4.Panel2.Controls.Add(CourseSearchTextBox);
            splitContainer4.Panel2.Controls.Add(CourseListView);
            splitContainer4.Panel2.Controls.Add(CourseDeleteButton);
            splitContainer4.Panel2.Controls.Add(label13);
            splitContainer4.Size = new Size(802, 422);
            splitContainer4.SplitterDistance = 505;
            splitContainer4.TabIndex = 0;
            // 
            // CourseResetLinkLabel
            // 
            CourseResetLinkLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CourseResetLinkLabel.AutoSize = true;
            CourseResetLinkLabel.Location = new Point(5, 359);
            CourseResetLinkLabel.Name = "CourseResetLinkLabel";
            CourseResetLinkLabel.Size = new Size(35, 15);
            CourseResetLinkLabel.TabIndex = 6;
            CourseResetLinkLabel.TabStop = true;
            CourseResetLinkLabel.Text = "Reset";
            CourseResetLinkLabel.VisitedLinkColor = Color.Blue;
            // 
            // CourseSaveCreateButton
            // 
            CourseSaveCreateButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CourseSaveCreateButton.BackColor = Color.FromArgb(231, 246, 242);
            CourseSaveCreateButton.Location = new Point(5, 377);
            CourseSaveCreateButton.Name = "CourseSaveCreateButton";
            CourseSaveCreateButton.Size = new Size(497, 42);
            CourseSaveCreateButton.TabIndex = 4;
            CourseSaveCreateButton.Text = "Save/Create";
            CourseSaveCreateButton.UseVisualStyleBackColor = false;
            CourseSaveCreateButton.Click += CourseSaveCreateButton_Click;
            // 
            // CourseNameTextBox
            // 
            CourseNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CourseNameTextBox.BackColor = Color.FromArgb(231, 246, 242);
            CourseNameTextBox.Location = new Point(85, 13);
            CourseNameTextBox.Name = "CourseNameTextBox";
            CourseNameTextBox.Size = new Size(406, 23);
            CourseNameTextBox.TabIndex = 0;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(5, 16);
            label11.Name = "label11";
            label11.Size = new Size(82, 15);
            label11.TabIndex = 0;
            label11.Text = "Course Name:";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label12.AutoSize = true;
            label12.Location = new Point(3, 401);
            label12.Name = "label12";
            label12.Size = new Size(45, 15);
            label12.TabIndex = 6;
            label12.Text = "Search:";
            // 
            // CourseSearchTextBox
            // 
            CourseSearchTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CourseSearchTextBox.BackColor = Color.FromArgb(231, 246, 242);
            CourseSearchTextBox.Location = new Point(54, 396);
            CourseSearchTextBox.Name = "CourseSearchTextBox";
            CourseSearchTextBox.Size = new Size(168, 23);
            CourseSearchTextBox.TabIndex = 5;
            // 
            // CourseListView
            // 
            CourseListView.AllowColumnReorder = true;
            CourseListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CourseListView.BackColor = Color.FromArgb(231, 246, 242);
            CourseListView.FullRowSelect = true;
            CourseListView.Location = new Point(3, 3);
            CourseListView.MultiSelect = false;
            CourseListView.Name = "CourseListView";
            CourseListView.ShowItemToolTips = true;
            CourseListView.Size = new Size(287, 387);
            CourseListView.TabIndex = 4;
            CourseListView.UseCompatibleStateImageBehavior = false;
            CourseListView.View = View.Details;
            CourseListView.ItemActivate += CoursesListView_ItemActivate;
            // 
            // CourseDeleteButton
            // 
            CourseDeleteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CourseDeleteButton.Location = new Point(228, 394);
            CourseDeleteButton.Name = "CourseDeleteButton";
            CourseDeleteButton.Size = new Size(62, 25);
            CourseDeleteButton.TabIndex = 3;
            CourseDeleteButton.Text = "Delete";
            CourseDeleteButton.UseVisualStyleBackColor = true;
            CourseDeleteButton.Click += CourseDeleteButton_Click;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label13.AutoSize = true;
            label13.Location = new Point(3, 1038);
            label13.Name = "label13";
            label13.Size = new Size(45, 15);
            label13.TabIndex = 2;
            label13.Text = "Search:";
            // 
            // OtherManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(57, 91, 100);
            ClientSize = new Size(834, 474);
            Controls.Add(OtherManagementTabControl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OtherManagementForm";
            Text = "OtherManagementForm";
            OtherManagementTabControl.ResumeLayout(false);
            MajorTabPage.ResumeLayout(false);
            MainPanel.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            DegreeTabPage.ResumeLayout(false);
            panel2.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            TermTabPage.ResumeLayout(false);
            panel3.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel1.PerformLayout();
            splitContainer3.Panel2.ResumeLayout(false);
            splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TermIDNumericUpDown).EndInit();
            CoursesTabPage.ResumeLayout(false);
            panel1.ResumeLayout(false);
            splitContainer4.Panel1.ResumeLayout(false);
            splitContainer4.Panel1.PerformLayout();
            splitContainer4.Panel2.ResumeLayout(false);
            splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).EndInit();
            splitContainer4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabControl OtherManagementTabControl;
        private TabPage MajorTabPage;
        private Panel MainPanel;
        private SplitContainer splitContainer1;
        private LinkLabel MajorFormResetLinkLabel;
        private Button MajorCreateSaveButton;
        private TextBox MajorNameTextBox;
        private Label label2;
        private ListView MajorListView;
        private Button MajorDeleteButton;
        private Label label1;
        private TabPage DegreeTabPage;
        private Label label4;
        private TextBox MajorSearchTextBox;
        private TabPage TermTabPage;
        private Panel panel2;
        private SplitContainer splitContainer2;
        private LinkLabel DegreeResetFormLinkLabel;
        private Button DegreeSaveCreateButton;
        private TextBox DegreeNameTextBox;
        private Label label3;
        private Label label5;
        private TextBox DegreeSearchTextBox;
        private Button DegreeDeleteButton;
        private Label label6;
        private Panel panel3;
        private SplitContainer splitContainer3;
        private LinkLabel TermResetFormLinkLabel;
        private Button TermSaveCreateButton;
        private Label label7;
        private Label label8;
        private TextBox TermSearchTextBox;
        private Button TermDeleteButton;
        private Label label9;
        private DateTimePicker TermStartDateTimePicker;
        private NumericUpDown TermIDNumericUpDown;
        private Label label10;
        private ListView DegreeListView;
        private ListView TermsListView;
        private TabPage CoursesTabPage;
        private Panel panel1;
        private SplitContainer splitContainer4;
        private LinkLabel CourseResetLinkLabel;
        private Button CourseSaveCreateButton;
        private TextBox CourseNameTextBox;
        private Label label11;
        private Label label12;
        private TextBox CourseSearchTextBox;
        private ListView CourseListView;
        private Button CourseDeleteButton;
        private Label label13;
    }
}