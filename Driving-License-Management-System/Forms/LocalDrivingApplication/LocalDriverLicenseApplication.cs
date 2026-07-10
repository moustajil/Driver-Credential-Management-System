using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Driving_License_Management_System.Forms.LocalDrivingApplication
{
    public partial class LocalDriverLicenseApplication : Form
    {

        int pID;

        public LocalDriverLicenseApplication()
        {
            InitializeComponent();
            UiTheme.Apply(this);
        }

        private void LocalDriverLicense_Load(object sender, EventArgs e)
        {
            applicationDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            cbClasses.Items.Clear();
            cbClasses.DataSource =
        DVLD_Business_Layer.LicenseClasses.BNLinceClasses.GetAllClasses();

            cbClasses.DisplayMember = "ClassName";

            if (cbClasses.Items.Count > 0)
                cbClasses.SelectedIndex = 0;

        }

        private void ctrFindPerson1_OnFindPersonID(int personID)
        {
            pID = personID;

            DataTable userInfo =
                DVL_Data_Access_Layer.Users.DBAUser.FindUserByPersonID(personID);

            lbCreatedBy.Text = userInfo.Rows.Count > 0
                ? userInfo.Rows[0]["UserName"].ToString()
                : "Unknown";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pID <= 0)
            {
                MessageBox.Show(
                    "Please find and select a person before continuing.",
                    "Person Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            tabControl1.SelectedIndex = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (pID <= 0)
                {
                    MessageBox.Show(
                        "Please find and select a person before saving.",
                        "Person Required",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                var person =
                    DVLD_Business_Layer.DVLD_Business_Layer.BNPeople.Find(pID);

                if (person == null)
                {
                    MessageBox.Show("Person not found.");
                    return;
                }

                if (cbClasses.SelectedItem == null)
                {
                    MessageBox.Show("Please select a license class.");
                    return;
                }

                DateTime date = DateTime.Parse(applicationDate.Text);
                string className = cbClasses.Text;
                string nationalID = person.NationalID;

                string fullName =
                    $"{person.FirstName} {person.SecondName} {person.LastName}";

                int applicationID =
                    DVLD_Business_Layer.LicensManage.DBALicenseManage
                    .DBBInsertApplication(
                        className,
                        nationalID,
                        fullName,
                        date
                    );

                if (applicationID > 0)
                {
                    lbApplicationID.Text = applicationID.ToString();

                    MessageBox.Show(
                        $"Application saved successfully.\nApplication ID: {applicationID}",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    MessageBox.Show(
                        "The application was not saved.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
