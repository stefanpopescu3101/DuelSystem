using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSysEntities
{
    public class Round
    {
        public int roundID;

        private int tournamentID;

        private bool status;

        public int RoundID
        {
            get { return roundID; }
            set { roundID = value; }
        }

        public int TournamentID
        {
            get { return tournamentID; }
            set { tournamentID = value; }
        }

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        public Round(int roundID, int tournamentID, bool status)
        {
            this.roundID = roundID;
            this.tournamentID = tournamentID;
            this.status = status;
        }

        public Round(int tournamentID, bool status)
        {
            this.tournamentID = tournamentID;
            this.status = status;
        }


    }
}
