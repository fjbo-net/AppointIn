using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using AppointIn.DesktopApp.Gui;
using AppointIn.DesktopApp.Gui.Forms;

namespace AppointIn.DesktopApp
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Core.AppActions.ErrorHandler = (exception) =>
			{
				MessageBox.Show(
					text: $"Error '{exception.GetType().ToString()}' encountered: \n{exception.Message} \n {exception.StackTrace}",
					caption: "Error Encountered",
					buttons: MessageBoxButtons.OK,
					icon: MessageBoxIcon.Error);
			};
			Application.Run(new Dashboard());
		}
	}
}
