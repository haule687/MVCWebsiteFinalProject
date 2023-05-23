/*Developed by Hau Le*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models;

namespace FinalProject.Data
{
    public class FinalProjectContext : DbContext
    {
        public FinalProjectContext (DbContextOptions<FinalProjectContext> options)
            : base(options)
        {
        }

        public DbSet<FinalProject.Models.Movie> Movie { get; set; } = default!;
        public DbSet<FinalProject.Models.Book> Book { get; set; } = default!;
        public DbSet<TodoItem> TodoItems { get; set; } = null!;
    }
}
