using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppointIn.Domain.Entities;
using AppointIn.Data;

namespace AppointIn.TestDataSeed
{
	public static partial class DataInitializer
	{
		public static string Username { get; } = "DataInitializer";

		public static bool DataSeedDatabase()
		{
			try
			{
				if (!DataBaseHasInitializedUsers())
				{
					foreach (var user in GetUsers())
					{
						UnitOfWork.Data.Users.Insert(user);
					}
				}

				if (!DataBaseHasInitializedCountries())
				{
					foreach (var country in GetCountries())
					{
						UnitOfWork.Data.Countries.Insert(country);
					}
				}

				UnitOfWork.Data.Save();

				return true;

			} catch (Exception e)
			{
				Console.WriteLine($"Exception'{nameof(e)}' encountered:");
				Console.WriteLine(e.Message);
				Console.WriteLine(e.StackTrace);

				return false;
			}
		}

		public static bool NeedsDataInitialization() 
			=> !(DataBaseHasInitializedCountries() 
				&& DataBaseHasInitializedUsers());
	}
}
