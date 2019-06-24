using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointIn.DesktopApp.Gui
{
	public partial class ActionButton : Button
	{
		#region Constructors
		public ActionButton()
		{
			
		}
		#endregion


		#region Properties
		public string DefaultText { get; private set; } = string.Empty;

		public override string Text
		{
			get => base.Text;
			set
			{
				base.Text = value;
				if (string.IsNullOrEmpty(DefaultText) && !string.IsNullOrEmpty(value)) DefaultText = value;
			}
		}
		#endregion

		#region Methods
		protected void Init()
		{
			InitializeComponent();
		}
		#endregion
	}
}
