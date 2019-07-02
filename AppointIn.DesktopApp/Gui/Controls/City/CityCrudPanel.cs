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

			CityForm.Text = "Add City";
			var result = CityForm.ShowDialog();

			if (result == DialogResult.OK)
			{
				using(var workSegment = new Data.UnitOfWork())
				{
					var repository = workSegment.Cities;

					repository.Insert(CityForm.City);

					workSegment.Save();
				}
			}

			RefreshAll();
		}

		public override void Edit()
		{
			if (!HasSelection) return;

			CityForm.Text = "Edit City";

			using(var workSegment = new Data.UnitOfWork())
			{
				var repository = workSegment.Cities;

				if(int.TryParse(ListView.SelectedItems[0].Text, out int cityId))
				{
					CityForm.City = repository.GetById(cityId);

					var result = CityForm.ShowDialog();

					if(result == DialogResult.OK)
					{
						var city = CityForm.City;

						city.LastUpdateBy = Dashboard.Username;

						workSegment.Save();

						CityForm.Reset();
					}
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

		public virtual void LocalizeText(string cultureName = "")
		{
			IdColumnHeader.Text = Resources.CityDataPanelStrings.IdLabelText;
			NameColumnHeader.Text = Resources.CityDataPanelStrings.NameLabelText;
			CountryColumnHeader.Text = Resources.CityDataPanelStrings.CountryLabelText;
			CreateDateColumnHeader.Text = Resources.CityDataPanelStrings.CreateDateLabelText;
			CreatedByColumnHeader.Text = Resources.CityDataPanelStrings.CreatedByLabelText;
			LastUpdateByColumHeader.Text = Resources.CityDataPanelStrings.LastUpdateByLabelText;
			LastUpdateColumnHeader.Text = Resources.CityDataPanelStrings.LastUpdateLabelText;
		}

		public override void Remove()
		{
			if(ListView.SelectedItems.Count > 0)
			{
				foreach(ListViewItem item in ListView.SelectedItems)
				{
					if(int.TryParse(item.Text, out int countryId))
					{
						using (var segmentOfWork = new Data.UnitOfWork())
						{
							segmentOfWork.Cities.Delete(countryId);

							segmentOfWork.Save();
						}
					}
				}
			}

			ReloadData();
		}

		protected override void SyncListView()
		{
			using(var workSegment = new Data.UnitOfWork())
			{
				var repository = workSegment.Cities;

				foreach(var city in repository.GetAll())
				{
					ListView.Items.Add(city.ToListViewItem());
				}
			}

			UpdateGui();
		}
		#endregion
	}
}
