namespace Driving_License_Management_System.Controller.People
{
    partial class ctlFromAddEdite
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            fName = new TextBox();
            sName = new TextBox();
            tName = new TextBox();
            foName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            nNumber = new TextBox();
            label7 = new Label();
            dtPiker = new DateTimePicker();
            label8 = new Label();
            rbMale = new RadioButton();
            rbFamel = new RadioButton();
            pBImage = new PictureBox();
            label9 = new Label();
            pNumber = new TextBox();
            label10 = new Label();
            email = new TextBox();
            label11 = new Label();
            cbCountry = new ComboBox();
            lkImage = new LinkLabel();
            label12 = new Label();
            rtbAddress = new RichTextBox();
            btnSave = new Button();
            btnClose = new Button();
            llRemoveImage = new LinkLabel();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pBImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(65, 51);
            label1.Name = "label1";
            label1.Size = new Size(65, 23);
            label1.TabIndex = 0;
            label1.Text = "Name :";
            // 
            // fName
            // 
            fName.Location = new Point(179, 47);
            fName.Name = "fName";
            fName.Size = new Size(125, 27);
            fName.TabIndex = 1;
            fName.TextChanged += textBox1_TextChanged;
            // 
            // sName
            // 
            sName.Location = new Point(340, 47);
            sName.Name = "sName";
            sName.Size = new Size(125, 27);
            sName.TabIndex = 2;
            // 
            // tName
            // 
            tName.Location = new Point(499, 47);
            tName.Name = "tName";
            tName.Size = new Size(125, 27);
            tName.TabIndex = 3;
            // 
            // foName
            // 
            foName.Location = new Point(662, 47);
            foName.Name = "foName";
            foName.Size = new Size(125, 27);
            foName.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(214, 21);
            label2.Name = "label2";
            label2.Size = new Size(42, 23);
            label2.TabIndex = 5;
            label2.Text = "First";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(368, 21);
            label3.Name = "label3";
            label3.Size = new Size(66, 23);
            label3.TabIndex = 6;
            label3.Text = "Second";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(532, 21);
            label4.Name = "label4";
            label4.Size = new Size(46, 23);
            label4.TabIndex = 7;
            label4.Text = "third";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(693, 21);
            label5.Name = "label5";
            label5.Size = new Size(58, 23);
            label5.TabIndex = 8;
            label5.Text = "fourth";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(28, 92);
            label6.Name = "label6";
            label6.Size = new Size(102, 23);
            label6.TabIndex = 9;
            label6.Text = "National N :";
            // 
            // nNumber
            // 
            nNumber.Location = new Point(179, 90);
            nNumber.Name = "nNumber";
            nNumber.Size = new Size(169, 27);
            nNumber.TabIndex = 10;
            nNumber.Leave += nNumber_Leave;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(380, 93);
            label7.Name = "label7";
            label7.Size = new Size(129, 23);
            label7.TabIndex = 11;
            label7.Text = "Date Of Birthe :";
            // 
            // dtPiker
            // 
            dtPiker.Location = new Point(530, 90);
            dtPiker.Name = "dtPiker";
            dtPiker.Size = new Size(253, 27);
            dtPiker.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(55, 139);
            label8.Name = "label8";
            label8.Size = new Size(75, 23);
            label8.TabIndex = 13;
            label8.Text = "Gender :";
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(155, 138);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(63, 24);
            rbMale.TabIndex = 14;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            rbMale.CheckedChanged += rbMale_CheckedChanged;
            // 
            // rbFamel
            // 
            rbFamel.AutoSize = true;
            rbFamel.Location = new Point(242, 138);
            rbFamel.Name = "rbFamel";
            rbFamel.Size = new Size(69, 24);
            rbFamel.TabIndex = 15;
            rbFamel.TabStop = true;
            rbFamel.Text = "Famel";
            rbFamel.UseVisualStyleBackColor = true;
            rbFamel.CheckedChanged += rbFamel_CheckedChanged;
            // 
            // pBImage
            // 
            pBImage.Image = Properties.Resources.famel;
            pBImage.Location = new Point(640, 136);
            pBImage.Name = "pBImage";
            pBImage.Size = new Size(167, 155);
            pBImage.SizeMode = PictureBoxSizeMode.Zoom;
            pBImage.TabIndex = 16;
            pBImage.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(317, 136);
            label9.Name = "label9";
            label9.Size = new Size(76, 25);
            label9.TabIndex = 17;
            label9.Text = "Phone :";
            // 
            // pNumber
            // 
            pNumber.Location = new Point(409, 137);
            pNumber.Name = "pNumber";
            pNumber.Size = new Size(169, 27);
            pNumber.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(65, 192);
            label10.Name = "label10";
            label10.Size = new Size(60, 23);
            label10.TabIndex = 19;
            label10.Text = "Email :";
            // 
            // email
            // 
            email.Location = new Point(179, 188);
            email.Name = "email";
            email.Size = new Size(169, 27);
            email.TabIndex = 20;
            email.Leave += email_Leave;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(374, 192);
            label11.Name = "label11";
            label11.Size = new Size(82, 23);
            label11.TabIndex = 21;
            label11.Text = "Country :";
            // 
            // cbCountry
            // 
            cbCountry.FormattingEnabled = true;
            cbCountry.Location = new Point(462, 188);
            cbCountry.Name = "cbCountry";
            cbCountry.Size = new Size(151, 28);
            cbCountry.TabIndex = 23;
            // 
            // lkImage
            // 
            lkImage.AutoSize = true;
            lkImage.Location = new Point(684, 313);
            lkImage.Name = "lkImage";
            lkImage.Size = new Size(76, 20);
            lkImage.TabIndex = 24;
            lkImage.TabStop = true;
            lkImage.Text = "Set Image";
            lkImage.LinkClicked += lkImage_LinkClicked;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(46, 248);
            label12.Name = "label12";
            label12.Size = new Size(79, 23);
            label12.TabIndex = 25;
            label12.Text = "Address :";
            // 
            // rtbAddress
            // 
            rtbAddress.Location = new Point(179, 248);
            rtbAddress.Name = "rtbAddress";
            rtbAddress.Size = new Size(434, 120);
            rtbAddress.TabIndex = 26;
            rtbAddress.Text = "";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(424, 413);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 27;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(299, 413);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 28;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // llRemoveImage
            // 
            llRemoveImage.AutoSize = true;
            llRemoveImage.Location = new Point(692, 348);
            llRemoveImage.Name = "llRemoveImage";
            llRemoveImage.Size = new Size(59, 20);
            llRemoveImage.TabIndex = 29;
            llRemoveImage.TabStop = true;
            llRemoveImage.Text = "remove";
            llRemoveImage.LinkClicked += llRemoveImage_LinkClicked;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ctlFromAddEdite
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(llRemoveImage);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(rtbAddress);
            Controls.Add(label12);
            Controls.Add(lkImage);
            Controls.Add(cbCountry);
            Controls.Add(label11);
            Controls.Add(email);
            Controls.Add(label10);
            Controls.Add(pNumber);
            Controls.Add(label9);
            Controls.Add(pBImage);
            Controls.Add(rbFamel);
            Controls.Add(rbMale);
            Controls.Add(label8);
            Controls.Add(dtPiker);
            Controls.Add(label7);
            Controls.Add(nNumber);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(foName);
            Controls.Add(tName);
            Controls.Add(sName);
            Controls.Add(fName);
            Controls.Add(label1);
            Name = "ctlFromAddEdite";
            Size = new Size(818, 452);
            Load += ctlFromAddEdite_Load;
            ((System.ComponentModel.ISupportInitialize)pBImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox fName;
        private TextBox sName;
        private TextBox tName;
        private TextBox foName;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox nNumber;
        private Label label7;
        private DateTimePicker dtPiker;
        private Label label8;
        private RadioButton rbMale;
        private RadioButton rbFamel;
        private PictureBox pBImage;
        private Label label9;
        private TextBox pNumber;
        private Label label10;
        private TextBox email;
        private Label label11;
        private ComboBox cbCountry;
        private LinkLabel lkImage;
        private Label label12;
        private RichTextBox rtbAddress;
        private Button btnSave;
        private Button btnClose;
        private LinkLabel llRemoveImage;
        private ErrorProvider errorProvider1;
    }
}
