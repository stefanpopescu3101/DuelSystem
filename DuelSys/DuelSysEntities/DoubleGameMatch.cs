using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSysEntities
{
    public class DoubleGameMatch
    {
        public int matchID;
        private int roundID;
        private int player1ID;
        private int player2ID;
        private string player1Name;
        private string player2Name;
        private int player1Match1Score;
        private int player1Match2Score;
        private int player2Match1Score;
        private int player2Match2Score;
        private int winnerID;


        public int MatchID
        {
            get { return matchID; }
            set { matchID = value; }
        }

        public int RoundID 
        {
            get { return roundID; }
            set { roundID = value; }
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

        public int Player1Match1Score
        {
            get { return player1Match1Score; }
            set { player1Match1Score = value; }
        }

        public int Player2Match1Score
        {
            get { return player2Match1Score; }
            set { player2Match1Score = value; }
        }

        public int Player1Match2Score
        {
            get { return player1Match2Score; }
            set { player1Match1Score = value; }
        }

        public int Player2Match2Score
        {
            get { return player2Match2Score; }
            set { player2Match1Score = value; }
        }

        public int WinnerID
        {
            get { return winnerID; }
            set { winnerID = value; }
        }



        public DoubleGameMatch(int matchId, int roundId, int player1Id, string player1Name, int player2Id,
        string player2Name, int player1Match1Score, int player2Match1Score, int player1Match2Score, int player2Match2Score, int winnerId)
        {
            this.matchID = matchId;
            this.roundID = roundId;
            this.player1ID = player1Id;
            this.player1Name = player1Name;
            this.player2ID = player2Id;
            this.player2Name = player2Name;
            this.player1Match1Score = player1Match1Score;
            this.player2Match1Score = player2Match1Score;
            this.player1Match2Score = player1Match2Score;
            this.player2Match2Score = player2Match2Score;
            this.winnerID = winnerId;
        }



        public DoubleGameMatch(int roundId, int player1Id, string player1Name, int player2Id,
        string player2Name, int player1Match1Score, int player2Match1Score, int player1Match2Score, int player2Match2Score, int winnerId)
        {
            this.roundID = roundId;
            this.player1ID = player1Id;
            this.player1Name = player1Name;
            this.player2ID = player2Id;
            this.player2Name = player2Name;
            this.player1Match1Score = player1Match1Score;
            this.player2Match1Score = player2Match1Score;
            this.player1Match2Score = player1Match2Score;
            this.player2Match2Score = player2Match2Score;
            this.winnerID = winnerId;
        }


        public void UpdateMatch(int player1Match1Score, int player2Match1Score, int player1Match2Score, int player2Match2Score, int winnerId)
        {
            this.player1Match1Score = player1Match1Score;
            this.player2Match1Score = player2Match1Score;
            this.player1Match2Score = player1Match2Score;
            this.player2Match2Score = player2Match2Score;
            this.winnerID = winnerId;
        }
    }
}
