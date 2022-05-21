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
    public partial class fmUpdateTournament : Form
    {
        private TournamentManager tournamentManager;

        public int ID;
        public fmUpdateTournament(int id)
        {
            InitializeComponent();

            this.tournamentManager = new TournamentManager(new TournamentMediator());

            this.ID = id;

            Initializer();
        }

        public void Initializer()
        {
            Tournament tournament = tournamentManager.GetTournament(ID);

            cmbSportType.Text = tournament.SportType;
            tbDescription.Text = tournament.Description;
            dtpStartDate.Text = tournament.StartDate;
            dtpEndDate.Text = tournament.EndDate;
            tbMinPlayers.Text = tournament.MinPlayers.ToString();
            tbMaxPlayers.Text = tournament.MaxPlayers.ToString();
            cmbLocation.Text = tournament.Location;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cmbSportType.Text != "" && tbDescription.Text != "" && dtpStartDate.Text != "" && dtpEndDate.Text != "" && tbMinPlayers.Text != "" && tbMaxPlayers.Text != "" && cmbLocation.Text != "")
            {
                DateTime startDate = Convert.ToDateTime(dtpStartDate.Text);
                DateTime endDate = Convert.ToDateTime(dtpEndDate.Text);

                Tournament tournament = tournamentManager.GetTournament(ID);

                tournamentManager.UpdateInfo(tournament, cmbSportType.Text, tbDescription.Text, startDate.ToString("d"), endDate.ToString("d"), Convert.ToInt32(tbMinPlayers.Text), Convert.ToInt32(tbMaxPlayers.Text), cmbLocation.Text);

                MessageBox.Show("Tournament has been updated successfuly!");

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
