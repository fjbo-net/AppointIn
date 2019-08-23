using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppointIn.Domain.Classes;

namespace AppointIn.Domain.Extensions
{
	public static class ValidationConditionExtensions
	{
		public static ValidationResult Validate<TypeOfValue>(
			this IEnumerable<ValidationCondition<TypeOfValue>> conditions,
			TypeOfValue valueToValidate)
		{
			bool isValid = true;
			List<string> errorMessages = new List<string>();

			foreach (var condition in conditions)
			{
				if(!condition.Rule(valueToValidate))
				{
					isValid = false;
					errorMessages.Add(condition.FailMessage);
				}
			}

			return new ValidationResult(isValid, errorMessages);
		}
	}
}
