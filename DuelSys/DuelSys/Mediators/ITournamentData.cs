using DuelSys.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSys.Mediators
{
    public interface ITournamentData
    {
        void AddTournament(Tournament tournament);
        void RemoveTournament(Tournament tournament);
        List<Tournament> GetTournaments();
        void UpdateInfo(Tournament tournament);
    }
}
