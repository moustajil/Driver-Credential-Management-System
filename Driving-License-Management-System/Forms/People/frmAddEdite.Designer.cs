namespace Driving_License_Management_System.Forms.People
{
    partial class frmAddEdite
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
            label2 = new Label();
            personID = new Label();
            ctlFromAddEdite1 = new Driving_License_Management_System.Controller.People.ctlFromAddEdite();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(336, 23);
            label1.Name = "label1";
            label1.Size = new Size(285, 46);
            label1.TabIndex = 0;
            label1.Text = "Add New Person";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(102, 78);
            label2.Name = "label2";
            label2.Size = new Size(137, 31);
            label2.TabIndex = 1;
            label2.Text = "Persone Id :";
            // 
            // personID
            // 
            personID.AutoSize = true;
            personID.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            personID.Location = new Point(245, 84);
            personID.Name = "personID";
            personID.Size = new Size(20, 25);
            personID.TabIndex = 2;
            personID.Text = "?";
            // 
            // ctlFromAddEdite1
            // 
            ctlFromAddEdite1.Location = new Point(102, 122);
            ctlFromAddEdite1.Name = "ctlFromAddEdite1";
            ctlFromAddEdite1.Size = new Size(878, 447);
            ctlFromAddEdite1.TabIndex = 3;
            ctlFromAddEdite1.GetPersonIdCreated += ctlFromAddEdite1_GetPersonIdCreated;
            // 
            // frmAddEdite
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 613);
            Controls.Add(ctlFromAddEdite1);
            Controls.Add(personID);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAddEdite";
            Text = "frmAddEdite";
            Load += frmAddEdite_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label personID;
        private Controller.People.ctlFromAddEdite ctlFromAddEdite1;
    }
}