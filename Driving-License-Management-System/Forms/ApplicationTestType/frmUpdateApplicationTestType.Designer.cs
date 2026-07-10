namespace Driving_License_Management_System.Forms.ApplicationTestType
{
    partial class frmUpdateApplicationTestType
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
            lbTestTypeID = new Label();
            lbtitleTestType = new Label();
            tbTitle = new TextBox();
            label3 = new Label();
            rtbDescription = new RichTextBox();
            label4 = new Label();
            tbFees = new TextBox();
            lable = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(86, 32);
            label1.Name = "label1";
            label1.Size = new Size(327, 31);
            label1.TabIndex = 0;
            label1.Text = "Update Application Test Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(104, 98);
            label2.Name = "label2";
            label2.Size = new Size(38, 23);
            label2.TabIndex = 1;
            label2.Text = "ID :";
            // 
            // lbTestTypeID
            // 
            lbTestTypeID.AutoSize = true;
            lbTestTypeID.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTestTypeID.Location = new Point(163, 98);
            lbTestTypeID.Name = "lbTestTypeID";
            lbTestTypeID.Size = new Size(31, 23);
            lbTestTypeID.TabIndex = 2;
            lbTestTypeID.Text = "???";
            // 
            // lbtitleTestType
            // 
            lbtitleTestType.AutoSize = true;
            lbtitleTestType.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbtitleTestType.Location = new Point(86, 150);
            lbtitleTestType.Name = "lbtitleTestType";
            lbtitleTestType.Size = new Size(56, 23);
            lbtitleTestType.TabIndex = 3;
            lbtitleTestType.Text = "Title :";
            // 
            // tbTitle
            // 
            tbTitle.Location = new Point(163, 146);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(219, 27);
            tbTitle.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 211);
            label3.Name = "label3";
            label3.Size = new Size(112, 23);
            label3.TabIndex = 5;
            label3.Text = "Description :";
            // 
            // rtbDescription
            // 
            rtbDescription.Location = new Point(163, 211);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(219, 86);
            rtbDescription.TabIndex = 6;
            rtbDescription.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(72, 325);
            label4.Name = "label4";
            label4.Size = new Size(54, 23);
            label4.TabIndex = 7;
            label4.Text = "Fees :";
            // 
            // tbFees
            // 
            tbFees.Location = new Point(163, 324);
            tbFees.Name = "tbFees";
            tbFees.Size = new Size(219, 27);
            tbFees.TabIndex = 8;
            // 
            // lable
            // 
            lable.Location = new Point(277, 384);
            lable.Name = "lable";
            lable.Size = new Size(105, 43);
            lable.TabIndex = 9;
            lable.Text = "Update";
            lable.UseVisualStyleBackColor = true;
            lable.Click += lable_Click;
            // 
            // button1
            // 
            button1.Location = new Point(164, 384);
            button1.Name = "button1";
            button1.Size = new Size(107, 43);
            button1.TabIndex = 10;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmUpdateApplicationTestType
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 474);
            Controls.Add(button1);
            Controls.Add(lable);
            Controls.Add(tbFees);
            Controls.Add(label4);
            Controls.Add(rtbDescription);
            Controls.Add(label3);
            Controls.Add(tbTitle);
            Controls.Add(lbtitleTestType);
            Controls.Add(lbTestTypeID);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmUpdateApplicationTestType";
            Text = "Update Test Type";
            Load += frmUpdateApplicationTestType_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lbTestTypeID;
        private Label lbtitleTestType;
        private TextBox tbTitle;
        private Label label3;
        private RichTextBox rtbDescription;
        private Label label4;
        private TextBox tbFees;
        private Button lable;
        private Button button1;
    }
}
