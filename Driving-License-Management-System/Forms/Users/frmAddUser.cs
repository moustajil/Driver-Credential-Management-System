using Driving_License_Management_System.Controller.Users;
using DVLD_Business_Layer.DVLD_Business_Layer;
using DVLD_Business_Layer.Users;
using System;
using System.Windows.Forms;

namespace Driving_License_Management_System.Forms.Users
{
    public partial class frmAddUser : Form
    {
        int personID;
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
                personID = BNPeople.FindPersonByColum(
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


        private void cbFilter_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            lbFilter.Clear();
            lbFilter.Focus();
        }

     

        private void btnNext_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private bool ValidateUserInputs()
        {
            bool isValid = true;

            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(tbUserName.Text))
            {
                errorProvider1.SetError(tbUserName, "Username is required.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                errorProvider1.SetError(tbPassword, "Password is required.");
                isValid = false;
            }
            else if (tbPassword.Text.Length < 4)
            {
                errorProvider1.SetError(
                    tbPassword,
                    "Password must contain at least 4 characters.");

                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(tbConfirmPassword.Text))
            {
                errorProvider1.SetError(
                    tbConfirmPassword,
                    "Please confirm the password.");

                isValid = false;
            }
            else if (tbPassword.Text != tbConfirmPassword.Text)
            {
                errorProvider1.SetError(
                    tbConfirmPassword,
                    "Passwords do not match.");

                isValid = false;
            }

            return isValid;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateUserInputs())
            {
                MessageBox.Show(
                    "Please correct the highlighted fields.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string userName = tbUserName.Text.Trim();
            string password = tbPassword.Text;
            bool isActive = cbActive.Checked;

            try
            {
                int userID = BNUser.AddUser(
                    personID,
                    userName,
                    password,
                    isActive);

                if (userID <= 0)
                {
                    MessageBox.Show(
                        "The user could not be added.\n" +
                        "The username or person may already be linked to another user.",
                        "Save Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                MessageBox.Show(
                    $"User added successfully.\n\nUser ID: {userID}",
                    "User Created",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                lbUserIDLogin.Text = userID.ToString();
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"An error occurred while saving the user:\n\n{ex.Message}",
                    "Save Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}