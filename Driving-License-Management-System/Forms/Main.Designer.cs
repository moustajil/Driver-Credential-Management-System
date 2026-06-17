namespace Driving_License_Management_System
{
    partial class Main
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
            menuStrip1 = new MenuStrip();
            applicationToolStripMenuItem = new ToolStripMenuItem();
            peopleToolStripMenuItem = new ToolStripMenuItem();
            showToolStripMenuItem = new ToolStripMenuItem();
            driverToolStripMenuItem = new ToolStripMenuItem();
            userToolStripMenuItem = new ToolStripMenuItem();
            accountSettingToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            drivingLicensServiceToolStripMenuItem = new ToolStripMenuItem();
            manageApplicationToolStripMenuItem = new ToolStripMenuItem();
            detainLicenseToolStripMenuItem = new ToolStripMenuItem();
            manageApplicationTypeToolStripMenuItem = new ToolStripMenuItem();
            manageTestTypeToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { applicationToolStripMenuItem, peopleToolStripMenuItem, driverToolStripMenuItem, userToolStripMenuItem, accountSettingToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1018, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // applicationToolStripMenuItem
            // 
            applicationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { drivingLicensServiceToolStripMenuItem, manageApplicationToolStripMenuItem, detainLicenseToolStripMenuItem, manageApplicationTypeToolStripMenuItem, manageTestTypeToolStripMenuItem });
            applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            applicationToolStripMenuItem.Size = new Size(100, 24);
            applicationToolStripMenuItem.Text = "Application";
            // 
            // peopleToolStripMenuItem
            // 
            peopleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { showToolStripMenuItem });
            peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            peopleToolStripMenuItem.Size = new Size(68, 24);
            peopleToolStripMenuItem.Text = "People";
            // 
            // showToolStripMenuItem
            // 
            showToolStripMenuItem.Name = "showToolStripMenuItem";
            showToolStripMenuItem.Size = new Size(132, 26);
            showToolStripMenuItem.Text = "Show ";
            showToolStripMenuItem.Click += showToolStripMenuItem_Click;
            // 
            // driverToolStripMenuItem
            // 
            driverToolStripMenuItem.Name = "driverToolStripMenuItem";
            driverToolStripMenuItem.Size = new Size(63, 24);
            driverToolStripMenuItem.Text = "Driver";
            // 
            // userToolStripMenuItem
            // 
            userToolStripMenuItem.Name = "userToolStripMenuItem";
            userToolStripMenuItem.Size = new Size(52, 24);
            userToolStripMenuItem.Text = "User";
            userToolStripMenuItem.Click += userToolStripMenuItem_Click;
            // 
            // accountSettingToolStripMenuItem
            // 
            accountSettingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logoutToolStripMenuItem });
            accountSettingToolStripMenuItem.Name = "accountSettingToolStripMenuItem";
            accountSettingToolStripMenuItem.Size = new Size(128, 24);
            accountSettingToolStripMenuItem.Text = "Account Setting";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(224, 26);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // drivingLicensServiceToolStripMenuItem
            // 
            drivingLicensServiceToolStripMenuItem.Name = "drivingLicensServiceToolStripMenuItem";
            drivingLicensServiceToolStripMenuItem.Size = new Size(262, 26);
            drivingLicensServiceToolStripMenuItem.Text = "Driving Licens Service";
            // 
            // manageApplicationToolStripMenuItem
            // 
            manageApplicationToolStripMenuItem.Name = "manageApplicationToolStripMenuItem";
            manageApplicationToolStripMenuItem.Size = new Size(262, 26);
            manageApplicationToolStripMenuItem.Text = "Manage Application";
            // 
            // detainLicenseToolStripMenuItem
            // 
            detainLicenseToolStripMenuItem.Name = "detainLicenseToolStripMenuItem";
            detainLicenseToolStripMenuItem.Size = new Size(262, 26);
            detainLicenseToolStripMenuItem.Text = "Detain License";
            // 
            // manageApplicationTypeToolStripMenuItem
            // 
            manageApplicationTypeToolStripMenuItem.Name = "manageApplicationTypeToolStripMenuItem";
            manageApplicationTypeToolStripMenuItem.Size = new Size(262, 26);
            manageApplicationTypeToolStripMenuItem.Text = "Manage Application Type";
            manageApplicationTypeToolStripMenuItem.Click += manageApplicationTypeToolStripMenuItem_Click;
            // 
            // manageTestTypeToolStripMenuItem
            // 
            manageTestTypeToolStripMenuItem.Name = "manageTestTypeToolStripMenuItem";
            manageTestTypeToolStripMenuItem.Size = new Size(262, 26);
            manageTestTypeToolStripMenuItem.Text = "Manage Test Type";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 654);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "Main";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem applicationToolStripMenuItem;
        private ToolStripMenuItem peopleToolStripMenuItem;
        private ToolStripMenuItem showToolStripMenuItem;
        private ToolStripMenuItem driverToolStripMenuItem;
        private ToolStripMenuItem userToolStripMenuItem;
        private ToolStripMenuItem accountSettingToolStripMenuItem;
        private Panel panel1;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem drivingLicensServiceToolStripMenuItem;
        private ToolStripMenuItem manageApplicationToolStripMenuItem;
        private ToolStripMenuItem detainLicenseToolStripMenuItem;
        private ToolStripMenuItem manageApplicationTypeToolStripMenuItem;
        private ToolStripMenuItem manageTestTypeToolStripMenuItem;
    }
}