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
    }
}
