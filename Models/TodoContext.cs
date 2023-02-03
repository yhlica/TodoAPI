﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace TodoAPI.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options) { }

        public DbSet<TodoItem> TodoItems { get; set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
