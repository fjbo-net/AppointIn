using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointIn.Domain.Repositories
{
	public interface IAppointmentRepository : IRepository<Entities.Appointment, int>
	{
		IEnumerable<Entities.Appointment> GetNextAppointments(Entities.User user);
	}
}
