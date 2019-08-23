using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointIn.Domain.Classes
{
	public class ValidationResult
	{
		#region Constructor
		public ValidationResult(bool isValid, List<string> errorMessages = null)
		{
			IsValid = isValid;
			ErrorMessages = errorMessages;
		}
		#endregion


		#region Properties
		public readonly bool IsValid;
		public readonly List<string> ErrorMessages;
		#endregion


		#region Methods
		public string ErrorMessagesAsString(bool multiLine = true)
		{
			StringBuilder builder = new StringBuilder();

			foreach (string message in ErrorMessages) builder.Append($"{message}{(multiLine ? Environment.NewLine : string.Empty)}");

			return builder.ToString().Trim();
		}

		// Using lambda expressino to simplify function return value reference
		public override string ToString() => ErrorMessagesAsString(true);
		#endregion


		#region Operator Overloads
		// Using lambda expressino to simplify function return value reference
		public static bool operator !(ValidationResult resultToEvaluate)
			=> !resultToEvaluate.IsValid;
		#endregion
	}
}
