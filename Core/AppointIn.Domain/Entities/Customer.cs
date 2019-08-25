using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppointIn.Domain.Extensions;
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
				name => !string.IsNullOrEmpty(name),
				Resources.CustomerStrings.NameRequiredValidationMessage),
			new ValidationCondition<string>(
				name => name.Length <= 40,
				Resources.CustomerStrings.NameMaxLengthValidationMessage)
		};

		public static List<ValidationCondition<Address>> AddressIdValidationConditions = new List<ValidationCondition<Address>>()
		{
			// Using lambda expression to get a computed result for a validation condition
			new ValidationCondition<Address>(
				address => address != null,
				Resources.CustomerStrings.AddressRequiredValidationMessage)
		};
		#endregion
	}
}
