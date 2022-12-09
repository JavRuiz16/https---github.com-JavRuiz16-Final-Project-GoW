using Microsoft.EntityFrameworkCore;

namespace Final_Project_GoW.Models
{
	public class AbilitiesContext : DbContext
	{
		public AbilitiesContext (DbContextOptions<CharacterGoWContext> options)
			: base(options)
		{
		}
		public DbSet<AbilitiesContext> Abilities{get; set;} = default!;
	}
}