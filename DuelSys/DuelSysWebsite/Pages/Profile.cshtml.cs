using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
    public class ProfileModel : PageModel
    {
        
        
            PlayerManager manager;

            public Player GetProfile { get; set; }

            [BindProperty]
            [Required, DataType(DataType.Text)]
            public string Username { get; set; }

            [BindProperty]
            [Required, DataType(DataType.Password)]
            public string Password { get; set; }
            public void OnGet()
            {
                manager = new PlayerManager(new PlayerMediator());
                GetProfile = manager.GetPlayer(User.Identity.Name);
            }

            //public IActionResult OnPostUpdate()
            //{
            //    manager = new MemberManager(new MemberMediator());
            //    Member member = manager.GetMember(User.Identity.Name);

            //    if (member != null)
            //    {
            //        manager.EditMember(member, Username, Hasher.ComputeSha256Hash(Password));
            //        return RedirectToPage("/LogOut");
            //    }
            //    else
            //    {
            //        return Page();
            //    }



            //}
        
    }
}
