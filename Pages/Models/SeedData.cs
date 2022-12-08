using Microsoft.EntityFrameworkCore;
namespace Final_Project_GoW.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CharacterGoWContext(
                serviceProvider.GetRequiredService<DbContextOptions<CharacterGoWContext>>()))
            {
                // Look for Game Character
                if (context.CharacterGoW.Any())
                {
                    return; // DB has been seeded
                }
                
                context.CharacterGoW.AddRange(
                    new CharacterGoW
                    {
                        Title = "Kratos"
                    },
                    new CharacterGoW
                    {
                        Title = "Atreus"
                    }
                );
                
                context.SaveChanges();
            }
        }
    }
}
