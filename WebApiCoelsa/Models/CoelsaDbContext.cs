using Microsoft.EntityFrameworkCore;

namespace WebApiCoelsa.Models
{
	public class CoelsaDbContext : DbContext
	{
		public CoelsaDbContext(DbContextOptions<CoelsaDbContext> options) : base(options)
		{

		}

		public DbSet<Contact> Contacts { get; set; }
	}
}
