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
            LoadData();
        }


        private void LoadData()
        {
            dataGridView1.DataSource = DVLD_Business_Layer.Users.BNUser.GetAllUsers();

            lbRecord.Text = DVLD_Business_Layer.Users.BNUser.GetCountAllUsers().ToString();
        }

        private void frmUserManagement_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmAddUser frmAddUser = new frmAddUser();
            frmAddUser.ShowDialog();
        }
    }
}
