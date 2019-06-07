using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AppointIn.Domain.Entities;

namespace AppointIn.DesktopApp.Gui.Forms
{
	public partial class LoginForm : BaseForm
	{
		#region Constructors
		public LoginForm() : base()
		{
			AttachEvents();
		}
		#endregion


		#region Properties
		User User = null;
		#endregion


		#region Methods
		private void AttachEvents()
		{
			LoginButton.Click += (sender, e) => DialogResult = DialogResult.OK;
		}

		protected override void InitializeVisualStyles()
		{
			base.InitializeVisualStyles();

			InitializeComponent();
		}
		#endregion
	}
}
