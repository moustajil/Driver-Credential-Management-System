namespace Driving_License_Management_System.Forms.Users
{
    partial class frmDetailsInfo
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
            ctrInforPerson1 = new Driving_License_Management_System.Controller.Users.ctrInforPerson();
            groupBox1 = new GroupBox();
            lbIsActive = new Label();
            lable = new Label();
            lbUserName = new Label();
            label3 = new Label();
            lbUserID = new Label();
            label1 = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ctrInforPerson1
            // 
            ctrInforPerson1.Location = new Point(12, 12);
            ctrInforPerson1.Name = "ctrInforPerson1";
            ctrInforPerson1.Size = new Size(832, 348);
            ctrInforPerson1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbIsActive);
            groupBox1.Controls.Add(lable);
            groupBox1.Controls.Add(lbUserName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lbUserID);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 348);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(822, 107);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login Info";
            // 
            // lbIsActive
            // 
            lbIsActive.AutoSize = true;
            lbIsActive.Location = new Point(677, 50);
            lbIsActive.Name = "lbIsActive";
            lbIsActive.Size = new Size(31, 23);
            lbIsActive.TabIndex = 5;
            lbIsActive.Text = "???";
            // 
            // lable
            // 
            lable.AutoSize = true;
            lable.Location = new Point(564, 50);
            lable.Name = "lable";
            lable.Size = new Size(77, 23);
            lable.TabIndex = 4;
            lable.Text = "Is Active";
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Location = new Point(407, 50);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(31, 23);
            lbUserName.TabIndex = 3;
            lbUserName.Text = "???";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(294, 50);
            label3.Name = "label3";
            label3.Size = new Size(107, 23);
            label3.TabIndex = 2;
            label3.Text = "User Name :";
            // 
            // lbUserID
            // 
            lbUserID.AutoSize = true;
            lbUserID.Location = new Point(152, 50);
            lbUserID.Name = "lbUserID";
            lbUserID.Size = new Size(31, 23);
            lbUserID.TabIndex = 1;
            lbUserID.Text = "???";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 50);
            label1.Name = "label1";
            label1.Size = new Size(78, 23);
            label1.TabIndex = 0;
            label1.Text = "User ID :";
            // 
            // button1
            // 
            button1.Location = new Point(709, 486);
            button1.Name = "button1";
            button1.Size = new Size(120, 38);
            button1.TabIndex = 2;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmDetailsInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 549);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(ctrInforPerson1);
            Name = "frmDetailsInfo";
            Text = "User Details";
            Load += frmDetailsInfo_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Controller.Users.ctrInforPerson ctrInforPerson1;
        private GroupBox groupBox1;
        private Label label1;
        private Label lbUserID;
        private Label lbIsActive;
        private Label lable;
        private Label lbUserName;
        private Label label3;
        private Button button1;
    }
}
