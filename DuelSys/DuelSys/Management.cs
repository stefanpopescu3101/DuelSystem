using DuelSys.Entities;
using DuelSys.Managers;
using DuelSys.Mediators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DuelSys
{
    public partial class fmManagement : Form
    {
        private StaffManager staffManager;

        private TournamentManager tournamentManager;

        public string staffName;
        public fmManagement(string staffName)
        {
            InitializeComponent();

            this.staffManager = new StaffManager(new StaffMediator());

            this.tournamentManager = new TournamentManager(new TournamentMediator());

            this.staffName = staffName;

            UpdateGUI();
        }

        public void UpdateGUI()
        {
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
    }
}
