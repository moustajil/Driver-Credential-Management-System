using System;
using System.Data;
using System.Windows.Forms;

namespace Driving_License_Management_System.Forms.ApplicationTestType
{
    public partial class frmManageTestApplicationtype : Form
    {
        public frmManageTestApplicationtype()
        {
            InitializeComponent();
            UiTheme.Apply(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmManageTestApplicationtype_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // Load test types into the DataGridView.
        private void LoadData()
        {
            try
            {
                DataTable testTypes =
                    DVLD_Business_Layer.ApplicationTestType
                    .BNApplicationTestType
                    .GetAllApplicationTestType();

                dataGridView1.DataSource = testTypes;

                lbRecorde.Text = testTypes.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"An error occurred while loading test types:\n\n{ex.Message}",
                    "Loading Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                dataGridView1.DataSource = null;
                lbRecorde.Text = "0";
            }
        }

        private void editeTypeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show(
                    "Please select a test type first.",
                    "No Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            int testTypeID = Convert.ToInt32(
                dataGridView1.CurrentRow.Cells["TestTypeID"].Value
            );

            frmUpdateApplicationTestType updateForm =
                new frmUpdateApplicationTestType(testTypeID);

            updateForm.ShowDialog();

            // Refresh the DataGridView after updating.
            LoadData();
        }
    }
}
