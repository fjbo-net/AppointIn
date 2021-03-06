﻿using AppointIn.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AppointIn.Domain.Extensions;

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
				customer.Address.AsString(),
				customer.IsActive ? "Active" : "Inactive",
				customer.CreateDate.ToLocalTime().ToLongDateAndTimeString(),
				customer.CreatedBy,
				customer.LastUpdate.AsString(),
				customer.LastUpdateBy
			};

			return new ListViewItem(items);
		}

		// Using lambda expression to simplify function definition due to simplicity
		public static string AsString(this Customer customer)
			=> $"{customer.Name} [{Resources.DataPanelStrings.IdLabelText}: {customer.Id}]";
	}
}
