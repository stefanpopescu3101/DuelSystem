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
    public class TournamentsModel : PageModel
    {

        public List<Tournament> tournaments;

        public TournamentManager tournamentManager;

        public PlayerManager playerManager;

        public TournamentsModel()
        {
            tournamentManager = new TournamentManager(new TournamentMediator());

            playerManager = new PlayerManager(new PlayerMediator());

            tournaments = new List<Tournament>();
        }

        public void OnGet()
        {
            tournaments = tournamentManager.GetTournaments();
        }


        public IActionResult OnPostAdd(int id)
        {


            EnrolledTournament enrollment = new EnrolledTournament(playerManager.GetPlayer(User.Identity.Name).Id, id);

            if(tournamentManager.AddEnrollment(enrollment))
            {
                return RedirectToPage("/Tournaments");
            }
            else
            {
                return RedirectToPage("/Torunaments");
            }
            

            

        }
    }
}
