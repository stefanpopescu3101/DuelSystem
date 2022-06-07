using DuelSysMediators;
using DuelSysMediators.Interfaces;
using DuelSysEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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


        public bool AddEnrollment(EnrolledTournament tournament)
        {
            if (tournament != null)
            {
                enrolledTournaments.Add(tournament);
                mediator.AddEnrollment(tournament);
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool PlayerAlreadyRegistered(int tournamentID, int playerID)
        {
            enrolledTournaments = GetEnrollingsForTournament(tournamentID);
            

            foreach(EnrolledTournament enrolledTournament in enrolledTournaments)
            {
                if(enrolledTournament.PlayerID==playerID)
                {
                    return true;
                }
            }

            return false;
        }

        public bool GenerateTournamentStructure(int id)
        {
            Tournament tournament = GetTournament(id);

            if (tournament.Status=="ENROLL")
            {
                enrolledPlayers = GetPlayersEnrolledForTournament(id);

                if(enrolledPlayers.Count %2 !=0)
                {
                    enrolledPlayers.Add(new Player("Dummy", "ssss"));
                }

                int numRounds = (enrolledPlayers.Count - 1);

                for(int i=0; i<numRounds;i++)
                {
                    roundManager.AddRound(new Round(id, false, i));
                }

                List<Round> rounds = new List<Round>(); 
                rounds = roundManager.GetRoundsForTournament(id);

                int halfSize = enrolledPlayers.Count / 2;

                List<Player> players = new List<Player>();


                players.AddRange(enrolledPlayers.Skip(halfSize).Take(halfSize));
                players.AddRange(enrolledPlayers.Skip(1).Take(halfSize - 1).ToArray().Reverse());

                int teamSize = players.Count;

                for(int round=0; round< numRounds;round++)
                {
                    int teamIdx = round % teamSize;

                    matchManager.AddMatch(new Match(rounds[round].RoundID, players[teamIdx].Id, players[teamIdx].Username,  enrolledPlayers[0].Id, enrolledPlayers[0].Username));

                    for(int idx = 1; idx < halfSize; idx++)
                    {
                        int firstTeam = (round + idx) % teamSize;
                        int secondTeam = (round + teamSize - idx) % teamSize;
                        matchManager.AddMatch(new Match(rounds[round].RoundID, players[firstTeam].Id, players[firstTeam].Username, players[secondTeam].Id, players[secondTeam].Username));
                    }


                }

                //roundManager.AddRound(new Round(id, false));
                //roundManager.AddRound(new Round(id, false));
                //roundManager.AddRound(new Round(id, false));

                //foreach(Round round in roundManager.GetRoundsForTournament(id))
                //{
                //    for(int i=0; i<enrolledPlayers.Count;i+=2)
                //    {
                //        matchManager.AddMatch(new Match(round.RoundID, enrolledPlayers[i].Id, enrolledPlayers[i].Username, enrolledPlayers[i + 1].Id, enrolledPlayers[i + 1].Username));
                //    }
                //}
                //return true;

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

        public List<Match> GetMatchesForRound(int id)
        {
            List<Match> allMatches = new List<Match>();

            allMatches = matchManager.GetMatches();

            roundMatches.Clear();

            foreach(Match match in allMatches)
            {
                if(match.RoundID==id)
                {
                    roundMatches.Add(match);
                }
            }

            return roundMatches;
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
