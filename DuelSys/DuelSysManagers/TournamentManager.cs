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


        public bool AddEnrollment(EnrolledTournament enrolledTournament)/// manager
        {
            Tournament tournament = GetTournament(enrolledTournament.TournamentID);
            
            if (enrolledTournament != null)
            {
                enrolledTournaments.Add(enrolledTournament);
                mediator.AddEnrollment(enrolledTournament);
                if (GetEnrollingsForTournament(enrolledTournament.TournamentID).Count == tournament.MaxPlayers)
                {
                    UpdateStatus(tournament, "LOCKED");
                }
                return true;
            }
            else
            {
                return false;
            }

        }

        public EnrolledTournament GetEnrolled(int playerID, int tournamentID)
        {
            enrolledTournaments = GetEnrollingsForTournament(tournamentID);

            foreach(EnrolledTournament enrolledTournament in enrolledTournaments)
            {
                if(enrolledTournament.PlayerID==playerID)
                {
                    return enrolledTournament;
                }
            }

            return null;
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

            if (tournament.Status=="LOCKED")
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

                    matchManager.AddMatch(new Match(rounds[round].RoundID, players[teamIdx].Id, players[teamIdx].Username,  enrolledPlayers[0].Id, enrolledPlayers[0].Username, 0, 0, 0));

                    for(int idx = 1; idx < halfSize; idx++)
                    {
                        int firstTeam = (round + idx) % teamSize;
                        int secondTeam = (round + teamSize - idx) % teamSize;
                        matchManager.AddMatch(new Match(rounds[round].RoundID, players[firstTeam].Id, players[firstTeam].Username, players[secondTeam].Id, players[secondTeam].Username, 0, 0, 0));
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
            enrolledPlayers.Clear();

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

        public List<Match> GetMatchesForTournament(int tournamentID)
        {
            List<Match> allMatches = new List<Match>();

            allMatches = matchManager.GetMatches();

            List<Round> rounds = new List<Round>();

            rounds = roundManager.GetRoundsForTournament(tournamentID);

            foreach (Round round in rounds)
            {
                foreach(Match match in allMatches)
                {
                    if (match.RoundID == round.RoundID)
                    {
                        roundMatches.Add(match);
                    }
                }
                
            }

            return roundMatches;
        }


        public void CalculateRankingWinners(int tournamentID)
        {
            List<EnrolledTournament> enrolledTournamentRanks = new List<EnrolledTournament>();

            enrolledTournamentRanks = GetEnrollingsForTournament(tournamentID);

            enrolledTournaments = GetEnrollingsForTournament(tournamentID);

            int max = 0;
            int listLenght = enrolledTournamentRanks.Count;

            for(int i=1;i<= listLenght;i++)
            {
                foreach (EnrolledTournament enrolledTournament in enrolledTournamentRanks)
                {
                    if (enrolledTournament.Points > max)
                    {
                        max = enrolledTournament.Points;
                    }
                }

                EnrolledTournament enrolledTournamentWinner = new EnrolledTournament(1, 1, 1, 1);
                //int encounters = 0;

                foreach (EnrolledTournament enrolledTournament1 in enrolledTournamentRanks)
                {
                   
                    if(enrolledTournament1.Points==max)
                    {

                        //encounters++;
                        enrolledTournamentWinner = enrolledTournament1;
                        UpdateRank(enrolledTournamentWinner, i);
                    }
                }

                
                enrolledTournamentRanks.Remove(enrolledTournamentWinner);
                max = 0;
            }

            



        }

        public bool CalculatePlayersPointsAndRankingForTournament(int tournamentID)
        {
            List<Match> matchesForTournament = new List<Match>();

            bool matchesCompleted = true;

            matchesForTournament = GetMatchesForTournament(tournamentID);

            foreach(Match match1 in matchesForTournament)
            {
                if(match1.Player1Score==0 || match1.Player2Score==0)
                {
                    matchesCompleted = false;
                }
            }

            if(matchesCompleted == true)
            {
                int points = 0;

                List<EnrolledTournament> tournamentEnrollings = new List<EnrolledTournament>();
                tournamentEnrollings = GetEnrollingsForTournament(tournamentID);


                matchesForTournament = GetMatchesForTournament(tournamentID);

                foreach (EnrolledTournament enrolledTournament in tournamentEnrollings)
                {

                    foreach (Match match in matchesForTournament)
                    {
                        if (match.Winner == enrolledTournament.PlayerID)
                        {
                            points++;
                        }
                    }

                    UpdatePoints(enrolledTournament, points);
                    points = 0;
                }

                CalculateRankingWinners(tournamentID);
                CalculateTournamentWinners(tournamentID);
                return true;
            }

            return false;
            
        }

        public void CalculateTournamentWinners(int tournamentID)
        {
            if(GetTournament(tournamentID).Status=="FINISHED")
            {
                int bronze = 0;
                int silver = 0;
                int gold = 0;


                foreach (EnrolledTournament enrolledTournament in GetEnrollingsForTournament(tournamentID))
                {
                    if (enrolledTournament.Rank == 1)
                    {
                        gold = enrolledTournament.PlayerID;
                    }

                    if (enrolledTournament.Rank == 2)
                    {
                        silver = enrolledTournament.PlayerID;
                    }

                    if (enrolledTournament.Rank == 3)
                    {
                        bronze = enrolledTournament.PlayerID;
                    }
                }

                UpdateRanking(GetTournament(tournamentID), bronze, silver, gold);

                
            }

            

        }



        public void UpdateInfo(Tournament tournament, string sportType, string description, string startDate, string endDate, int minPlayers, int maxPlayers, string location, string status)
        {
            tournament.UpdateInfo(sportType, description, startDate, endDate, minPlayers, maxPlayers, location, status);
            mediator.UpdateInfo(tournament);
        }

        public void UpdateRanking(Tournament tournament, int bronze, int silver, int gold)
        {
            tournament.UpdateRanking(bronze, silver, gold);
            mediator.UpdateRanking(tournament);
        }

        public void UpdatePoints(EnrolledTournament enrolledTournament, int points)
        {
            enrolledTournament.UpdatePoints(points);
            mediator.UpdatePoints(enrolledTournament);
        }

        public void UpdateRank(EnrolledTournament enrolledTournament, int rank)
        {
            enrolledTournament.UpdateRank(rank);
            mediator.UpdateRank(enrolledTournament);
        }

        public void UpdateStatus(Tournament tournament, string status)
        {
            tournament.UpdateStatus(status);
            mediator.UpdateStatus(tournament);
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
