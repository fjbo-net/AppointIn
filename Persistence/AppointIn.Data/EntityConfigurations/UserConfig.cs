using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

using AppointIn.Domain.Entities;

namespace AppointIn.Data.EntityConfigurations
{
	public class UserConfig:EntityTypeConfiguration<User>
	{
		public UserConfig()
		{
			Property(user => user.Id)
				.IsRequired()
				.HasColumnName("userId");

			Property(user => user.Username)
				.IsRequired()
				.HasColumnName("userName")
				.HasMaxLength(50);

			Property(user => user.Password)
				.IsRequired()
				.HasColumnName("password")
				.HasMaxLength(50);

			Property(user => user.IsActive)
				.IsRequired()
				.HasColumnName("active");

			Property(user => user.CreateDate)
				.IsRequired()
				.HasColumnName("createDate");

			Property(user => user.CreatedBy)
				.IsRequired()
				.HasColumnName("createdBy")
				.HasMaxLength(40);

			Property(user => user.LastUpdate)
				.HasColumnName("lastUpdate")
				.IsRowVersion();

			Property(user => user.LastUpdateBy)
				.IsRequired()
				.HasColumnName("lastUpdateBy")
				.HasMaxLength(40);

			ToTable("user");
		}
	}
}
