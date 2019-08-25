using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppointIn.Data;
using AppointIn.Domain.Entities;

namespace AppointIn.TestDataSeed
{
	public static partial class DataInitializer
	{
		// Using lambda expression to simplify function definition due to simplicity
		public static bool DataBaseHasInitializedUsers()
			=> UnitOfWork.Data.Users.GetAll().Any();

		public class UserMockRepository : GenericMockRepository<User, int>, Domain.Repositories.IUserRepository
		{
			public UserMockRepository(ICollection<User> data) : base(data)
			{

			}

			// Using lambda expression to simplify call to an object property's method
			public User GetByUsername(string username) => _data.Where(entity => entity.Username == username).Single();
		}

		public static ICollection<User> GenerateUsers()
		{
			var newCities = new List<User>()
			{
				new User()
				{
					Id = 1,
					Username = "test",
					Password = "test",
					CreateDate = DateTime.Now.ToUniversalTime(),
					CreatedBy = "DataInitializer",
					IsActive = true,
					LastUpdateBy = "DataInitializer"
				},

				new User()
				{
					Id = 2,
					Username = "sales",
					Password = "test",
					CreateDate = DateTime.Now.ToUniversalTime(),
					CreatedBy = "DataInitializer",
					IsActive = true,
					LastUpdateBy = "DataInitializer"
				},

				new User()
				{
					Id = 3,
					Username = "marketing",
					Password = "test",
					CreateDate = DateTime.Now.ToUniversalTime(),
					CreatedBy = "DataInitializer",
					IsActive = true,
					LastUpdateBy = "DataInitializer"
				},

				new User()
				{
					Id = 4,
					Username = "management",
					Password = "test",
					CreateDate = DateTime.Now.ToUniversalTime(),
					CreatedBy = "DataInitializer",
					IsActive = true,
					LastUpdateBy = "DataInitializer"
				}
			};

			return newCities;
		}
	}
}
