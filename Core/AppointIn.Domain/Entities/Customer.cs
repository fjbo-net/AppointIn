﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppointIn.Domain.Interfaces;

namespace AppointIn.Domain.Entities
{
	public class Customer:IEntity
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int AddressId { get; set; }
		public bool IsActive { get; set; }
		public DateTime CreateDate { get; set; }
		public string CreatedBy { get; set; }
		public byte[] LastUpdate { get; set; }
		public string LastUpdateBy { get; set; }
	}
}
