using HD.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace HD.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Idea>()
                .HasOne(i => i.Topic)
                .WithMany(t => t.Ideas)
                .HasForeignKey(i => i.TopicId);

            builder.Entity<Idea>()
                .HasOne(i => i.Category)
                .WithMany(c => c.Ideas)
                .HasForeignKey(i => i.CategoryId);
        }

        public DbSet<HD.Models.Idea> Ideas { get; set; }
        public DbSet<HD.Models.Topic> Topics { get; set; }
        public DbSet<HD.Models.Category> Categories { get; set; }
        public DbSet<HD.Models.View> Views { get; set; }
        public DbSet<HD.Models.React> Reacts { get; set; }
        public DbSet<HD.Models.Comment> Comments { get; set; }
        public DbSet<HD.Models.Department> Departments { get; set; }
        public DbSet<HD.Models.DepartmentUser> DepartmentUsers { get; set; }
    }
}