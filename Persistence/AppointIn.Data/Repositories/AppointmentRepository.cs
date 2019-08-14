using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppointIn.Domain.Entities;
using AppointIn.Domain.Repositories;

namespace AppointIn.Data.Repositories
{
	internal class AppointmentRepository : GenericRepository<Appointment, int>, IAppointmentRepository
	{
		public AppointmentRepository(Context context) : base(context)
		{
		}

		public IEnumerable<Appointment> GetNextAppointments(User user = null)
		{
			var now = DateTime.Now;
			var timeInFifteenMinutes = now.AddMinutes(15);
			var upcomingAppointments = UnitOfWork.Data.Appointments
				.GetAll()
				//.Select(appointment =>
				//{
				//	appointment.Start = appointment.Start.ToLocalTime();
				//	appointment.End = appointment.End.ToLocalTime();
				//	appointment.CreateDate = appointment.CreateDate.ToLocalTime();
				//	return appointment;
				//})
				.Where(appointment =>
					appointment.Start <= timeInFifteenMinutes
					&& appointment.Start > now)
				.OrderByDescending(appointment => appointment.Start);

			if (user == null) return upcomingAppointments;

			return upcomingAppointments
				.Where(appointment => appointment.User.Id == user.Id);
		}
	}
}
