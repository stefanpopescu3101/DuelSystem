using DuelSysMediators;
using DuelSysMediators.Interfaces;
using DuelSysEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSysManagers
{
    public class TournamentManager
    {
        private List<Tournament> tournaments;

        private List<Player> enrolledPlayers;

        private List<EnrolledTournament> enrolledTournaments;

        private List<Round> tournamentRounds;

        private List<Match> roundMatches;

        private ITournamentData mediator;

        private PlayerManager playerManager;

        private RoundManager roundManager;

        private MatchManager matchManager;

        public TournamentManager(ITournamentData src)
        {
            tournaments = new List<Tournament>();
            enrolledPlayers = new List<Player>();
            enrolledTournaments = new List<EnrolledTournament>();
            tournamentRounds = new List<Round>();
            roundMatches = new List<Match>();

            playerManager = new PlayerManager(new PlayerMediator());
            roundManager = new RoundManager(new RoundMediator());
            matchManager = new MatchManager(new MatchMediator());

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

        public bool GenerateTournamentStructure(int id)
        {
            Tournament tournament = GetTournament(id);

            if (tournament.Status=="LOCKED")
            {
                enrolledPlayers = GetPlayersEnrolledForTournament(id);

                roundManager.AddRound(new Round(id, false));
                roundManager.AddRound(new Round(id, false));
                roundManager.AddRound(new Round(id, false));

                foreach(Round round in roundManager.GetRoundsForTournament(id))
                {
                    for(int i=0; i<enrolledPlayers.Count;i+=2)
                    {
                        matchManager.AddMatch(new Match(round.RoundID, enrolledPlayers[i].Id, enrolledPlayers[i].Username, enrolledPlayers[i + 1].Id, enrolledPlayers[i + 1].Username));
                    }
                }
                return true;
            }

            return false;
        }


        //Gets all enrollments for a specific tournament
        public List<EnrolledTournament> GetEnrollingsForTournament(int id)
        {
            List<EnrolledTournament> enrolledForTournament = new List<EnrolledTournament>();

            enrolledTournaments = mediator.GetEnrollings();

            foreach(EnrolledTournament enrolledTournament in enrolledTournaments)
            {
                if(enrolledTournament.TournamentID==id)
                {
                    enrolledForTournament.Add(enrolledTournament);
                }
            }
            return enrolledForTournament;
        }

        //Gets all players objects enrolled for a specific tournament
        public List<Player> GetPlayersEnrolledForTournament(int id)
        {

            foreach(EnrolledTournament enrolledTournament in GetEnrollingsForTournament(id))
            {
                foreach(Player player in playerManager.GetAllPlayers())
                {
                    if (player.Id == enrolledTournament.PlayerID)
                    {
                        enrolledPlayers.Add(player);
                    }
                }
            }

            return enrolledPlayers;
        }

        

        public void UpdateInfo(Tournament tournament, string sportType, string description, string startDate, string endDate, int minPlayers, int maxPlayers, string location, string status)
        {
            tournament.UpdateInfo(sportType, description, startDate, endDate, minPlayers, maxPlayers, location, status);
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
