using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointIn.Domain.Classes
{
	public class ValidationCondition<TypeOfValue>
	{
		public string InfoMessage { get; private set; }
		public string FailMessage { get; private set; }
		public Func<TypeOfValue, bool> Rule { get; private set; }

		public ValidationCondition(
			Func<TypeOfValue, bool> rule,
			string infoMessage = "",
			string failMessage = "")
		{
			this.Rule = rule;
			if (!string.IsNullOrEmpty(failMessage)) this.FailMessage = failMessage;
			if (!string.IsNullOrEmpty(infoMessage))
			{
				this.InfoMessage = infoMessage;
				if (string.IsNullOrEmpty(failMessage)) this.FailMessage = infoMessage;
			}
		}
	}
}
