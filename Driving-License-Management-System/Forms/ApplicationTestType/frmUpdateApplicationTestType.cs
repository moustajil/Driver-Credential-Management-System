using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Driving_License_Management_System.Forms.ApplicationTestType
{
    public partial class frmUpdateApplicationTestType : Form
    {
        private int _testTypeID;
        public frmUpdateApplicationTestType(int testTypeID)
        {
            InitializeComponent();
            _testTypeID = testTypeID;
        }

        private void frmUpdateApplicationTestType_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt =
                    DVLD_Business_Layer.ApplicationTestType.BNApplicationTestType
                        .GetApplicationTestTypeByID(_testTypeID);

                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "Test type was not found.",
                        "Not Found",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    this.Close();
                    return;
                }

                DataRow row = dt.Rows[0];

                lbTestTypeID.Text = row["TestTypeID"].ToString();
                tbTitle.Text = row["TestTypeTitle"].ToString();
                rtbDescription.Text = row["TestTypeDescription"].ToString();
                tbFees.Text = row["TestTypeFees"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"An error occurred while loading the test type:\n\n{ex.Message}",
                    "Loading Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                this.Close();
            }
        }
    }
}
