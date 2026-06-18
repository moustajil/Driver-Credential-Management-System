using Driving_License_Management_System.Forms.ApplicationType;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Driving_License_Management_System.Forms.Application
{
    public partial class frmManagetypeApplication : Form
    {
        public frmManagetypeApplication()
        {
            InitializeComponent();
            UiTheme.Apply(this);

        }


        private void UpdateDataOfApplication_DataBack(object sender, int applicationTypeID)
        {
            LoadData();
        }
        private void AddUserForm_DataBack(object sender, int userID)
        {
            LoadData();
        }

        private void frmManagetypeApplication_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {

                dataGridView1.DataSource = DVLD_Business_Layer.ApplicationType.BNApplicationType.GetAllApplicationTypes();

                lbRecorde.Text = DVLD_Business_Layer.ApplicationType.BNApplicationType.GetAllApplicationTypes().Rows.Count.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"An error occurred while loading application types:\n\n{ex.Message}",
                    "Loading Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                lbRecorde.Text = "0";
            }
        }

        private void editeApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show(
                    "Please select an application type first.",
                    "No Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            int applicationTypeID = Convert.ToInt32(
                dataGridView1.CurrentRow.Cells["ApplicationTypeID"].Value
            );

            using (frmUpdateApplicationType updateApplicationType =
                   new frmUpdateApplicationType(applicationTypeID))
            {

                updateApplicationType.DataBack += UpdateDataOfApplication_DataBack;

                updateApplicationType.ShowDialog();
            }

            // Refresh the DataGridView after updating.
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
