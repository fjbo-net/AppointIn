using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppointIn.Domain.Entities;

namespace AppointIn.Data.Repositories
{
	internal class AddressRepository:GenericRepository<Address, int>
	{
		public AddressRepository(Context context) : base(context)
		{
			
		}

		public override IEnumerable<Address> GetAll()
		{
			var addresses = _entityDbSet.ToList();
			foreach(var address in addresses)
			{
				address.CreateDate = address.CreateDate;
			}

			return addresses;
		}
		public override Address GetById(int id)
		{
			var address = _entityDbSet.Find(id);
			address.CreateDate = address.CreateDate;
			return address;
		}
		public override void Insert(Address entity) => _entityDbSet.Add(entity);
	}
}
