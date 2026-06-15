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
            using (frmAddUser addUserForm = new frmAddUser())
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
    }
}