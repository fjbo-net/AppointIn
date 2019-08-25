using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointIn.Domain.Extensions
{
	public static class ByteExtensions
	{
		public static string AsString(this byte[] array)
		{
			return array != null
				? BitConverter.ToString(array)
				: string.Empty;
		}
	}
}
