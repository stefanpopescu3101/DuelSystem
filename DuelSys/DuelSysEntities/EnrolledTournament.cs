using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSysEntities
{
    public class EnrolledTournament
    {
        private int tournamentID;

        private int playerID;

        private int points;

        private int rank;

        public int TournamentID
        {
            get { return tournamentID; }
        }

        public int PlayerID
        {
            get { return playerID; }
        }

        public int Points
        {
            get { return points; }
            set { points = value; }
        }

        public int Rank
        {
            get { return rank; }
            set { rank = value; }
        }

        public EnrolledTournament(int tournamentID ,int playerID, int points, int rank)
        {
            this.tournamentID = tournamentID;
            this.playerID = playerID;
            this.points = points;
            this.rank=rank;
        }

        public void UpdatePoints(int points)
        {
            this.points = points;
        }

        public void UpdateRank(int rank)
        {
            this.rank = rank;
        }
    }
}
