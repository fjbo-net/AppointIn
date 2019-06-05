using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointIn.Data
{
	public static class ConnectionSettings
	{
		//public static string ConnectionString = ConfigurationManager.ConnectionStrings["AppointInContext"].ConnectionString;
		public static string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FjboAppointIn;Integrated Security=True;MultipleActiveResultSets=True";
	}
}
