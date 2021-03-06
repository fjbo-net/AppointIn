﻿using System.Windows.Forms;

using AppointIn.Domain.Extensions;
using AppointIn.Domain.Entities;

namespace AppointIn.DesktopApp.Gui.Extensions
{
	public static class CountryExtensions
	{
		public static ListViewItem ToListViewItem(this Country country)
		{
			var items = new[]
			{
				country.Id.ToString(),
				country.Name,
				country.CreateDate.ToLocalTime().ToLongDateAndTimeString(),
				country.CreatedBy,
				country.LastUpdate.AsString(),
				country.LastUpdateBy
			};

			return new ListViewItem(items);
		}
	}
}
