﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Chapter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ChapterNumber { get; set; }

        public int BookId { get; set; }
        public Book? Book { get; set; }
    }
}
