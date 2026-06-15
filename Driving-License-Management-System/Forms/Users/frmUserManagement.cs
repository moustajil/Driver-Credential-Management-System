using DVLD_Business_Layer.Users;
using System;
using System.Windows.Forms;

namespace Driving_License_Management_System.Forms.Users
{
    public partial class frmUserManagement : Form
    {
        public frmUserManagement()
        {
            InitializeComponent();
        }

        private void frmUserManagement_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = BNUser.GetAllUsers();

                lbRecord.Text = BNUser
                    .GetCountAllUsers()
                    .ToString();

                ConfigureDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"An error occurred while loading users:\n\n{ex.Message}",
                    "Loading Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ConfigureDataGridView()
        {
            dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            using (frmAddUser addUserForm = new frmAddUser())
            {
                // Subscribe to the DataBack event.
                addUserForm.DataBack += AddUserForm_DataBack;

                addUserForm.ShowDialog();
            }
        }

        private void AddUserForm_DataBack(object sender, int userID)
        {
            // Reload all records from the database.
            LoadData();
        }
    }
}