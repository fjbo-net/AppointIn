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

		public static bool DataSeedDatabase(UnitOfWork workSegment)
		{
			try
			{
				if (!DataBaseHasInitializedUsers(workSegment))
				{
					foreach (var user in GetUsers())
					{
						workSegment.Users.Insert(user);
					}
				}

				if (!DataBaseHasInitializedCountries(workSegment))
				{
					foreach (var country in GetCountries())
					{
						workSegment.Countries.Insert(country);
					}
				}

				workSegment.Save();

				return true;

			} catch (Exception e)
			{
				Console.WriteLine($"Exception'{nameof(e)}' encountered:");
				Console.WriteLine(e.Message);
				Console.WriteLine(e.StackTrace);

				return false;
			}
		}

		public static bool NeedsDataInitialization(UnitOfWork segmentOfWork) 
			=> !(DataBaseHasInitializedCountries(segmentOfWork) 
				&& DataBaseHasInitializedUsers(segmentOfWork));
	}
}
