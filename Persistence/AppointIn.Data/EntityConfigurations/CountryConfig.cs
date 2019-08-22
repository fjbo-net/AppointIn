using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

using AppointIn.Domain.Entities;

namespace AppointIn.Data.EntityConfigurations
{
	public class CountryConfig : EntityTypeConfiguration<Country>
	{
		public CountryConfig()
		{
			// Using lambda expressions to define EF's entity configuration using EF's fluid API
			Property(country => country.Id)
				.IsRequired()
				.HasColumnName("countryId");

			Property(country => country.Name)
				.IsRequired()
				.HasColumnName("country")
				.HasMaxLength(50);

			Property(country => country.CreateDate)
				.IsRequired()
				.HasColumnName("createDate");

			Property(country => country.CreatedBy)
				.IsRequired()
				.HasColumnName("createBy")
				.HasMaxLength(40);

			Property(country => country.LastUpdate)
				.HasColumnName("lastUpdate")
				.IsRowVersion();

			Property(country => country.LastUpdateBy)
				.IsRequired()
				.HasColumnName("lastUpdateBy")
				.HasMaxLength(40);

			HasKey(country => country.Id);

			//HasMany(country => country.Cities)
			//	.WithRequired(city => city.Country)
			//	.HasForeignKey(city => city.CountryId);

			ToTable("country");
		}
	}
}
