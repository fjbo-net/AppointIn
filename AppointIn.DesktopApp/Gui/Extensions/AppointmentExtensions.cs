using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
				appointment.Start.ToLocalTime().ToLongDateString(),
				appointment.End.ToLocalTime().ToLongDateString(),
				appointment.CreateDate.ToLocalTime().ToLongDateString(),
				appointment.CreatedBy,
				appointment.LastUpdate.ToString(),
				appointment.LastUpdateBy
			};

			return new ListViewItem(items);
		}
	}
}
