using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointIn.Core
{
	public class Result<TypeOfResult>
	{
		#region Constructors
		public Result(TypeOfResult value, List<string> messages)
		{
			Value = value;
			Messages = messages;
		}
		#endregion


		#region Properties
		public TypeOfResult Value { get; private set; }
		public List<string> Messages { get; private set; }
		#endregion


		#region Methods
		
		#endregion
	}
}
