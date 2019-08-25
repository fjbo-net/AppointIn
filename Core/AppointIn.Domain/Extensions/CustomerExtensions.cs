using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppointIn.Domain.Classes;
using AppointIn.Domain.Entities;

namespace AppointIn.Domain.Extensions
{
	public static class CustomerExtensions
	{
		public static ValidationResult Validate(this Customer customer)
		{
			var nameResult = Customer.NameValidationConditions.Validate(customer.Name);
			var addressResult = Customer.AddressIdValidationConditions.Validate(customer.Address);

			return new ValidationResult(
				nameResult.IsValid && addressResult.IsValid,
				nameResult.ErrorMessages
					.Concat(addressResult.ErrorMessages).ToList());
		}
	}
}
