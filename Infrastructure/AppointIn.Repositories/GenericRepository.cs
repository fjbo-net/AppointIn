using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppointIn.Domain.Interfaces;

namespace AppointIn.Repositories
{
	internal class GenericRepository<TypeOfEntity> where TypeOfEntity:IEntity
	{
		private GenericRepository()
		{
			
		}


		public static GenericRepository<TypeOfEntity> Instance = new GenericRepository<TypeOfEntity>();


		
	}
}
