using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppointIn.Domain.Entities;
using AppointIn.Domain.Repositories;

namespace AppointIn.Domain
{
	public interface IUnitOfWork : IDisposable
	{
		IRepository<Address,int> Addresses { get; }
		IRepository<Appointment,int> Appointments { get; }
		IRepository<City,int> Cities { get; }
		IRepository<Country,int> Countries { get; }
		IRepository<Customer,int> Customers { get; }
		IUserRepository Users { get; }
	}
}
