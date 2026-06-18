using System;
using System.IO;
using System.Windows.Forms;

namespace Driving_License_Management_System.Forms.Users
{
    public partial class frmLogin : Form
    {
        private string FilePath = "C:\\Users\\Microsoft\\source\\repos\\Driving-License-Management-System\\Driving-License-Management-System\\Properties\\RememberMe.txt";

        public frmLogin()
        {
            InitializeComponent();
            UiTheme.Apply(this);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (File.Exists(FilePath))
            {
                string[] data = File.ReadAllLines(FilePath);

                if (data.Length >= 2)
                {
                    tbusername.Text = data[0];
                    tbpassword.Text = data[1];
                    cbActive.Checked = true;
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbusername.Text.Trim();
            string password = tbpassword.Text.Trim();

            bool checkUser =
                DVLD_Business_Layer.Users.BNUser.checkIfUserExists(username, password);

            if (checkUser)
            {
                /*if (cbActive.Checked)
                {
                    File.WriteAllLines(FilePath, new string[]
                    {
                        username,
                        password
                    });
                }
                else
                {
                    if (File.Exists(FilePath))
                        File.Delete(FilePath);
                }*/

                Main main = new Main();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    "Invalid Username Or Password",
                    "Login Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
