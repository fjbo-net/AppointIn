using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppointIn.Data;
using AppointIn.Domain.Entities;

namespace AppointIn.TestDataSeed
{
	public partial class DataInitializer
	{
		private static ICollection<Country> Countries { get; } = GenerateCountries(new List<string>() {
			"United States",
			"Canada",
			"Mexico"
		});

		
		public static bool DataBaseHasInitializedCountries(UnitOfWork segmentOfWork)
			=> segmentOfWork.Countries.GetAll().Any();

		public static Country GenerateCountry(int id, string name) => new Country()
		{
			Id = id,
			Name = name,
			CreateDate = DateTime.Now,
			CreatedBy = "DataInitializer",
			LastUpdateBy = "DataInitializer"
		};

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

		public static ICollection<Country> GetCountries() => Countries;

		
		public class CountryMockRepository : GenericMockRepository<Country, int>
		{
			public CountryMockRepository(ICollection<Country> data) : base(data)
			{

			}
		}
	}
}
