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

        }

        private void ctrFindPerson1_OnFindPersonID(int personID)
        {
            lbCreatedBy.Text = DVL_Data_Access_Layer.Users.DBAUser.FindUserByPersonID(personID).Rows[0]["UserName"].ToString();
        }
    }
}
