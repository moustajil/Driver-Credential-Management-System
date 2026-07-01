using System;
using System.Data;
using System.Windows.Forms;

namespace Driving_License_Management_System.Controller.Users
{
    public partial class ctrFindPerson : UserControl
    {

        public event Action<int> OnFindPersonID;
        protected virtual void PersonId(int personID)
        {
            Action<int> handler = OnFindPersonID;
            if (handler!=null)
            {
                handler(personID);
                
            }
        }
        
        public ctrFindPerson()
        {
            InitializeComponent();
        }

        private void ctrFindPerson_Load(object sender, EventArgs e)
        {
            cbFilter.Items.Clear();

            cbFilter.Items.Add("National ID");
            cbFilter.Items.Add("Person ID");

            // Select the first filter by default
            cbFilter.SelectedIndex = 0;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string value = tbValue.Text.Trim();

            if (string.IsNullOrWhiteSpace(value))
            {
                MessageBox.Show(
                    "Please enter a value.",
                    "Missing Value",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                tbValue.Focus();
                return;
            }

            if (cbFilter.SelectedItem == null)
            {
                MessageBox.Show(
                    "Please select a filter.",
                    "Missing Filter",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            string nameKey;

            if (cbFilter.SelectedItem.ToString() == "National ID")
            {
                nameKey = "NationalNo";
            }
            else
            {
                nameKey = "PersonID";
            }

            DataTable personTable =
                DVLD_Business_Layer.DVLD_Business_Layer.BNPeople
                .FindByCol(nameKey, value);

            if (personTable == null || personTable.Rows.Count == 0)
            {
                MessageBox.Show(
                    "Person was not found.",
                    "Not Found",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                personID.Text = "";
                name.Text = "";

                return;
            }
            DataRow personRow = personTable.Rows[0];

            if (OnFindPersonID != null)
            {
                OnFindPersonID(int.Parse(personRow["PersonID"].ToString()));
            }

           

            personID.Text = personRow["PersonID"].ToString();
            name.Text = personRow["FirstName"].ToString() + personRow["SecondName"].ToString();
            natiolity.Text = personRow["NationalNo"].ToString();
            gender.Text = int.Parse(personRow["Gendor"].ToString()) == 0 ? "Male" : "Female";
            email.Text = personRow["Email"].ToString();
            address.Text = personRow["Address"].ToString();
            dateOfBirthe.Text = personRow["DateOfBirth"].ToString();
            phone.Text = personRow["Phone"].ToString();
            country.Text = DVLD_Business_Layer.BnCountries.GetCountryNameByCountryID(int.Parse(personRow["NationalityCountryID"].ToString()));
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}