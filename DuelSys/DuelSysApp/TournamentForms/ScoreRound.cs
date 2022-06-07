using DuelSysEntities;
using DuelSysManagers;
using DuelSysMediators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DuelSysApp.TournamentForms
{
    public partial class fmScoreRound : Form
    {
        private List<Match> matches;

        private TournamentManager tournamentManager;

        private MatchManager matchManager;
        int RoundID { get; set; }
        public fmScoreRound(int roundID)
        {
            InitializeComponent();

            RoundID = roundID;

            tournamentManager = new TournamentManager(new TournamentMediator());
            matchManager = new MatchManager(new MatchMediator());

            matches = new List<Match>();

            Initializer();
        }


        private void Initializer()
        {
            matches = tournamentManager.GetMatchesForRound(RoundID);
            List<int> matchesIDS = new List<int>();
            foreach(Match match in matches)
            {
                matchesIDS.Add(match.MatchID);
            }

            cmbMatches.DataSource = matchesIDS;
            //cmbMatches.DataSource = matchesIDS.ToString();
        }
        private void btnMatch_Click(object sender, EventArgs e)
        {

        }

        private void cmbMatches_SelectedIndexChanged(object sender, EventArgs e)
        {
            Match match = matchManager.GetMatch(Convert.ToInt32(cmbMatches.SelectedItem));
            lbPlayer1.Text = match.Player1Name;
            lbPlayer2.Text = match.Player2Name;
        }
    }
}
