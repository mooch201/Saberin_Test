using Microsoft.EntityFrameworkCore;
using Saberin_Test.Data.Models;

namespace Saberin_Test.Data.Context
{
	public class ApiContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseInMemoryDatabase(databaseName: "ContactDb");
		}
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<Address> Addresses { get; set; }
	}
}