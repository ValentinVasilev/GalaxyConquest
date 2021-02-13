namespace GalaxyConquest.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;

    public class LoggedInController : Controller
    {
        public IActionResult LoggedIn()
        {
            if (this.User.Identity.IsAuthenticated)
            {
                return this.View("/Logged");
            }

            return this.RedirectToAction("/Home/Index");
        }
    }
}
