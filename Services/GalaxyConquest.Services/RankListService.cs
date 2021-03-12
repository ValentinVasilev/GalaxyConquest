namespace GalaxyConquest.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using GalaxyConquest.Data;
   

    public class RankListService
    {
        private readonly ApplicationDbContext dbContext;

        public RankListService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        //public RankList()
        //{
        //    var viewModel = new RankListViewModel
        //    {
        //        Rank = this.dbContext.RankLists.All(x => x.Rank),

        //    }
        //}
    }
}
