using Driving_License_Management_System.Controller.Users;
using DVLD_Business_Layer.DVLD_Business_Layer;
using DVLD_Business_Layer.Users;
using System;
using System.Windows.Forms;

namespace Driving_License_Management_System.Forms.Users
{
    public partial class frmAddUser : Form
    {
        // Event used to return the newly created User ID.
        public delegate void DataBackEventHandler(object sender, int userID);
        public event DataBackEventHandler DataBack;

        // -1 means that no person has been selected yet.
        private int _personID = -1;

        public frmAddUser()
        {
            InitializeComponent();
        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {
            LoadFilterItems();

            // Prevent moving to the login information tab manually.
            tabControl1.SelectedTab = tabPage1;

            lbUserIDLogin.Text = "N/A";
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
            // Reset the previous person before starting a new search.
            _personID = -1;

            if (cbFilter.SelectedItem == null)
            {
                MessageBox.Show(
                    "Please select a search filter.",
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
                    "The selected search filter is invalid.",
                    "Search Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            if (databaseColumn == "PersonID" &&
                !int.TryParse(value, out int parsedPersonID))
            {
                MessageBox.Show(
                    "Person ID must be a valid number.",
                    "Invalid Value",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                lbFilter.Focus();
                lbFilter.SelectAll();
                return;
            }

            // Keep this validation only if Gender is stored as 0 or 1.
            if (databaseColumn == "Gendor")
            {
                if (!int.TryParse(value, out int gender) ||
                    (gender != 0 && gender != 1))
                {
                    MessageBox.Show(
                        "Gender must be 0 or 1.",
                        "Invalid Gender",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    lbFilter.Focus();
                    lbFilter.SelectAll();
                    return;
                }
            }

            try
            {
                _personID = BNPeople.FindPersonByColum(
                    databaseColumn,
                    value);

                if (_personID <= 0)
                {
                    _personID = -1;

                    MessageBox.Show(
                        "No person was found using the entered value.",
                        "Person Not Found",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }

                ctrInforPerson1.LoadPersonInfo(_personID);

                MessageBox.Show(
                    $"Person found successfully.\n\nPerson ID: {_personID}",
                    "Person Found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                _personID = -1;

                MessageBox.Show(
                    $"An error occurred while searching:\n\n{ex.Message}",
                    "Search Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbFilter.Clear();
            lbFilter.Focus();

            // The previous person should not remain selected
            // after changing the search filter.
            _personID = -1;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_personID <= 0)
            {
                MessageBox.Show(
                    "Please find and select a person before continuing.",
                    "Person Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                tabControl1.SelectedTab = tabPage1;
                lbFilter.Focus();
                return;
            }

            tabControl1.SelectedTab = tabPage2;
            tbUserName.Focus();
        }

        private bool ValidateUserInputs()
        {
            bool isValid = true;

            errorProvider1.Clear();

            if (_personID <= 0)
            {
                MessageBox.Show(
                    "Please find and select a person first.",
                    "Person Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                tabControl1.SelectedTab = tabPage1;
                return false;
            }

            string userName = tbUserName.Text.Trim();
            string password = tbPassword.Text;
            string confirmPassword = tbConfirmPassword.Text;

            if (string.IsNullOrWhiteSpace(userName))
            {
                errorProvider1.SetError(
                    tbUserName,
                    "Username is required.");

                isValid = false;
            }
            else if (userName.Length < 3)
            {
                errorProvider1.SetError(
                    tbUserName,
                    "Username must contain at least 3 characters.");

                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                errorProvider1.SetError(
                    tbPassword,
                    "Password is required.");

                isValid = false;
            }
            else if (password.Length < 4)
            {
                errorProvider1.SetError(
                    tbPassword,
                    "Password must contain at least 4 characters.");

                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(confirmPassword))
            {
                errorProvider1.SetError(
                    tbConfirmPassword,
                    "Please confirm the password.");

                isValid = false;
            }
            else if (password != confirmPassword)
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
                    _personID,
                    userName,
                    password,
                    isActive);

                if (userID <= 0)
                {
                    MessageBox.Show(
                        "The user could not be added.\n\n" +
                        "The username may already exist, or this person " +
                        "may already be linked to another user.",
                        "Save Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                lbUserIDLogin.Text = userID.ToString();

                MessageBox.Show(
                    $"User added successfully.\n\nUser ID: {userID}",
                    "User Created",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Notify frmUserManagement that a user was created.
                DataBack?.Invoke(this, userID);

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}