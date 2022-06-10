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
    public partial class fmScoreDoubleRound : Form
    {
        private List<DoubleGameMatch> matches;

        private TournamentManager tournamentManager;

        private DoubleGameMatchManager matchManager;
        int RoundID { get; set; }
        public fmScoreDoubleRound(int roundID)
        {
            InitializeComponent();

            RoundID = roundID;

            tournamentManager = new TournamentManager(new TournamentMediator());
            matchManager = new DoubleGameMatchManager(new DoubleGameMatchMediator());

            matches = new List<DoubleGameMatch>();

            lbRound.Text = lbRound.Text + " " + "#" + RoundID.ToString();

            Initializer();
        }

        private void Initializer()
        {
            matches = tournamentManager.GetDoubleGameMatchesForRound(RoundID);
            List<int> matchesIDS = new List<int>();
            foreach (DoubleGameMatch match in matches)
            {
                if (match.Player1Match1Score == 0 && match.Player2Match1Score == 0 && match.Player1Match2Score==0 && match.Player2Match2Score==0)
                {
                    matchesIDS.Add(match.MatchID);
                }

            }

            cmbMatches.DataSource = matchesIDS;
            //cmbMatches.DataSource = matchesIDS.ToString();
        }
        private void btnMatch_Click(object sender, EventArgs e)
        {
            DoubleGameMatch match = matchManager.GetDoubleGameMatch(Convert.ToInt32(cmbMatches.SelectedItem));
            int winner;
            if (Convert.ToInt32(tbPlayer1Match1.Text) + Convert.ToInt32(tbPlayer1Match2.Text) > Convert.ToInt32(tbPlayer2Match1.Text) + Convert.ToInt32(tbPlayer2Match2.Text))
            {
                winner = match.Player1ID;
            }
            else
            {
                winner = match.Player2ID;
            }
            matchManager.UpdateInfo(match, Convert.ToInt32(tbPlayer1Match1.Text), Convert.ToInt32(tbPlayer2Match1.Text), Convert.ToInt32(tbPlayer1Match2.Text), Convert.ToInt32(tbPlayer2Match2.Text), winner);
            Initializer();
        }

        private void cmbMatches_SelectedIndexChanged(object sender, EventArgs e)
        {
            DoubleGameMatch match = matchManager.GetDoubleGameMatch(Convert.ToInt32(cmbMatches.SelectedItem));
            lbPlayer1Match1.Text = match.Player1Name;
            lbPlayer2Match1.Text = match.Player2Name;
            lbPlayer1Match2.Text = match.Player1Name;
            lbPlayer2Match2.Text = match.Player2Name;
        }
    }
}
