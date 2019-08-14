using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppointIn.Domain.Entities;

namespace AppointIn.Data.Repositories
{
	internal class CustomerRepository : GenericRepository<Customer, int>
	{
		public CustomerRepository(Context context) : base(context)
		{
		}

		public override IEnumerable<Customer> GetAll()
		{
			var customers = _entityDbSet.ToList();
			foreach (var customer in customers)
			{
				customer.CreateDate = customer.CreateDate.ToLocalTime();
			}

			return customers;
		}
		public override Customer GetById(int id)
		{
			var customer = _entityDbSet.Find(id);
			customer.CreateDate = customer.CreateDate.ToLocalTime();
			return customer;
		}
	}
}
