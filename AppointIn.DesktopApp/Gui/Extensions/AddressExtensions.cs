using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AppointIn.Domain.Entities;

namespace AppointIn.DesktopApp.Gui.Extensions
{
	public static class AddressExtensions
	{
		public static ListViewItem ToListViewItem(this Address address)
		{
			var items = new[]
			{
				address.Id.ToString(),
				address.StreetName,
				address.BuildingOrInterior,
				address.City.Name,
				address.PostalCode,
				address.Phone,
				address.CreateDate.ToLongDateString(),
				address.CreatedBy,
				address.LastUpdate.ToString(),
				address.LastUpdateBy
			};

			return new ListViewItem(items);
		}

		public static string AsString(this Address address)
		{
			if (!string.IsNullOrWhiteSpace(address.StreetName)
				&& !string.IsNullOrWhiteSpace(address.City.Name)
				&& !string.IsNullOrWhiteSpace(address.City.Country.Name))
			{
				return $"{address.StreetName}{(!string.IsNullOrWhiteSpace(address.BuildingOrInterior) ? $" {address.BuildingOrInterior}" : string.Empty )}, {address.City.Name}, {address.City.Country.Name}";
			}
			return "[Empty]";
		}
	}
}
