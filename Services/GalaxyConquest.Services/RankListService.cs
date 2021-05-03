namespace GalaxyConquest.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using GalaxyConquest.Data;
    using GalaxyConquest.Web.ViewModels.Home;

    public class RankListService
    {
        private readonly ApplicationDbContext dbContext;

        public RankListService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        //public static List<RankingViewModel> RankList()
        //{
        //    string sql = "@select Rank, Username, TotalPointsEarned, QuizzTaken from dbo.RankLists";

        //    return 
        //}
    }
}
