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
	public partial class AddressCrudPanel : CrudPanel, ILocalizable
	{
		public AddressCrudPanel()
		{
			Localizables.All.Add(this);
			AddressCrudPanels.Add(this);
			LoadData();
		}

		#region Properties
		protected static List<AddressCrudPanel> AddressCrudPanels = new List<AddressCrudPanel>();
		protected AddressForm AddressForm = new AddressForm();
		#endregion

		#region Methods
		public override void Add()
		{
			AddressForm.Address = new Domain.Entities.Address()
			{
				Id = 0,
				CreateDate = DateTime.Now,
				CreatedBy = Dashboard.Username,
				LastUpdateBy = Dashboard.Username
			};

			AddressForm.Text = Resources.AddressFormStrings.TitleAdd;
			var result = AddressForm.ShowDialog();

			if(result == DialogResult.OK)
			{
				var repository = UnitOfWork.Data.Addresses;

				var address = AddressForm.Address;

				address.CreateDate = address.CreateDate;

				repository.Insert(address);

				UnitOfWork.Data.Save();
			}

			RefreshAll();
		}
		
		public override void Edit()
		{
			if (!HasSelection) return;

			AddressForm.Text = Resources.AddressFormStrings.TitleEdit;

			if(int.TryParse(ListView.SelectedItems[0].Text, out int addressId))
			{
				AddressForm.Address = UnitOfWork.Data.Addresses.GetById(addressId);

				var result = AddressForm.ShowDialog();

				if(result == DialogResult.OK)
				{
					var address = AddressForm.Address;

					address.LastUpdateBy = Dashboard.Username;

					address.CreateDate = address.CreateDate;

					UnitOfWork.Data.Save();

					AddressForm.Reset();
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
			Text = Resources.AddressCrudPanelStrings.Title;

			IdColumnHeader.Text = Resources.DataPanelStrings.IdLabelText;
			AddressColumnHeader.Text = Resources.AddressDataPanelStrings.AddressLabelText;
			Address2ColumnHeader.Text = Resources.AddressDataPanelStrings.Address2LabelText;
			CityColumnHeader.Text = Resources.AddressDataPanelStrings.CityLabelText;
			PostalCodeColumnHeader.Text = Resources.AddressDataPanelStrings.PostalCodeLabelText;
			PhoneColumnHeader.Text = Resources.AddressDataPanelStrings.PhoneLabelText;
			CreateDateColumnHeader.Text = Resources.DataPanelStrings.CreateDateLabelText;
			CreatedByColumnHeader.Text = Resources.DataPanelStrings.CreatedByLabelText;
			LastUpdateColumnHeader.Text = Resources.DataPanelStrings.LastUpdateLabelText;
			LastUpdateByColumHeader.Text = Resources.DataPanelStrings.LastUpdateByLabelText;

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
					if(int.TryParse(item.Text, out int addressId))
					{
						UnitOfWork.Data.Addresses.Delete(addressId);

						UnitOfWork.Data.Save();
					}
				}
			}

			RefreshAll();
		}

		protected override void SyncListView()
		{
			foreach(var address in UnitOfWork.Data.Addresses.GetAll())
			{
				ListView.Items.Add(address.ToListViewItem());
			}

			UpdateGui();
		}
		#endregion
	}
}
