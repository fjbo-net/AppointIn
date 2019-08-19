using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppointIn.Domain.Entities;
using AppointIn.Domain.Repositories;

namespace AppointIn.Core.Reports
{
	public class UserScheduleReport : Abstracts.Report
	{
		#region Constructors
		public UserScheduleReport(Parameters parameters, Strings strings)
		{
			_Parameters = parameters;
			_Strings = strings;
		}
		#endregion


		#region Properties
		private readonly Parameters _Parameters;
		private readonly Strings _Strings;
		#endregion


		#region Structs
		public struct Parameters
		{
			public IAppointmentRepository Appointments;
			public DateTime End;
			public DateTime Start;
			public int UserId;
			public string UserName;
			public IUserRepository Users;
			public Func<Appointment,string> AppointmentFormatter;
		}

		public struct Strings
		{
			public string AppointmentsFoundForUser;
			public string Title;
			public string DateRangeMessage;
			public string AppointmentPluralNoun;
			public string AppointmentSingularNoun;
			public string End;
			public string Start;
		}
		#endregion


		#region Methods
		public override string Generate()
		{
			var builder = new StringBuilder();

			builder.AppendLine($"{_Strings.Title} {string.Format(_Strings.DateRangeMessage, _Strings.Start, _Strings.End)}".ToUpper());
			builder.AppendLine();

			foreach (var user in _Parameters.Users.GetAll())
			{
				var userAppointments = _Parameters.Appointments.GetAll()
					.Where(appointment
							=> appointment.User.Id == user.Id
							&& appointment.Start >= _Parameters.Start
							&& appointment.End <= _Parameters.End)
					.OrderBy(appointment => appointment.Start);

				builder.AppendLine(string.Format(
									_Strings.AppointmentsFoundForUser,
									user.Username,
									userAppointments.Count(),
									userAppointments.Count() == 1
										? _Strings.AppointmentSingularNoun
										: _Strings.AppointmentPluralNoun));

				builder.AppendLine();

				if (userAppointments.Any())
				{
					foreach (var appointment in userAppointments)
					{
						foreach (var line in _Parameters.AppointmentFormatter(appointment).Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
						{
							builder.AppendLine($"\t{line}");
						}

						builder.AppendLine();
					}
				}

				builder.AppendLine();
			}

			return builder.ToString();
		}
		#endregion
	}
}
