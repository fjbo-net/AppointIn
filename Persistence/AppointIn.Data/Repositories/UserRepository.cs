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

		public override IEnumerable<User> GetAll()
		{
			var users = _entityDbSet.ToList();
			foreach (var user in users)
			{
				//user.CreateDate = user.CreateDate.ToLocalTime();
			}

			return users;
		}
		public override User GetById(int id)
		{
			var user = _entityDbSet.Find(id);
			//user.CreateDate = user.CreateDate.ToLocalTime();
			return user;
		}
	}
}
