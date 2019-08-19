using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointIn.Core.Reports.Abstracts
{
	public abstract class Report
	{
		#region Constructors
		protected Report()
		{
		}
		#endregion

		#region Methods
		public abstract string Generate();
		#endregion
	}
}
