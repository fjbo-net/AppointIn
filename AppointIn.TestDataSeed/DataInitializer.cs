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
					foreach (var user in GenerateUsers())
					{
						UnitOfWork.Data.Users.Insert(user);
					}

					UnitOfWork.Data.Save();
				}

				if (!DataBaseHasInitializedCountries())
				{
					foreach (var country in GetCountries())
					{
						UnitOfWork.Data.Countries.Insert(country);
					}

					UnitOfWork.Data.Save();
				}

				if(!DataBaseHasInitializedCities())
				{
					foreach (var city in GenerateCities())
					{
						UnitOfWork.Data.Cities.Insert(city);
					}

					UnitOfWork.Data.Save();
				}

				if(!DataBaseHasInitializedAddresses())
				{
					foreach(var address in GenerateAddresses())
					{
						UnitOfWork.Data.Addresses.Insert(address);
					}

					UnitOfWork.Data.Save();
				}

				if(!DataBaseHasInitializedCustomers())
				{
					foreach(var customer in GenerateCustomers())
					{
						UnitOfWork.Data.Customers.Insert(customer);
					}

					UnitOfWork.Data.Save();
				}

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
		{
			var hasUsers = DataBaseHasInitializedUsers();
			var hasCountries = DataBaseHasInitializedCountries();
			var hasCities = DataBaseHasInitializedCities();
			var hasAddresses = DataBaseHasInitializedAddresses();
			var hasCustomers = DataBaseHasInitializedCustomers();

			return !hasUsers && !hasCountries && !hasCities && !hasAddresses && !hasCustomers;
		}
	}
}
