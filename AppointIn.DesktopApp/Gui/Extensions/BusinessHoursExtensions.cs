using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppointIn.Domain.Classes;
using AppointIn.Domain.Extensions;

namespace AppointIn.DesktopApp.Gui.Extensions
{
	public static class BusinessHoursExtensions
	{
		public static string AsString(this Dictionary<DayOfWeek, List<TimeRange>> businessHours)
		{
			var output = new StringBuilder();

			foreach(var day in businessHours)
			{
				output.Append($"{day.Key.ToString()}:{day.Value.AsString()}.{Environment.NewLine}");
			}

			return output.ToString().Trim();
		}
	}
}
