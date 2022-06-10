using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DuelSysEntities;
using DuelSysManagers;
using DuelSysMediators;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DuelSysWebsite.Pages
{
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
        public List<EnrolledTournament> enrolledTournaments;
        public void OnGet(int id)
        {
            Tournament = tournamentManager.GetTournament(id);
            enrolledTournaments = tournamentManager.GetEnrollingsForTournament(id);
            matches = tournamentManager.GetMatchesForTournament(id);
        }

        

        public TournamentDetailModel()
        {
            tournamentManager = new TournamentManager(new TournamentMediator());
            playerManager = new PlayerManager(new PlayerMediator());
            matchManager = new MatchManager(new MatchMediator());

            tournaments = new List<Tournament>();
            rounds = new List<Round>();
            matches = new List<Match>();
            enrolledTournaments = new List<EnrolledTournament>();

        }
    }
}
