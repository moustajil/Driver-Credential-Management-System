using System;
using System.Windows.Forms;
using BNPeople = DVLD_Business_Layer.DVLD_Business_Layer.BNPeople;

namespace Driving_License_Management_System.Forms.People
{
    public partial class People : Form
    {
        public People()
        {
            InitializeComponent();
        }

        private void LoadPeople()
        {
            dataGridView1.DataSource = BNPeople.GetAllPeople();
            recordes.Text = BNPeople.NumbersOfPeople().ToString();
        }

        private void People_Load(object sender, EventArgs e)
        {
            dataGridView1.ContextMenuStrip = contextMenuStrip1;

            LoadPeople();

            cbFilter.Items.Add("none");
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

        // ---------------- FILTER CHANGE ----------------

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbfilter.Clear();

            if (cbFilter.SelectedItem == null)
                return;

            string selected = cbFilter.SelectedItem.ToString();

            if (selected == "none")
            {
                tbfilter.Visible = false;
                LoadPeople();
                return;
            }

            tbfilter.Visible = true;
            tbfilter.Focus();
        }

        // ---------------- SEARCH ENGINE ----------------

        private void ApplySearch(string column, string value)
        {
            string dbColumn = column switch
            {
                "Person ID" => "PersonID",
                "NationalID" => "NationalNo",
                "FirstName" => "FirstName",
                "SecondName" => "SecondName",
                "ThirdName" => "ThirdName",
                "LastName" => "LastName",
                "Gendor" => "Gendor",
                "Phone" => "Phone",
                "Email" => "Email",
                _ => null
            };

            if (string.IsNullOrEmpty(dbColumn))
                return;

            MessageBox.Show(dbColumn + "==" + value, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            dataGridView1.DataSource = BNPeople.FindByCol(dbColumn, value);
        }

        // ---------------- ADD ----------------

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmAddEdite frm = new frmAddEdite(0);
            frm.DataBack += Frm_DataBack;
            frm.ShowDialog();
        }

        // ---------------- EDIT ----------------

        private void editePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;

            if (!int.TryParse(dataGridView1.CurrentRow.Cells["PersonID"].Value?.ToString(), out int personID))
                return;

            frmAddEdite frm = new frmAddEdite(personID);
            frm.DataBack += Frm_DataBack;
            frm.ShowDialog();
        }

        private void Frm_DataBack(object sender, int personID)
        {
            LoadPeople();
        }

        // ---------------- DELETE ----------------

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select a person first.");
                return;
            }

            if (!int.TryParse(dataGridView1.CurrentRow.Cells["PersonID"].Value?.ToString(), out int personID))
            {
                MessageBox.Show("Invalid Person ID.");
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this person?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            if (BNPeople.DeletePerson(personID))
            {
                MessageBox.Show("Deleted successfully.");
                LoadPeople();
            }
            else
            {
                MessageBox.Show("Delete failed.");
            }
        }

        // ---------------- LIVE SEARCH ----------------

        private void tbfilter_TextChanged_1(object sender, EventArgs e)
        {
            if (!tbfilter.Visible) return;
            if (cbFilter.SelectedItem == null) return;

            string column = cbFilter.SelectedItem.ToString();


            if (column == "none")
                return;

            string value = tbfilter.Text.Trim();

            if (string.IsNullOrWhiteSpace(value))
            {
                LoadPeople();
                return;
            }



            ApplySearch(column, value);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}