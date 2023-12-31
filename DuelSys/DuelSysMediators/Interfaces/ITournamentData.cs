﻿using DuelSysEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSysMediators.Interfaces
{
    public interface ITournamentData
    {
        bool AddTournament(Tournament tournament);
        bool RemoveTournament(Tournament tournament);
        List<Tournament> GetTournaments();
        bool UpdateInfo(Tournament tournament);
        List<EnrolledTournament> GetEnrollings();
        bool AddEnrollment(EnrolledTournament tournament);
        bool UpdateRanking(Tournament tournament);
        bool UpdatePoints(EnrolledTournament enrolledTournament);
        bool UpdateRank(EnrolledTournament enrolledTournament);
        bool UpdateStatus(Tournament tournament);
    }
}
