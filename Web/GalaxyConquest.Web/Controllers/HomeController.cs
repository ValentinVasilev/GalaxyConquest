namespace GalaxyConquest.Web.Controllers
{
    using System.Diagnostics;
    using System.Linq;
    using GalaxyConquest.Data;
    using GalaxyConquest.Web.ViewModels;
    using GalaxyConquest.Web.ViewModels.Home;
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : BaseController
    {
        private readonly ApplicationDbContext dbContext;

        public HomeController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IActionResult Index()
        {
            //if (!this.User.Identity.IsAuthenticated)
            //{
            //    return this.BadRequest();
            //}
            System.Console.WriteLine();
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

        public IActionResult Ranking(string username)
        {
            var viewModel = new RankingViewModel
            {
                Rank = this.dbContext.Users.Count(),
                Username = this.dbContext.RankLists.Count().ToString(),
                Points = this.dbContext.RankLists.Count(),
                QuizzTaken = this.dbContext.RankLists.Count(),
            };

            return this.View(viewModel);
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
