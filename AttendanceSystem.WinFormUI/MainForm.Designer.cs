namespace AttendanceSystem.WinFormUI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ToolBarPanel = new Panel();
            OtherManagementButton = new Button();
            UserManagmentButton = new Button();
            ClassManagementButton = new Button();
            AttendanceListButton = new Button();
            DisplayDataButton = new Button();
            panel1 = new Panel();
            StatusPanel = new Panel();
            menuStrip1 = new MenuStrip();
            NameMenuItem = new ToolStripMenuItem();
            toolStripTextBox1 = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripTextBox2 = new ToolStripMenuItem();
            RoleTextBox = new ToolStripTextBox();
            ContainerPanel = new Panel();
            ToolBarPanel.SuspendLayout();
            StatusPanel.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // ToolBarPanel
            // 
            ToolBarPanel.BackColor = Color.FromArgb(44, 51, 51);
            ToolBarPanel.Controls.Add(OtherManagementButton);
            ToolBarPanel.Controls.Add(UserManagmentButton);
            ToolBarPanel.Controls.Add(ClassManagementButton);
            ToolBarPanel.Controls.Add(AttendanceListButton);
            ToolBarPanel.Controls.Add(DisplayDataButton);
            ToolBarPanel.Controls.Add(panel1);
            ToolBarPanel.Dock = DockStyle.Left;
            ToolBarPanel.Location = new Point(0, 0);
            ToolBarPanel.Name = "ToolBarPanel";
            ToolBarPanel.Size = new Size(149, 664);
            ToolBarPanel.TabIndex = 0;
            // 
            // OtherManagementButton
            // 
            OtherManagementButton.BackColor = Color.FromArgb(57, 91, 100);
            OtherManagementButton.Dock = DockStyle.Top;
            OtherManagementButton.FlatStyle = FlatStyle.Flat;
            OtherManagementButton.ForeColor = SystemColors.ButtonFace;
            OtherManagementButton.Location = new Point(0, 260);
            OtherManagementButton.Name = "OtherManagementButton";
            OtherManagementButton.Size = new Size(149, 39);
            OtherManagementButton.TabIndex = 5;
            OtherManagementButton.Text = "Other";
            OtherManagementButton.UseVisualStyleBackColor = false;
            OtherManagementButton.Click += OtherManagementButton_Click;
            // 
            // UserManagmentButton
            // 
            UserManagmentButton.BackColor = Color.FromArgb(57, 91, 100);
            UserManagmentButton.Dock = DockStyle.Top;
            UserManagmentButton.FlatStyle = FlatStyle.Flat;
            UserManagmentButton.ForeColor = SystemColors.ButtonFace;
            UserManagmentButton.Location = new Point(0, 221);
            UserManagmentButton.Name = "UserManagmentButton";
            UserManagmentButton.Size = new Size(149, 39);
            UserManagmentButton.TabIndex = 4;
            UserManagmentButton.Text = "User Managment";
            UserManagmentButton.UseVisualStyleBackColor = false;
            UserManagmentButton.Visible = false;
            UserManagmentButton.Click += UserManagmentButton_Click;
            // 
            // ClassManagementButton
            // 
            ClassManagementButton.BackColor = Color.FromArgb(57, 91, 100);
            ClassManagementButton.Dock = DockStyle.Top;
            ClassManagementButton.FlatStyle = FlatStyle.Flat;
            ClassManagementButton.ForeColor = SystemColors.ButtonFace;
            ClassManagementButton.Location = new Point(0, 182);
            ClassManagementButton.Name = "ClassManagementButton";
            ClassManagementButton.Size = new Size(149, 39);
            ClassManagementButton.TabIndex = 3;
            ClassManagementButton.Text = "Class Management";
            ClassManagementButton.UseVisualStyleBackColor = false;
            ClassManagementButton.Visible = false;
            ClassManagementButton.Click += ClassManagementButton_Click;
            // 
            // AttendanceListButton
            // 
            AttendanceListButton.BackColor = Color.FromArgb(57, 91, 100);
            AttendanceListButton.Dock = DockStyle.Top;
            AttendanceListButton.FlatStyle = FlatStyle.Flat;
            AttendanceListButton.ForeColor = SystemColors.ButtonFace;
            AttendanceListButton.Location = new Point(0, 143);
            AttendanceListButton.Name = "AttendanceListButton";
            AttendanceListButton.Size = new Size(149, 39);
            AttendanceListButton.TabIndex = 2;
            AttendanceListButton.Text = "Attendance List";
            AttendanceListButton.UseVisualStyleBackColor = false;
            AttendanceListButton.Visible = false;
            AttendanceListButton.Click += AttendanceListButton_Click;
            // 
            // DisplayDataButton
            // 
            DisplayDataButton.BackColor = Color.FromArgb(57, 91, 100);
            DisplayDataButton.Dock = DockStyle.Top;
            DisplayDataButton.FlatStyle = FlatStyle.Flat;
            DisplayDataButton.ForeColor = SystemColors.ButtonFace;
            DisplayDataButton.Location = new Point(0, 104);
            DisplayDataButton.Name = "DisplayDataButton";
            DisplayDataButton.Size = new Size(149, 39);
            DisplayDataButton.TabIndex = 1;
            DisplayDataButton.Text = "Search";
            DisplayDataButton.UseVisualStyleBackColor = false;
            DisplayDataButton.Visible = false;
            DisplayDataButton.Click += DisplayDataButton_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(149, 104);
            panel1.TabIndex = 0;
            // 
            // StatusPanel
            // 
            StatusPanel.BackColor = Color.FromArgb(44, 51, 51);
            StatusPanel.Controls.Add(menuStrip1);
            StatusPanel.Dock = DockStyle.Top;
            StatusPanel.Location = new Point(149, 0);
            StatusPanel.Name = "StatusPanel";
            StatusPanel.Size = new Size(900, 43);
            StatusPanel.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { NameMenuItem, RoleTextBox });
            menuStrip1.Location = new Point(732, 9);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RightToLeft = RightToLeft.Yes;
            menuStrip1.Size = new Size(159, 27);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // NameMenuItem
            // 
            NameMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripTextBox1, toolStripSeparator1, toolStripTextBox2 });
            NameMenuItem.Name = "NameMenuItem";
            NameMenuItem.Size = new Size(49, 23);
            NameMenuItem.Text = "Login";
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(112, 22);
            toolStripTextBox1.Text = "Setting";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(109, 6);
            // 
            // toolStripTextBox2
            // 
            toolStripTextBox2.Name = "toolStripTextBox2";
            toolStripTextBox2.Size = new Size(112, 22);
            toolStripTextBox2.Text = "Logout";
            //toolStripTextBox2.Click += toolStripTextBox2_Click;
            // 
            // RoleTextBox
            // 
            RoleTextBox.Name = "RoleTextBox";
            RoleTextBox.ReadOnly = true;
            RoleTextBox.Size = new Size(100, 23);
            RoleTextBox.TextBoxTextAlign = HorizontalAlignment.Center;
            // 
            // ContainerPanel
            // 
            ContainerPanel.Dock = DockStyle.Fill;
            ContainerPanel.Location = new Point(149, 43);
            ContainerPanel.Name = "ContainerPanel";
            ContainerPanel.Size = new Size(900, 621);
            ContainerPanel.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 51, 51);
            ClientSize = new Size(1049, 664);
            Controls.Add(ContainerPanel);
            Controls.Add(StatusPanel);
            Controls.Add(ToolBarPanel);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Attendance System";
            ToolBarPanel.ResumeLayout(false);
            StatusPanel.ResumeLayout(false);
            StatusPanel.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel ToolBarPanel;
        private Panel StatusPanel;
        private Panel ContainerPanel;
        private Button UserManagmentButton;
        private Button ClassManagementButton;
        private Button AttendanceListButton;
        private Button DisplayDataButton;
        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem NameMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripTextBox1;
        private ToolStripMenuItem toolStripTextBox2;
        private ToolStripTextBox RoleTextBox;
        private Button OtherManagementButton;
    }
}