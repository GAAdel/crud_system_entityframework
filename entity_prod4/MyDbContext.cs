using entity_prod4.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entity_prod4
{
	public class MyDbContext : DbContext
	{
		public MyDbContext() : base("DbConnectionString")
		{

		}

		public DbSet<User> Users { get; set; }
		public DbSet<Role> Roles { get; set; }
		public DbSet<Office> Offices { get; set; }
		public DbSet<Country> Countries { get; set; }
		public DbSet<Log> Logs { get; set; }

	}
}
