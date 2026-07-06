namespace Driving_License_Management_System.Forms.LocalDrivingApplication
{
    partial class LocalDriverLicenseApplication
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
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button1 = new Button();
            ctrFindPerson1 = new Driving_License_Management_System.Controller.Users.ctrFindPerson();
            tabPage2 = new TabPage();
            lbCreatedBy = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            cbClasses = new ComboBox();
            label3 = new Label();
            applicationDate = new Label();
            label4 = new Label();
            lbApplicationID = new Label();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(182, 9);
            label1.Name = "label1";
            label1.Size = new Size(411, 31);
            label1.TabIndex = 0;
            label1.Text = "New Local Driver License Application";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(24, 59);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(719, 649);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(ctrFindPerson1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(711, 616);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Person Info";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(584, 550);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ctrFindPerson1
            // 
            ctrFindPerson1.Location = new Point(18, 16);
            ctrFindPerson1.Name = "ctrFindPerson1";
            ctrFindPerson1.Size = new Size(679, 528);
            ctrFindPerson1.TabIndex = 0;
            ctrFindPerson1.OnFindPersonID += ctrFindPerson1_OnFindPersonID;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lbCreatedBy);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(cbClasses);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(applicationDate);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(lbApplicationID);
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(711, 616);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Application Info";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbCreatedBy
            // 
            lbCreatedBy.AutoSize = true;
            lbCreatedBy.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCreatedBy.Location = new Point(320, 347);
            lbCreatedBy.Name = "lbCreatedBy";
            lbCreatedBy.Size = new Size(31, 23);
            lbCreatedBy.TabIndex = 9;
            lbCreatedBy.Text = "???";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(172, 342);
            label7.Name = "label7";
            label7.Size = new Size(126, 28);
            label7.TabIndex = 8;
            label7.Text = "Created By :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(372, 286);
            label6.Name = "label6";
            label6.Size = new Size(30, 23);
            label6.TabIndex = 7;
            label6.Text = "15";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(172, 281);
            label5.Name = "label5";
            label5.Size = new Size(179, 28);
            label5.TabIndex = 6;
            label5.Text = "Application Fees :";
            // 
            // cbClasses
            // 
            cbClasses.FormattingEnabled = true;
            cbClasses.Location = new Point(372, 213);
            cbClasses.Name = "cbClasses";
            cbClasses.Size = new Size(275, 28);
            cbClasses.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(186, 213);
            label3.Name = "label3";
            label3.Size = new Size(145, 28);
            label3.TabIndex = 4;
            label3.Text = "License Class :";
            // 
            // applicationDate
            // 
            applicationDate.AutoSize = true;
            applicationDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            applicationDate.Location = new Point(378, 155);
            applicationDate.Name = "applicationDate";
            applicationDate.Size = new Size(31, 23);
            applicationDate.TabIndex = 3;
            applicationDate.Text = "???";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(168, 148);
            label4.Name = "label4";
            label4.Size = new Size(183, 28);
            label4.TabIndex = 2;
            label4.Text = "Application Date :";
            // 
            // lbApplicationID
            // 
            lbApplicationID.AutoSize = true;
            lbApplicationID.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbApplicationID.Location = new Point(378, 95);
            lbApplicationID.Name = "lbApplicationID";
            lbApplicationID.Size = new Size(31, 23);
            lbApplicationID.TabIndex = 1;
            lbApplicationID.Text = "???";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(168, 88);
            label2.Name = "label2";
            label2.Size = new Size(194, 28);
            label2.TabIndex = 0;
            label2.Text = "D.L Application ID :";
            // 
            // button2
            // 
            button2.Location = new Point(645, 726);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(532, 726);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 3;
            button3.Text = "Close";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // LocalDriverLicense
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 807);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Name = "LocalDriverLicense";
            Text = "LocalDriverLicense";
            Load += LocalDriverLicense_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Controller.Users.ctrFindPerson ctrFindPerson1;
        private ComboBox cbClasses;
        private Label label3;
        private Label applicationDate;
        private Label label4;
        private Label lbApplicationID;
        private Label label2;
        private Label lbCreatedBy;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}