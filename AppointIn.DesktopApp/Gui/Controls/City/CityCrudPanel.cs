using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AppointIn.DesktopApp.Gui.Extensions;

namespace AppointIn.DesktopApp.Gui.Controls
{
	public partial class CityCrudPanel : CrudPanel, Interfaces.ILocalizable
	{
		public CityCrudPanel()
		{
			Localizables.All.Add(this);
			CityCrudPanels.Add(this);
			LoadData();
		}

		#region Properties
		protected static List<CityCrudPanel> CityCrudPanels = new List<CityCrudPanel>();
		protected CityForm CityForm = new CityForm();
		#endregion

		#region Methods
		public override void Add()
		{
			CityForm.City = new Domain.Entities.City()
			{
				Id = 0,
				CreateDate = DateTime.Now,
				CreatedBy = Dashboard.Username,
				LastUpdateBy = Dashboard.Username
			};

			CityForm.Text = Resources.CityFormStrings.TitleAdd;
			var result = CityForm.ShowDialog();

			if (result == DialogResult.OK)
			{
				var repository = Data.UnitOfWork.Data.Cities;

				repository.Insert(CityForm.City);

				Data.UnitOfWork.Data.Save();
			}

			RefreshAll();
		}

		public override void Edit()
		{
			if (!HasSelection) return;

			CityForm.Text = Resources.CityFormStrings.TitleEdit;

			if(int.TryParse(ListView.SelectedItems[0].Text, out int cityId))
			{
				CityForm.City = Data.UnitOfWork.Data.Cities.GetById(cityId);

				var result = CityForm.ShowDialog();

				if(result == DialogResult.OK)
				{
					var city = CityForm.City;

					city.LastUpdateBy = Dashboard.Username;

					Data.UnitOfWork.Data.Save();

					CityForm.Reset();
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

		public override void LocalizeText(string cultureName = "")
		{
			Text = Resources.CityCrudPanelStrings.Title;

			IdColumnHeader.Text = Resources.DataPanelStrings.IdLabelText;
			NameColumnHeader.Text = Resources.CityDataPanelStrings.NameLabelText;
			CountryColumnHeader.Text = Resources.CityDataPanelStrings.CountryLabelText;
			CreateDateColumnHeader.Text = Resources.DataPanelStrings.CreateDateLabelText;
			CreatedByColumnHeader.Text = Resources.DataPanelStrings.CreatedByLabelText;
			LastUpdateByColumHeader.Text = Resources.DataPanelStrings.LastUpdateByLabelText;
			LastUpdateColumnHeader.Text = Resources.DataPanelStrings.LastUpdateLabelText;

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
					if(int.TryParse(item.Text, out int countryId))
					{
						Data.UnitOfWork.Data.Cities.Delete(countryId);

						Data.UnitOfWork.Data.Save();
					}
				}
			}

			RefreshAll();
		}

		protected override void SyncListView()
		{
			foreach(var city in Data.UnitOfWork.Data.Cities.GetAll())
			{
				ListView.Items.Add(city.ToListViewItem());
			}

			UpdateGui();
		}
		#endregion
	}
}
