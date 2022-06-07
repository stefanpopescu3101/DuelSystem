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

        int i;

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

        public int I
        {
            get { return i; }
            set { i = value; }
        }

        public Round(int roundID, int tournamentID, bool status, int i)
        {
            this.roundID = roundID;
            this.tournamentID = tournamentID;
            this.status = status;
            this.i = i;
        }

        public Round(int tournamentID, bool status, int i)
        {
            this.tournamentID = tournamentID;
            this.status = status;
            this.i = i;
        }


    }
}
