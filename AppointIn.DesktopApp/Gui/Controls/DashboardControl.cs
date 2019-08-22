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
	public partial class DashboardControl : UserControl
	{
		#region Constructors
		public DashboardControl()
		{
			Init();
		}
		#endregion


		#region Properties
		[Bindable(true)]
		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[EditorBrowsable(EditorBrowsableState.Always)]
		public override string Text
		{
			// Using lambda expressions to simplify property's getter and setter
			get => TitleLabel.Text;
			set => TitleLabel.Text = value;
		}
		#endregion

		#region Methods
		protected void ApplyVisualStyles()
		{
			BackColor = Color.FromArgb(200, 0, 0, 0);
		}

		protected void Init()
		{
			InitializeComponent();
			ApplyVisualStyles();
		}
		#endregion
	}
}
