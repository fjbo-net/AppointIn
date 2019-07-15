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
	public partial class AllAddressesForm : SubForm
	{
		public AllAddressesForm()
		{
		}

		#region Properties
		private static AllAddressesForm sharedInstance;
		public static AllAddressesForm SharedInstance
		{
			get
			{
				if (sharedInstance == null) sharedInstance = new AllAddressesForm();
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

			Text = Resources.AllAdressesFormStrings.Title;

			if(CrudPanel != null) CrudPanel.LocalizeText(cultureName);
		}
		#endregion
	}
}
