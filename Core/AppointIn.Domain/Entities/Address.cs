using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppointIn.Domain.Classes;

using AppointIn.Domain.Interfaces;

namespace AppointIn.Domain.Entities
{
	public class Address : IEntity<int>
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


		#region Non-Mapped Properties
		// Using lambda expressino to simplify GET only property
		public string FullAddress => $"{StreetName}{(!string.IsNullOrWhiteSpace(BuildingOrInterior) ? $" {BuildingOrInterior}" : string.Empty)}, {City.Name}, {City.Country.Name}";
		#endregion


		#region Navigation Properties
		public virtual City City { get; set; }
		#endregion


		#region Validation Rules
		public static List<ValidationCondition<string>> AddressValidationConditions = new List<ValidationCondition<string>>()
		{
			new ValidationCondition<string>(
				addresss => addresss.Length > 0,
				Resources.AddressStrings.AddressRequiredValidationMessage),
			new ValidationCondition<string>(
				address => address.Length <= 50,
				Resources.AddressStrings.AddressMaxLengthValidationMessage)
		};

		public static List<ValidationCondition<string>> Address2ValidationConditions = new List<ValidationCondition<string>>()
		{
			new ValidationCondition<string>(
				address2 => address2.Length <= 50,
				Resources.AddressStrings.Address2MaxLengthValidationMessage)
		};

		public static List<ValidationCondition<City>> CityValidationRules = new List<ValidationCondition<City>>()
		{
			new ValidationCondition<City>(
				city => city != null,
				Resources.AddressStrings.CityRequiredValidationMessage)
		};

		public static List<ValidationCondition<string>> PostalCodeValidationConditions = new List<ValidationCondition<string>>()
		{
			new ValidationCondition<string>(
				postalCode => postalCode.Length > 0,
				Resources.AddressStrings.PostalCodeRequiredValidationMessage),
			new ValidationCondition<string>(
				postalCode => postalCode.Length <= 10,
				Resources.AddressStrings.PostalCodeMaxLengthValidationMessage)
		};

		public static List<ValidationCondition<string>> PhoneValidationConditions = new List<ValidationCondition<string>>()
		{
			new ValidationCondition<string>(
				phone => phone.Length > 0,
				Resources.AddressStrings.PhoneRequiredValidationMessage),
			new ValidationCondition<string>(
				phone => phone.Length <= 20,
				Resources.AddressStrings.PhoneMaxLengthValidationMessage)
		};
		#endregion
	}
}
