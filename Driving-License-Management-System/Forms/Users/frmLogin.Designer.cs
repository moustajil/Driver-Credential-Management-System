namespace Driving_License_Management_System.Forms.Users
{
    partial class frmLogin
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
            tbusername = new TextBox();
            tbpassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cbActive = new CheckBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // tbusername
            // 
            tbusername.Location = new Point(313, 135);
            tbusername.Name = "tbusername";
            tbusername.Size = new Size(237, 27);
            tbusername.TabIndex = 0;
            // 
            // tbpassword
            // 
            tbpassword.Location = new Point(313, 195);
            tbpassword.Name = "tbpassword";
            tbpassword.Size = new Size(237, 27);
            tbpassword.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(323, 34);
            label1.Name = "label1";
            label1.Size = new Size(198, 41);
            label1.TabIndex = 2;
            label1.Text = "Login Screen";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(200, 142);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 3;
            label2.Text = "user name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(200, 202);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 4;
            label3.Text = "password :";
            // 
            // cbActive
            // 
            cbActive.AutoSize = true;
            cbActive.Location = new Point(313, 244);
            cbActive.Name = "cbActive";
            cbActive.Size = new Size(72, 24);
            cbActive.TabIndex = 5;
            cbActive.Text = "Active";
            cbActive.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(456, 286);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 457);
            Controls.Add(btnLogin);
            Controls.Add(cbActive);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbpassword);
            Controls.Add(tbusername);
            Name = "frmLogin";
            Text = "frmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbusername;
        private TextBox tbpassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox cbActive;
        private Button btnLogin;
    }
}