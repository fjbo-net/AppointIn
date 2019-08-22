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
	public partial class BaseForm : Form
	{
		#region Constructors
		public BaseForm()
		{
			Init();
		}

		// Using lambda expression to simplify constructor definition
		public BaseForm(string title) : base() => Text = title;
		#endregion


		#region Properties
		protected static string _appName = "AppointIn";
		// Using lambda expression to simplify GET only property
		protected string AppName { get => _appName; }

		protected string _title = string.Empty;
		public override string Text {
			// Using lambda expression to simplify property getter
			get => _title;

			set
			{
				_title = value;
				base.Text = $"{_title} | {_appName}";
			}
		}
		#endregion


		#region Methods
		protected virtual void AttachEvents()
		{

		}

		protected virtual void Init()
		{
			InitializeVisualStyles();
			LocalizeText();
			AttachEvents();
		}

		protected virtual void InitializeVisualStyles()
		{
			InitializeComponent();

			BackColor = ColorPalette.BackgroundColor;
			ForeColor = ColorPalette.TextColor;
		}

		public virtual void LocalizeText(string cultureName = "")
		{

		}
		#endregion
	}
}
