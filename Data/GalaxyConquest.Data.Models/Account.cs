namespace GalaxyConquest.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using GalaxyConquest.Data.Common.Models;
    using Microsoft.AspNetCore.Identity;

    public class Account : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        // Create Reference to AspNet Users table
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public int QuizId { get; set; }

        public Quiz Quiz { get; set; }

        // Status ?!
        // public int Status { get; set; }
        public double BestScore { get; set; }

        public double TotalPointsEarned { get; set; }

        // TODO: Have to create Achievements Table
        public int AchievementsId { get; set; }
    }
}
