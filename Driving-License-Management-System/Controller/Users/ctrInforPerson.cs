using DVLD_Business_Layer.DVLD_Business_Layer;
using System;
using System.Windows.Forms;

namespace Driving_License_Management_System.Controller.Users
{
    public partial class ctrInforPerson : UserControl
    {
        private int _personID = -1;

        public int PersonID
        {
            get { return _personID; }
        }

        public ctrInforPerson()
        {
            InitializeComponent();
        }

        public ctrInforPerson(int personID)
        {
            InitializeComponent();
            LoadPersonInfo(personID);
        }

        public void LoadPersonInfo(int personID)
        {
            if (personID <= 0)
            {
                //ClearPersonInfo();
                return;
            }

            _personID = personID;

            string nationalNo = string.Empty;
            string firstName = string.Empty;
            string secondName = string.Empty;
            string thirdName = string.Empty;
            string lastName = string.Empty;
            DateTime dateOfBirth = DateTime.MinValue;
            byte gender = 0;
            string address = string.Empty;
            string phone = string.Empty;
            string email = string.Empty;
            int nationalityCountryID = -1;
            string imagePath = string.Empty;

            BNPeople person = DVLD_Business_Layer.DVLD_Business_Layer.BNPeople.Find(personID);



            // Change these control names to your actual label names.
            lbPersonID.Text = person.PersonID.ToString();
            lbName.Text = person.FirstName + " " + person.SecondName + " " + person.ThirdName ;
            lbCountry.Text = DVLD_Business_Layer.BnCountries.GetCountryNameByCountryID(person.NationalityCountryID);
            lbAddress.Text = person.Address;
            lbNationalID.Text = person.NationalID;
            lbGender.Text = person.Gender == 0 ? "Male" : "Female";
            lbPhone.Text = person.Phone;
            lbEmail.Text = person.Email;
            lbDateOfBirth.Text = person.DateOfBirth.ToString();
            

            //LoadPersonImage(imagePath);
        }

       

       /* public void ClearPersonInfo()
        {
            _personID = -1;

            lblPersonID.Text = "[????]";
            lblNationalNo.Text = "[????]";
            lblFullName.Text = "[????]";
            lblDateOfBirth.Text = "[????]";
            lblGender.Text = "[????]";
            lblAddress.Text = "[????]";
            lblPhone.Text = "[????]";
            lblEmail.Text = "[????]";
            lblNationality.Text = "[????]";

            pbPersonImage.Image = null;
            pbPersonImage.ImageLocation = null;
        }*/

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }
    }
}