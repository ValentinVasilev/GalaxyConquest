namespace GalaxyConquest.Web.Controllers
{
    using System.Diagnostics;

    using GalaxyConquest.Web.ViewModels;

    using Microsoft.AspNetCore.Mvc;

    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return this.View();
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        public IActionResult News()
        {
            return this.View();
        }

        public IActionResult Ranking()
        {
            return this.View();
        }

        public IActionResult Info()
        {
            return this.View();
        }

        public IActionResult Forum()
        {
            return this.View();
        }

        public IActionResult SupportUs()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
