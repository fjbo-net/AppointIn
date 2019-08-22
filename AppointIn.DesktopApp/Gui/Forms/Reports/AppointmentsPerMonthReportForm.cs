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

using AppointIn.Core.Reports;

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

			// Using lambda expression to simplify event handler due to handler's simplicity
			if (MonthDateTimePicker != null) MonthDateTimePicker.ValueChanged += (sender, e)
					=> GenerateReport();
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

			var report = new AppointmentsPerMonthReport(
				new AppointmentsPerMonthReport.Parameters()
				{
					Appointments = UnitOfWork.Data.Appointments,
					AppointmentFormatter = appointment => appointment.ToLocalString(),
					Start = dateRangeStart.ToUniversalTime(),
					End = dateRangeEnd.ToUniversalTime()
				},
				new AppointmentsPerMonthReport.Strings()
				{
					Title = Resources.AppointmentsPerMonthReportFormStrings.Title,
					Month = MonthDateTimePicker.Value.ToString("MMMM yyyy"),
					AppointmentsFoundMessage = Resources.AppointmentsPerMonthReportFormStrings.AppointmentsFoundMessage,
					AppointmentSingularNoun = Resources.ReportFormStrings.AppointmentNounSingular,
					AppointmentPluralNoun = Resources.ReportFormStrings.AppointmentNounPlural,
					NoAppointmentsFoundMessage = Resources.AppointmentsPerMonthReportFormStrings.NoAppointmentsFoundMessage
				}
				);

			TextBox.Text = report.Generate();

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
