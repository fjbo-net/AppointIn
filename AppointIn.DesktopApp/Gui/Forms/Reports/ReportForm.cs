using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointIn.DesktopApp.Gui
{
	public partial class ReportForm : SubForm, Interfaces.ILocalizable
	{
		public ReportForm()
		{
		}

		#region Properties
		private static ReportForm sharedInstance;
		internal static ReportForm SharedInstance
		{
			get
			{
				if (sharedInstance == null) sharedInstance = new ReportForm();
				return sharedInstance;
			}
		}

		public override string Text
		{
			get => base.Text;
			set
			{
				if (TitleLabel != null) TitleLabel.Text = value;
				base.Text = value;
			}
		}
		#endregion

		#region Methods
		protected override void AttachEvents()
		{
			base.AttachEvents();

			if(CloseActionButton != null) CloseActionButton.Click += (sender, e) => Close();
			if (SaveAsActionButton != null) SaveAsActionButton.Click += SaveAsButtonClickHandler;
		}

		protected override void Init()
		{
			base.Init();

			InitializeComponent();

			LocalizeText();
		}

		public override void LocalizeText(string cultureName = "")
		{
			base.LocalizeText(cultureName);

			if(CloseActionButton != null) CloseActionButton.Text = Resources.ReportFormStrings.CloseButtonText;
			if(SaveAsActionButton != null) SaveAsActionButton.Text = Resources.ReportFormStrings.SaveAsButtonText;
		}

		protected virtual void Reset()
		{
			TextBox.Text = string.Empty;
		}

		protected void SaveAsButtonClickHandler(object sender, EventArgs e)
		{
			using (SaveFileDialog saveDialog = new SaveFileDialog() {
				Filter = "Text Files|*.txt|All Files (*.*)|*.*",
				CheckPathExists = true,
				DefaultExt = ".txt",
				AddExtension = true
			})
			{
				if(saveDialog.ShowDialog() != DialogResult.OK) return;

				SaveReport(saveDialog.FileName);
			}
		}

		protected virtual void SaveReport(string path)
		{
			using (StreamWriter outputFile = new StreamWriter(path)) {
				outputFile.Write(TextBox.Text);
			}
		}
		#endregion
	}
}
