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
using AppointIn.DesktopApp.Gui.Interfaces;

namespace AppointIn.DesktopApp.Gui.Controls
{
	public partial class CountryCrudPanel : CrudPanel, ILocalizable
	{
		public CountryCrudPanel() : base()
		{
			CountryCrudPanels.Add(this);
			Localizables.All.Add(this);

			LoadData();
		}


		#region Properties
		protected static List<CountryCrudPanel> CountryCrudPanels = new List<CountryCrudPanel>();
		protected CountryForm CountryForm = new CountryForm();
		#endregion


		#region Methods
		public override void Add()
		{
			var now = DateTime.Now;
			var nowInUtc = now.ToUniversalTime();

			CountryForm.Country = new Domain.Entities.Country()
			{
				Id = 0,
				CreateDate = now,
				CreatedBy = Dashboard.Username,
				LastUpdateBy = Dashboard.Username
			};

			CountryForm.Text = Resources.CountryFormStrings.TitleAdd;
			var result = CountryForm.ShowDialog();

			if(result == DialogResult.OK)
			{
				var repository = UnitOfWork.Data.Countries;

				CountryForm.Country.CreateDate = nowInUtc;

				repository.Insert(CountryForm.Country);

				UnitOfWork.Data.Save();
			}

			RefreshAll();
		}

		public override void Edit()
		{
			if (!HasSelection) return;

			CountryForm.Text = Resources.CountryFormStrings.TitleEdit;
			
			var repository = UnitOfWork.Data.Countries;

			if(int.TryParse(ListView.SelectedItems[0].Text, out int countryId))
			{
				CountryForm.Country = repository.GetById(countryId);
				var country = CountryForm.Country;
				var result = CountryForm.ShowDialog();

				if (result == DialogResult.OK)
				{
					country.LastUpdateBy = Dashboard.Username;

					country.CreateDate = country.CreateDate.ToUniversalTime();

					UnitOfWork.Data.Save();
						
					CountryForm.Reset();
				} else
				{
					if(country.Id > 0)
					{
						UnitOfWork.Data.Countries.Reset(country);
					}
				}
			}

			RefreshAll();
		}

		protected override void Init()
		{
			base.Init();

			InitializeComponent();
		}

		public override void LocalizeText(string culture = "")
		{
			Text = Resources.CountryCrudPanelStrings.Title;

			CountryIdColumnHeader.Text = Resources.DataPanelStrings.IdLabelText;
			CountryNameColumnHeader.Text = Resources.CountryDataPanelStrings.NameLabelText;
			CountryCreateDateColumnHeader.Text = Resources.DataPanelStrings.CreateDateLabelText;
			CountryCreatedByColumnHeader.Text = Resources.DataPanelStrings.CreatedByLabelText;
			CountryLastUpdateColumnHeader.Text = Resources.DataPanelStrings.LastUpdateLabelText;
			CountryLastUpdateByColumnHeader.Text = Resources.DataPanelStrings.LastUpdateByLabelText;

			AddButton.Text = Resources.CrudPanelStrings.AddButtonText;
			EditButton.Text = Resources.CrudPanelStrings.EditButtonText;
			RemoveButton.Text = Resources.CrudPanelStrings.RemoveButtonText;
		}

		public override void Remove()
		{
			if(ListView.SelectedItems.Count > 0)
			{
				foreach (ListViewItem item in ListView.SelectedItems)
				{
					if(int.TryParse(item.Text, out int countryId))
					{
						UnitOfWork.Data.Countries.Delete(countryId);

						UnitOfWork.Data.Save();
					}
				}
			}

			RefreshAll();
		}

		protected override void SetupListView()
		{
		}

		protected override void SyncListView()
		{
			var repository = UnitOfWork.Data.Countries;

			foreach(var country in repository.GetAll())
			{
				ListView.Items.Add(country.ToListViewItem());
			}

			UpdateGui();
		}
		#endregion
	}
}
