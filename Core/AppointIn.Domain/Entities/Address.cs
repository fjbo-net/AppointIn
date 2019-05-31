using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppointIn.Domain.Interfaces;

namespace AppointIn.Domain.Entities
{
	public class Address:IEntity
	{
		public int Id { get; set; }
		public string StreetName { get; set; }
		public string BuildingOrInterior { get; set; }
		public int CityId { get; set; }
		public string PostalCode { get; set; }
		public string Phone { get; set; }
		public DateTime CreateDate { get; set; }
		public string CreatedBy { get; set; }
		public byte[] LastUpdate { get; set; }
		public string LastUpdateBy { get; set; }
	}
}
