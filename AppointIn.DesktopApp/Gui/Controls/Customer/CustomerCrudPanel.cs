using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppointIn.Domain.Repositories;
using AppointIn.Domain.Entities;

using AppointIn.Data;
using AppointIn.DesktopApp.Gui.Extensions;
using AppointIn.DesktopApp.Gui.Interfaces;

namespace AppointIn.DesktopApp.Gui.Controls
{
	public partial class CustomerCrudPanel : CrudPanel, ILocalizable
	{
		public CustomerCrudPanel() : base()
		{
			CustomerCrudPanels.Add(this);
			Localizables.All.Add(this);
			LoadData();
		}


		#region Properties
		protected static List<CustomerCrudPanel> CustomerCrudPanels = new List<CustomerCrudPanel>();
		protected CustomerForm CustomerForm = new CustomerForm();
		#endregion


		#region Methods
		public override void Add()
		{
			CustomerForm.Customer = new Domain.Entities.Customer()
			{
				Id = 0,
				CreateDate = DateTime.Now,
				CreatedBy = Dashboard.Username,
				LastUpdateBy = Dashboard.Username
			};

			CustomerForm.Text = Resources.CustomerFormStrings.TitleAdd;
			var result = CustomerForm.ShowDialog();

			if(result == DialogResult.OK)
			{
				var repository = UnitOfWork.Data.Customers;

				repository.Insert(CustomerForm.Customer);

				UnitOfWork.Data.Save();
			}

			RefreshAll();
		}

		public override void Edit()
		{
			if (!HasSelection) return;

			CustomerForm.Text = Resources.CustomerFormStrings.TitleEdit;

			if(int.TryParse(ListView.SelectedItems[0].Text, out int customerId))
			{
				CustomerForm.Customer = UnitOfWork.Data.Customers.GetById(customerId);

				var result = CustomerForm.ShowDialog();

				if(result == DialogResult.OK)
				{
					var customer = CustomerForm.Customer;

					customer.LastUpdateBy = Dashboard.Username;

					UnitOfWork.Data.Save();

					CustomerForm.Reset();
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
			Text = Resources.CustomerCrudPanelStrings.Title;

			IdColumnHeader.Text = Resources.DataPanelStrings.IdLabelText;
			NameColumnHeader.Text = Resources.CustomerDataPanelStrings.NameLabelText;
			AddressColumnHeader.Text = Resources.CustomerDataPanelStrings.AddressLabelText;
			ActiveColumnHeader.Text = Resources.CustomerDataPanelStrings.ActiveLabelText;
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
					if(int.TryParse(item.Text, out int customerId))
					{
						UnitOfWork.Data.Customers.Delete(customerId);

						UnitOfWork.Data.Save();
					}
				}
			}

			RefreshAll();
		}

		protected override void SyncListView()
		{
			foreach(var customer in UnitOfWork.Data.Customers.GetAll())
			{
				ListView.Items.Add(customer.ToListViewItem());
			}

			UpdateGui();
		}
		#endregion
	}
}
