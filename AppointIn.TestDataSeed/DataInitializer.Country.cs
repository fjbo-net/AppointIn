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
		private static ICollection<Country> Countries { get; } = GenerateCountries(new List<string>() {
			"Argentina",
			"Austria",
			"Belgium",
			"Brazil",
			"Canada",
			"Denmark",
			"Finland",
			"France",
			"Germany",
			"Ireland",
			"Italy",
			"Mexico",
			"Norway",
			"Poland",
			"Portugal",
			"Spain",
			"Sweden",
			"Switzerland",
			"UK",
			"USA",
			"Venezuela"
		});


		// Using lambda expression to simplify function definition due to simplicity
		public static bool DataBaseHasInitializedCountries()
			=> UnitOfWork.Data.Countries.GetAll().Any();

		public static Country GenerateCountry(int id, string name)
		{
			var now = DateTime.Now;
			var nowUtc = DateTime.UtcNow;

			return new Country()
			{
				Id = id,
				Name = name,
				CreateDate = nowUtc,
				CreatedBy = "DataInitializer",
				LastUpdateBy = "DataInitializer"
			};
		}

		public static List<Country> GenerateCountries(IEnumerable<string> countryNames)
		{
			var output = new List<Country>();

			foreach(var name in countryNames) {
				if(!output.Any(country => country.Name.Equals(name, StringComparison.OrdinalIgnoreCase))) {
					output.Add(GenerateCountry(output.Count + 1, name));
				}
			}

			return output;
		}

		// Using lambda expressino to simplify function return value reference
		public static ICollection<Country> GetCountries() => Countries;


		public class CountryMockRepository : GenericMockRepository<Country, int>
		{
			public CountryMockRepository(ICollection<Country> data) : base(data)
			{

			}
		}
	}
}
