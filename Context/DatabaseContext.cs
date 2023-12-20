using Microsoft.EntityFrameworkCore;
using Mud_Blazor.Data;

namespace Mud_Blazor.Context
{
	public class DatabaseContext : DbContext
	{

		public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) {
		}

		public DbSet <Customer> Customers { get; set; }
	}
}
