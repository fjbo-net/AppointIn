using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

using AppointIn.Domain.Entities;

namespace AppointIn.Data.EntityConfigurations
{
	public class CityConfig:EntityTypeConfiguration<City>
	{
		public CityConfig()
		{
			Property(city => city.Id)
				.IsRequired()
				.HasColumnName("cityId")
				.HasColumnType("int(1,999999999");

			Property(city => city.Name)
				.IsRequired()
				.HasColumnName("city")
				.HasMaxLength(50);

			Property(city => city.CreateDate)
				.IsRequired()
				.HasColumnName("createDate");

			Property(city => city.CreatedBy)
				.IsRequired()
				.HasColumnName("createdBy")
				.HasMaxLength(40);

			Property(city => city.LastUpdate)
				.HasColumnName("lastUpdate")
				.IsConcurrencyToken()
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);

			Property(city => city.LastUpdateBy)
				.IsRequired()
				.HasColumnName("lastUpdateBy")
				.HasMaxLength(40);

			ToTable("city");
		}
	}
}
