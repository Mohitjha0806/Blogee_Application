using BlogeeCoreMVC.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace BlogeeCoreMVC.Data
{
    public class BlogeeDbContext : DbContext
    {
        public BlogeeDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<BlogPost>  BlogPosts { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
