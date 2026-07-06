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
        }

        private void LocalDriverLicense_Load(object sender, EventArgs e)
        {
            applicationDate.Text = DateTime.Now.ToString();
            cbClasses.Items.Clear();
            cbClasses.DataSource =
        DVLD_Business_Layer.LicenseClasses.BNLinceClasses.GetAllClasses();

            cbClasses.DisplayMember = "ClassName";
            cbClasses.SelectedIndex = 0;

        }

        private void ctrFindPerson1_OnFindPersonID(int personID)
        {
            lbCreatedBy.Text = DVL_Data_Access_Layer.Users.DBAUser.FindUserByPersonID(personID).Rows[0]["UserName"].ToString();
            pID = personID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
                string className = cbClasses.SelectedItem.ToString();
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
