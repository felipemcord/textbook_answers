﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Infra.Database.Context
{
    public class TextBookAnswersContext : DbContext
    {
        public TextBookAnswersContext(DbContextOptions<TextBookAnswersContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
