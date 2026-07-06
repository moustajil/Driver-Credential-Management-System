using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Driving_License_Management_System.Forms.LocalDrivingApplication
{
    public partial class LocalDriverLicense : Form
    {
        public LocalDriverLicense()
        {
            InitializeComponent();
        }

        private void LocalDriverLicense_Load(object sender, EventArgs e)
        {
            applicationDate.Text = DateTime.Now.ToString();
            cbClasses.Items.Clear();
            cbClasses.DataSource =
        DVLD_Business_Layer.LicenseClasses.BNLinceClasses.GetAllClasses();

            cbClasses.DisplayMember = "ClassName";
            cbClasses.SelectedIndex = 0;

        }

        private void ctrFindPerson1_OnFindPersonID(int personID)
        {
            lbCreatedBy.Text = DVL_Data_Access_Layer.Users.DBAUser.FindUserByPersonID(personID).Rows[0]["UserName"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // save application
        }
    }
}
