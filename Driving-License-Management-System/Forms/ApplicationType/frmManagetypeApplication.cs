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
    }
}
