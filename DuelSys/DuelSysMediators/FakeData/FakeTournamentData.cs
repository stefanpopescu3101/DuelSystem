using DuelSysEntities;
using DuelSysMediators.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSysMediators.FakeData
{
    public class FakeTournamentData : ITournamentData
    {
        List<Tournament> tournaments;
        public FakeTournamentData()
        {
            tournaments = new List<Tournament>();
            tournaments.Add(new Tournament("badminton", "It is a sport", "16/05/2022", "20/05/2022", 4, 10, "Eindhoven", "robin-rounds", "ENROLL"));
            tournaments.Add(new Tournament("badminton", "It is a sport", "16/05/2022", "20/05/2022", 4, 10, "Eindhoven", "robin-rounds", "ENROLL"));
            tournaments.Add(new Tournament("badminton", "It is a sport", "16/05/2022", "20/05/2022", 4, 10, "Eindhoven", "robin-rounds", "ENROLL"));
            tournaments.Add(new Tournament("badminton", "It is a sport", "16/05/2022", "20/05/2022", 4, 10, "Eindhoven", "robin-rounds", "ENROLL"));
            tournaments.Add(new Tournament("badminton", "It is a sport", "16/05/2022", "20/05/2022", 4, 10, "Eindhoven", "robin-rounds", "ENROLL"));
            tournaments.Add(new Tournament(1, "badminton", "It is a sport", "16/05/2022", "20/05/2022", 4, 10, "Eindhoven", "robin-rounds", "ENROLL"));

        }

        public bool AddTournament(Tournament tournament)
        {
            return true;
        }

        public List<EnrolledTournament> GetEnrollings()
        {
            throw new NotImplementedException();
        }

        public List<Player> GetPlayersEnrolled()
        {
            throw new NotImplementedException();
        }

        public List<Tournament> GetTournaments()
        {
            return tournaments;
        }

        public bool RemoveTournament(Tournament tournament)
        {
            return true;
        }

        public bool UpdateInfo(Tournament tournament)
        {
            return true;
        }
    }
}
