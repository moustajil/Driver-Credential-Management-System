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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUser));
            lbStatuUser = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnNext = new Button();
            ctrInforPerson1 = new Driving_License_Management_System.Controller.Users.ctrInforPerson();
            gbFindPerson = new GroupBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            lbFilter = new TextBox();
            cbFilter = new ComboBox();
            tabPage2 = new TabPage();
            cbActive = new CheckBox();
            tbPassword = new TextBox();
            tbConfirmPassword = new TextBox();
            tbUserName = new TextBox();
            lbUserIDLogin = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            errorProvider1 = new ErrorProvider(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            gbFindPerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lbStatuUser
            // 
            lbStatuUser.AutoSize = true;
            lbStatuUser.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbStatuUser.Location = new Point(387, 36);
            lbStatuUser.Name = "lbStatuUser";
            lbStatuUser.Size = new Size(137, 38);
            lbStatuUser.TabIndex = 0;
            lbStatuUser.Text = "Add User";
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
            tabPage1.Controls.Add(btnNext);
            tabPage1.Controls.Add(ctrInforPerson1);
            tabPage1.Controls.Add(gbFindPerson);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(899, 481);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Person Info";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(762, 442);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 29);
            btnNext.TabIndex = 2;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // ctrInforPerson1
            // 
            ctrInforPerson1.Location = new Point(29, 104);
            ctrInforPerson1.Name = "ctrInforPerson1";
            ctrInforPerson1.Size = new Size(839, 332);
            ctrInforPerson1.TabIndex = 1;
            // 
            // gbFindPerson
            // 
            gbFindPerson.Controls.Add(pictureBox2);
            gbFindPerson.Controls.Add(pictureBox1);
            gbFindPerson.Controls.Add(lbFilter);
            gbFindPerson.Controls.Add(cbFilter);
            gbFindPerson.Location = new Point(29, 21);
            gbFindPerson.Name = "gbFindPerson";
            gbFindPerson.Size = new Size(839, 77);
            gbFindPerson.TabIndex = 0;
            gbFindPerson.TabStop = false;
            gbFindPerson.Text = "Filter Person";
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
            // 
            // lbFilter
            // 
            lbFilter.Location = new Point(305, 32);
            lbFilter.Name = "lbFilter";
            lbFilter.Size = new Size(229, 27);
            lbFilter.TabIndex = 1;
            // 
            // cbFilter
            // 
            cbFilter.FormattingEnabled = true;
            cbFilter.Location = new Point(52, 30);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(220, 28);
            cbFilter.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(cbActive);
            tabPage2.Controls.Add(tbPassword);
            tabPage2.Controls.Add(tbConfirmPassword);
            tabPage2.Controls.Add(tbUserName);
            tabPage2.Controls.Add(lbUserIDLogin);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(899, 481);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Login Into";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbActive
            // 
            cbActive.AutoSize = true;
            cbActive.Location = new Point(450, 316);
            cbActive.Name = "cbActive";
            cbActive.Size = new Size(86, 24);
            cbActive.TabIndex = 8;
            cbActive.Text = "Is Active";
            cbActive.UseVisualStyleBackColor = true;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(450, 218);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(125, 27);
            tbPassword.TabIndex = 7;
            // 
            // tbConfirmPassword
            // 
            tbConfirmPassword.Location = new Point(450, 266);
            tbConfirmPassword.Name = "tbConfirmPassword";
            tbConfirmPassword.Size = new Size(125, 27);
            tbConfirmPassword.TabIndex = 6;
            // 
            // tbUserName
            // 
            tbUserName.Location = new Point(450, 164);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(125, 27);
            tbUserName.TabIndex = 5;
            // 
            // lbUserIDLogin
            // 
            lbUserIDLogin.AutoSize = true;
            lbUserIDLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbUserIDLogin.Location = new Point(450, 120);
            lbUserIDLogin.Name = "lbUserIDLogin";
            lbUserIDLogin.Size = new Size(31, 23);
            lbUserIDLogin.TabIndex = 4;
            lbUserIDLogin.Text = "???";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(251, 270);
            label5.Name = "label5";
            label5.Size = new Size(180, 23);
            label5.TabIndex = 3;
            label5.Text = "Confirme Password : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(331, 222);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 2;
            label4.Text = "Password : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(319, 168);
            label3.Name = "label3";
            label3.Size = new Size(112, 23);
            label3.TabIndex = 1;
            label3.Text = "User Name : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(348, 120);
            label2.Name = "label2";
            label2.Size = new Size(83, 23);
            label2.TabIndex = 0;
            label2.Text = "User ID : ";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(844, 624);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(732, 624);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmAddUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 703);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(tabControl1);
            Controls.Add(lbStatuUser);
            Name = "frmAddUser";
            Text = "frmAddUser";
            Load += frmAddUser_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            gbFindPerson.ResumeLayout(false);
            gbFindPerson.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbStatuUser;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Controller.Users.ctrInforPerson ctrInforPerson1;
        protected GroupBox gbFindPerson;
        private TextBox lbFilter;
        private ComboBox cbFilter;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button btnNext;
        private Label lbUserIDLogin;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private CheckBox cbActive;
        private TextBox tbPassword;
        private TextBox tbConfirmPassword;
        private TextBox tbUserName;
        private Button btnSave;
        private Button btnCancel;
        private ErrorProvider errorProvider1;
    }
}