using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppointIn.Data;
using AppointIn.Domain.Entities;

namespace AppointIn.TestDataSeed
{
	public static partial class DataInitializer
	{
		//private static ICollection<City> Cities { get; } = GenerateCities();

		public static ICollection<City> GenerateCities()
		{
			var countries = UnitOfWork.Data.Countries.GetAll();
			var now = DateTime.Now;
			var nowUtc = now.ToUniversalTime();

			/* 
			 * Okay, this is a pretty weird way to initialize the cities,
			 * but I am using a SQL query to build the text to create the table
			 * items from a customers demo table from w3schools, but was faster
			 * to filter here using Linq than figuring it out to do it in SQL...
			 */

			var cityCollection = new List<City>()
			{
				new City() { Name = "Berlin", Country = countries.Where(country => country.Name == "Germany").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "CDMX", Country = countries.Where(country => country.Name == "Mexico").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "CDMX", Country = countries.Where(country => country.Name == "Mexico").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "London", Country = countries.Where(country => country.Name == "UK").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Luleå", Country = countries.Where(country => country.Name == "Sweden").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Mannheim", Country = countries.Where(country => country.Name == "Germany").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Strasbourg", Country = countries.Where(country => country.Name == "France").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Madrid", Country = countries.Where(country => country.Name == "Spain").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Marseille", Country = countries.Where(country => country.Name == "France").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Tsawassen", Country = countries.Where(country => country.Name == "Canada").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "London", Country = countries.Where(country => country.Name == "UK").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Buenos Aires", Country = countries.Where(country => country.Name == "Argentina").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "CDMX", Country = countries.Where(country => country.Name == "Mexico").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Bern", Country = countries.Where(country => country.Name == "Switzerland").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "São Paulo", Country = countries.Where(country => country.Name == "Brazil").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "London", Country = countries.Where(country => country.Name == "UK").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Aachen", Country = countries.Where(country => country.Name == "Germany").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Nantes", Country = countries.Where(country => country.Name == "France").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "London", Country = countries.Where(country => country.Name == "UK").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Graz", Country = countries.Where(country => country.Name == "Austria").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "São Paulo", Country = countries.Where(country => country.Name == "Brazil").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Madrid", Country = countries.Where(country => country.Name == "Spain").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Lille", Country = countries.Where(country => country.Name == "France").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Bräcke", Country = countries.Where(country => country.Name == "Sweden").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "München", Country = countries.Where(country => country.Name == "Germany").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Nantes", Country = countries.Where(country => country.Name == "France").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Torino", Country = countries.Where(country => country.Name == "Italy").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Lisboa", Country = countries.Where(country => country.Name == "Portugal").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Barcelona", Country = countries.Where(country => country.Name == "Spain").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Sevilla", Country = countries.Where(country => country.Name == "Spain").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Campinas", Country = countries.Where(country => country.Name == "Brazil").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Eugene", Country = countries.Where(country => country.Name == "USA").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Caracas", Country = countries.Where(country => country.Name == "Venezuela").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Rio de Janeiro", Country = countries.Where(country => country.Name == "Brazil").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "San Cristóbal", Country = countries.Where(country => country.Name == "Venezuela").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Elgin", Country = countries.Where(country => country.Name == "USA").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Cork", Country = countries.Where(country => country.Name == "Ireland").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Cowes", Country = countries.Where(country => country.Name == "UK").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Brandenburg", Country = countries.Where(country => country.Name == "Germany").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Versailles", Country = countries.Where(country => country.Name == "France").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Toulouse", Country = countries.Where(country => country.Name == "France").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Vancouver", Country = countries.Where(country => country.Name == "Canada").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Walla Walla", Country = countries.Where(country => country.Name == "USA").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Frankfurt a.M. ", Country = countries.Where(country => country.Name == "Germany").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "San Francisco", Country = countries.Where(country => country.Name == "USA").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Barquisimeto", Country = countries.Where(country => country.Name == "Venezuela").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "I. de Margarita", Country = countries.Where(country => country.Name == "Venezuela").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Portland", Country = countries.Where(country => country.Name == "USA").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Bergamo", Country = countries.Where(country => country.Name == "Italy").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Bruxelles", Country = countries.Where(country => country.Name == "Belgium").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Montréal", Country = countries.Where(country => country.Name == "Canada").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Leipzig", Country = countries.Where(country => country.Name == "Germany").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "London", Country = countries.Where(country => country.Name == "UK").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Buenos Aires", Country = countries.Where(country => country.Name == "Argentina").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Anchorage", Country = countries.Where(country => country.Name == "USA").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Köln", Country = countries.Where(country => country.Name == "Germany").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Paris", Country = countries.Where(country => country.Name == "France").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "CDMX", Country = countries.Where(country => country.Name == "Mexico").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Salzburg", Country = countries.Where(country => country.Name == "Austria").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Lisboa", Country = countries.Where(country => country.Name == "Portugal").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Rio de Janeiro", Country = countries.Where(country => country.Name == "Brazil").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "São Paulo", Country = countries.Where(country => country.Name == "Brazil").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Cunewalde", Country = countries.Where(country => country.Name == "Germany").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Buenos Aires", Country = countries.Where(country => country.Name == "Argentina").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Albuquerque", Country = countries.Where(country => country.Name == "USA").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Reggio Emilia", Country = countries.Where(country => country.Name == "Italy").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Rio de Janeiro", Country = countries.Where(country => country.Name == "Brazil").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Genève", Country = countries.Where(country => country.Name == "Switzerland").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Madrid", Country = countries.Where(country => country.Name == "Spain").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Stavern", Country = countries.Where(country => country.Name == "Norway").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Boise", Country = countries.Where(country => country.Name == "USA").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "London", Country = countries.Where(country => country.Name == "UK").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "København", Country = countries.Where(country => country.Name == "Denmark").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Paris", Country = countries.Where(country => country.Name == "France").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Lander", Country = countries.Where(country => country.Name == "USA").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Charleroi", Country = countries.Where(country => country.Name == "Belgium").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Portland", Country = countries.Where(country => country.Name == "USA").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Butte", Country = countries.Where(country => country.Name == "USA").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Münster", Country = countries.Where(country => country.Name == "Germany").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "CDMX", Country = countries.Where(country => country.Name == "Mexico").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "São Paulo", Country = countries.Where(country => country.Name == "Brazil").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Kirkland", Country = countries.Where(country => country.Name == "USA").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Århus", Country = countries.Where(country => country.Name == "Denmark").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Lyon", Country = countries.Where(country => country.Name == "France").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Reims", Country = countries.Where(country => country.Name == "France").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Stuttgart", Country = countries.Where(country => country.Name == "Germany").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Oulu", Country = countries.Where(country => country.Name == "Finland").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Resende", Country = countries.Where(country => country.Name == "Brazil").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Seattle", Country = countries.Where(country => country.Name == "USA").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Helsinki", Country = countries.Where(country => country.Name == "Finland").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" },
				new City() { Name = "Walla", Country = countries.Where(country => country.Name == "Poland").Single(), CreateDate = nowUtc, CreatedBy = "DataInitializer", LastUpdateBy = "DataInitializer" }
			};

			// Using lambdas for LINQ's lambda expression notation
			var distinctCityNames = cityCollection.Select(city => city.Name).Distinct();

			var output = new List<City>();

			foreach(var city in cityCollection)
			{
				if (distinctCityNames.Contains(city.Name))
				{
					output.Add(city);
				}

				// Using lambdas for LINQ's lambda expression notation
				distinctCityNames = distinctCityNames.Where(cityName=> cityName != city.Name);
			}

			return output;
		}


		// Using lambda expression to simplify call to an object property's method
		public static bool DataBaseHasInitializedCities()
			=> UnitOfWork.Data.Cities.GetAll().Any();
	}
}
