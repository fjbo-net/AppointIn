using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppointIn.Domain.Entities;

namespace AppointIn.DesktopApp.Gui.Extensions
{
	public static class UserExtensions
	{
		// Using lambda expression to simplify function definition due to simplicity
		public static string AsString(this User user) => user.Username;
	}
}
