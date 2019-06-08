using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppointIn.Domain.Interfaces;

namespace AppointIn.Domain.Repositories
{
	public interface IRepository<TypeOfEntity,TypeOfKey> where TypeOfEntity : class, IEntity<TypeOfKey>
	{
		void Delete(TypeOfKey id);
		void Delete(TypeOfEntity entity);
		IEnumerable<TypeOfEntity> GetAll();
		TypeOfEntity GetById(TypeOfKey id);
		void Insert(TypeOfEntity entity);
	}
}
