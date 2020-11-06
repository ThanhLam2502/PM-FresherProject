using Entities.Models;
using Entitties.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Runtime.CompilerServices;

namespace Entitties.Contexts
{
    public class PMContext : DbContext
    {
        public DbSet<TaskProject> Tasks { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaskUser>()
                .HasKey(tu => new { tu.TaskID, tu.UserID });

            modelBuilder.Entity<TaskUser>()
               .HasOne(tu => tu.Task)
               .WithMany(t => t.TaskUsers)
               .HasForeignKey(tu => tu.Task);

            modelBuilder.Entity<TaskUser>()
                .HasOne(tu => tu.User)
                .WithMany(u => u.TaskUsers)
                .HasForeignKey(tu => tu.User);

            modelBuilder.Entity<User>()
                .HasOne(u => u.Project)
                .WithOne(p => p.User)
                .HasForeignKey<Project>(p => p.AssignTo);

            modelBuilder.Entity<Project>()
                .HasMany(p => p.Tasks)
                .WithOne(t => t.Project)
                .HasForeignKey(t => t.ProjectID);
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=PM-FresherProjectDB;Integrated Security=True");
        }

    }
}
