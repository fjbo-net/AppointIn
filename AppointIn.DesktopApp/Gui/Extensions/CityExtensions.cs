using System.Windows.Forms;

using AppointIn.Domain.Entities;

namespace AppointIn.DesktopApp.Gui.Extensions
{
	public static class CityExtensions
	{
		public static ListViewItem ToListViewItem(this City city)
		{
			var items = new[]
			{
				city.Id.ToString(),
				city.Name,
				city.Country.Name,
				city.CreateDate.ToLocalTime().ToLongDateAndTimeString(),
				city.CreatedBy,
				city.LastUpdate.ToString(),
				city.LastUpdateBy
			};

			return new ListViewItem(items);
		}
	}
}
