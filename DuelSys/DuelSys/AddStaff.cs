using DuelSys.Entities;
using DuelSys.Managers;
using DuelSys.Mediators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DuelSys
{
    public partial class fmAddStaff : Form
    {
        private StaffManager staffManager;
        public fmAddStaff()
        {
            InitializeComponent();
            this.staffManager = new StaffManager(new StaffMediator());

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbFirstName.Text != "" && tbLastName.Text != "" && tbCNP.Text != "" && tbEmail.Text != "" && tbPhone.Text != "" && cmbGender.Text != "" && cmbAdmin.Text!="" && tbUsername.Text != "" && tbPassword.Text != "")
            {
                bool admin;

                if(cmbAdmin.Text=="YES")
                {
                    admin = true;
                }
                else
                {
                    admin = false;
                }

                Staff staff = new Staff(tbFirstName.Text, tbLastName.Text, Convert.ToInt32(tbCNP.Text), tbEmail.Text, Convert.ToInt32(tbPhone.Text), cmbGender.Text, admin, tbUsername.Text, Hasher.ComputeSha256Hash(tbPassword.Text));

                staffManager.AddStaff(staff);

                MessageBox.Show("New staff has been addded successfuly!");

                var generalForm = Application.OpenForms.OfType<fmManagement>().Single();
                generalForm.UpdateGUI();

                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill in all the fields!");
            }
        }
    }
}
