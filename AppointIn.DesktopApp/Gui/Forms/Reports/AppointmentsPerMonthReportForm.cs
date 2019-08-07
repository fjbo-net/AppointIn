using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AppointIn.Data;
using AppointIn.DesktopApp.Gui.Extensions;

namespace AppointIn.DesktopApp.Gui
{
	public partial class AppointmentsPerMonthReportForm : ReportForm, Interfaces.ILocalizable
	{
		public AppointmentsPerMonthReportForm()
		{
		}

		protected override void AttachEvents()
		{
			base.AttachEvents();

			if (MonthDateTimePicker != null) MonthDateTimePicker.ValueChanged += (sender, e) => {
				GenerateReport();
			};
		}

		protected override void Init()
		{
			base.Init();

			InitializeComponent();

			AttachEvents();

			LocalizeText();

			Reset();

			GenerateReport();
		}

		public void GenerateReport()
		{
			MonthDateTimePicker.Enabled = false;

			var dateRangeStart = new DateTime(MonthDateTimePicker.Value.Year, MonthDateTimePicker.Value.Month, 1, 0, 0, 0);
			var dateRangeEnd = new DateTime(MonthDateTimePicker.Value.Year, MonthDateTimePicker.Value.Month, DateTime.DaysInMonth(MonthDateTimePicker.Value.Year, MonthDateTimePicker.Value.Month), 23, 59, 59);

			var appointments = UnitOfWork.Data.Appointments
				.GetAll()
				.Where(appointment
					=> appointment.Start >= dateRangeStart
					&& appointment.Start <= dateRangeEnd
					&& appointment.End >= dateRangeStart
					&& appointment.End <= dateRangeEnd)
				.OrderBy(appointment => appointment.Start);

			var builder = new StringBuilder();

			builder.AppendLine($"{Resources.AppointmentsPerMonthReportFormStrings.Title}, {MonthDateTimePicker.Value.ToString("MMMM yyyy")}".ToUpper());
			builder.AppendLine();

			if (appointments.Any())
			{
				builder.AppendLine(string.Format(
					Resources.AppointmentsPerMonthReportFormStrings.AppointmentsFoundMessage,
					appointments.Count(),
					appointments.Count() == 1 ? Resources.ReportFormStrings.AppointmentNounSingular.ToLower() : Resources.ReportFormStrings.AppointmentNounPlural.ToLower(),
					MonthDateTimePicker.Value.ToString("MMMM yyyy")));

				builder.AppendLine();

				foreach (var appointment in appointments) builder.AppendLine(appointment.ToLocalString());
			} else
			{
				builder.AppendLine(string.Format(Resources.AppointmentsPerMonthReportFormStrings.NoAppointmentsFoundMessage, MonthDateTimePicker.Value.ToString("MMMM yyyy")) + ":");
				builder.AppendLine();
				builder.AppendLine();
			}

			TextBox.Text = builder.ToString();

			MonthDateTimePicker.Enabled = true;
		}

		public override void LocalizeText(string cultureName = "")
		{
			base.LocalizeText(cultureName);

			Text = Resources.AppointmentsPerMonthReportFormStrings.Title;

			if(MonthLabel != null) MonthLabel.Text = Resources.AppointmentsPerMonthReportFormStrings.DateTimePickerLabelText;
		}

		protected override void Reset()
		{
			base.Reset();
			
			MonthDateTimePicker.Value = DateTime.Today;
		}
	}
}
