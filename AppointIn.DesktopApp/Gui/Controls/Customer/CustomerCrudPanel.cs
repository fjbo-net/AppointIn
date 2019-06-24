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

namespace AppointIn.DesktopApp.Gui.Controls
{
	public partial class CustomerCrudPanel : CrudPanel
	{
		public CustomerCrudPanel() : base()
		{
			CustomerCrudPanels.Add(this);
		}


		#region Properties
		protected static List<CustomerCrudPanel> CustomerCrudPanels = new List<CustomerCrudPanel>();
		#endregion


		#region Methods
		internal override void LoadData()
		{
			SyncListView();
		}

		protected override void SyncListView()
		{
			//using (var workSegment = new UnitOfWork())
			//{
			//	var customers = workSegment.Customers;

			//	foreach(var customer in customers.GetAll())
			//	{
			//		var customerListView = customer.ToListViewItem();
			//		ListView.Items.Add(customerListView);
			//	}
			//}
		}
		#endregion
	}
}
