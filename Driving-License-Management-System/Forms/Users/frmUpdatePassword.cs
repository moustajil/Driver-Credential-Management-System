using System;
using System.Windows.Forms;

namespace Driving_License_Management_System.Forms.Users
{
    public partial class frmInforUserWithPerson : Form
    {
        private readonly int _userID;

        // Initializes the form with the selected user ID.
        public frmInforUserWithPerson(int userID)
        {
            InitializeComponent();
            UiTheme.Apply(this);
            _userID = userID;
        }

        // Loads the selected user's information when the form opens.
        private void frmInforUserWithPerson_Load(object sender, EventArgs e)
        {
            ctrInforPersonWithUser1.LoadUserInfo(_userID);
        }

        private void ctrInforPersonWithUser1_Load(object sender, EventArgs e)
        {
        }
    }
}
