using Driving_License_Management_System.Controller.People;
using Driving_License_Management_System.Forms.Users;
using DVLD_Business_Layer.Users;
using System;
using System.Data;
using System.Windows.Forms;

namespace Driving_License_Management_System.Controller.Users
{
    public partial class ctrInforPersonWithUser : UserControl
    {
        private int _userID = -1;
        private int _personID = -1;

        // Initializes the control without a user ID.
        public ctrInforPersonWithUser()
        {
            InitializeComponent();
        }

        // Initializes the control with a specific user ID.
        public ctrInforPersonWithUser(int userID)
        {
            InitializeComponent();
            _userID = userID;
        }

        // Loads the user automatically when the control opens
        // and a valid user ID was provided.
        private void ctrInforPersonWithUser_Load(object sender, EventArgs e)
        {
            if (_userID != -1)
            {
                LoadData();
            }
        }

        // Loads the user and the associated person's information.
        private void LoadData()
        {
            try
            {
                DataTable userInfo = BNUser.FindUserByID(_userID);

                if (userInfo == null || userInfo.Rows.Count == 0)
                {
                    ClearUserInformation();

                    MessageBox.Show(
                        "User information was not found.",
                        "User Not Found",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                DataRow userRow = userInfo.Rows[0];

                _personID = Convert.ToInt32(userRow["PersonID"]);

                // Load the person's information into the existing
                // person information control from the Designer.
                ctrInforPerson1.LoadPersonInfo(_personID);

                // Load the user's login information.
                lbUserID.Text = Convert.ToString(userRow["UserID"]);
                lbUserName.Text = Convert.ToString(userRow["UserName"]);

                bool isActive = Convert.ToBoolean(userRow["IsActive"]);

                lbIsUserActive.Text = isActive ? "Yes" : "No";
            }
            catch (Exception ex)
            {
                ClearUserInformation();

                MessageBox.Show(
                    $"An error occurred while loading the user information:\n\n{ex.Message}",
                    "Loading Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Loads a specific user's information into the control.
        public void LoadUserInfo(int userID)
        {
            if (userID <= 0)
            {
                ClearUserInformation();

                MessageBox.Show(
                    "The user ID is invalid.",
                    "Invalid User ID",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            _userID = userID;
            LoadData();
        }

        // Clears all displayed user information.
        private void ClearUserInformation()
        {
            _userID = -1;
            _personID = -1;

            lbUserID.Text = "N/A";
            lbUserName.Text = "N/A";
            lbIsUserActive.Text = "N/A";


        }

        // Changes the current user's password after validating all fields.
        private void button1_Click(object sender, EventArgs e)
        {
            string oldPassword = tbPasswors.Text.Trim();
            string newPassword = tbNewPassword.Text.Trim();
            string confirmPassword = tbConfirmePassword.Text.Trim();

            // Validate required fields.
            if (string.IsNullOrWhiteSpace(oldPassword))
            {
                MessageBox.Show(
                    "Please enter your current password.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                tbPasswors.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show(
                    "Please enter the new password.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                tbNewPassword.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show(
                    "Please confirm the new password.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                tbConfirmePassword.Focus();
                return;
            }

            // Verify the current password.
            bool isOldPasswordCorrect =
                DVLD_Business_Layer.Users.BNUser.CheckIfPasswordCorrect(
                    _userID,
                    oldPassword);

            if (!isOldPasswordCorrect)
            {
                MessageBox.Show(
                    "The current password is incorrect.",
                    "Incorrect Password",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                tbPasswors.Focus();
                tbPasswors.SelectAll();
                return;
            }

            // Verify that the new password and confirmation match.
            if (newPassword != confirmPassword)
            {
                MessageBox.Show(
                    "The new password and confirmation password do not match.",
                    "Password Mismatch",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                tbConfirmePassword.Focus();
                tbConfirmePassword.SelectAll();
                return;
            }

            // Prevent using the same password again.
            if (oldPassword == newPassword)
            {
                MessageBox.Show(
                    "The new password must be different from the current password.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                tbNewPassword.Focus();
                tbNewPassword.SelectAll();
                return;
            }

            // Update the password.
            bool isPasswordUpdated =
                DVLD_Business_Layer.Users.BNUser.UpdatePassword(
                    _userID,
                    newPassword);

            if (isPasswordUpdated)
            {
                MessageBox.Show(
                    "Password updated successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show(
                    "The password could not be updated.",
                    "Update Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}