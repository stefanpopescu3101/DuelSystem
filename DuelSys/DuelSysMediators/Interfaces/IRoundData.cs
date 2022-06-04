using DuelSysEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSysMediators.Interfaces
{
    public interface IRoundData
    {
        List<Round> GetRounds();
        bool AddRound(Round round);
    }
}
