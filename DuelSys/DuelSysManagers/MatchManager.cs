using DuelSysEntities;
using DuelSysMediators.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSysManagers
{
    public class MatchManager : IMatchData
    {
        private List<Match> matches;

        private IMatchData matchMediator;
        public MatchManager(IMatchData src)
        {
            this.matches = new List<Match>();

            matchMediator = src;
        }

        public bool AddMatch(Match match)
        {
            if(match!=null)
            {
                matches.Add(match);
                matchMediator.AddMatch(match);
                return true;
            }

            return false;
        }

        public List<Match> GetMatches()
        {
            matches = matchMediator.GetMatches();
            return matches;
        }
    }
}
