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

            lbRound.Text = lbRound.Text + " " + "#" + RoundID.ToString();

            Initializer();
        }


        private void Initializer()
        {
            matches = tournamentManager.GetMatchesForRound(RoundID);
            List<int> matchesIDS = new List<int>();
            foreach(Match match in matches)
            {
                if(match.Player1Score==0 && match.Player2Score==0)
                {
                    matchesIDS.Add(match.MatchID);
                }
                
            }

            cmbMatches.DataSource = matchesIDS;
            //cmbMatches.DataSource = matchesIDS.ToString();
        }
        private void btnMatch_Click(object sender, EventArgs e)
        {
            Match match = matchManager.GetMatch(Convert.ToInt32(cmbMatches.SelectedItem));
            int winner;
            if(Convert.ToInt32(tbPlayer1.Text)>Convert.ToInt32(tbPlayer2.Text))
            {
                winner = match.Player1ID;
            }
            else
            {
                winner = match.Player2ID;
            }
            matchManager.UpdateInfo(match, Convert.ToInt32(tbPlayer1.Text), Convert.ToInt32(tbPlayer2.Text), winner);
            Initializer();
        }

        private void cmbMatches_SelectedIndexChanged(object sender, EventArgs e)
        {
            Match match = matchManager.GetMatch(Convert.ToInt32(cmbMatches.SelectedItem));
            lbPlayer1.Text = match.Player1Name;
            lbPlayer2.Text = match.Player2Name;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbPlayer2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPlayer1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbPlayer1_Click(object sender, EventArgs e)
        {

        }

        private void lbPlayer2_Click(object sender, EventArgs e)
        {

        }

        private void lbRound_Click(object sender, EventArgs e)
        {

        }
    }
}
