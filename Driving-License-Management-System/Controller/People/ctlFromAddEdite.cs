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

        // Mode: add or update
        private string status = "add";

        // Current Person ID (used in update)
        private int personId = 0;

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
        /// Text changed event (unused).
        /// </summary>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Validate national number uniqueness.
        /// </summary>
        private void nNumber_Leave(object sender, EventArgs e)
        {
            string nationalityNumber = nNumber.Text.Trim();

            bool exists =
                DVLD_Business_Layer.DVLD_Business_Layer.BNPeople
                .checkNationaNumber(nationalityNumber);

            if (exists)
            {
                errorProvider1.SetError(nNumber, "National Number already exists.");
                nNumber.Focus();
            }
            else
            {
                errorProvider1.SetError(nNumber, "");
            }
        }

        /// <summary>
        /// Male selected.
        /// </summary>
        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            pBImage.Image = Properties.Resources.famel;
        }

        /// <summary>
        /// Female selected.
        /// </summary>
        private void rbFamel_CheckedChanged(object sender, EventArgs e)
        {
            pBImage.Image = Properties.Resources.male;
        }

        /// <summary>
        /// Email validation.
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
                    MessageBoxIcon.Error);

                email.Focus();
            }
        }

        /// <summary>
        /// Load event.
        /// </summary>
        private void ctlFromAddEdite_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Select image.
        /// </summary>
        private void lkImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pBImage.Image = Image.FromFile(ofd.FileName);
                pBImage.ImageLocation = ofd.FileName;
                llRemoveImage.Visible = true;
            }
        }

        /// <summary>
        /// Build BNPeople object from form data.
        /// </summary>
        private BNPeople BuildPerson()
        {
            return new BNPeople(
                nNumber.Text.Trim(),
                fName.Text.Trim(),
                sName.Text.Trim(),
                tName.Text.Trim(),
                foName.Text.Trim(),
                dtPiker.Value.Date,
                rbFamel.Checked ? 1 : 0,
                rtbAddress.Text.Trim(),
                pNumber.Text.Trim(),
                email.Text.Trim(),
                cbCountry.SelectedIndex >= 0 ? cbCountry.SelectedIndex + 1 : 0,
                string.IsNullOrWhiteSpace(pBImage.ImageLocation) ? null : pBImage.ImageLocation
            );
        }

        /// <summary>
        /// Add new person.
        /// </summary>
        private void AddPerson()
        {
            try
            {
                BNPeople people = BuildPerson();

                personId = people.AddNewPerson();

                if (personId > 0)
                {
                    PersonIdCreated(personId);

                    status = "update";

                    MessageBox.Show(
                        "Person added successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        "Failed to add person.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception");
            }
        }

        /// <summary>
        /// Update existing person.
        /// </summary>
        private void UpdatePerson(int id)
        {
            try
            {
                BNPeople people = BuildPerson();

                people.PersonID = id;

                bool result = people.UpdatePerson();

                if (result)
                {
                    MessageBox.Show(
                        "Person updated successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        "Failed to update person.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception");
            }
        }

        /// <summary>
        /// Save button click.
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            savePerson();
        }

        /// <summary>
        /// Decide add or update.
        /// </summary>
        private void savePerson()
        {
            if (status == "add")
            {
                AddPerson();
            }
            else
            {
                UpdatePerson(personId);
            }
        }

        /// <summary>
        /// Remove image.
        /// </summary>
        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pBImage.Image = rbFamel.Checked
                ? Properties.Resources.male
                : Properties.Resources.famel;

            pBImage.ImageLocation = null;
        }
    }
}