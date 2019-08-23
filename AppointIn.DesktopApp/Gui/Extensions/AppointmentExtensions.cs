using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AppointIn.Domain.Extensions;
using AppointIn.Domain.Entities;

namespace AppointIn.DesktopApp.Gui.Extensions
{
	public static class AppointmentExtensions
	{
		public static ListViewItem ToListViewItem(this Appointment appointment)
		{
			var items = new[]
			{
				appointment.Id.ToString(),
				appointment.Customer != null ? appointment.Customer.Name : "",
				appointment.User != null ? appointment.User.Username : "",
				appointment.Title,
				appointment.Description,
				appointment.Location,
				appointment.Contact,
				appointment.Type,
				appointment.Url,
				appointment.Start.ToLocalTime().ToShortDateAndTimeString(),
				appointment.End.ToLocalTime().ToShortDateAndTimeString(),
				appointment.CreateDate.ToLocalTime().ToLongDateAndTimeString(),
				appointment.CreatedBy,
				appointment.LastUpdate.AsString(),
				appointment.LastUpdateBy
			};

			return new ListViewItem(items);
		}

		public static string ToLocalString(this Appointment appointment)
		{
			var builder = new StringBuilder();

			builder.AppendLine($"{Resources.ReportFormStrings.AppointmentNounSingular.ToUpper()} {Resources.DataPanelStrings.IdLabelText}: {appointment.Id}");
			builder.AppendLine($"\t{Resources.AppointmentDataPanelStrings.CustomerLabelText}: {appointment.Customer.AsString()}");
			builder.AppendLine($"\t{Resources.AppointmentDataPanelStrings.UserLabelText}: {appointment.User.AsString()}");
			builder.AppendLine($"\t{Resources.AppointmentDataPanelStrings.TitleLabelText}: {appointment.Title}");
			builder.AppendLine($"\t{Resources.AppointmentDataPanelStrings.DescriptionLabelText}: {appointment.Description}");
			builder.AppendLine($"\t{Resources.AppointmentDataPanelStrings.LocationLabelText}: {appointment.Location}");
			builder.AppendLine($"\t{Resources.AppointmentDataPanelStrings.ContactLabelText}: {appointment.Contact}");
			builder.AppendLine($"\t{Resources.AppointmentDataPanelStrings.TypeLabelText}: {appointment.Type}");
			builder.AppendLine($"\t{Resources.AppointmentDataPanelStrings.UrlLabelText}: {appointment.Url}");
			builder.AppendLine($"\t{Resources.AppointmentDataPanelStrings.StartLabelText}: {appointment.Start.ToLocalTime().ToLongDateAndTimeString()}");
			builder.AppendLine($"\t{Resources.AppointmentDataPanelStrings.EndLabelText}: {appointment.End.ToLocalTime().ToLongDateAndTimeString()}");
			builder.AppendLine($"\t{Resources.DataPanelStrings.CreateDateLabelText}: {appointment.CreateDate.ToLocalTime().ToLongDateAndTimeString()}");
			builder.AppendLine($"\t{Resources.DataPanelStrings.CreatedByLabelText}: {appointment.CreatedBy}");
			builder.AppendLine($"\t{Resources.DataPanelStrings.LastUpdateLabelText}: {appointment.LastUpdate}");
			builder.AppendLine($"\t{Resources.DataPanelStrings.LastUpdateByLabelText}: {appointment.LastUpdateBy}");
			builder.AppendLine();

			return builder.ToString();
		}
	}
}
