using Microsoft.EntityFrameworkCore;

namespace Final_Project_GoW.Models
{
	public class GodofWarDbContext : DbContext
	{
		public GodofWarDbContext (DbContextOptions<BlogDbContext> options)
			: base(options)
		{
		}
		public DbSet<Blog> Blogs {get; set;} = default!;
	}
}
