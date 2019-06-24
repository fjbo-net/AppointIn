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
	public partial class AllCountriesForm : SubForm
	{
		public AllCountriesForm()
		{
		}


		#region Properties
		private static AllCountriesForm sharedInstance;
		public static AllCountriesForm SharedInstance
		{
			get
			{
				if (sharedInstance == null) sharedInstance = new AllCountriesForm();
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

			Text = Resources.AllCountriesFormStrings.Title;
		}
		#endregion
	}
}
