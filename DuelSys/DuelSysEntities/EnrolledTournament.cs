using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSysEntities
{
    public class EnrolledTournament
    {
        private int tournamentID;

        private int playerID;

        public int TournamentID
        {
            get { return tournamentID; }
        }

        public int PlayerID
        {
            get { return playerID; }
        }

        public EnrolledTournament(int tournamentID ,int playerID)
        {
            this.tournamentID = tournamentID;
            this.playerID = playerID;
        }
    }
}
