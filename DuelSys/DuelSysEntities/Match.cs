using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSysEntities
{
    public class Match
    {
        public int matchID;

        private int roundID;

        private int player1ID;

        private string player1Name;

        private int player2ID;

        private string player2Name;

        private int player1Score;

        private int player2Score;

        private int winner;

        public int MatchID
        {
            get { return matchID; }
            set { matchID = value; }
        }

        public int RoundID
        {
            get { return roundID; }
        }
        public int Player1ID
        {
            get { return player1ID; }
            set { player1ID = value; }
        }
        public string Player1Name
        {
            get { return player1Name; }
            set { player1Name = value; }
        }
        public int Player2ID
        {
            get { return player2ID; }
            set { player2ID = value; }
        }
        public string Player2Name
        {
            get { return player2Name; }
            set { player2Name = value; }
        }

        public int Player1Score
        {
            get { return player1Score; }
            set { player1Score = value; }
        }

        public int Player2Score
        {
            get { return player2Score; }
            set { player2Score = value; }
        }

        public int Winner
        {
            get { return winner; }
            set { winner = value; }
        }

        public Match(int matchID, int roundID, int player1ID, string player1Name, int player2ID, string player2Name, int player1Score, int player2Score, int winner)
        {
            this.matchID = matchID;
            this.roundID = roundID;
            this.player1ID = player1ID;
            this.player1Name = player1Name;
            this.player2ID = player2ID;
            this.player2Name = player2Name;
            this.player1Score = player1Score;
            this.player2Score = player2Score;
            this.winner = winner;
        }

        public Match(int roundID, int player1ID, string player1Name, int player2ID, string player2Name, int player1Score, int player2Score, int winner)
        {
            this.roundID = roundID;
            this.player1ID = player1ID;
            this.player1Name = player1Name;
            this.player2ID = player2ID;
            this.player2Name = player2Name;
            this.player1Score = player1Score;
            this.player2Score = player2Score;
            this.winner = winner;
        }

        public void UpdateInfo(int player1Score, int player2Score, int winner)
        {

            this.player1Score = player1Score;
            this.player2Score = player2Score;
            this.winner = winner;
        }
    }
}
