using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppointIn.Domain.Interfaces;
using AppointIn.Domain.Repositories;

namespace AppointIn.Data.Repositories
{
	internal class GenericRepository<TypeOfEntity, TypeOfKey> : IRepository<TypeOfEntity, TypeOfKey> where TypeOfEntity : class, IEntity<TypeOfKey>
	{
		protected readonly Context _context;
		protected DbSet<TypeOfEntity> _entityDbSet;


		public GenericRepository(Context context)
		{
			_context = context;
			_entityDbSet = context.Set<TypeOfEntity>();
		}

		// Using lambda expression to simplify call to an object property's method
		public virtual void Delete(TypeOfKey id) => Delete(GetById(id));
		public virtual void Delete(TypeOfEntity entity)
		{
			_entityDbSet.Remove(entity);
			_context.Entry(entity).State = EntityState.Deleted;
		}
		// Using lambda expression to simplify call to an object property's method
		public virtual IEnumerable<TypeOfEntity> GetAll() => _entityDbSet.ToList();
		// Using lambda expression to simplify call to an object property's method
		public virtual TypeOfEntity GetById(TypeOfKey id) => _entityDbSet.Find(id);
		// Using lambda expression to simplify call to an object property's method
		public virtual void Insert(TypeOfEntity entity) => _entityDbSet.Add(entity);
	}
}
