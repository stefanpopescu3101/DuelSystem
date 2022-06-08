using DuelSysEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSysMediators.Interfaces
{
    public interface IMatchData
    {
        List<Match> GetMatches();
        bool AddMatch(Match match);
        bool UpdateInfo(Match match);

    }
}
