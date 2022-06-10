using DuelSysEntities;
using DuelSysMediators.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSysManagers
{
    public class DoubleGameMatchManager
    {
        private List<DoubleGameMatch> matches;

        private IDoubleGameMatchData matchMediator;
        public DoubleGameMatchManager(IDoubleGameMatchData src)
        {
            this.matches = new List<DoubleGameMatch>();

            matchMediator = src;
        }

        public bool AddDoubleGameMatch(DoubleGameMatch match)
        {
            if (match != null)
            {
                matches.Add(match);
                matchMediator.AddDoubleGameMatch(match);
                return true;
            }

            return false;
        }

        public List<DoubleGameMatch> GetDoubleGameMatches()
        {
            matches = matchMediator.GetDoubleGameMatches();
            return matches;
        }

        public DoubleGameMatch GetDoubleGameMatch(int id)
        {
            foreach (DoubleGameMatch match in GetDoubleGameMatches())
            {
                if (match.MatchID == id)
                {
                    return match;
                }
            }

            return null;
        }

        public void UpdateInfo(DoubleGameMatch match, int player1Match1Score, int player2Match1Score, int player1Match2Score, int player2Match2Score, int winner)
        {
            match.UpdateMatch(player1Match1Score, player2Match1Score, player1Match2Score, player2Match2Score, winner);
            matchMediator.UpdateMatch(match);
        }
    }
}
