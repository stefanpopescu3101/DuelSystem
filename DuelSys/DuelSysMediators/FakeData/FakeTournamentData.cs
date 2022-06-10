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
        List<EnrolledTournament> enrolledTournaments;
        List<Player> players = new List<Player>();
        
            

        public FakeTournamentData()
        {
            tournaments = new List<Tournament>();
            enrolledTournaments = new List<EnrolledTournament>();
            players = new List<Player>();

            tournaments.Add(new Tournament(1, "badminton", "It is a sport", "16/05/2022", "20/05/2022", 4, 10, "Eindhoven", "robin-rounds", 0, 0, 0, "LOCKED"));
            tournaments.Add(new Tournament("badminton", "It is a sport", "16/05/2022", "20/05/2022", 4, 10, "Eindhoven", "robin-rounds", 0, 0, 0, "ENROLL"));
            tournaments.Add(new Tournament("badminton", "It is a sport", "16/05/2022", "20/05/2022", 4, 10, "Eindhoven", "robin-rounds", 0, 0, 0, "ENROLL"));
            tournaments.Add(new Tournament("badminton", "It is a sport", "16/05/2022", "20/05/2022", 4, 10, "Eindhoven", "robin-rounds", 0, 0, 0, "ENROLL"));
            tournaments.Add(new Tournament("badminton", "It is a sport", "16/05/2022", "20/05/2022", 4, 10, "Eindhoven", "robin-rounds", 0, 0, 0, "ENROLL"));
            tournaments.Add(new Tournament(1, "badminton", "It is a sport", "16/05/2022", "20/05/2022", 4, 10, "Eindhoven", "robin-rounds", 0, 0, 0, "ENROLL"));

            enrolledTournaments.Add(new EnrolledTournament(1, 1, 0, 0));
            enrolledTournaments.Add(new EnrolledTournament(1, 2, 0, 0));
            enrolledTournaments.Add(new EnrolledTournament(1, 3, 0, 0));
            enrolledTournaments.Add(new EnrolledTournament(1, 4, 0, 0));

            players.Add(new Player(1, "w", "2"));
            players.Add(new Player(2, "w", "2"));
            players.Add(new Player(3, "w", "2"));
            players.Add(new Player(4, "w", "2"));
        }

        public bool AddEnrollment(EnrolledTournament tournament)
        {
            throw new NotImplementedException();
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

        public bool UpdatePoints(EnrolledTournament enrolledTournament)
        {
            throw new NotImplementedException();
        }

        public bool UpdateRank(EnrolledTournament enrolledTournament)
        {
            throw new NotImplementedException();
        }

        public bool UpdateRanking(Tournament tournament)
        {
            throw new NotImplementedException();
        }

        public bool UpdateStatus(Tournament tournament)
        {
            throw new NotImplementedException();
        }
    }
}
