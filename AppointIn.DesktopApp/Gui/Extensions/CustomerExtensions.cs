using AppointIn.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointIn.DesktopApp.Gui.Extensions
{
	public static class CustomerExtensions
	{
		public static ListViewItem ToListViewItem(this Customer customer)
		{
			var items = new[]
			{
				customer.Id.ToString(),
				customer.Name,
				customer.Address.ToString(),
				customer.CreateDate.ToLocalTime().ToLongDateString()
			};

			return new ListViewItem(items);
		}
	}
}
