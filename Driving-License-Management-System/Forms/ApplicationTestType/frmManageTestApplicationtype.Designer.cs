namespace Driving_License_Management_System.Forms.ApplicationTestType
{
    partial class frmManageTestApplicationtype
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            label2 = new Label();
            lbRecorde = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editeTypeTestToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(241, 54);
            label1.Name = "label1";
            label1.Size = new Size(287, 31);
            label1.TabIndex = 0;
            label1.Text = "Manage Test Types";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.Location = new Point(73, 154);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(667, 188);
            dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(646, 398);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(73, 398);
            label2.Name = "label2";
            label2.Size = new Size(90, 23);
            label2.TabIndex = 3;
            label2.Text = "Records:";
            // 
            // lbRecorde
            // 
            lbRecorde.AutoSize = true;
            lbRecorde.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbRecorde.Location = new Point(169, 398);
            lbRecorde.Name = "lbRecorde";
            lbRecorde.Size = new Size(31, 23);
            lbRecorde.TabIndex = 4;
            lbRecorde.Text = "???";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editeTypeTestToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(211, 56);
            // 
            // editeTypeTestToolStripMenuItem
            // 
            editeTypeTestToolStripMenuItem.Name = "editeTypeTestToolStripMenuItem";
            editeTypeTestToolStripMenuItem.Size = new Size(210, 24);
            editeTypeTestToolStripMenuItem.Text = "Edit Test Type";
            editeTypeTestToolStripMenuItem.Click += editeTypeTestToolStripMenuItem_Click;
            // 
            // frmManageTestApplicationtype
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbRecorde);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "frmManageTestApplicationtype";
            Text = "Manage Test Types";
            Load += frmManageTestApplicationtype_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button button1;
        private Label label2;
        private Label lbRecorde;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editeTypeTestToolStripMenuItem;
    }
}
