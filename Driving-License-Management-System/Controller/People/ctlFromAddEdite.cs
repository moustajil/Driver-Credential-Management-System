using Driving_License_Management_System.Forms.People;
using DVLD_Business_Layer.DVLD_Business_Layer;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Driving_License_Management_System.Controller.People
{
    public partial class ctlFromAddEdite : UserControl
    {
        public event Action<int> GetPersonIdCreated;

        /// <summary>
        /// Raises the GetPersonIdCreated event and sends the created person ID.
        /// </summary>
        protected virtual void PersonIdCreated(int persondID)
        {
            Action<int> handler = GetPersonIdCreated;

            if (handler != null)
            {
                handler(persondID);
            }
        }

        /// <summary>
        /// Initializes the control and loads default values.
        /// </summary>
        public ctlFromAddEdite()
        {
            InitializeComponent();

            dtPiker.MinDate = new DateTime(1900, 1, 1);
            dtPiker.MaxDate = DateTime.Today.AddYears(-18);
            dtPiker.Value = dtPiker.MaxDate;

            rbMale.Checked = true;

            string[] countries = DVLD_Business_Layer.BnCountries.GetAllCountries();
            cbCountry.Items.AddRange(countries);
            cbCountry.SelectedIndex = 0;

            llRemoveImage.Visible = false;
        }

        /// <summary>
        /// Handles text changes in TextBox1.
        /// </summary>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Validates the national number when the control loses focus.
        /// </summary>
        private void nNumber_Leave(object sender, EventArgs e)
        {
            string nationalityNumber = nNumber.Text.Trim();

            bool checkNationaNumber =
                DVLD_Business_Layer.DVLD_Business_Layer.BNPeople
                .checkNationaNumber(nationalityNumber);

            if (checkNationaNumber)
            {
                errorProvider1.SetError(
                    nNumber,
                    "National Number already exists."
                );

                nNumber.Focus();
            }
            else
            {
                errorProvider1.SetError(nNumber, "");
            }
        }

        /// <summary>
        /// Changes the displayed image when Male is selected.
        /// </summary>
        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            pBImage.Image = Properties.Resources.famel;
        }

        /// <summary>
        /// Changes the displayed image when Female is selected.
        /// </summary>
        private void rbFamel_CheckedChanged(object sender, EventArgs e)
        {
            pBImage.Image = Properties.Resources.male;
        }

        /// <summary>
        /// Validates the email format when the control loses focus.
        /// </summary>
        private void email_Leave(object sender, EventArgs e)
        {
            string emailT = email.Text;

            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!Regex.IsMatch(emailT, pattern))
            {
                MessageBox.Show(
                    "Invalid email format!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                email.Focus();
            }
        }

        /// <summary>
        /// Handles control load event.
        /// </summary>
        private void ctlFromAddEdite_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Opens a dialog to select an image.
        /// </summary>
        private void lkImage_LinkClicked(
            object sender,
            LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pBImage.Image = Image.FromFile(ofd.FileName);
                llRemoveImage.Visible = true;
            }
        }

        /// <summary>
        /// Saves the person information and creates a new person record.
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = fName.Text?.Trim() ?? "";
                string secondName = sName.Text?.Trim() ?? "";
                string thirdName = tName.Text?.Trim() ?? "";
                string lastName = foName.Text?.Trim() ?? "";

                string emailText = email.Text?.Trim() ?? "";
                string phoneNumber = pNumber.Text?.Trim() ?? "";
                string nationalityNumber = nNumber.Text?.Trim() ?? "";
                string address = rtbAddress.Text?.Trim() ?? "";

                int gender = rbFamel.Checked ? 1 : 0;

                DateTime birthDate = dtPiker.Value.Date;

                DateTime sqlMin = new DateTime(1753, 1, 1);
                DateTime sqlMax = new DateTime(9999, 12, 31);

                if (birthDate < sqlMin || birthDate > sqlMax)
                {
                    MessageBox.Show("Birth date is out of valid range.");
                    return;
                }

                int age = DateTime.Today.Year - birthDate.Year;

                if (birthDate > DateTime.Today.AddYears(-age))
                    age--;

                if (age < 18)
                {
                    MessageBox.Show(
                        "Person must be at least 18 years old."
                    );

                    return;
                }

                int country = cbCountry.SelectedIndex != null
                    ? Convert.ToInt32(cbCountry.SelectedIndex) + 1
                    : 0;

                string imagePath = string.IsNullOrWhiteSpace(
                    pBImage.ImageLocation)
                    ? null
                    : pBImage.ImageLocation;

                MessageBox.Show(
                    $"National Number: {nationalityNumber}\n" +
                    $"Name: {firstName} {secondName} {thirdName} {lastName}\n" +
                    $"Birth Date: {birthDate}\n" +
                    $"Gender: {gender}\n" +
                    $"Phone: {phoneNumber}\n" +
                    $"Email: {emailText}\n" +
                    $"Country: {country}\n" +
                    $"Address: {address}\n" +
                    $"Image: {imagePath}",
                    "Debug"
                );

                BNPeople people = new BNPeople(
                    nationalityNumber,
                    firstName,
                    secondName,
                    thirdName,
                    lastName,
                    birthDate,
                    gender,
                    address,
                    phoneNumber,
                    emailText,
                    country,
                    imagePath
                );

                int personId = people.AddNewPerson();

                if (personId > 0)
                {
                    if (GetPersonIdCreated != null)
                    {
                        PersonIdCreated(personId);
                    }

                    MessageBox.Show(
                        "Person added successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    MessageBox.Show(
                        "Failed to add person.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message + "\n\n" + ex.StackTrace,
                    "Exception",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        /// <summary>
        /// Removes the selected image and restores the default image.
        /// </summary>
        private void llRemoveImage_LinkClicked(
            object sender,
            LinkLabelLinkClickedEventArgs e)
        {
            pBImage.Image = rbFamel.Checked
                ? Properties.Resources.male
                : Properties.Resources.famel;
        }
    }
}