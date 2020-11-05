using Entitties.Models;
using System.Data.Entity;

namespace Entitties.Contexts
{
    public class PMContext : DbContext
    {
        public DbSet<TaskProject> Tasks { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public PMContext() : base("name=ConnectSQL")
        {
            Database.SetInitializer<PMContext>(new DropCreateDatabaseIfModelChanges<PMContext>());
        }
       
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        
        }


    }
}
