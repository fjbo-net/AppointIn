using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppointIn.Domain.Classes;

namespace AppointIn.Domain.Extensions
{
	public static class TimeRangeExtensions
	{
		public static bool ContainsTimeRange(this IEnumerable<TimeRange> ranges, DateTime startTime, DateTime endTime)
		{
			var duration = endTime - startTime;
			var matches = new List<bool>();

			foreach (var range in ranges)
			{
				var rangeStart = new DateTime(
					startTime.Year,
					startTime.Month,
					startTime.Day,
					range.Start.Hour,
					range.Start.Minute,
					0);

				var rangeEnd = new DateTime(
					endTime.Year,
					endTime.Month,
					endTime.Day,
					range.End.Hour,
					range.End.Minute,
					0);

				matches.Add(
					startTime >= rangeStart
					&& startTime.Add(duration) <= rangeEnd);
			}

			// Using lambdas for LINQ's lambda expression notation
			return matches.Any(match => match == true);
		}

		public static string AsString(this IEnumerable<TimeRange> ranges, DateTime? relativeToDate = null)
		{
			var output = new StringBuilder();

			if (relativeToDate != null) output.Append($"{((DateTime)relativeToDate).ToString("dddd MMMM dd, yyyy")}:");

			foreach (var range in ranges)
			{
				var reference = relativeToDate ?? DateTime.Now;
				var start = new DateTime(
					reference.Year,
					reference.Month,
					reference.Day,
					range.Start.Hour,
					range.Start.Minute,
					0);
				var end = new DateTime(
					reference.Year,
					reference.Month,
					reference.Day,
					range.End.Hour,
					range.End.Minute,
					0);

				output.Append($" {start.ToShortTimeString()}-{end.ToShortTimeString()},");
			}

			return output.ToString().Trim(new []{ ',' });
		}
	}
}
