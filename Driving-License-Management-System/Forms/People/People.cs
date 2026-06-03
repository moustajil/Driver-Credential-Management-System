using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Driving_License_Management_System.Forms.People
{
    public partial class People : Form
    {
        public People()
        {
            InitializeComponent();
        }

        private void People_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DVLD_Business_Layer.DVLD_Business_Layer.BNPeople.GetAllPeople();

            comboBox1.Items.Add("NationalID");
            comboBox1.Items.Add("FirstName");
            comboBox1.Items.Add("SecondName");

            comboBox1.Items.Add("ThirdName");
            comboBox1.Items.Add("LastName");
            comboBox1.Items.Add("Phone");
            comboBox1.Items.Add("Email");

            comboBox1.SelectedIndex = 0;

            recordes.Text = DVLD_Business_Layer.DVLD_Business_Layer.BNPeople.NumbersOfPeople().ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = comboBox1.SelectedItem.ToString();

           
        }
    }
}
