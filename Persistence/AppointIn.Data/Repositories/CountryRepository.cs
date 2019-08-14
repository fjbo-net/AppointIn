using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppointIn.Domain.Entities;

namespace AppointIn.Data.Repositories
{
	internal class CountryRepository : GenericRepository<Country, int>
	{
		public CountryRepository(Context context) : base(context)
		{
		}

		public override IEnumerable<Country> GetAll()
		{
			var countries = _entityDbSet.ToList();
			foreach (var country in countries)
			{
				country.CreateDate = country.CreateDate.ToLocalTime();
			}

			return countries;
		}
		public override Country GetById(int id)
		{
			var country = _entityDbSet.Find(id);
			country.CreateDate = country.CreateDate.ToLocalTime();
			return country;
		}
	}
}
