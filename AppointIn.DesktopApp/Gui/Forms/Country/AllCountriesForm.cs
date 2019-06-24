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
		public static AllCountriesForm SharedInstance = new AllCountriesForm();
		#endregion


		#region Methods
		protected override void Init()
		{
			base.Init();

			InitializeComponent();
		}
		#endregion
	}
}
