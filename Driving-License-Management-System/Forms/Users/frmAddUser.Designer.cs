namespace Driving_License_Management_System.Forms.Users
{
    partial class frmAddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUser));
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            ctrInforPerson1 = new Driving_License_Management_System.Controller.Users.ctrInforPerson();
            groupBox1 = new GroupBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            lbFilter = new TextBox();
            cbFilter = new ComboBox();
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(387, 36);
            label1.Name = "label1";
            label1.Size = new Size(137, 38);
            label1.TabIndex = 0;
            label1.Text = "Add User";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(35, 92);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(907, 514);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(ctrInforPerson1);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(899, 481);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Person Info";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // ctrInforPerson1
            // 
            ctrInforPerson1.Location = new Point(29, 104);
            ctrInforPerson1.Name = "ctrInforPerson1";
            ctrInforPerson1.Size = new Size(839, 315);
            ctrInforPerson1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(lbFilter);
            groupBox1.Controls.Add(cbFilter);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(29, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(839, 77);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter Person";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(648, 30);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(49, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(570, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(49, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lbFilter
            // 
            lbFilter.Location = new Point(305, 32);
            lbFilter.Name = "lbFilter";
            lbFilter.Size = new Size(229, 31);
            lbFilter.TabIndex = 1;
            // 
            // cbFilter
            // 
            cbFilter.FormattingEnabled = true;
            cbFilter.Location = new Point(52, 30);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(220, 33);
            cbFilter.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(899, 481);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Login Into";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmAddUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 633);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Name = "frmAddUser";
            Text = "frmAddUser";
            Load += frmAddUser_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Controller.Users.ctrInforPerson ctrInforPerson1;
        protected GroupBox groupBox1;
        private TextBox lbFilter;
        private ComboBox cbFilter;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}