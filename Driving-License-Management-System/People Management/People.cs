using DVLD_Business_Layer;

namespace Driving_License_Management_System
{
    public partial class People : Form
    {
        public People()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DVLD_Business_Layer.DVLD_Business_Layer.BNPeople.GetAllPeople();

        }
    }
}
