using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppointIn.Domain.Entities;
using AppointIn.Domain.Interfaces;
using AppointIn.Domain.Repositories;

namespace AppointIn.TestDataSeed
{
	public class GenericMockRepository<TypeOfEntity, TypeOfKey> : IRepository<TypeOfEntity, TypeOfKey> where TypeOfEntity : class, IEntity<TypeOfKey>
	{
		#region Constructors
		public GenericMockRepository(ICollection<TypeOfEntity> data)
		{
			_data = data;
		}
		#endregion

		#region Properties
		protected ICollection<TypeOfEntity> _data = new List<TypeOfEntity>();
		#endregion


		private ICollection<TypeOfEntity> EmptyDataSource()
			=> _data = new List<TypeOfEntity>();


		public void Delete(TypeOfKey id)
		{
			var oldData = _data;
			EmptyDataSource();

			_data = oldData.Where(entity => !entity.Id.Equals(id)).ToList();
		}

		public void Delete(TypeOfEntity entity)
		{
			var oldData = _data;
			EmptyDataSource();

			_data = oldData.Where(entityInCollection => !entityInCollection.Id.Equals(entity.Id)).ToList();
		}

		public IEnumerable<TypeOfEntity> GetAll() => _data.ToList();

		public TypeOfEntity GetById(TypeOfKey id) => _data.Where(entity => entity.Id.Equals(id)).Single();

		public void Insert(TypeOfEntity entity) => _data.Add(entity);
	}
}
