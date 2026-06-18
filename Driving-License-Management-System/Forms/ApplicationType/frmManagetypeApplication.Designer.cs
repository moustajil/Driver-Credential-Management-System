namespace Driving_License_Management_System.Forms.Application
{
    partial class frmManagetypeApplication
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
            contextMenuStrip1 = new ContextMenuStrip(components);
            editeApplicationToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            label2 = new Label();
            lbRecorde = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(123, 30);
            label1.Name = "label1";
            label1.Size = new Size(352, 38);
            label1.TabIndex = 0;
            label1.Text = "Manage Type Application";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.Location = new Point(12, 107);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(589, 256);
            dataGridView1.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editeApplicationToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(211, 56);
            // 
            // editeApplicationToolStripMenuItem
            // 
            editeApplicationToolStripMenuItem.Name = "editeApplicationToolStripMenuItem";
            editeApplicationToolStripMenuItem.Size = new Size(210, 24);
            editeApplicationToolStripMenuItem.Text = "Edite Application";
            editeApplicationToolStripMenuItem.Click += editeApplicationToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.Location = new Point(507, 390);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 394);
            label2.Name = "label2";
            label2.Size = new Size(85, 23);
            label2.TabIndex = 3;
            label2.Text = "Recorde :";
            // 
            // lbRecorde
            // 
            lbRecorde.AutoSize = true;
            lbRecorde.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbRecorde.Location = new Point(103, 394);
            lbRecorde.Name = "lbRecorde";
            lbRecorde.Size = new Size(20, 23);
            lbRecorde.TabIndex = 4;
            lbRecorde.Text = "0";
            // 
            // frmManagetypeApplication
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 461);
            Controls.Add(lbRecorde);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "frmManagetypeApplication";
            Text = "frmManagetypeApplication";
            Load += frmManagetypeApplication_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button button1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editeApplicationToolStripMenuItem;
        private Label label2;
        private Label lbRecorde;
    }
}