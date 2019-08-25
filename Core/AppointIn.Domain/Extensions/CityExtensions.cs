using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppointIn.Domain.Classes;
using AppointIn.Domain.Entities;

namespace AppointIn.Domain.Extensions
{
	public static class CityExtensions
	{
		public static ValidationResult Validate(this City city)
		{
			var nameResult = City.NameValidationConditions.Validate(city.Name);
			var countryResult = City.CountryValidationConditions.Validate(city.Country);

			return new ValidationResult(
				nameResult.IsValid && countryResult.IsValid,
				nameResult.ErrorMessages
					.Concat(countryResult.ErrorMessages).ToList());
		}
	}
}
