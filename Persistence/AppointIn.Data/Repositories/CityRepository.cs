using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppointIn.Domain.Entities;

namespace AppointIn.Data.Repositories
{
	internal class CityRepository : GenericRepository<Domain.Entities.City, int>
	{
		public CityRepository(Context context) : base(context)
		{
		}

		public override IEnumerable<City> GetAll() => _entityDbSet.Include("Country").ToList();
	}
}
