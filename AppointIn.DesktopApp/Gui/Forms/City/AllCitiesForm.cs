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
	public partial class AllCitiesForm : SubForm
	{
		public AllCitiesForm()
		{
		}

		#region Properties
		private static AllCitiesForm sharedInstance;
		public static AllCitiesForm SharedInstance
		{
			get
			{
				if (sharedInstance == null) sharedInstance = new AllCitiesForm();
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

			Text = Resources.AllCitiesFormStrings.Title;

			if(cityCrudPanel1 != null) cityCrudPanel1.LocalizeText(cultureName);
		}
		#endregion
	}
}
