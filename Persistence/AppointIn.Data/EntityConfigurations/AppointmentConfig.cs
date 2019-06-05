using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

using AppointIn.Domain.Entities;

namespace AppointIn.Data.EntityConfigurations
{
	public class AppointmentConfig : EntityTypeConfiguration<Appointment>
	{
		public AppointmentConfig()
		{
			Property(appointment => appointment.Id)
				.IsRequired()
				.HasColumnName("appointmentId");


			
			Property(appointment => appointment.Title)
				.IsRequired()
				.HasColumnName("title")
				.HasMaxLength(255);

			Property(appointment => appointment.Description)
				.HasColumnName("description")
				.HasColumnType("TEXT");

			Property(appointment => appointment.Location)
				.HasColumnName("location")
				.HasColumnType("TEXT");

			Property(appointment => appointment.Contact)
				.IsRequired()
				.HasColumnName("contact")
				.HasColumnType("TEXT");

			Property(appointment => appointment.Type)
				.HasColumnName("type")
				.HasColumnType("TEXT");

			Property(appointment => appointment.Url)
				.HasColumnName("url")
				.HasMaxLength(255);

			Property(appointment => appointment.Start)
				.HasColumnName("start");

			Property(appointment => appointment.End)
				.HasColumnName("end");

			Property(appointment => appointment.CreateDate)
				.IsRequired()
				.HasColumnName("createDate");

			Property(appointment => appointment.CreatedBy)
				.IsRequired()
				.HasColumnName("createdBy")
				.HasMaxLength(40);

			Property(appointment => appointment.LastUpdate)
				.HasColumnName("lastUpdate")
				.IsRowVersion();

			Property(appointment => appointment.LastUpdateBy)
				.IsRequired()
				.HasColumnName("lastUpdateBy")
				.HasMaxLength(40);


			HasRequired(appointment => appointment.Customer);
			HasRequired(appointment => appointment.User);

			ToTable("appointment");
		}
	}
}
