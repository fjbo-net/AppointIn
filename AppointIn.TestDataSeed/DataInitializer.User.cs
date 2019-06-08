using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppointIn.Domain.Entities;

namespace AppointIn.TestDataSeed
{
	public static partial class DataInitializer
	{
		private static ICollection<User> Users { get; } = new List<User>()
		{
			new User()
			{
				Id = 1,
				Username = "test",
				Password = "test",
				CreateDate = DateTime.Now,
				CreatedBy = "System",
				IsActive = true,
				LastUpdateBy = "System"
			},
			
			new User()
			{
				Id = 2,
				Username = "fjbo",
				Password = "MyPass123",
				CreateDate = DateTime.Now,
				CreatedBy = "System",
				IsActive = true,
				LastUpdateBy = "System"
			}
		};


		public static ICollection<User> GetUsers() => Users;


		public class UserMockRepository : GenericMockRepository<User, int>, Domain.Repositories.IUserRepository
		{
			public UserMockRepository(ICollection<User> data) : base(data)
			{

			}

			public User GetByUsername(string username) => _data.Where(entity => entity.Username == username).Single();
		}
	}
}
