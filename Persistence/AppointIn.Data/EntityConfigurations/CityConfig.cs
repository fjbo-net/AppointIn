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
				.HasColumnName("cityId");

			Property(city => city.Name)
				.IsRequired()
				.HasColumnName("city")
				.HasMaxLength(50);

			Property(city => city.CountryId)
				.IsRequired()
				.HasColumnName("countryId");
			
			Property(city => city.CreateDate)
				.IsRequired()
				.HasColumnName("createDate");

			Property(city => city.CreatedBy)
				.IsRequired()
				.HasColumnName("createdBy")
				.HasMaxLength(40);

			Property(city => city.LastUpdate)
				.HasColumnName("lastUpdate")
				.IsRowVersion();

			Property(city => city.LastUpdateBy)
				.IsRequired()
				.HasColumnName("lastUpdateBy")
				.HasMaxLength(40);

			HasRequired(city => city.Country);

			HasKey(city => city.Id);
			
			ToTable("city");
		}
	}
}
