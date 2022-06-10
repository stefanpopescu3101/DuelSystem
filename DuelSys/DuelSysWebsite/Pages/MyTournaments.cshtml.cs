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
    public class MyTournamentsModel : PageModel
    {
        public List<Tournament> tournaments;

        public TournamentManager tournamentManager;

        public PlayerManager playerManager;


        public MyTournamentsModel()
        {
            tournamentManager = new TournamentManager(new TournamentMediator());

            playerManager = new PlayerManager(new PlayerMediator());

            tournaments = new List<Tournament>();
        }
        public void OnGet()
        {

            tournaments = tournamentManager.GetTournamentsForPlayer(playerManager.GetPlayer(User.Identity.Name).Id);
            //foreach(Tournament tournament in tournaments)
            //{
            //    foreach(TournamentSubscription tournamentSubscription in TournamentManager.GetTournamentSubscriptions(tournament.Id))
            //    {
            //        if(tournament.Id == tournamentSubscription.TournamentId)
            //        {
            //            Player.Id = tournamentSubscription.Id;

            //            //NumberOfPlayers = NumberOfPlayers.Count(Player.Id);
            //        }
            //    }

            //}

        }
    }
}
