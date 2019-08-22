using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointIn.DesktopApp.Gui.Extensions
{
	public static class DateTimeExtensions
	{
		// Using lambda expression to simplify function definition due to simplicity
		public static string ToLongDateAndTimeString(this DateTime date)
			=> $"{date.ToLongDateString()} {date.ToLongTimeString()}";

		// Using lambda expression to simplify function definition due to simplicity
		public static string ToShortDateAndTimeString(this DateTime date)
			=> $"{date.ToShortDateString()} {date.ToShortTimeString()}";
	}
}
