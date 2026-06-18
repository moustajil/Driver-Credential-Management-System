using Driving_License_Management_System.Forms.Application;
using Driving_License_Management_System.Forms.ApplicationTestType;
using Driving_License_Management_System.Forms.ApplicationType;
using Driving_License_Management_System.Forms.People;
using Driving_License_Management_System.Forms.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Driving_License_Management_System
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            UiTheme.Apply(this);
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {

            People people = new People();
            people.Show();

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Close();
            login.Show();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserManagement userManagement = new frmUserManagement();
            userManagement.Show();
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManagetypeApplication frmManagetype = new frmManagetypeApplication();
            frmManagetype.Show();
        }

        private void manageTestTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageTestApplicationtype applicationTest = new frmManageTestApplicationtype();
            applicationTest.ShowDialog();
        }
    }
}
