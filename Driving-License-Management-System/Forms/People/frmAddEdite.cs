using Driving_License_Management_System.Controller.People;
using System;
using System.Windows.Forms;

namespace Driving_License_Management_System.Forms.People
{
    public partial class frmAddEdite : Form
    {
        /// <summary>
        /// Initializes the Add/Edit Person form.
        /// </summary>
        public frmAddEdite()
        {
            InitializeComponent();
            personID.Text = "0";
        }

        /// <summary>
        /// Handles Label1 click event.
        /// </summary>
        private void label1_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Handles form load event.
        /// </summary>
        private void frmAddEdite_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Receives the created person ID from the user control.
        /// </summary>
        private void ctlFromAddEdite1_GetPersonIdCreated(int obj)
        {
            personID.Text = obj.ToString();
        }
    }
}