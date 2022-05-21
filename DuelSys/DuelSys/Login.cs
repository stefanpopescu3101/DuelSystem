using DuelSysClassLibrary.Entities;
using DuelSysClassLibrary.Managers;
using DuelSysClassLibrary.Mediators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuelSys
{
    public partial class fmLogIn : Form
    {
        private StaffManager staffManager;
        public fmLogIn()
        {
            InitializeComponent();

            this.staffManager = new StaffManager(new StaffMediator());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text != "" && tbPassword.Text != "")
            {
                if (staffManager.CheckCredentials(tbUsername.Text, Hasher.ComputeSha256Hash(tbPassword.Text)) != null)
                {

                    Staff staff = staffManager.CheckCredentials(tbUsername.Text, Hasher.ComputeSha256Hash(tbPassword.Text));

                    if(staff.Admin==false)
                    {
                        fmManagement gf = new fmManagement(staff.FirstName, false);
                        this.Hide();
                        gf.Show();
                    }
                    else
                    {
                        fmManagement gf = new fmManagement(staff.FirstName, true);
                        this.Hide();
                        gf.Show();
                    }
                    

                }
                else
                {
                    MessageBox.Show("These credentials do not exist");
                }
            }
            else
            {
                MessageBox.Show("Please fill in asll the required fields!");
            }
        }
    }
}
