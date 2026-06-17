using DVLD_Business_Layer.Users;
using System;
using System.Windows.Forms;

namespace Driving_License_Management_System.Forms.Users
{
    public partial class frmUserManagement : Form
    {
        private string columnName = string.Empty;

        public frmUserManagement()
        {
            InitializeComponent();
        }

        private void frmUserManagement_Load(object sender, EventArgs e)
        {
            InitializeFilterComboBox();
            ConfigureDataGridView();
            LoadData();
        }

        private void InitializeFilterComboBox()
        {
            cbFilterUsers.Items.Clear();

            cbFilterUsers.Items.Add("None");
            cbFilterUsers.Items.Add("User ID");
            cbFilterUsers.Items.Add("User Name");
            cbFilterUsers.Items.Add("Person ID");
            cbFilterUsers.Items.Add("Full Name");
            cbFilterUsers.Items.Add("Is Active");

            cbFilterUsers.SelectedIndex = 0;

            tbFilter.Clear();
            tbFilter.Visible = false;
        }

        private void LoadData()
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = BNUser.GetAllUsers();

                UpdateRecordCount();
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

        private void UpdateRecordCount()
        {
            // This displays the number of currently visible rows.
            lbRecord.Text = dataGridView1.Rows.Count.ToString();

            // You can use this instead when you always want the total
            // number of users from the database:
            //
            // lbRecord.Text = BNUser.GetCountAllUsers().ToString();
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
            dataGridView1.RowHeadersVisible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            using (frmAddUser addUserForm = new frmAddUser(-1))
            {
                addUserForm.DataBack += AddUserForm_DataBack;
                addUserForm.ShowDialog();
            }
        }

        private void AddUserForm_DataBack(object sender, int userID)
        {
            LoadData();
        }

        private void cbFilterUsers_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (cbFilterUsers.SelectedItem == null)
                return;

            string selectedFilter = cbFilterUsers.SelectedItem.ToString();

            tbFilter.Clear();

            switch (selectedFilter)
            {
                case "User ID":
                    columnName = "UserID";
                    tbFilter.Visible = true;
                    break;

                case "User Name":
                    columnName = "UserName";
                    tbFilter.Visible = true;
                    break;

                case "Person ID":
                    columnName = "PersonID";
                    tbFilter.Visible = true;
                    break;


                case "Is Active":
                    columnName = "IsActive";
                    tbFilter.Visible = true;
                    tbFilter.PlaceholderText = "Enter true or false";
                    break;

                default:
                    columnName = string.Empty;
                    tbFilter.Visible = false;
                    LoadData();
                    break;
            }

            if (selectedFilter != "Is Active")
                tbFilter.PlaceholderText = "Enter search value";
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            if (!tbFilter.Visible)
                return;

            if (string.IsNullOrWhiteSpace(columnName))
                return;

            string value = tbFilter.Text.Trim();

            if (string.IsNullOrWhiteSpace(value))
            {
                LoadData();
                return;
            }

            ApplySearch(columnName, value);
        }

        private void ApplySearch(string databaseColumn, string value)
        {
            try
            {
                if (databaseColumn == "IsActive")
                {
                    if (!TryConvertActiveValue(value, out bool isActive))
                    {
                        dataGridView1.DataSource = null;
                        lbRecord.Text = "0";
                        return;
                    }

                    value = isActive.ToString();
                }

                dataGridView1.DataSource = null;
                dataGridView1.DataSource =
                    BNUser.FindUserByColums(databaseColumn, value);

                UpdateRecordCount();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"An error occurred while searching:\n\n{ex.Message}",
                    "Search Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private bool TryConvertActiveValue(string value, out bool isActive)
        {
            value = value.Trim().ToLower();

            switch (value)
            {
                case "true":
                case "1":
                case "yes":
                case "active":
                    isActive = true;
                    return true;

                case "false":
                case "0":
                case "no":
                case "inactive":
                    isActive = false;
                    return true;

                default:
                    isActive = false;
                    return false;
            }
        }

        private void deletUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show(
                    "Please select a user first.",
                    "No User Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            int userID = Convert.ToInt32(
                dataGridView1.CurrentRow.Cells["UserID"].Value
            );

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete user with ID {userID}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result != DialogResult.Yes)
                return;

            try
            {
                bool isDeleted = BNUser.DeletUser(userID);

                if (isDeleted)
                {
                    MessageBox.Show(
                        "User deleted successfully.",
                        "Deleted",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    LoadData();
                }
                else
                {
                    MessageBox.Show(
                        "The user could not be deleted.",
                        "Delete Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"An error occurred while deleting the user:\n\n{ex.Message}",
                    "Delete Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void editeUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(
                dataGridView1.CurrentRow.Cells["UserID"].Value
            );

            using (frmAddUser addUserForm = new frmAddUser(userID))
            {
                addUserForm.DataBack += AddUserForm_DataBack;
                addUserForm.ShowDialog();
            }


        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void editePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(
                dataGridView1.CurrentRow.Cells["UserID"].Value
            );

            frmInforUserWithPerson frmUpdate = new frmInforUserWithPerson(userID);
            frmUpdate.ShowDialog();

        }
    }
}