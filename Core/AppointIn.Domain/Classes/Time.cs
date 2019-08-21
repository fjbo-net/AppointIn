using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointIn.Domain.Classes
{
	public class Time
	{
		public Time(int hour, int minute)
		{
			Hour = hour;
			Minute = minute;
		}

		public int Hour { get; private set; }
		public int Minute { get; private set; }
	}
}
