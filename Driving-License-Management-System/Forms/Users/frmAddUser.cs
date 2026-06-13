using Driving_License_Management_System.Controller.Users;
using DVLD_Business_Layer.DVLD_Business_Layer;
using System;
using System.Windows.Forms;

namespace Driving_License_Management_System.Forms.Users
{
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {
            LoadFilterItems();
        }

        private void LoadFilterItems()
        {
            cbFilter.Items.Clear();

            cbFilter.Items.Add("Person ID");
            cbFilter.Items.Add("National ID");
            cbFilter.Items.Add("First Name");
            cbFilter.Items.Add("Second Name");
            cbFilter.Items.Add("Third Name");
            cbFilter.Items.Add("Last Name");
            cbFilter.Items.Add("Gender");
            cbFilter.Items.Add("Phone");
            cbFilter.Items.Add("Email");

            cbFilter.SelectedIndex = 0;
        }

        private string GetDatabaseColumnName(string selectedFilter)
        {
            switch (selectedFilter)
            {
                case "Person ID":
                    return "PersonID";

                case "National ID":
                    return "NationalNo";

                case "First Name":
                    return "FirstName";

                case "Second Name":
                    return "SecondName";

                case "Third Name":
                    return "ThirdName";

                case "Last Name":
                    return "LastName";

                case "Gender":
                    return "Gendor";

                case "Phone":
                    return "Phone";

                case "Email":
                    return "Email";

                default:
                    return string.Empty;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FindPerson();
        }

        private void FindPerson()
        {
            if (cbFilter.SelectedItem == null)
            {
                MessageBox.Show(
                    "Please select a filter.",
                    "Search Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cbFilter.Focus();
                return;
            }

            string value = lbFilter.Text.Trim();

            if (string.IsNullOrWhiteSpace(value))
            {
                MessageBox.Show(
                    "Please enter a value to search.",
                    "Search Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                lbFilter.Focus();
                return;
            }

            string selectedFilter = cbFilter.SelectedItem.ToString();
            string databaseColumn = GetDatabaseColumnName(selectedFilter);

            if (string.IsNullOrWhiteSpace(databaseColumn))
            {
                MessageBox.Show(
                    "The selected filter is invalid.",
                    "Search Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            if ((databaseColumn == "PersonID" || databaseColumn == "Gendor") &&
                !int.TryParse(value, out _))
            {
                MessageBox.Show(
                    $"{selectedFilter} must be a valid number.",
                    "Invalid Value",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                lbFilter.Focus();
                lbFilter.SelectAll();
                return;
            }

            try
            {
                int personID = BNPeople.FindPersonByColum(
                    databaseColumn,
                    value);

                if (personID == -1)
                {
                    MessageBox.Show(
                        "No person was found using the entered value.",
                        "Person Not Found",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }

                ctrInforPerson1.LoadPersonInfo(personID);


                MessageBox.Show(
                    $"Person found successfully.\n\nPerson ID: {personID}",
                    "Person Found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadPersonInformation(personID);
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

        private void LoadPersonInformation(int personID)
        {
            // Send the PersonID to your user control or person-information form.
            // Example:
            //
            // ctrlPersonCard1.LoadPersonInfo(personID);
        }

        private void cbFilter_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            lbFilter.Clear();
            lbFilter.Focus();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}