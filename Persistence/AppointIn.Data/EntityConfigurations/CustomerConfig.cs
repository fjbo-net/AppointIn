using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

using AppointIn.Domain.Entities;

namespace AppointIn.Data.EntityConfigurations
{
	public class CustomerConfig : EntityTypeConfiguration<Customer>
	{
		public CustomerConfig()
		{
			Property(customer => customer.Id)
				.IsRequired()
				.HasColumnName("customerId")
				.HasColumnType("int(1,999999999)");

			Property(customer => customer.Name)
				.IsRequired()
				.HasColumnName("customerName")
				.HasMaxLength(45);

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
				.IsConcurrencyToken()
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);

			Property(customer => customer.LastUpdateBy)
				.IsRequired()
				.HasColumnName("lastUpdateBy")
				.HasMaxLength(40);

			ToTable("customer");
		}
	}
}
