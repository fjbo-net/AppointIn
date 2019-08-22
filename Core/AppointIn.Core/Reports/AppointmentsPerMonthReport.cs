using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppointIn.Domain.Entities;
using AppointIn.Domain.Repositories;

namespace AppointIn.Core.Reports
{
	public class AppointmentsPerMonthReport : Abstracts.Report
	{
		#region Constructors
		public AppointmentsPerMonthReport(Parameters parameters, Strings strings)
		{
			_Parameters = parameters;
			_Strings = strings;
		}
		#endregion


		#region Structs
		public struct Parameters
		{
			public IAppointmentRepository Appointments;
			public DateTime Start;
			public DateTime End;
			public Func<Appointment, string> AppointmentFormatter;
		}

		public struct Strings
		{
			public string Title;
			public string Month;
			public string AppointmentsFoundMessage;
			public string AppointmentSingularNoun;
			public string AppointmentPluralNoun;
			public string NoAppointmentsFoundMessage;
		}
		#endregion


		#region Properties
		private readonly Parameters _Parameters;
		private readonly Strings _Strings;
		#endregion


		#region Method
		public override string Generate()
		{
			var appointments = _Parameters.Appointments.GetAll()
				// Using lambdas for LINQ's lambda expression notation
				.Where(appointment
					=> appointment.Start >= _Parameters.Start
					&& appointment.Start <= _Parameters.End
					&& appointment.End >= _Parameters.Start
					&& appointment.End <= _Parameters.End)
				.OrderBy(appointment => appointment.Start);

			var builder = new StringBuilder();

			builder.AppendLine($"{_Strings.Title}, {_Strings.Month}".ToUpper());
			builder.AppendLine();

			if (appointments.Any())
			{
				builder.AppendLine(string.Format(
					_Strings.AppointmentsFoundMessage,
					appointments.Count(),
					appointments.Count() == 1 ? _Strings.AppointmentSingularNoun.ToLower() : _Strings.AppointmentPluralNoun.ToLower(),
					_Strings.Month));

				builder.AppendLine();

				foreach (var appointment in appointments) builder.AppendLine(_Parameters.AppointmentFormatter(appointment));
			}
			else
			{
				builder.AppendLine(string.Format(_Strings.NoAppointmentsFoundMessage, _Strings.Month) + ":");
				builder.AppendLine();
				builder.AppendLine();
			}

			return builder.ToString();
		}
		#endregion
	}
}
