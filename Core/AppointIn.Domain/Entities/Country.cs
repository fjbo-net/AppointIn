using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppointIn.Domain.Classes;
using AppointIn.Domain.Interfaces;

namespace AppointIn.Domain.Entities
{
	public class Country : IEntity<int>
	{
		#region Entity Properties
		public int Id { get; set; }
		public string Name { get; set; }
		public DateTime CreateDate { get; set; }
		public string CreatedBy { get; set; }
		public Byte[] LastUpdate { get; set; }
		public string LastUpdateBy { get; set; }
		#endregion


		#region Validation Rules
		public static List<ValidationCondition<string>> NameValidationConditions = new List<ValidationCondition<string>>()
		{
			new ValidationCondition<string>(
				name => name.Length > 0,
				Resources.CountryStrings.NameRequiredValidationMessage),
			new ValidationCondition<string>(
				name => name.Length <= 50,
				Resources.CountryStrings.NameMaxLengthValidationMessage)
		};
		#endregion
	}
}
