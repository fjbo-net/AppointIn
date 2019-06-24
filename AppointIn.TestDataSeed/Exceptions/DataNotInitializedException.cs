using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointIn.TestDataSeed
{
	[Serializable]
	internal class DataNotInitializedException : Exception
	{
		internal DataNotInitializedException() { }

		internal DataNotInitializedException(string repositoryName)
			: base($"Table corresponding to repository \"{repositoryName}\" has not being initialized.")
		{
			
		}
	}
}
