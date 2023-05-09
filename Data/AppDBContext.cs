using System;
using Microsoft.EntityFrameworkCore;
namespace BlazorCRUD.Data
{
    public class AppDBContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            Post[] postsToSeed = new Post[10];
            for (int i = 1; i <= 10; i++)
            {
                postsToSeed[i - 1] = new Post
                {
                    Id = i,
                    Title = $"Post {i}",
                    Content = $"This is some example content for post{i}."
                };
            }
            modelBuilder.Entity<Post>().HasData(postsToSeed);
        }
    }
}

