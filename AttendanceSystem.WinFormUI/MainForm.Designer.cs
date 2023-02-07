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
            this.ToolBarPanel = new System.Windows.Forms.Panel();
            this.UserManagmentButton = new System.Windows.Forms.Button();
            this.ClassManagementButton = new System.Windows.Forms.Button();
            this.AttendanceListButton = new System.Windows.Forms.Button();
            this.DisplayDataButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.StatusPanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.NameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripMenuItem();
            this.RoleTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.ContainerPanel = new System.Windows.Forms.Panel();
            this.ToolBarPanel.SuspendLayout();
            this.StatusPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolBarPanel
            // 
            this.ToolBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ToolBarPanel.Controls.Add(this.UserManagmentButton);
            this.ToolBarPanel.Controls.Add(this.ClassManagementButton);
            this.ToolBarPanel.Controls.Add(this.AttendanceListButton);
            this.ToolBarPanel.Controls.Add(this.DisplayDataButton);
            this.ToolBarPanel.Controls.Add(this.panel1);
            this.ToolBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ToolBarPanel.Location = new System.Drawing.Point(0, 0);
            this.ToolBarPanel.Name = "ToolBarPanel";
            this.ToolBarPanel.Size = new System.Drawing.Size(149, 664);
            this.ToolBarPanel.TabIndex = 0;
            // 
            // UserManagmentButton
            // 
            this.UserManagmentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(91)))), ((int)(((byte)(100)))));
            this.UserManagmentButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserManagmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserManagmentButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.UserManagmentButton.Location = new System.Drawing.Point(0, 221);
            this.UserManagmentButton.Name = "UserManagmentButton";
            this.UserManagmentButton.Size = new System.Drawing.Size(149, 39);
            this.UserManagmentButton.TabIndex = 4;
            this.UserManagmentButton.Text = "User Managment";
            this.UserManagmentButton.UseVisualStyleBackColor = false;
            this.UserManagmentButton.Visible = false;
            this.UserManagmentButton.Click += new System.EventHandler(this.UserManagmentButton_Click);
            // 
            // ClassManagementButton
            // 
            this.ClassManagementButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(91)))), ((int)(((byte)(100)))));
            this.ClassManagementButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClassManagementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClassManagementButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ClassManagementButton.Location = new System.Drawing.Point(0, 182);
            this.ClassManagementButton.Name = "ClassManagementButton";
            this.ClassManagementButton.Size = new System.Drawing.Size(149, 39);
            this.ClassManagementButton.TabIndex = 3;
            this.ClassManagementButton.Text = "Class Management";
            this.ClassManagementButton.UseVisualStyleBackColor = false;
            this.ClassManagementButton.Visible = false;
            this.ClassManagementButton.Click += new System.EventHandler(this.ClassManagementButton_Click);
            // 
            // AttendanceListButton
            // 
            this.AttendanceListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(91)))), ((int)(((byte)(100)))));
            this.AttendanceListButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AttendanceListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AttendanceListButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AttendanceListButton.Location = new System.Drawing.Point(0, 143);
            this.AttendanceListButton.Name = "AttendanceListButton";
            this.AttendanceListButton.Size = new System.Drawing.Size(149, 39);
            this.AttendanceListButton.TabIndex = 2;
            this.AttendanceListButton.Text = "Attendance List";
            this.AttendanceListButton.UseVisualStyleBackColor = false;
            this.AttendanceListButton.Visible = false;
            this.AttendanceListButton.Click += new System.EventHandler(this.AttendanceListButton_Click);
            // 
            // DisplayDataButton
            // 
            this.DisplayDataButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(91)))), ((int)(((byte)(100)))));
            this.DisplayDataButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.DisplayDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DisplayDataButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DisplayDataButton.Location = new System.Drawing.Point(0, 104);
            this.DisplayDataButton.Name = "DisplayDataButton";
            this.DisplayDataButton.Size = new System.Drawing.Size(149, 39);
            this.DisplayDataButton.TabIndex = 1;
            this.DisplayDataButton.Text = "Search";
            this.DisplayDataButton.UseVisualStyleBackColor = false;
            this.DisplayDataButton.Visible = false;
            this.DisplayDataButton.Click += new System.EventHandler(this.DisplayDataButton_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 104);
            this.panel1.TabIndex = 0;
            // 
            // StatusPanel
            // 
            this.StatusPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.StatusPanel.Controls.Add(this.menuStrip1);
            this.StatusPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.StatusPanel.Location = new System.Drawing.Point(149, 0);
            this.StatusPanel.Name = "StatusPanel";
            this.StatusPanel.Size = new System.Drawing.Size(900, 43);
            this.StatusPanel.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NameMenuItem,
            this.RoleTextBox});
            this.menuStrip1.Location = new System.Drawing.Point(612, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(279, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // NameMenuItem
            // 
            this.NameMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripSeparator1,
            this.toolStripTextBox2});
            this.NameMenuItem.Name = "NameMenuItem";
            this.NameMenuItem.Size = new System.Drawing.Size(49, 23);
            this.NameMenuItem.Text = "Login";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(180, 22);
            this.toolStripTextBox1.Text = "Setting";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(180, 22);
            this.toolStripTextBox2.Text = "Logout";
            this.toolStripTextBox2.Click += new System.EventHandler(this.toolStripTextBox2_Click);
            // 
            // RoleTextBox
            // 
            this.RoleTextBox.Name = "RoleTextBox";
            this.RoleTextBox.ReadOnly = true;
            this.RoleTextBox.Size = new System.Drawing.Size(100, 23);
            this.RoleTextBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ContainerPanel
            // 
            this.ContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContainerPanel.Location = new System.Drawing.Point(149, 43);
            this.ContainerPanel.Name = "ContainerPanel";
            this.ContainerPanel.Size = new System.Drawing.Size(900, 621);
            this.ContainerPanel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1049, 664);
            this.Controls.Add(this.ContainerPanel);
            this.Controls.Add(this.StatusPanel);
            this.Controls.Add(this.ToolBarPanel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance System";
            this.ToolBarPanel.ResumeLayout(false);
            this.StatusPanel.ResumeLayout(false);
            this.StatusPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

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
    }
}