using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AppointIn.Data;
using AppointIn.DesktopApp.Gui.Extensions;

namespace AppointIn.DesktopApp.Gui.Controls.Appointment
{
	public partial class AppointmentCrudPanel : CrudPanel, Interfaces.ILocalizable
	{
		public AppointmentCrudPanel()
		{
			Localizables.All.Add(this);
			AppointmentCrudPanels.Add(this);
			LoadData();
		}

		#region Properties
		protected static List<AppointmentCrudPanel> AppointmentCrudPanels = new List<AppointmentCrudPanel>();
		protected AppointmentForm AppointmentForm = new AppointmentForm();
		#endregion

		#region Methods
		public override void Add()
		{
			AppointmentForm.Appointment = new Domain.Entities.Appointment()
			{
				Id = 0,
				Start = DateTime.Now,
				End = DateTime.Now,
				CreateDate = DateTime.Now,
				CreatedBy = Dashboard.Username,
				LastUpdateBy = Dashboard.Username
			};

			AppointmentForm.Text = Resources.AppointmentFormStrings.TitleAdd;
			var result = AppointmentForm.ShowDialog();

			if(result == DialogResult.OK)
			{
				var repository = UnitOfWork.Data.Appointments;

				repository.Insert(AppointmentForm.Appointment);

				UnitOfWork.Data.Save();
			}

			RefreshAll();
		}

		public override void Edit()
		{
			if (!HasSelection) return;

			AppointmentForm.Text = Resources.AppointmentFormStrings.TitleEdit;

			if(int.TryParse(ListView.SelectedItems[0].Text, out int appointmentId))
			{
				AppointmentForm.Appointment = UnitOfWork.Data.Appointments.GetById(appointmentId);

				var result = AppointmentForm.ShowDialog();

				if(result == DialogResult.OK)
				{
					var appointment = AppointmentForm.Appointment;

					appointment.LastUpdateBy = Dashboard.Username;

					UnitOfWork.Data.Save();

					AppointmentForm.Reset();
				}
			}

			RefreshAll();
		}

		protected override void Init()
		{
			base.Init();

			InitializeComponent();

			LocalizeText();
		}

		public override void LocalizeText(string culture = "")
		{
			Text = Resources.AppointmentCrudPanelStrings.Title;

			IdColumnHeader.Text = Resources.DataPanelStrings.IdLabelText;
			CustomerColumnHeader.Text = Resources.AppointmentDataPanelStrings.CustomerLabelText;
			UserColumnHeader.Text = Resources.AppointmentDataPanelStrings.UserLabelText;
			TitleColumnHeader.Text = Resources.AppointmentDataPanelStrings.TitleLabelText;
			DescriptionColumnHeader.Text = Resources.AppointmentDataPanelStrings.DescriptionLabelText;
			LocationColumnHeader.Text = Resources.AppointmentDataPanelStrings.LocationLabelText;
			ContactColumnHeader.Text = Resources.AppointmentDataPanelStrings.ContactLabelText;
			TypeColumnHeader.Text = Resources.AppointmentDataPanelStrings.TypeLabelText;
			UrlColumnHeader.Text = Resources.AppointmentDataPanelStrings.UrlLabelText;
			StartColumnHeader.Text = Resources.AppointmentDataPanelStrings.StartLabelText;
			EndColumnHeader.Text = Resources.AppointmentDataPanelStrings.EndLabelText;
			CreateDateColumnHeader.Text = Resources.DataPanelStrings.CreateDateLabelText;
			CreatedByColumnHeader.Text = Resources.DataPanelStrings.CreatedByLabelText;
			LastUpdateColumnHeader.Text = Resources.DataPanelStrings.LastUpdateLabelText;
			LastUpdateByColumnHeader.Text = Resources.DataPanelStrings.LastUpdateByLabelText;

			AddButton.Text = Resources.CrudPanelStrings.AddButtonText;
			EditButton.Text = Resources.CrudPanelStrings.EditButtonText;
			RemoveButton.Text = Resources.CrudPanelStrings.RemoveButtonText;
		}

		public override void Remove()
		{
			if(ListView.SelectedItems.Count > 0)
			{
				foreach(ListViewItem item in ListView.SelectedItems)
				{
					if(int.TryParse(item.Text, out int appointmentId))
					{
						UnitOfWork.Data.Appointments.Delete(appointmentId);

						UnitOfWork.Data.Save();
					}
				}
			}

			RefreshAll();
		}

		protected override void SyncListView()
		{
			foreach(var appointment in UnitOfWork.Data.Appointments.GetAll())
			{
				ListView.Items.Add(appointment.ToListViewItem());
			}

			UpdateGui();
		}
		#endregion
	}
}
