namespace Driving_License_Management_System.Forms.Users
{
    partial class frmUserManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserManagement));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            showUserToolStripMenuItem = new ToolStripMenuItem();
            addUserToolStripMenuItem = new ToolStripMenuItem();
            deletUserToolStripMenuItem = new ToolStripMenuItem();
            editeUserToolStripMenuItem = new ToolStripMenuItem();
            editePasswordToolStripMenuItem = new ToolStripMenuItem();
            pictureBox2 = new PictureBox();
            cbFilterUsers = new ComboBox();
            tbFilter = new TextBox();
            label2 = new Label();
            lbRecord = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(331, 144);
            label1.Name = "label1";
            label1.Size = new Size(289, 41);
            label1.TabIndex = 0;
            label1.Text = "Users Management";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(399, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(153, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.Location = new Point(155, 287);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(735, 188);
            dataGridView1.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { showUserToolStripMenuItem, addUserToolStripMenuItem, deletUserToolStripMenuItem, editeUserToolStripMenuItem, editePasswordToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(211, 152);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // showUserToolStripMenuItem
            // 
            showUserToolStripMenuItem.Name = "showUserToolStripMenuItem";
            showUserToolStripMenuItem.Size = new Size(210, 24);
            showUserToolStripMenuItem.Text = "Show User";
            showUserToolStripMenuItem.Click += showUserToolStripMenuItem_Click;
            // 
            // addUserToolStripMenuItem
            // 
            addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            addUserToolStripMenuItem.Size = new Size(210, 24);
            addUserToolStripMenuItem.Text = "Add User";
            // 
            // deletUserToolStripMenuItem
            // 
            deletUserToolStripMenuItem.Name = "deletUserToolStripMenuItem";
            deletUserToolStripMenuItem.Size = new Size(210, 24);
            deletUserToolStripMenuItem.Text = "Delete User";
            deletUserToolStripMenuItem.Click += deletUserToolStripMenuItem_Click;
            // 
            // editeUserToolStripMenuItem
            // 
            editeUserToolStripMenuItem.Name = "editeUserToolStripMenuItem";
            editeUserToolStripMenuItem.Size = new Size(210, 24);
            editeUserToolStripMenuItem.Text = "Edit User";
            editeUserToolStripMenuItem.Click += editeUserToolStripMenuItem_Click;
            // 
            // editePasswordToolStripMenuItem
            // 
            editePasswordToolStripMenuItem.Name = "editePasswordToolStripMenuItem";
            editePasswordToolStripMenuItem.Size = new Size(210, 24);
            editePasswordToolStripMenuItem.Text = "Edit Password";
            editePasswordToolStripMenuItem.Click += editePasswordToolStripMenuItem_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(832, 226);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(58, 46);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // cbFilterUsers
            // 
            cbFilterUsers.FormattingEnabled = true;
            cbFilterUsers.Location = new Point(155, 244);
            cbFilterUsers.Name = "cbFilterUsers";
            cbFilterUsers.Size = new Size(151, 28);
            cbFilterUsers.TabIndex = 4;
            cbFilterUsers.SelectedIndexChanged += cbFilterUsers_SelectedIndexChanged;
            // 
            // tbFilter
            // 
            tbFilter.Location = new Point(331, 245);
            tbFilter.Name = "tbFilter";
            tbFilter.Size = new Size(125, 27);
            tbFilter.TabIndex = 5;
            tbFilter.TextChanged += tbFilter_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(155, 491);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 6;
            label2.Text = "Record :";
            // 
            // lbRecord
            // 
            lbRecord.AutoSize = true;
            lbRecord.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbRecord.Location = new Point(243, 491);
            lbRecord.Name = "lbRecord";
            lbRecord.Size = new Size(20, 25);
            lbRecord.TabIndex = 7;
            lbRecord.Text = "?";
            // 
            // button1
            // 
            button1.Location = new Point(796, 487);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmUserManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 537);
            Controls.Add(button1);
            Controls.Add(lbRecord);
            Controls.Add(label2);
            Controls.Add(tbFilter);
            Controls.Add(cbFilterUsers);
            Controls.Add(pictureBox2);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "frmUserManagement";
            Text = "Users Management";
            Load += frmUserManagement_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private PictureBox pictureBox2;
        private ComboBox cbFilterUsers;
        private TextBox tbFilter;
        private Label label2;
        private Label lbRecord;
        private Button button1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem showUserToolStripMenuItem;
        private ToolStripMenuItem addUserToolStripMenuItem;
        private ToolStripMenuItem deletUserToolStripMenuItem;
        private ToolStripMenuItem editeUserToolStripMenuItem;
        private ToolStripMenuItem editePasswordToolStripMenuItem;
    }
}
