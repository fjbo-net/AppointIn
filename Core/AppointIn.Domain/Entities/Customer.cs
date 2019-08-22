using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppointIn.Core.Extensions;
using AppointIn.Domain.Classes;
using AppointIn.Domain.Repositories;

using AppointIn.Domain.Interfaces;

namespace AppointIn.Domain.Entities
{
	public class Customer:IEntity<int>
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int AddressId { get; set; }
		public bool IsActive { get; set; }
		public DateTime CreateDate { get; set; }
		public string CreatedBy { get; set; }
		public byte[] LastUpdate { get; set; }
		public string LastUpdateBy { get; set; }


		#region Navigation Properties
		public virtual Address Address { get; set; }
		#endregion
			
			
		#region Validation Rules
		public static List<ValidationCondition<string>> NameValidationConditions = new List<ValidationCondition<string>>()
		{
			// Using lambda expression to get a computed result for a validation condition
			new ValidationCondition<string>(
				name => name.Length <= 40,
				$"{nameof(Customer)}'s name must not exceed 40 characters long.")
		};

		public static List<ValidationCondition<int>> AddressIdValidationConditions = new List<ValidationCondition<int>>()
		{
			// Using lambda expression to get a computed result for a validation condition
			new ValidationCondition<int>(
				addressId => addressId > 0,
				$"{nameof(Customer)}'s Address ID must be a positive integer.")
		};
		#endregion
	}
}
