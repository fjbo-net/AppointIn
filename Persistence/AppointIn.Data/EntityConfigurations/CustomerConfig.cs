using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

using AppointIn.Domain.Entities;

namespace AppointIn.Data.EntityConfigurations
{
	public class CustomerConfig : EntityTypeConfiguration<Customer>
	{
		public CustomerConfig()
		{
			// Using lambda expressions to define EF's entity configuration using EF's fluid API
			Property(customer => customer.Id)
				.IsRequired()
				.HasColumnName("customerId");

			Property(customer => customer.Name)
				.IsRequired()
				.HasColumnName("customerName")
				.HasMaxLength(45);

			Property(customer => customer.AddressId)
				.IsRequired()
				.HasColumnName("addressId");

			Property(customer => customer.IsActive)
				.IsRequired()
				.HasColumnName("active");

			Property(customer => customer.CreateDate)
				.IsRequired()
				.HasColumnName("createDate");

			Property(customer => customer.CreatedBy)
				.IsRequired()
				.HasColumnName("createdBy")
				.HasMaxLength(40);

			Property(customer => customer.LastUpdate)
				.HasColumnName("lastUpdate")
				.IsRowVersion();

			Property(customer => customer.LastUpdateBy)
				.IsRequired()
				.HasColumnName("lastUpdateBy")
				.HasMaxLength(40);

			HasRequired(customer => customer.Address);

			HasKey(customer => customer.Id);

			ToTable("customer");
		}
	}
}
