namespace Driving_License_Management_System.Controller.Users
{
    partial class ctrInforPersonWithUser
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            ctrInforPerson1 = new ctrInforPerson();
            groupBox1 = new GroupBox();
            lbIsUserActive = new Label();
            label6 = new Label();
            lbUserName = new Label();
            label4 = new Label();
            lbUserID = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            tbPasswors = new TextBox();
            tbNewPassword = new TextBox();
            tbConfirmePassword = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ctrInforPerson1
            // 
            ctrInforPerson1.Location = new Point(0, 0);
            ctrInforPerson1.Name = "ctrInforPerson1";
            ctrInforPerson1.Size = new Size(816, 323);
            ctrInforPerson1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbIsUserActive);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(lbUserName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lbUserID);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(3, 329);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(813, 108);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login Info";
            // 
            // lbIsUserActive
            // 
            lbIsUserActive.AutoSize = true;
            lbIsUserActive.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbIsUserActive.Location = new Point(634, 49);
            lbIsUserActive.Name = "lbIsUserActive";
            lbIsUserActive.Size = new Size(31, 23);
            lbIsUserActive.TabIndex = 5;
            lbIsUserActive.Text = "???";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(518, 49);
            label6.Name = "label6";
            label6.Size = new Size(110, 23);
            label6.TabIndex = 4;
            label6.Text = "User Active :";
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbUserName.Location = new Point(398, 49);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(31, 23);
            lbUserName.TabIndex = 3;
            lbUserName.Text = "???";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(285, 49);
            label4.Name = "label4";
            label4.Size = new Size(107, 23);
            label4.TabIndex = 2;
            label4.Text = "User Name :";
            // 
            // lbUserID
            // 
            lbUserID.AutoSize = true;
            lbUserID.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbUserID.Location = new Point(138, 49);
            lbUserID.Name = "lbUserID";
            lbUserID.Size = new Size(31, 23);
            lbUserID.TabIndex = 1;
            lbUserID.Text = "???";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(54, 49);
            label1.Name = "label1";
            label1.Size = new Size(78, 23);
            label1.TabIndex = 0;
            label1.Text = "User ID :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(78, 465);
            label2.Name = "label2";
            label2.Size = new Size(166, 23);
            label2.TabIndex = 2;
            label2.Text = "Current Password  :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(103, 514);
            label3.Name = "label3";
            label3.Size = new Size(141, 23);
            label3.TabIndex = 3;
            label3.Text = "New Password  :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(64, 562);
            label5.Name = "label5";
            label5.Size = new Size(180, 23);
            label5.TabIndex = 4;
            label5.Text = "Confirme Password  :";
            // 
            // button1
            // 
            button1.Location = new Point(710, 637);
            button1.Name = "button1";
            button1.Size = new Size(106, 34);
            button1.TabIndex = 5;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(562, 637);
            button2.Name = "button2";
            button2.Size = new Size(106, 34);
            button2.TabIndex = 6;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // tbPasswors
            // 
            tbPasswors.Location = new Point(250, 461);
            tbPasswors.Name = "tbPasswors";
            tbPasswors.Size = new Size(262, 27);
            tbPasswors.TabIndex = 7;
            // 
            // tbNewPassword
            // 
            tbNewPassword.Location = new Point(250, 510);
            tbNewPassword.Name = "tbNewPassword";
            tbNewPassword.Size = new Size(262, 27);
            tbNewPassword.TabIndex = 8;
            // 
            // tbConfirmePassword
            // 
            tbConfirmePassword.Location = new Point(250, 558);
            tbConfirmePassword.Name = "tbConfirmePassword";
            tbConfirmePassword.Size = new Size(262, 27);
            tbConfirmePassword.TabIndex = 9;
            // 
            // ctrInforPersonWithUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbConfirmePassword);
            Controls.Add(tbNewPassword);
            Controls.Add(tbPasswors);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(ctrInforPerson1);
            Name = "ctrInforPersonWithUser";
            Size = new Size(840, 701);
            Load += ctrInforPersonWithUser_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ctrInforPerson ctrInforPerson1;
        private GroupBox groupBox1;
        private Label lbIsUserActive;
        private Label label6;
        private Label lbUserName;
        private Label label4;
        private Label lbUserID;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Button button1;
        private Button button2;
        private TextBox tbPasswors;
        private TextBox tbNewPassword;
        private TextBox tbConfirmePassword;
    }
}
