using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CustomerWebsite.Pages
{
    [Authorize]
    public class LogOutModel : PageModel
    {
        public IActionResult OnGet()
        {

            HttpContext.SignOutAsync();

            return RedirectToPage("/Index");
        }
    }
}
