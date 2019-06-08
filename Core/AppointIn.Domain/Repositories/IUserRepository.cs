using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointIn.Domain.Repositories
{
	public interface IUserRepository : IRepository<Entities.User, int>
	{
		Entities.User GetByUsername(string username);
	}
}
