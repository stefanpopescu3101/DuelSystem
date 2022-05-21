using DuelSys.Entities;
using DuelSys.Mediators;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSys.Managers
{
    public class TournamentManager
    {
        private List<Tournament> tournaments;

        private ITournamentData mediator;


        public TournamentManager(ITournamentData src)
        {
            tournaments = new List<Tournament>();
            mediator = src;
        }

        public bool AddTournament(Tournament tournament)
        {
            if (tournament != null)
            {
                tournaments.Add(tournament);
                mediator.AddTournament(tournament);
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool RemoveTournament(Tournament tournament)
        {
            foreach (Tournament t in tournaments)
            {
                if (t.ID == tournament.ID)
                {
                    tournaments.Remove(tournament);
                    mediator.RemoveTournament(tournament);

                    return true;
                }
            }
            return false;

        }


        public Tournament[] GetAllTournaments()
        {
            tournaments = GetTournaments();
            return tournaments.ToArray();
        }


        public List<Tournament> GetTournaments()
        {
            tournaments = mediator.GetTournaments();
            return tournaments;
        }

        public Tournament GetTournament(int id)
        {
            foreach (Tournament tournament in GetTournaments())
            {
                if (id == tournament.id)
                {
                    return tournament;
                }
            }

            return null;
        }

        public void UpdateInfo(Tournament tournament, string sportType, string description, string startDate, string endDate, int minPlayers, int maxPlayers, string location)
        {
            tournament.UpdateInfo(sportType, description, startDate, endDate, minPlayers, maxPlayers, location);
            mediator.UpdateInfo(tournament);
        }

        public List<Tournament> SearchTournaments(string item)
        {
            this.tournaments = GetTournaments();
            List<Tournament> foundTournaments = new List<Tournament>();

            foreach (Tournament tournament in tournaments)
            {
                if (item == tournament.SportType || item == tournament.Location || item == tournament.StartDate)
                {
                    foundTournaments.Add(tournament);

                }
            }

            return foundTournaments;
        }
    }
}
