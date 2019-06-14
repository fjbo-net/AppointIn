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

		public User GetByUsername(string username) => _entityDbSet.Where(user => user.Username == username).SingleOrDefault();
	}
}
