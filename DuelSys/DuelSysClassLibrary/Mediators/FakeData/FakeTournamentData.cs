using DuelSys.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSys.Mediators.FakeData
{
    public class FakeTournamentData : ITournamentData
    {
        List<Tournament> tournaments;
        public FakeTournamentData()
        {
            tournaments = new List<Tournament>();
            tournaments.Add(new Tournament("badminton", "It is a sport", "16/05/2022", "20/05/2022", 4, 10, "Eindhoven", "robin-rounds"));
            tournaments.Add(new Tournament("badminton", "It is a sport", "16/05/2022", "20/05/2022", 4, 10, "Eindhoven", "robin-rounds"));
            tournaments.Add(new Tournament("badminton", "It is a sport", "16/05/2022", "20/05/2022", 4, 10, "Eindhoven", "robin-rounds"));
            tournaments.Add(new Tournament("badminton", "It is a sport", "16/05/2022", "20/05/2022", 4, 10, "Eindhoven", "robin-rounds"));
            tournaments.Add(new Tournament("badminton", "It is a sport", "16/05/2022", "20/05/2022", 4, 10, "Eindhoven", "robin-rounds"));
            tournaments.Add(new Tournament(1, "badminton", "It is a sport", "16/05/2022", "20/05/2022", 4, 10, "Eindhoven", "robin-rounds"));

        }

        public bool AddTournament(Tournament tournament)
        {
            return true;
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
