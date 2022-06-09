using DuelSysEntities;
using DuelSysManagers;
using DuelSysMediators;
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

namespace DuelSysApp.GeneralForms
{
    public partial class fmManagement : Form
    {
        private StaffManager staffManager;

        private TournamentManager tournamentManager;

        public string staffName;

        public bool admin;
        public fmManagement(string staffName, bool admin)
        {
            InitializeComponent();

            this.staffManager = new StaffManager(new StaffMediator());

            this.tournamentManager = new TournamentManager(new TournamentMediator());

            this.staffName = staffName;

            this.admin = admin;

            UpdateGUI();
        }

        public void UpdateGUI()
        {
            if (admin == false)
            {
                btnAddStaff.Enabled = false;
                btnUpdateStaff.Enabled = false;
                btnDeleteStaff.Enabled = false;
            }
            else
            {
                btnAddStaff.Enabled = true;
                btnUpdateStaff.Enabled = true;
                btnDeleteStaff.Enabled = true;
            }

            lbWelcome.Text = staffName + "!";

            dtgvStaff.DataSource = staffManager.GetAllStaffs();

            dtgvTournament.DataSource = tournamentManager.GetAllTournaments();

        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            fmAddStaff a = new fmAddStaff();
            a.Show();
        }

        private void btnUpdateStaff_Click(object sender, EventArgs e)
        {
            if (dtgvStaff.SelectedRows.Count > -1)
            {
                int id = Convert.ToInt32(dtgvStaff.SelectedRows[0].Cells[0].Value);

                fmUpdateStaff dc = new fmUpdateStaff(id);
                dc.Show();
            }
            else
            {
                MessageBox.Show("Select a staff first!");
            }
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            if(dtgvStaff.SelectedCells.Count>-1)
            {
                int id = Convert.ToInt32(dtgvStaff.SelectedRows[0].Cells[0].Value);

                Staff staff = this.staffManager.GetStaff(id);
                staffManager.RemoveStaff(staff);

                MessageBox.Show("Selected staff has been removed!");

                UpdateGUI();
            }
            else
            {
                MessageBox.Show("Select a staff first!");
            }
        }

        private void btnAddTournament_Click(object sender, EventArgs e)
        {
            fmAddTournament a = new fmAddTournament();
            a.Show();
        }

        private void btnUpdateTournament_Click(object sender, EventArgs e)
        {
            if (dtgvTournament.SelectedRows.Count > -1)
            {
                int id = Convert.ToInt32(dtgvTournament.SelectedRows[0].Cells[0].Value);

                fmUpdateTournament dc = new fmUpdateTournament(id);
                dc.Show();
            }
            else
            {
                MessageBox.Show("Select a tournament first!");
            }
        }

        private void btnDeleteTournament_Click(object sender, EventArgs e)
        {
            if (dtgvTournament.SelectedCells.Count > -1)
            {
                int id = Convert.ToInt32(dtgvTournament.SelectedRows[0].Cells[0].Value);

                Tournament tournament = this.tournamentManager.GetTournament(id);
                tournamentManager.RemoveTournament(tournament);

                MessageBox.Show("Selected tournament has been removed!");

                UpdateGUI();
            }
            else
            {
                MessageBox.Show("Select a tournament first!");
            }
        }

        private void btnLogOutStaff_Click(object sender, EventArgs e)
        {
            this.Close();
            fmLogIn a = new fmLogIn();
            a.Show();
        }

        private void btnLogOutTournament_Click(object sender, EventArgs e)
        {
            this.Close();
            fmLogIn a = new fmLogIn();
            a.Show();
        }

        

        private void btnScoreTournament_Click(object sender, EventArgs e)
        {

            if (dtgvTournament.SelectedRows.Count > -1)
            {
                int id = Convert.ToInt32(dtgvTournament.SelectedRows[0].Cells[0].Value);

                fmScoreTournament a = new fmScoreTournament(tournamentManager.GetTournament(id));
                a.Show();
            }
            else
            {
                MessageBox.Show("Select a tournament first!");
            }
            
        }

        private void btnGenerateTournament_Click(object sender, EventArgs e)
        {
            if(tournamentManager.GetTournament(Convert.ToInt32(dtgvTournament.SelectedRows[0].Cells[0].Value)).Status=="LOCKED")
            {
                tournamentManager.GenerateTournamentStructure(Convert.ToInt32(dtgvTournament.SelectedRows[0].Cells[0].Value));
            }
            else
            {
                MessageBox.Show("Tournament is not locked yet! Lock the tournament before proceeding.");
            }
            
        }
    }
}
