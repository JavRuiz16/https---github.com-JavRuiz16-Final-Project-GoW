using Microsoft.EntityFrameworkCore;
namespace Final_Project_GoW.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DbContext(
                serviceProvider.GetRequiredService<DbContextOptions<GodofWarDbContext>>()))
            {
                // Look for any blogs.
                if (context.GodofWar.Any())
                {
                    return; // DB has been seeded
                }
                
                context.Blogs.AddRange(
                    new Blog
                    {
                        Title = "My First Blog"
                    },
                    new Blog
                    {
                        Title = "My Second Blog"
                    }
                );
                
                context.SaveChanges();
            }
        }
    }
}
