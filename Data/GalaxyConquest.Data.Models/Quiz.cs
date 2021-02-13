namespace GalaxyConquest.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using GalaxyConquest.Data.Common.Models;

    public class Quiz : BaseDeletableModel<int>
    {
        public Account AccountId { get; set; }

        //public Account Account { get; set; }

        public string Name { get; set; }

        public string Context { get; set; }

        public int NumberOfQuestions { get; set; }

        public double MaximumPoints { get; set; }

        public DateTime StartsAt { get; set; }

        public DateTime EndsAt { get; set; }
    }
}
