using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

using AppointIn.Domain.Entities;

namespace AppointIn.Data.EntityConfigurations
{
	public class CountryConfig : EntityTypeConfiguration<Country>
	{
		public CountryConfig()
		{
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

			Property(country => country.LasUpdateBy)
				.IsRequired()
				.HasColumnName("lastUpdateBy")
				.HasMaxLength(40);

			ToTable("country");
		}
	}
}
