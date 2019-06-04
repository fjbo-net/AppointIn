using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppointIn.Domain.Entities;
using AppointIn.Data.EntityConfigurations;

namespace AppointIn.Data
{
	public class Context : DbContext
	{
		public Context()
		{
			Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Context>());
		}

		public DbSet<Address> Addresses { get; set; }
		public DbSet<Appointment> Appointments { get; set; }
		public DbSet<City> Cities { get; set; }
		public DbSet<Country> Countries { get; set; }
		public DbSet<Customer> Customers { get; set; }
		public DbSet<User> Users { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Configurations.Add(new AddressConfig());
			modelBuilder.Configurations.Add(new AppointmentConfig());
			modelBuilder.Configurations.Add(new CityConfig());
			modelBuilder.Configurations.Add(new CountryConfig());
			modelBuilder.Configurations.Add(new CustomerConfig());
			modelBuilder.Configurations.Add(new UserConfig());
		}
	}
}
