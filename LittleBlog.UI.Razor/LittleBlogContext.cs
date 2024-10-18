using LittleBlog.UI.Razor.Mapping;
using LittleBlog.UI.Razor.Models;
using Microsoft.EntityFrameworkCore;

namespace LittleBlog.UI.Razor
{
    public class LittleBlogContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public LittleBlogContext(DbContextOptions<LittleBlogContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(ArticleMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
        }
    }
}
