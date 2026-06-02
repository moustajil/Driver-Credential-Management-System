using System;
using System.Windows.Forms;
using DVLD_Business_Layer.Users;

namespace DVLD_Presentation_Layer.PeopleManagment
{
    public partial class People : Form
    {
        BnPeopleManagement peopleBL = new BnPeopleManagement();

        public People()
        {
            InitializeComponent();
        }

        private void People_Load(object sender, EventArgs e)
        {
            LoadPeopleData();
        }

        private void LoadPeopleData()
        {
            try
            {
                dataGridView1.DataSource = peopleBL.GetAllPeople();

                // UI improvements
                /*dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.ReadOnly = true;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.AllowUserToAddRows = false;*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading people: " + ex.Message);
            }
        }
    }
}