using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointIn.Domain.Classes
{
	public class ValidationResult
	{
		public readonly bool IsValid;
		public readonly List<string> ErrorMessages;


		public string ErrorMessagesAsString(bool multiLine = true)
		{
			StringBuilder builder = new StringBuilder();

			foreach (string message in ErrorMessages) builder.Append($"{message}{(multiLine ? Environment.NewLine : string.Empty )}");

			return builder.ToString().Trim();
		}

		public ValidationResult(bool isValid, List<string> errorMessages = null)
		{
			IsValid = isValid;
			ErrorMessages = errorMessages;
		}

		#region Operator Overloads
		public static bool operator !(ValidationResult resultToEvaluate)
		{
			return !resultToEvaluate.IsValid;
		}
		#endregion
	}
}
