using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppointIn.Domain.Classes;
using AppointIn.Domain.Interfaces;

namespace AppointIn.Domain.Entities
{
	public class Appointment : IEntity<int>
	{
		public int Id { get; set; }
		public int CustomerId { get; set; }
		public int UserId { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string Location { get; set; }
		public string Contact { get; set; }
		public string Type { get; set; }
		public string Url { get; set; }
		public DateTime Start { get; set; }
		public DateTime End { get; set; }
		public DateTime CreateDate { get; set; }
		public string CreatedBy { get; set; }
		public byte[] LastUpdate { get; set; }
		public string LastUpdateBy { get; set; }

		#region Navigation Properties
		public virtual Customer Customer { get; set; }
		public virtual User User { get; set; }
		#endregion

		#region Validation Rules
		public static List<ValidationCondition<Customer>> CustomerIdValidationConditions = new List<ValidationCondition<Customer>>()
		{
			new ValidationCondition<Customer>(
				customer => customer != null,
				Resources.AppointmentStrings.CustomerIdValidationMessage)
		};

		public static List<ValidationCondition<User>> UserIdValidationConditions = new List<ValidationCondition<User>>()
		{
			new ValidationCondition<User>(
				user => user != null,
				Resources.AppointmentStrings.UserIdValidationMessage)
		};

		public static List<ValidationCondition<string>> TitleValidationConditions = new List<ValidationCondition<string>>() {
			new ValidationCondition<string>(
				title => title.Length > 0,
				Resources.AppointmentStrings.TitleRequiredValidationMessage),
			new ValidationCondition<string>(
				title => title.Length <= 255,
				Resources.AppointmentStrings.TitleMaxLengthValidationMessage)
		};

		public static List<ValidationCondition<string>> ContactValidationConditions = new List<ValidationCondition<string>>() {
			new ValidationCondition<string>(
				contact => contact.Length > 0,
				Resources.AppointmentStrings.ContactRequiredValidationMessage)
		};

		public static List<ValidationCondition<string>> UrlValidationConditions = new List<ValidationCondition<string>>() {
			new ValidationCondition<string>(
				url => url.Length <= 255,
				Resources.AppointmentStrings.UrlMaxLengthValidationMessage)
		};
		#endregion
	}
}
