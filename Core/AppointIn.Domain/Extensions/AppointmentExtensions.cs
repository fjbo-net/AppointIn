using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppointIn.Domain.Classes;
using AppointIn.Domain.Entities;
using AppointIn.Domain.Repositories;

namespace AppointIn.Domain.Extensions
{
	public static class AppointmentExtensions
	{
		public static ValidationResult Validate(this Appointment appointment)
		{
			var customerResult = Appointment.CustomerIdValidationConditions.Validate(appointment.Customer);
			var userResult = Appointment.UserIdValidationConditions.Validate(appointment.User);
			var titleResult = Appointment.TitleValidationConditions.Validate(appointment.Title);
			var contactResult = Appointment.ContactValidationConditions.Validate(appointment.Contact);
			var urlResult = Appointment.UrlValidationConditions.Validate(appointment.Url);

			return new ValidationResult(
				customerResult.IsValid
					&& userResult.IsValid
					&& titleResult.IsValid
					&& contactResult.IsValid
					&& urlResult.IsValid,
				customerResult.ErrorMessages
					.Concat(userResult.ErrorMessages).ToList()
					.Concat(titleResult.ErrorMessages).ToList()
					.Concat(contactResult.ErrorMessages).ToList()
					.Concat(urlResult.ErrorMessages).ToList());
		}

		public static IEnumerable<string> FindOverlappingAppointments(this Appointment appointment, IAppointmentRepository savedAppointments)
		{
			var overlappingAppointments = savedAppointments.GetAll()
				.Where(savedAppointment
					=> appointment.User.Id == savedAppointment.User.Id
					&& (appointment.Start >= savedAppointment.Start &&
						appointment.Start < savedAppointment.End)
					|| (appointment.End > savedAppointment.Start &&
						appointment.End <= savedAppointment.End));

			var output = overlappingAppointments.Select(savedAppointment => $"\"{savedAppointment.Title}\": {savedAppointment.Start.ToLocalTime().ToShortDateAndTimeString()}-{savedAppointment.End.ToLocalTime().ToShortDateAndTimeString()}.");

			return output;
		}
	}
}
