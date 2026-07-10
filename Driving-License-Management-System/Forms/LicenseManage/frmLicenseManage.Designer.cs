namespace Driving_License_Management_System.LicenseManage
{
    partial class frmLicenseManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLicenseManage));
            label1 = new Label();
            dgvApplicaton = new DataGridView();
            label2 = new Label();
            cbfilter = new ComboBox();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            lbRecorde = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvApplicaton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(179, 58);
            label1.Name = "label1";
            label1.Size = new Size(528, 46);
            label1.TabIndex = 0;
            label1.Text = "Local Driver License Application";
            // 
            // dgvApplicaton
            // 
            dgvApplicaton.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvApplicaton.Location = new Point(36, 255);
            dgvApplicaton.Name = "dgvApplicaton";
            dgvApplicaton.RowHeadersWidth = 51;
            dgvApplicaton.Size = new Size(1120, 188);
            dgvApplicaton.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(36, 218);
            label2.Name = "label2";
            label2.Size = new Size(87, 23);
            label2.TabIndex = 2;
            label2.Text = "Filter By :";
            // 
            // cbfilter
            // 
            cbfilter.FormattingEnabled = true;
            cbfilter.Location = new Point(138, 213);
            cbfilter.Name = "cbfilter";
            cbfilter.Size = new Size(151, 28);
            cbfilter.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(316, 214);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1111, 199);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(36, 464);
            label3.Name = "label3";
            label3.Size = new Size(85, 23);
            label3.TabIndex = 6;
            label3.Text = "Records:";
            // 
            // lbRecorde
            // 
            lbRecorde.AutoSize = true;
            lbRecorde.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbRecorde.Location = new Point(127, 466);
            lbRecorde.Name = "lbRecorde";
            lbRecorde.Size = new Size(31, 23);
            lbRecorde.TabIndex = 7;
            lbRecorde.Text = "???";
            // 
            // frmLicenseManage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1198, 506);
            Controls.Add(lbRecorde);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(cbfilter);
            Controls.Add(label2);
            Controls.Add(dgvApplicaton);
            Controls.Add(label1);
            Name = "frmLicenseManage";
            Text = "Local Driving License Applications";
            Load += LicenseManage_Load;
            ((System.ComponentModel.ISupportInitialize)dgvApplicaton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvApplicaton;
        private Label label2;
        private ComboBox cbfilter;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Label label3;
        private Label lbRecorde;
    }
}
