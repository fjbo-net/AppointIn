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

namespace AppointIn.DesktopApp.Gui.Controls
{
	public partial class CountryCrudPanel : CrudPanel
	{
		public CountryCrudPanel() : base()
		{
			CountryCrudPanels.Add(this);

			LoadData();
		}


		#region Properties
		protected static List<CountryCrudPanel> CountryCrudPanels = new List<CountryCrudPanel>();
		protected CountryForm CountryForm = new CountryForm();
		#endregion


		#region Methods
		public override void Add()
		{
			CountryForm.Country = new Domain.Entities.Country()
			{
				Id = 0,
				CreateDate = DateTime.Now,
				CreatedBy = Dashboard.Username,
				LastUpdateBy = Dashboard.Username
			};

			CountryForm.Text = "Add Country";
			var result = CountryForm.ShowDialog();

			if(result == DialogResult.OK)
			{
				using(var workSegment = new UnitOfWork())
				{
					var repository = workSegment.Countries;

					repository.Insert(CountryForm.Country);

					workSegment.Save();
				}
			}

			RefreshAll();
		}

		public override void Edit()
		{
			if (!HasSelection) return;

			CountryForm.Text = "Edit Country";
			
			using(var workSegment = new UnitOfWork())
			{
				var repository = workSegment.Countries;

				if(int.TryParse(ListView.SelectedItems[0].Text, out int countryId))
				{
					CountryForm.Country = repository.GetById(countryId);

					var result = CountryForm.ShowDialog();

					if (result == DialogResult.OK)
					{
						var country = CountryForm.Country;

						country.LastUpdateBy = Dashboard.Username;

						workSegment.Save();
						
						CountryForm.Reset();
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

		public override void Remove()
		{
			if(ListView.SelectedItems.Count > 0)
			{
				foreach (ListViewItem item in ListView.SelectedItems)
				{
					if(int.TryParse(item.Text, out int countryId))
					{
						using (var segmentOfWork = new UnitOfWork())
						{
							segmentOfWork.Countries.Delete(countryId);

							segmentOfWork.Save();
						}
					}
				}
			}

			ReloadData();
		}

		protected override void SetupListView()
		{
		}

		protected override void SyncListView()
		{
			using(var workSegment = new UnitOfWork())
			{
				var repository = workSegment.Countries;

				foreach(var country in repository.GetAll())
				{
					ListView.Items.Add(country.ToListViewItem());
				}
			}

			UpdateGui();
		}
		#endregion
	}
}
