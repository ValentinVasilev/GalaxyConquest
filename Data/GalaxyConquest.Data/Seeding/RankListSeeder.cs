namespace GalaxyConquest.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class RankListSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.RankLists.Any())
            {
                return;
            }

            dbContext.RankLists.Add(new Models.RankList { Username = "Evgeni", TotalPointsEarned = 100, QuizzTaken = 10 });
            dbContext.RankLists.Add(new Models.RankList { Username = "Anastas", TotalPointsEarned = 98, QuizzTaken = 11 });
            dbContext.RankLists.Add(new Models.RankList { Username = "Liubomir", TotalPointsEarned = 97, QuizzTaken = 12 });

            dbContext.SaveChanges();
        }
    }
}
