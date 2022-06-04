using DuelSysEntities;
using DuelSysMediators.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSysManagers
{
    public class RoundManager : IRoundData
    {
        private List<Round> rounds;

        private IRoundData roundMediator;

        public RoundManager(IRoundData src)
        {
            this.rounds = new List<Round>();

            roundMediator = src;
        }

        public bool AddRound(Round round)
        {
            if(round!=null)
            {
                rounds.Add(round);
                roundMediator.AddRound(round);
                return true;
            }

            return false;
        }

        public List<Round> GetRounds()
        {
            rounds = roundMediator.GetRounds();
            return rounds;
        }

        public List<Round> GetRoundsForTournament(int id)
        {
            List<Round> roundsForTournament = new List<Round>();

            foreach(Round round in GetRounds())
            {
                if(round.TournamentID==id)
                {
                    roundsForTournament.Add(round);
                }
            }

            return roundsForTournament;
        }
    }
}
