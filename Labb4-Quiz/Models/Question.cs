﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Labb4_Quiz
{
    public class Question
    {
        [Key]
        public int QuestionId { get; set; }
        public string QuestionContent { get; set; }
        public bool IsApproved { get; set; }
        public virtual IList<Answer> Answers { get; set; }
    }
}
