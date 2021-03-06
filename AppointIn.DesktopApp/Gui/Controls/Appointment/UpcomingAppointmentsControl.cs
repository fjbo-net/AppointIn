﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AppointIn.Data;
using AppointIn.DesktopApp.Gui.Interfaces;

namespace AppointIn.DesktopApp.Gui.Controls.Appointment
{
	public partial class UpcomingAppointmentsControl : UserControl, ILocalizable
	{
		public UpcomingAppointmentsControl()
		{
			Init();

			Localizables.All.Add(this);
		}

		protected void Init()
		{
			InitializeComponent();

			MonthAppointmentCrudPanel.DataSource = () =>
			{
				var today = DateTime.Now;
				var daysInThisMonth = DateTime.DaysInMonth(today.Year, today.Month);
				var limit = new DateTime(today.Year, today.Month, daysInThisMonth, 23, 59, 59);

				var items = UnitOfWork.Data.Appointments.GetAll()
				// Using lambdas for LINQ's lambda expression notation
				.Where(appointment =>
					appointment.Start > today.ToUniversalTime()
					&& appointment.Start < limit.ToUniversalTime())
				.OrderBy(appointment => appointment.Start);

				return items;
			};

			// Using lambda expression as to simplify property definition for computed data source
			WeekAppointmentCrudPanel.DataSource = () =>
			{
				var today = DateTime.Now;
				var limit = new DateTime(today.Year, today.Month, (today.AddDays(7)).Day, 23, 59, 59);

				var items = UnitOfWork.Data.Appointments.GetAll()
				// Using lambdas for LINQ's lambda expression notation
				.Where(appointment =>
					appointment.Start > today.ToUniversalTime()
					&& appointment.Start < limit.ToUniversalTime())
				.OrderBy(appointment => appointment.Start);

				return items;
			};

			LocalizeText();
		}

		public void LocalizeText(string culture = "")
		{
			WeekPage.Text = Resources.UpcomingAppointmentsControlStrings.WeekPageText;
			MonthPage.Text = Resources.UpcomingAppointmentsControlStrings.MonthPageText;

			MonthAppointmentCrudPanel.LocalizeText(culture);
			WeekAppointmentCrudPanel.LocalizeText(culture);

			MonthAppointmentCrudPanel.Text = Resources.UpcomingAppointmentsControlStrings.MonthAppointmentCrudPanelText;
			WeekAppointmentCrudPanel.Text = Resources.UpcomingAppointmentsControlStrings.WeekAppointmentCrudPanelText;
		}
	}
}
