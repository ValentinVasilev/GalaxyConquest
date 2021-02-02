namespace GalaxyConquest.Data.Models
{
    using GalaxyConquest.Data.Common.Models;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Questions : BaseDeletableModel<int>
    {
        // What number in the current question in the quizz
        public int QuestionNumber { get; set; }

        public string QuestionDescription { get; set; }

        public string PictureUrl { get; set; }
    }
}
