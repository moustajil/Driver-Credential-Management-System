using DVLD_Business_Layer.Users;
using System;
using System.Data;
using System.Windows.Forms;

namespace Driving_License_Management_System.Forms.Users
{
    public partial class frmDetailsInfo : Form
    {
        private readonly int _userID;
        private int _personID = -1;

        public frmDetailsInfo(int userID)
        {
            InitializeComponent();
            UiTheme.Apply(this);
            _userID = userID;
        }

        // Loads the user and related person information.
        private void LoadData()
        {
            try
            {
                DataTable userInfo = BNUser.FindUserByID(_userID);

                if (userInfo == null || userInfo.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "User information was not found.",
                        "User Not Found",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    Close();
                    return;
                }

                DataRow userRow = userInfo.Rows[0];

                // Get the PersonID related to this user.
                _personID = Convert.ToInt32(userRow["PersonID"]);

                // Load the person's information using PersonID, not UserID.
                ctrInforPerson1.LoadPersonInfo(_personID);

                // Load the login information.
                lbUserID.Text = userRow["UserID"].ToString();
                lbUserName.Text = userRow["UserName"].ToString();

                bool isActive = Convert.ToBoolean(userRow["IsActive"]);
                lbIsActive.Text = isActive ? "Yes" : "No";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"An error occurred while loading the user information:\n\n{ex.Message}",
                    "Loading Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Loads the information when the form opens.
        private void frmDetailsInfo_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // Closes the form.
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
