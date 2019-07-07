using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

using AppointIn.Domain.Entities;

namespace AppointIn.Data.EntityConfigurations
{
	public class AddressConfig : EntityTypeConfiguration<Address>
	{
		public AddressConfig()
		{
			Property(address => address.Id)
				.IsRequired()
				.HasColumnName("addressId");

			Property(address => address.StreetName)
				.IsRequired()
				.HasColumnName("address")
				.HasMaxLength(50);

			Property(address => address.BuildingOrInterior)
				.IsOptional()
				.HasColumnName("address2")
				.HasMaxLength(50);

			Property(address => address.CityId)
				.IsRequired()
				.HasColumnName("cityId");

			Property(address => address.PostalCode)
				.IsRequired()
				.HasColumnName("postalCode")
				.HasMaxLength(10);

			Property(address => address.Phone)
				.IsRequired()
				.HasColumnName("phone")
				.HasMaxLength(20);

			Property(address => address.CreateDate)
				.IsRequired()
				.HasColumnName("createDate");

			Property(address => address.CreatedBy)
				.IsRequired()
				.HasColumnName("createBy")
				.HasMaxLength(40);

			Property(address => address.LastUpdate)
				.HasColumnName("lastUpdate")
				.IsRowVersion();

			Property(address => address.LastUpdateBy)
				.IsRequired()
				.HasColumnName("lastUpdateBy")
				.HasMaxLength(40);

			HasRequired(address => address.City);

			HasKey(address => address.Id);

			ToTable("address");
		}
	}
}
