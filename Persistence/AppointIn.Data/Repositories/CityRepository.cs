using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppointIn.Domain.Entities;

namespace AppointIn.Data.Repositories
{
	internal class CityRepository : GenericRepository<City, int>
	{
		public CityRepository(Context context) : base(context)
		{
		}

		public override IEnumerable<City> GetAll()
		{
			var cities = _entityDbSet.ToList();
			foreach (var city in cities)
			{
				city.CreateDate = city.CreateDate.ToLocalTime();
			}

			return cities;
		}
		public override City GetById(int id)
		{
			var city = _entityDbSet.Find(id);
			city.CreateDate = city.CreateDate.ToLocalTime();
			return city;
		}
	}
}
