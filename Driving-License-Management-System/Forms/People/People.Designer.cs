namespace Driving_License_Management_System.Forms.People
{
    partial class People
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(People));
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            cbFilter = new ComboBox();
            label2 = new Label();
            recordes = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            editePersonToolStripMenuItem = new ToolStripMenuItem();
            label3 = new Label();
            tbfilter = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(573, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(55, 334);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1260, 188);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1250, 259);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(65, 60);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 299);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 3;
            label1.Text = "Filter By :";
            // 
            // cbFilter
            // 
            cbFilter.FormattingEnabled = true;
            cbFilter.Location = new Point(130, 291);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(151, 28);
            cbFilter.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 539);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 6;
            label2.Text = "Records:";
            // 
            // recordes
            // 
            recordes.AutoSize = true;
            recordes.Location = new Point(138, 539);
            recordes.Name = "recordes";
            recordes.Size = new Size(16, 20);
            recordes.TabIndex = 7;
            recordes.Text = "?";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, editePersonToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(160, 76);
            contextMenuStrip1.Text = "Show";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(159, 24);
            toolStripMenuItem1.Text = "Delete";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click_1;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(159, 24);
            toolStripMenuItem2.Text = "Add Person";
            // 
            // editePersonToolStripMenuItem
            // 
            editePersonToolStripMenuItem.Name = "editePersonToolStripMenuItem";
            editePersonToolStripMenuItem.Size = new Size(159, 24);
            editePersonToolStripMenuItem.Text = "Edit Person";
            editePersonToolStripMenuItem.Click += editePersonToolStripMenuItem_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(455, 166);
            label3.Name = "label3";
            label3.Size = new Size(349, 46);
            label3.TabIndex = 8;
            label3.Text = "People Management";
            // 
            // tbfilter
            // 
            tbfilter.BackColor = SystemColors.HighlightText;
            tbfilter.ForeColor = SystemColors.InactiveCaptionText;
            tbfilter.Location = new Point(308, 291);
            tbfilter.Name = "tbfilter";
            tbfilter.Size = new Size(263, 27);
            tbfilter.TabIndex = 9;
            tbfilter.TextChanged += tbfilter_TextChanged_1;
            // 
            // People
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1366, 640);
            Controls.Add(tbfilter);
            Controls.Add(label3);
            Controls.Add(recordes);
            Controls.Add(label2);
            Controls.Add(cbFilter);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Name = "People";
            Text = "People";
            Load += People_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private PictureBox pictureBox2;
        private Label label1;
        private ComboBox cbFilter;
        private Label label2;
        private Label recordes;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private Label label3;
        private ToolStripMenuItem editePersonToolStripMenuItem;
        private TextBox tbfilter;
    }
}
