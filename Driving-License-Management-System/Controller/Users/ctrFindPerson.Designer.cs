namespace Driving_License_Management_System.Controller.Users
{
    partial class ctrFindPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrFindPerson));
            groupBox1 = new GroupBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            tbValue = new TextBox();
            cbFilter = new ComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            pictureBox3 = new PictureBox();
            country = new Label();
            label9 = new Label();
            phone = new Label();
            lable = new Label();
            dateOfBirthe = new Label();
            label8 = new Label();
            address = new Label();
            email = new Label();
            gender = new Label();
            natiolity = new Label();
            name = new Label();
            personID = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(tbValue);
            groupBox1.Controls.Add(cbFilter);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(21, 19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(641, 92);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(506, 30);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(574, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // tbValue
            // 
            tbValue.Location = new Point(328, 40);
            tbValue.Name = "tbValue";
            tbValue.Size = new Size(144, 34);
            tbValue.TabIndex = 2;
            // 
            // cbFilter
            // 
            cbFilter.FormattingEnabled = true;
            cbFilter.Location = new Point(156, 40);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(151, 36);
            cbFilter.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 40);
            label1.Name = "label1";
            label1.Size = new Size(102, 28);
            label1.TabIndex = 0;
            label1.Text = "Filter by : ";
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox3);
            groupBox2.Controls.Add(country);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(phone);
            groupBox2.Controls.Add(lable);
            groupBox2.Controls.Add(dateOfBirthe);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(address);
            groupBox2.Controls.Add(email);
            groupBox2.Controls.Add(gender);
            groupBox2.Controls.Add(natiolity);
            groupBox2.Controls.Add(name);
            groupBox2.Controls.Add(personID);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(21, 132);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(641, 387);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Person Information";
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(461, 144);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(154, 139);
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            // 
            // country
            // 
            country.AutoSize = true;
            country.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            country.Location = new Point(333, 191);
            country.Name = "country";
            country.Size = new Size(34, 23);
            country.TabIndex = 17;
            country.Text = "???";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(253, 194);
            label9.Name = "label9";
            label9.Size = new Size(73, 20);
            label9.TabIndex = 16;
            label9.Text = "Country :";
            // 
            // phone
            // 
            phone.AutoSize = true;
            phone.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            phone.Location = new Point(320, 148);
            phone.Name = "phone";
            phone.Size = new Size(34, 23);
            phone.TabIndex = 15;
            phone.Text = "???";
            // 
            // lable
            // 
            lable.AutoSize = true;
            lable.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lable.Location = new Point(253, 151);
            lable.Name = "lable";
            lable.Size = new Size(61, 20);
            lable.TabIndex = 14;
            lable.Text = "Phone :";
            // 
            // dateOfBirthe
            // 
            dateOfBirthe.AutoSize = true;
            dateOfBirthe.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateOfBirthe.Location = new Point(373, 47);
            dateOfBirthe.Name = "dateOfBirthe";
            dateOfBirthe.Size = new Size(34, 23);
            dateOfBirthe.TabIndex = 13;
            dateOfBirthe.Text = "???";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(253, 50);
            label8.Name = "label8";
            label8.Size = new Size(114, 20);
            label8.TabIndex = 12;
            label8.Text = "Date of Birth:";
            // 
            // address
            // 
            address.AutoSize = true;
            address.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            address.Location = new Point(119, 315);
            address.Name = "address";
            address.Size = new Size(34, 23);
            address.TabIndex = 11;
            address.Text = "???";
            // 
            // email
            // 
            email.AutoSize = true;
            email.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            email.Location = new Point(119, 260);
            email.Name = "email";
            email.Size = new Size(34, 23);
            email.TabIndex = 10;
            email.Text = "???";
            // 
            // gender
            // 
            gender.AutoSize = true;
            gender.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gender.Location = new Point(156, 204);
            gender.Name = "gender";
            gender.Size = new Size(34, 23);
            gender.TabIndex = 9;
            gender.Text = "???";
            // 
            // natiolity
            // 
            natiolity.AutoSize = true;
            natiolity.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            natiolity.Location = new Point(170, 151);
            natiolity.Name = "natiolity";
            natiolity.Size = new Size(34, 23);
            natiolity.TabIndex = 8;
            natiolity.Text = "???";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            name.Location = new Point(156, 99);
            name.Name = "name";
            name.Size = new Size(34, 23);
            name.TabIndex = 7;
            name.Text = "???";
            // 
            // personID
            // 
            personID.AutoSize = true;
            personID.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            personID.Location = new Point(156, 50);
            personID.Name = "personID";
            personID.Size = new Size(34, 23);
            personID.TabIndex = 6;
            personID.Text = "???";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(39, 318);
            label7.Name = "label7";
            label7.Size = new Size(71, 20);
            label7.TabIndex = 5;
            label7.Text = "Address :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(39, 263);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 4;
            label6.Text = "Email :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(39, 207);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 3;
            label5.Text = "Gender :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(39, 154);
            label4.Name = "label4";
            label4.Size = new Size(114, 20);
            label4.TabIndex = 2;
            label4.Text = "National ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(39, 101);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 1;
            label3.Text = "Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 52);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 0;
            label2.Text = "Person ID :";
            // 
            // ctrFindPerson
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ctrFindPerson";
            Size = new Size(696, 551);
            Load += ctrFindPerson_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox tbValue;
        private ComboBox cbFilter;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox3;
        private Label country;
        private Label label9;
        private Label phone;
        private Label lable;
        private Label dateOfBirthe;
        private Label label8;
        private Label address;
        private Label email;
        private Label gender;
        private Label natiolity;
        private Label name;
        private Label personID;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
    }
}
