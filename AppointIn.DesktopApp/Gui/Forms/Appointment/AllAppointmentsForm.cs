using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointIn.DesktopApp.Gui
{
	public partial class AllAppointmentsForm : SubForm
	{
		public AllAppointmentsForm()
		{
		}

		#region Properties
		private static AllAppointmentsForm sharedInstance;
		public static AllAppointmentsForm SharedInstance
		{
			get
			{
				if (sharedInstance == null) sharedInstance = new AllAppointmentsForm();
				return sharedInstance;
			}
		}
		#endregion

		#region Methods
		protected override void Init()
		{
			base.Init();

			InitializeComponent();
			LocalizeText();
		}

		public override void LocalizeText(string cultureName = "")
		{
			base.LocalizeText(cultureName);


			if (CrudPanel != null) CrudPanel.LocalizeText(cultureName);
		}
		#endregion
	}
}
