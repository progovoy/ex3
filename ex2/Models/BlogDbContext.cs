namespace ex2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BlogDbContext : DbContext
    {
        public BlogDbContext()
            : base("name=BlogConnectionSettings")
        {
            Database.SetInitializer<BlogDbContext>(new DropCreateDatabaseIfModelChanges<BlogDbContext>());
        }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public DbSet<Fan> Fans { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }

    }
}
