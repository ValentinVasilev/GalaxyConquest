namespace GalaxyConquest.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using GalaxyConquest.Data.Common.Models;

    public class Account : BaseDeletableModel<int>
    {
        // Create Reference to AspNet Users table
        public string UserId { get; set; }

        public int QuizId { get; set; }

        // Status ?!
        // public int Status { get; set; }
        public double BestScore { get; set; }

        public double TotalPointsEarned { get; set; }

        // TODO: Have to create Achievements Table
        public int AchievementsId { get; set; }
    }
}
