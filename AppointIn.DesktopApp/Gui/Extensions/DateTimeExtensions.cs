using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointIn.DesktopApp.Gui.Extensions
{
	public static class DateTimeExtensions
	{
		public static string ToLongDateAndTimeString(this DateTime date)
			=> $"{date.ToLongDateString()} {date.ToLongTimeString()}";

		public static string ToShortDateAndTimeString(this DateTime date)
			=> $"{date.ToShortDateString()} {date.ToShortTimeString()}";
	}
}
