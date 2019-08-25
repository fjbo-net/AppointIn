using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppointIn.Domain.Classes;
using AppointIn.Domain.Interfaces;

namespace AppointIn.Domain.Entities
{
	public class City:IEntity<int>
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int CountryId { get; set; }
		public DateTime CreateDate { get; set; }
		public string CreatedBy { get; set; }
		public byte[] LastUpdate { get; set; }
		public string LastUpdateBy { get; set; }


		#region Navigation Properties
		public virtual Country Country { get; set; }
		#endregion


		#region Validation Rules
		public static List<ValidationCondition<string>> NameValidationConditions = new List<ValidationCondition<string>>()
		{
			new ValidationCondition<string>(
				name => name.Length > 0,
				Resources.CityStrings.NameRequiredValidationMessage),
			new ValidationCondition<string>(
				name => name.Length <= 50,
				Resources.CityStrings.NameMaxLengthValidationMessage)
		};

		public static List<ValidationCondition<Country>> CountryValidationConditions = new List<ValidationCondition<Country>>()
		{
			new ValidationCondition<Country>(
				country => country != null,
				Resources.CityStrings.CountryRequiredValidationMessage)
		};
		#endregion
	}
}
