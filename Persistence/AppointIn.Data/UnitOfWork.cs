using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppointIn.Domain;
using AppointIn.Domain.Entities;
using AppointIn.Domain.Repositories;
using AppointIn.Data.Repositories;

namespace AppointIn.Data
{
	public class UnitOfWork : IUnitOfWork
	{
		private UnitOfWork()
		{
			_context = new Context();
		}

		private static UnitOfWork _instance;
		public static UnitOfWork Data
		{
			get
			{
				if (_instance == null) _instance = new UnitOfWork();
				return _instance;
			}
		}


		#region Context
		private Context _context;


		public void Save() => _context.SaveChanges();
		#endregion
		
		#region Repositories
		private IRepository<Address, int> _addresses;
		public IRepository<Address, int> Addresses
		{
			get
			{
				if (_addresses == null) _addresses = new GenericRepository<Address, int>(_context);
				return _addresses;
			}
		}

		public IRepository<Appointment, int> _appointments;
		public IRepository<Appointment, int> Appointments
		{
			get
			{
				if (_appointments == null) _appointments = new GenericRepository<Appointment, int>(_context);
				return _appointments;
			}
		}

		public IRepository<City, int> _cities;
		public IRepository<City, int> Cities
		{
			get
			{
				if (_cities == null) _cities = new GenericRepository<City, int>(_context);
				return _cities;
			}
		}

		public IRepository<Country, int> _countries;
		public IRepository<Country, int> Countries
		{
			get
			{
				if (_countries == null) _countries = new GenericRepository<Country, int>(_context);
				return _countries;
			}
		}

		public IRepository<Customer, int> _customers;
		public IRepository<Customer, int> Customers
		{
			get
			{
				if (_customers == null) new GenericRepository<Customer, int>(_context);
				return _customers;
			}
		}

		public IUserRepository _users;
		public IUserRepository Users
		{
			get
			{
				if (_users == null) _users = new UserRepository(_context);
				return _users;
			}
		}
		#endregion

		#region IDisposable
		private bool _disposed = false;


		protected virtual void Dispose(bool disposing)
		{
			if(!_disposed)
			{
				if (disposing) _context.Dispose();
			}
			_disposed = true;
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
		#endregion
	}
}
