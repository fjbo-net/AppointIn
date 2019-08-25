using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppointIn.Domain.Classes;
using AppointIn.Domain.Entities;

namespace AppointIn.Domain.Extensions
{
	public static class CountryExtensions
	{
		public static ValidationResult Validate(this Country country)
			=> Country.NameValidationConditions.Validate(country.Name);
	}
}
