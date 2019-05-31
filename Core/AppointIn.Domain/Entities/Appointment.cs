﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointIn.Domain.Entities
{
	public class Appointment
	{
		public int Id { get; set; }
		public int CustomerId { get; set; }
		public int UserId { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string Location { get; set; }
		public string Contact { get; set; }
		public string Type { get; set; }
		public string Url { get; set; }
		public DateTime Start { get; set; }
		public DateTime End { get; set; }
		public DateTime CreateDate { get; set; }
		public string CreatedBy { get; set; }
		public byte[] LastUpdate { get; set; }
		public string LastUpdateBy { get; set; }
	}
}
