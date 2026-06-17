using Driving_License_Management_System.Forms.People;
using DVLD_Business_Layer.DVLD_Business_Layer;
using DVLD_Business_Layer.Users;
using System;
using System.Data;
using System.Windows.Forms;

namespace Driving_License_Management_System.Forms.Users
{
    public partial class frmAddUser : Form
    {
        // Represents the current form mode.
        private enum FormMode
        {
            AddNew,
            Update
        }

        // Stores whether the form is adding or updating a user.
        private FormMode _mode = FormMode.AddNew;

        // Stores the current user ID. -1 means no existing user.
        private int _userID = -1;

        // Stores the selected person's ID. -1 means no person is selected.
        private int _personID = -1;

        // Event used to return the saved user ID to the management form.
        public delegate void DataBackEventHandler(object sender, int userID);

        public event DataBackEventHandler DataBack;

        // Opens the form in Add New mode.
        public frmAddUser()
        {
            InitializeComponent();

            _mode = FormMode.AddNew;
            _userID = -1;
            _personID = -1;
        }

        // Opens the form in Update mode using an existing user ID.
        public frmAddUser(int userID)
        {
            InitializeComponent();

            _mode = FormMode.Update;
            _userID = userID;
        }

        // Initializes the form and loads the required information.
        private void frmAddUser_Load(object sender, EventArgs e)
        {
            LoadFilterItems();

            tabControl1.SelectedTab = tabPage1;

            if (_mode == FormMode.AddNew)
            {
                PrepareAddMode();
            }
            else
            {
                PrepareUpdateMode();
            }
        }

        // Configures the form for adding a new user.
        private void PrepareAddMode()
        {
            lbStatuUser.Text = "Add New User";
            lbUserIDLogin.Text = "N/A";

            _userID = -1;
            _personID = -1;

            gbFindPerson.Enabled = true;
            btnNext.Enabled = true;

            tbUserName.Clear();
            tbPassword.Clear();
            tbConfirmPassword.Clear();

            cbActive.Checked = true;
        }

        // Configures the form for updating an existing user.
        private void PrepareUpdateMode()
        {
            lbStatuUser.Text = "Update User";
            lbUserIDLogin.Text = _userID.ToString();

            gbFindPerson.Enabled = false;

            LoadUserData();
        }

        // Loads the existing user's data into the form controls.
        private void LoadUserData()
        {
            try
            {
                DataTable userData = BNUser.FindUserByID(_userID);

                if (userData == null || userData.Rows.Count == 0)
                {
                    MessageBox.Show(
                        $"No user was found with ID {_userID}.",
                        "User Not Found",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    Close();
                    return;
                }

                DataRow row = userData.Rows[0];

                _personID = Convert.ToInt32(row["PersonID"]);

                tbUserName.Text = row["UserName"].ToString();
                tbPassword.Text = row["Password"].ToString();
                tbConfirmPassword.Text = row["Password"].ToString();
                cbActive.Checked = Convert.ToBoolean(row["IsActive"]);

                ctrInforPerson1.LoadPersonInfo(_personID);

                tabControl1.SelectedTab = tabPage2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"An error occurred while loading the user:\n\n{ex.Message}",
                    "Loading Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                Close();
            }
        }

        // Loads all available person-search filters.
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

        // Converts the displayed filter name to its database column name.
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

        // Searches for a person when the search picture is clicked.
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FindPerson();
        }

        // Validates the search value and searches for a person.
        private void FindPerson()
        {
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

            string databaseColumn =
                GetDatabaseColumnName(selectedFilter);

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
                !int.TryParse(value, out _))
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

        // Clears the previous search when the filter changes.
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbFilter.Clear();
            lbFilter.Focus();

            if (_mode == FormMode.AddNew)
            {
                _personID = -1;
            }
        }

        // Moves the user to the login information tab.
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

        // Validates the username, password, and selected person.
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

        // Saves a new user or updates the existing user.
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

            try
            {
                bool isSaved;

                if (_mode == FormMode.AddNew)
                {
                    isSaved = AddNewUser();
                }
                else
                {
                    isSaved = UpdateExistingUser();
                }

                if (!isSaved)
                {
                    return;
                }

                DataBack?.Invoke(this, _userID);

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

        // Adds a new user to the database.
        private bool AddNewUser()
        {
            string userName = tbUserName.Text.Trim();
            string password = tbPassword.Text;
            bool isActive = cbActive.Checked;

            int newUserID = BNUser.AddUser(
                _personID,
                userName,
                password,
                isActive);

            if (newUserID <= 0)
            {
                MessageBox.Show(
                    "The user could not be added.\n\n" +
                    "The username may already exist, or this person " +
                    "may already be linked to another user.",
                    "Save Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }

            _userID = newUserID;

            lbUserIDLogin.Text = _userID.ToString();
            lbStatuUser.Text = "Update User";

            MessageBox.Show(
                $"User added successfully.\n\nUser ID: {_userID}",
                "User Created",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            return true;
        }

        // Updates the current user's information in the database.
        private bool UpdateExistingUser()
        {
            string userName = tbUserName.Text.Trim();
            string password = tbPassword.Text;
            bool isActive = cbActive.Checked;

            bool isUpdated = BNUser.UpdateUser(
                 _userID,
                 _personID,
                 userName,
                 password,
                 isActive);


            if (!isUpdated)
            {
                MessageBox.Show(
                    "The user could not be updated.\n\n" +
                    "The username may already be used by another user.",
                    "Update Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }

            MessageBox.Show(
                $"User updated successfully.\n\nUser ID: {_userID}",
                "User Updated",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            return true;
        }

        // Closes the form without saving changes.
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmAddEdite addPerson = new frmAddEdite(_personID);

            addPerson.ShowDialog();
        }

       
    }
}