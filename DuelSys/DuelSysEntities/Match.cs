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

        public Match(int matchID, int roundID, int player1ID, string player1Name, int player2ID, string player2Name)
        {
            this.matchID = matchID;
            this.roundID = roundID;
            this.player1ID = player1ID;
            this.player1Name = player1Name;
            this.player2ID = player2ID;
            this.player2Name = player2Name;
        }

        public Match(int roundID, int player1ID, string player1Name, int player2ID, string player2Name)
        {
            this.roundID = roundID;
            this.player1ID = player1ID;
            this.player1Name = player1Name;
            this.player2ID = player2ID;
            this.player2Name = player2Name;
        }
    }
}
