using Driving_License_Management_System.Forms.People;
using DVLD_Business_Layer.DVLD_Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Driving_License_Management_System.Controller.People
{
    public partial class ctlFromAddEdite : UserControl
    {
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void nNumber_Leave(object sender, EventArgs e)
        {

            string nationalityNumber = nNumber.Text.Trim();

            // Check if National Number exists
            bool checkNationaNumber = DVLD_Business_Layer.DVLD_Business_Layer.BNPeople.checkNationaNumber(nationalityNumber);

            if (checkNationaNumber)
            {
                errorProvider1.SetError(nNumber, "National Number already exists.");
                nNumber.Focus();
            }
            else
            {
                errorProvider1.SetError(nNumber, "");
            }

        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            pBImage.Image = Properties.Resources.famel;
        }

        private void rbFamel_CheckedChanged(object sender, EventArgs e)
        {
            pBImage.Image = Properties.Resources.male;

        }

        private void email_Leave(object sender, EventArgs e)
        {
            string emailT = email.Text;

            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!Regex.IsMatch(emailT, pattern))
            {
                MessageBox.Show("Invalid email format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                email.Focus();
            }
        }

        private void ctlFromAddEdite_Load(object sender, EventArgs e)
        {

        }

        private void lkImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pBImage.Image = Image.FromFile(ofd.FileName);
                llRemoveImage.Visible = true;
            }
        }

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

                // SQL SAFE RANGE CHECK
                DateTime sqlMin = new DateTime(1753, 1, 1);
                DateTime sqlMax = new DateTime(9999, 12, 31);

                if (birthDate < sqlMin || birthDate > sqlMax)
                {
                    MessageBox.Show("Birth date is out of valid range.");
                    return;
                }

                // AGE VALIDATION (18+)
                int age = DateTime.Today.Year - birthDate.Year;
                if (birthDate > DateTime.Today.AddYears(-age)) age--;

                if (age < 18)
                {
                    MessageBox.Show("Person must be at least 18 years old.");
                    return;
                }

                int country = cbCountry.SelectedIndex != null
                    ? Convert.ToInt32(cbCountry.SelectedIndex) + 1
                    : 0;

                string imagePath = string.IsNullOrWhiteSpace(pBImage.ImageLocation)
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
                    "Debug");

                // CORRECT ORDER: nationalID, firstName, secondName, thirdName, lastName, dateOfBirth, gender, address, phone, email, nationalityCountryID, imagePath
                BNPeople people = new BNPeople(
                    nationalityNumber,      // 1. nationalID
                    firstName,              // 2. firstName
                    secondName,             // 3. secondName
                    thirdName,              // 4. thirdName
                    lastName,               // 5. lastName
                    birthDate,              // 6. dateOfBirth
                    gender,                 // 7. gender
                    address,                // 8. address ← CORRIGÉ
                    phoneNumber,            // 9. phone ← CORRIGÉ
                    emailText,              // 10. email ← CORRIGÉ
                    country,                // 11. nationalityCountryID ← CORRIGÉ
                    imagePath               // 12. imagePath
                );

                if (people.AddNewPerson())
                {
                    MessageBox.Show("Person added successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to add person.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace,
                    "Exception",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pBImage.Image = rbFamel.Checked ? Properties.Resources.male : Properties.Resources.famel;
        }
    }
}