using DuelSysClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSysClassLibrary.Mediators
{
    public interface ITournamentData
    {
        bool AddTournament(Tournament tournament);
        bool RemoveTournament(Tournament tournament);
        List<Tournament> GetTournaments();
        bool UpdateInfo(Tournament tournament);
    }
}
