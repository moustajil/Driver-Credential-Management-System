using System;
using System.Windows.Forms;
using DVLD_Business_Layer.DVLD_Business_Layer;

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

            comboBox1.Items.Add("NationalID");
            comboBox1.Items.Add("FirstName");
            comboBox1.Items.Add("SecondName");
            comboBox1.Items.Add("ThirdName");
            comboBox1.Items.Add("LastName");
            comboBox1.Items.Add("Phone");
            comboBox1.Items.Add("Email");

            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // optional: reset search box or prepare filter
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmAddEdite frm = new frmAddEdite(0);

            // FIX: make sure event exists in frmAddEdite
            frm.DataBack += Frm_DataBack;

            frm.ShowDialog();
        }

        private void editePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int personID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["PersonID"].Value);

            frmAddEdite frm = new frmAddEdite(personID);

            frm.DataBack += Frm_DataBack;
            frm.ShowDialog();
        }

        private void Frm_DataBack(object sender, int personID)
        {
            // IMPORTANT: reload data from DB (not Refresh)
            LoadPeople();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // optional delete/edit logic here
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            int personID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["PersonID"].Value);
            bool deletPerson = DVLD_Business_Layer.DVLD_Business_Layer.BNPeople.DeletePerson(personID);

            if (deletPerson)
            {
                LoadPeople();
            }
        }
    }
}