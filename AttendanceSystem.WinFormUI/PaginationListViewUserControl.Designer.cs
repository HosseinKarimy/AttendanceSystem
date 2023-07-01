namespace AttendanceSystem.WinFormUI
{
    partial class PaginationListViewUserControl
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
            MainPanel = new Panel();
            splitContainer1 = new SplitContainer();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            SearchByFlowLayoutPanel = new FlowLayoutPanel();
            OrderByFlowLayoutPanel = new FlowLayoutPanel();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            SearchStringTextBox = new TextBox();
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MainPanel.BackColor = Color.FromArgb(231, 246, 242);
            MainPanel.Controls.Add(splitContainer1);
            MainPanel.Location = new Point(3, 3);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(511, 568);
            MainPanel.TabIndex = 0;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel2;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox1);
            splitContainer1.Size = new Size(511, 568);
            splitContainer1.SplitterDistance = 417;
            splitContainer1.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(511, 417);
            dataGridView1.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(SearchByFlowLayoutPanel);
            groupBox1.Controls.Add(OrderByFlowLayoutPanel);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(SearchStringTextBox);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(511, 147);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search Filter";
            // 
            // SearchByFlowLayoutPanel
            // 
            SearchByFlowLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            SearchByFlowLayoutPanel.AutoScroll = true;
            SearchByFlowLayoutPanel.FlowDirection = FlowDirection.BottomUp;
            SearchByFlowLayoutPanel.Location = new Point(65, 99);
            SearchByFlowLayoutPanel.Name = "SearchByFlowLayoutPanel";
            SearchByFlowLayoutPanel.Size = new Size(440, 43);
            SearchByFlowLayoutPanel.TabIndex = 5;
            // 
            // OrderByFlowLayoutPanel
            // 
            OrderByFlowLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            OrderByFlowLayoutPanel.AutoScroll = true;
            OrderByFlowLayoutPanel.FlowDirection = FlowDirection.BottomUp;
            OrderByFlowLayoutPanel.Location = new Point(65, 49);
            OrderByFlowLayoutPanel.Name = "OrderByFlowLayoutPanel";
            OrderByFlowLayoutPanel.Size = new Size(440, 44);
            OrderByFlowLayoutPanel.TabIndex = 5;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(366, 23);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 4;
            label1.Text = "Page Number:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericUpDown1.Location = new Point(455, 20);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(51, 23);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(3, 108);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 4;
            label4.Text = "Search By:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(3, 60);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 4;
            label3.Text = "Order By:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 23);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 4;
            label2.Text = "Search:";
            // 
            // SearchStringTextBox
            // 
            SearchStringTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SearchStringTextBox.Location = new Point(65, 20);
            SearchStringTextBox.Name = "SearchStringTextBox";
            SearchStringTextBox.Size = new Size(236, 23);
            SearchStringTextBox.TabIndex = 1;
            SearchStringTextBox.TextChanged += SearchStringTextBox_TextChanged;
            // 
            // PaginationListViewUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(231, 246, 242);
            Controls.Add(MainPanel);
            Name = "PaginationListViewUserControl";
            Size = new Size(517, 574);
            Load += PaginationListViewUserControl_Load;
            MainPanel.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPanel;
        private TextBox SearchStringTextBox;
        private Label label2;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private FlowLayoutPanel OrderByFlowLayoutPanel;
        private FlowLayoutPanel SearchByFlowLayoutPanel;
        private SplitContainer splitContainer1;
    }
}
