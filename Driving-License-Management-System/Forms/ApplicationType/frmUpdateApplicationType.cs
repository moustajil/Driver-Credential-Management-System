using System;
using System.Data;
using System.Windows.Forms;

namespace Driving_License_Management_System.Forms.ApplicationType
{
    public partial class frmUpdateApplicationType : Form
    {
        // Event used to return the updated Application Type ID.
        public delegate void DataBackEventHandler(
            object sender,
            int applicationTypeID
        );

        public event DataBackEventHandler DataBack;

        private readonly int _applicationTypeID;

        public frmUpdateApplicationType(int applicationTypeID)
        {
            InitializeComponent();

            UiTheme.Apply(this);

            _applicationTypeID = applicationTypeID;
        }

        // Load the application type information.
        private void frmUpdateApplicationType_Load(
            object sender,
            EventArgs e
        )
        {
            LoadApplicationTypeInfo();
        }

        // Get the application type information and display it.
        private void LoadApplicationTypeInfo()
        {
            try
            {
                DataTable infoApplicationType =
                    DVLD_Business_Layer.ApplicationType.BNApplicationType
                        .FindApplicatonTypeByID(_applicationTypeID);

                if (infoApplicationType == null ||
                    infoApplicationType.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "Application type was not found.",
                        "Not Found",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    Close();
                    return;
                }

                DataRow row = infoApplicationType.Rows[0];

                lbID.Text =
                    row["ApplicationTypeID"].ToString();

                tbTitle.Text =
                    row["ApplicationTypeTitle"].ToString();

                tbFees.Text =
                    row["ApplicationFees"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"An error occurred while loading the application type:\n\n{ex.Message}",
                    "Loading Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                Close();
            }
        }

        // Validate and update the application type.
        private void button1_Click(object sender, EventArgs e)
        {
            string applicationTitle = tbTitle.Text.Trim();

            if (string.IsNullOrWhiteSpace(applicationTitle))
            {
                MessageBox.Show(
                    "Please enter the application type title.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                tbTitle.Focus();
                return;
            }

            if (!decimal.TryParse(
                    tbFees.Text.Trim(),
                    out decimal applicationFees))
            {
                MessageBox.Show(
                    "Please enter valid application fees.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                tbFees.Focus();
                tbFees.SelectAll();
                return;
            }

            if (applicationFees < 0)
            {
                MessageBox.Show(
                    "Application fees cannot be negative.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                tbFees.Focus();
                tbFees.SelectAll();
                return;
            }

            try
            {
                bool isUpdated =
                    DVLD_Business_Layer.ApplicationType
                        .BNApplicationType
                        .UpdateApplicationType(
                            _applicationTypeID,
                            applicationTitle,
                            decimal.Parse(tbFees.Text)
                        );

                if (!isUpdated)
                {
                    MessageBox.Show(
                        "Failed to update the application type.",
                        "Update Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    return;
                }

                MessageBox.Show(
                    "Application type updated successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Return the updated ID to the parent form.
                DataBack?.Invoke(this, _applicationTypeID);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"An error occurred while updating the application type:\n\n{ex.Message}",
                    "Update Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}