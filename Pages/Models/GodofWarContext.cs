using Microsoft.EntityFrameworkCore;

namespace Final_Project_GoW.Models
{
	public class GodofWarContext : DbContext
	{
		public GodofWarContext (DbContextOptions<GodofWarContext> options)
			: base(options)
		{
		}
		public DbSet<Professor> Professor {get; set;} = default!;
	}
}