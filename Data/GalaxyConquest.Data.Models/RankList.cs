namespace GalaxyConquest.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using GalaxyConquest.Data.Common.Models;

    public class RankList : BaseDeletableModel<int>
    {
        public int Rank { get; set; }

        public string Username { get; set; }

        public int TotalPointsEarned { get; set; }

        public int QuizzTaken { get; set; }

        public Account AccountId { get; set; }

    }
}
