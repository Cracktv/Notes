using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zametki.Models;
using Microsoft.EntityFrameworkCore;

namespace Zametki.Data
{
    public class ZametkiContext : DbContext
    {
        public ZametkiContext(DbContextOptions<ZametkiContext> options) : base(options)
        {
        }
        public DbSet<Note> Notes { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Note>().ToTable("Note");
            modelBuilder.Entity<User>().ToTable("User");
        }
    }
    
}
