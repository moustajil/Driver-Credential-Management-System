
using DVLD_Presentation_Layer.PeopleManagment;

namespace DVLD_Presentation_Layer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            People people = new People();
            people.Show();
        }
    }
}
