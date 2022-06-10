using DuelSysEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSysMediators.Interfaces
{
    public interface IDoubleGameMatchData
    {
        List<DoubleGameMatch> GetDoubleGameMatches();
        bool AddDoubleGameMatch(DoubleGameMatch match);
        bool UpdateMatch(DoubleGameMatch match);

    }
}
