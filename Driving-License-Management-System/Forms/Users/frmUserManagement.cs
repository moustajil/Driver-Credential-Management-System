using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Driving_License_Management_System.Forms.Users
{
    public partial class frmUserManagement : Form
    {
        public frmUserManagement()
        {
            InitializeComponent();
            dataGridView1.DataSource = DVLD_Business_Layer.Users.BNUser.GetAllUsers();
        }

        private void frmUserManagement_Load(object sender, EventArgs e)
        {

        }
    }
}
