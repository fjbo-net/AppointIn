using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppointIn.Domain.Entities;

namespace AppointIn.Data.Repositories
{
	internal class UserRepository : GenericRepository<Domain.Entities.User, int>, Domain.Repositories.IUserRepository
	{
		public UserRepository(Context context) : base(context)
		{
		}

		// Using lambda expression to simplify call to an object property's method
		public User GetByUsername(string username)
			=> _entityDbSet
				// Using lambdas for LINQ's lambda expression notation
				.Where(user => user.Username == username)
				.SingleOrDefault();
		
		// Using lambda expression to simplify call to an object property's method
		public override IEnumerable<User> GetAll() => _entityDbSet.ToList();

		// Using lambda expression to simplify call to an object property's method
		public override User GetById(int id) => _entityDbSet.Find(id);
	}
}
