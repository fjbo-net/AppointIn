using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppointIn.Domain.Classes;
using AppointIn.Domain.Entities;

namespace AppointIn.Domain.Extensions
{
	public static class AddressExtensions
	{
		public static ValidationResult Validate(this Address address)
		{
			var addressResult = Address.AddressValidationConditions.Validate(address.StreetName);
			var address2Result = Address.Address2ValidationConditions.Validate(address.BuildingOrInterior);
			var cityResult = Address.CityValidationRules.Validate(address.City);
			var postalCodeResult = Address.PostalCodeValidationConditions.Validate(address.PostalCode);
			var phoneResult = Address.PhoneValidationConditions.Validate(address.Phone);

			return new ValidationResult(
				addressResult.IsValid
					&& address2Result.IsValid
					&& cityResult.IsValid
					&& postalCodeResult.IsValid
					&& phoneResult.IsValid,
				addressResult.ErrorMessages
					.Concat(address2Result.ErrorMessages).ToList()
					.Concat(cityResult.ErrorMessages).ToList()
					.Concat(postalCodeResult.ErrorMessages).ToList()
					.Concat(phoneResult.ErrorMessages).ToList());
		}
	}
}
