using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointIn.Domain.Extensions
{
	public static class StringExtensions
	{
		public static string Truncate(this string input, int length)
		{
			if (length <= 0 || input.Length == 0) return string.Empty;
			if (input.Length <= length) return input;

			var ellipsisCharacter = '.';
			var ellipsisLength = 3;

			switch (length)
			{
				case 1:
					return input.Substring(0, 1);
				case 2:
					return $"{input.Substring(0, 1)}{ellipsisCharacter}";
				case 3:
					return $"{input.Substring(0, 1)}{Repeat(ellipsisCharacter, 2)}";
				default:
					return $"{input.Substring(0, length - ellipsisLength)}{Repeat(ellipsisCharacter, ellipsisLength)}";
			}
		}

		private static string Repeat(char character, int times = 3)
		{
			if (times <= 0) return string.Empty;

			var output = new StringBuilder();

			while (times > 0) output.Append(character);

			return output.ToString();
		}

		public static string AsString(this IEnumerable<string> stringEnumerable)
		{
			var output = new StringBuilder();

			foreach (var str in stringEnumerable) output.Append($"{str} ");

			return output.ToString().Trim();
		}

		public static string AsMultilineString(this IEnumerable<string> stringEnumerable)
		{
			var output = new StringBuilder();

			foreach (var str in stringEnumerable) output.AppendLine(str);

			return output.ToString();
		}
	}
}
