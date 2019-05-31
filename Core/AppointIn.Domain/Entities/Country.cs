using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppointIn.Domain.Interfaces;

namespace AppointIn.Domain.Entities
{
	public class Country:IEntity
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public DateTime CreateDate { get; set; }
		public string CreatedBy { get; set; }
		public Byte[] LastUpdate { get; set; }
		public string LasUpdateBy { get; set; }
	}
}
