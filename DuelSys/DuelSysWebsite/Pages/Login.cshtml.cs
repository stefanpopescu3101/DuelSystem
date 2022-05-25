using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using DuelSysEntities;
using DuelSysManagers;
using DuelSysMediators;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DuelSysWebsite.Pages
{
    public class LoginModel : PageModel
    {

        [BindProperty]
        [Required, DataType(DataType.Text)]
        public string Username { get; set; }

        [BindProperty]
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        PlayerManager playerManager;
        StaffManager staffManager;
        public void OnGet()
        {
        }

        public IActionResult OnPost(string? returnUrl)
        {
            List<Claim> claims = new List<Claim>();

            playerManager = new PlayerManager(new PlayerMediator());
            staffManager = new StaffManager(new StaffMediator());
            if (ModelState.IsValid
                && ((playerManager.CheckCredentials(Username, Hasher.ComputeSha256Hash(Password)) != null)))

            {

                Player player = playerManager.GetPlayer(Username);

                claims.Add(new Claim(ClaimTypes.Name, Username));
                claims.Add(new Claim("id", player.Id.ToString()));


                claims.Add(new Claim(ClaimTypes.Role, "user"));

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity));




                if (!String.IsNullOrWhiteSpace(returnUrl) && Url.IsLocalUrl(returnUrl))
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    return RedirectToPage("Index");
                }
            }
            else if (ModelState.IsValid
                && ((staffManager.CheckCredentials(Username, Hasher.ComputeSha256Hash(Password)) != null)))
            {
                Staff staff = staffManager.CheckCredentials(Username, Password);

                claims.Add(new Claim(ClaimTypes.Name, Username));
                claims.Add(new Claim("id", staff.ID.ToString()));


                claims.Add(new Claim(ClaimTypes.Role, "admin"));

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity));




                if (!String.IsNullOrWhiteSpace(returnUrl) && Url.IsLocalUrl(returnUrl))
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    return RedirectToPage("Index");
                }
            }
            else
            {
                ModelState.AddModelError("InvalidCredentials", "The supplied username and/or password is invalid");
                return Page();
            }
        }


        public IActionResult OnPostRegister(string? returnUrl)
        {
            playerManager = new PlayerManager(new PlayerMediator());

            Player player = new Player(Username, Hasher.ComputeSha256Hash(Password));
            if (playerManager.AddPlayer(player))
            {
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }


        }
    }
}
