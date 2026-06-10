using Driving_License_Management_System.Controller.People;
using System;
using System.Windows.Forms;

namespace Driving_License_Management_System.Forms.People
{
    public partial class frmAddEdite : Form
    {

        public delegate void DelegateEventHandler(object sender, int personID);
        public DelegateEventHandler DataBack;

        /// <summary>
        /// Initializes the Add/Edit Person form.
        /// </summary>
 

        private int _personID = 0;

        public frmAddEdite(int persID)
        {
            InitializeComponent();
            if (_personID > 0)
            {
                updateAddPerson.Text = "Update Person";
            }
            _personID = persID;
            personID.Text = persID.ToString();
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
            ctlFromAddEdite1.LoadPerson(_personID); // ✅ send to control
        }

        /// <summary>
        /// Receives the created person ID from the user control.
        /// </summary>
        private void ctlFromAddEdite1_GetPersonIdCreated(int obj)
        {
            personID.Text = obj.ToString();
            updateAddPerson.Text = "Update Person";
            DataBack?.Invoke(this,obj);
        }
    }
}