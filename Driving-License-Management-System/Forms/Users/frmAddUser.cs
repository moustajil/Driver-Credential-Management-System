using DVLD_Business_Layer.DVLD_Business_Layer;
using System.Data.Common;


namespace Driving_License_Management_System.Forms.Users
{
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            cbFilter.Items.Clear();

            cbFilter.Items.Add("Person ID");
            cbFilter.Items.Add("NationalID");
            cbFilter.Items.Add("FirstName");
            cbFilter.Items.Add("SecondName");
            cbFilter.Items.Add("ThirdName");
            cbFilter.Items.Add("LastName");
            cbFilter.Items.Add("Gendor");
            cbFilter.Items.Add("Phone");
            cbFilter.Items.Add("Email");

            cbFilter.SelectedIndex = 0;
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {

        }

        private string GetDatabaseColumnName(string column)
        {
            switch (column)
            {
                case "Person ID":
                    return "PersonID";

                case "NationalID":
                    return "NationalNo";

                case "FirstName":
                    return "FirstName";

                case "SecondName":
                    return "SecondName";

                case "ThirdName":
                    return "ThirdName";

                case "LastName":
                    return "LastName";

                case "Gendor":
                    return "Gendor";

                case "Phone":
                    return "Phone";

                case "Email":
                    return "Email";

                default:
                    return null;
            }
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (cbFilter.SelectedItem == null)
            {
                MessageBox.Show(
                    "Please select a filter.",
                    "Search Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            string column = cbFilter.SelectedItem.ToString();

            string value = lbFilter.Text.Trim();

            if (string.IsNullOrEmpty(value))
            {
                MessageBox.Show(
                    "Please enter a value to search.",
                    "Search Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            string dbColumn = GetDatabaseColumnName(column);

            if (string.IsNullOrEmpty(dbColumn))
            {
                MessageBox.Show(
                    "Invalid filter selected.",
                    "Search Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            BNPeople person = BNPeople.FindByCol(dbColumn, value);

            if (person == null)
            {
                MessageBox.Show(
                    "Person not found.",
                    "Search Result",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            MessageBox.Show(
                "Person Found:\n\n" +
                "National ID: " + person.NationalID + "\n" +
                "Gender: " + person.Gender,
                "Search Result",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        }
    }
}
