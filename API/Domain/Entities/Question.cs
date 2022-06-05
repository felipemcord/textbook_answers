﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int QuestionNumber { get; set; }

        public int ChapterId { get; set; }
        public Chapter Chapter { get; set; }

    }
}
