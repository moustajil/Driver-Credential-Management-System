namespace Driving_License_Management_System.Forms.Users
{
    partial class frmInforUserWithPerson
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
            ctrInforPersonWithUser1 = new Driving_License_Management_System.Controller.Users.ctrInforPersonWithUser();
            SuspendLayout();
            // 
            // ctrInforPersonWithUser1
            // 
            ctrInforPersonWithUser1.Location = new Point(12, 12);
            ctrInforPersonWithUser1.Name = "ctrInforPersonWithUser1";
            ctrInforPersonWithUser1.Size = new Size(828, 711);
            ctrInforPersonWithUser1.TabIndex = 0;
            ctrInforPersonWithUser1.Load += ctrInforPersonWithUser1_Load;
            // 
            // frmInforUserWithPerson
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 743);
            Controls.Add(ctrInforPersonWithUser1);
            Name = "frmInforUserWithPerson";
            Text = "frmInforUserWithPerson";
            Load += frmInforUserWithPerson_Load;
            ResumeLayout(false);
        }

        #endregion

        private Controller.Users.ctrInforPersonWithUser ctrInforPersonWithUser1;
    }
}