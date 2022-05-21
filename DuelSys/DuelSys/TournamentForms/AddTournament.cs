using DuelSysClassLibrary.Entities;
using DuelSysClassLibrary.Managers;
using DuelSysClassLibrary.Mediators;
using DuelSys.GeneralForms;
using DuelSys.StaffForms;
using DuelSys.TournamentForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DuelSys.TournamentForms
{
    public partial class fmAddTournament : Form
    {
        private TournamentManager tournamentManager;
        public fmAddTournament()
        {
            InitializeComponent();

            this.tournamentManager = new TournamentManager(new TournamentMediator());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbSportType.Text != "" && tbDescription.Text != "" && dtpStartDate.Text != "" && dtpEndDate.Text != "" && tbMinPlayers.Text != "" && tbMaxPlayers.Text != "" && cmbLocation.Text != "" && cmbTournamentType.Text != "")
            {
                DateTime startDate=Convert.ToDateTime(dtpStartDate.Text);
                DateTime endDate=Convert.ToDateTime(dtpEndDate.Text);

                Tournament tournament = new Tournament(cmbSportType.Text, tbDescription.Text, startDate.ToString("d"), endDate.ToString("d"), Convert.ToInt32(tbMinPlayers.Text), Convert.ToInt32(tbMaxPlayers.Text), cmbLocation.Text, cmbTournamentType.Text);

                tournamentManager.AddTournament(tournament);

                MessageBox.Show("New tournament has been addded successfuly!");

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
