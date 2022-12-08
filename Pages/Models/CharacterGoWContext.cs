using Microsoft.EntityFrameworkCore;

namespace Final_Project_GoW.Models
{
	public class CharacterGoWContext : DbContext
	{
		public CharacterGoWContext (DbContextOptions<CharacterGoWContext> options)
			: base(options)
		{
		}
		public DbSet<CharacterGoW> CharacterGoW {get; set;} = default!;
	}
}