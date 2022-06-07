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
    public partial class fmScoreTournament : Form
    {
        private TournamentManager tournamentManager;

        private RoundManager roundManager;

        private MatchManager matchManager;

        Label label;
        private int TournamentID { get; set; }
        public fmScoreTournament(Tournament tournament)
        {
            InitializeComponent();

            TournamentID = tournament.ID;
            tournamentManager = new TournamentManager(new TournamentMediator());
            roundManager = new RoundManager(new RoundMediator());
            matchManager = new MatchManager(new MatchMediator());
            RefreshCalender();
        }


        private void ShowInLabel()
        {
            lbTournament.Text = lbTournament.Text+ " "+"#" +TournamentID.ToString();
        }
        private void RefreshCalender()
        {
            pCalender.Controls.Clear();

            List<Round> rounds = new List<Round>();
            rounds = roundManager.GetRoundsForTournament(TournamentID);
            
            for (int i = 0; i < rounds.Count; i++)
            {
                //Panel panelRound = new Panel { Dock = DockStyle.Bottom, Height = 100 };

                Panel p = new Panel { Dock = DockStyle.Right, Width = 180 , Height = 100};

                
                Button button = new Button { Dock = DockStyle.Top };
                p.Controls.Add(label = new Label { Text = (i).ToString(), Dock = DockStyle.Top });

                button.Tag = Convert.ToInt32(rounds[i].RoundID);

                
                p.Controls.Add(button);

                //weekPanel.Controls.Add(p);
                button.Click += Button_Click;

                button.Text = "Round "+ i.ToString();

                button.Height = 40;


                pCalender.Controls.Add(p);
            }
            ShowInLabel();

        }


        private void Button_Click(object sender, EventArgs e)
        {
            int roundID = (int)((Button)sender).Tag;


            fmScoreRound a = new fmScoreRound(roundID);
            a.Show();
            
        }
    }
}
