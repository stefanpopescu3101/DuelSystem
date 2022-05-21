using DuelSysClassLibrary.Entities;
using DuelSysClassLibrary.Managers;
using DuelSysClassLibrary.Mediators;
using DuelSysApp.GeneralForms;
using DuelSysApp.StaffForms;
using DuelSysApp.TournamentForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DuelSysApp.StaffForms
{
    public partial class fmUpdateStaff : Form
    {
        private StaffManager staffManager;

        public int ID;
        public fmUpdateStaff(int id)
        {
            InitializeComponent();

            this.staffManager = new StaffManager(new StaffMediator());

            this.ID = id;

            Initializer();
        }

        public void Initializer()
        {
            Staff staff = staffManager.GetStaff(ID);

            tbFirstName.Text = staff.FirstName;
            tbLastName.Text = staff.LastName;
            tbCNP.Text = staff.CNP.ToString();
            tbEmail.Text = staff.Email;
            tbPhone.Text = staff.Phone.ToString();
            cmbGender.Text = staff.Gender;
            tbUsername.Text = staff.Username;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbFirstName.Text != "" && tbLastName.Text != "" && tbCNP.Text != "" && tbEmail.Text != "" && tbPhone.Text != "" && cmbGender.Text != "" && tbUsername.Text != "")
            {

                Staff staff = staffManager.GetStaff(ID);

                staffManager.UpdateInfo(staff, tbFirstName.Text, tbLastName.Text, Convert.ToInt32(tbCNP.Text), tbEmail.Text, Convert.ToInt32(tbPhone.Text), cmbGender.Text, tbUsername.Text);

                MessageBox.Show("Staff has been updated successfuly!");

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
