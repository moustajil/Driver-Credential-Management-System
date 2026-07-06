using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Driving_License_Management_System.LicenseManage
{
    public partial class frmLicenseManage : Form
    {
        public frmLicenseManage()
        {
            InitializeComponent();
        }

        private void LicenseManage_Load(object sender, EventArgs e)
        {
            DataTable applications =
        DVLD_Business_Layer.LicensManage.DBALicenseManage.GetallApplicaiton();

            dgvApplicaton.DataSource = applications;

            lbRecorde.Text = applications.Rows.Count.ToString();

            cbfilter.Items.Clear();

            cbfilter.Items.Add("None");
            cbfilter.Items.Add("L.D.L AppID");
            cbfilter.Items.Add("National ID");
            cbfilter.Items.Add("Status");

        }
    }
}
