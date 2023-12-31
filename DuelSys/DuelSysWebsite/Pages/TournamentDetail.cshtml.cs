using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DuelSysEntities;
using DuelSysManagers;
using DuelSysMediators;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DuelSysWebsite.Pages
{
    [Authorize]
    public class TournamentDetailModel : PageModel
    {

        [BindProperty]
        public Tournament Tournament { get; set; }

        public TournamentManager tournamentManager;
        public PlayerManager playerManager;
        public MatchManager matchManager;

        public List<Tournament> tournaments;
        public List<Round> rounds;
        public List<Match> matches;
        public List<DoubleGameMatch> doubleGameMatches;
        public List<EnrolledTournament> enrolledTournaments;
        public void OnGet(int id)
        {
            Tournament = tournamentManager.GetTournament(id);
            enrolledTournaments = tournamentManager.GetEnrollingsForTournament(id);
            matches = tournamentManager.GetMatchesForTournament(id);
            doubleGameMatches = tournamentManager.GetDoubleGameMatchesForTournament(id);
        }

        

        public TournamentDetailModel()
        {
            tournamentManager = new TournamentManager(new TournamentMediator());
            playerManager = new PlayerManager(new PlayerMediator());
            matchManager = new MatchManager(new MatchMediator());

            tournaments = new List<Tournament>();
            rounds = new List<Round>();
            matches = new List<Match>();
            doubleGameMatches = new List<DoubleGameMatch>();
            enrolledTournaments = new List<EnrolledTournament>();

        }
    }
}
