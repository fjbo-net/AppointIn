﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using AppointIn.DesktopApp.Gui;

using AppointIn.Data;
using AppointIn.TestDataSeed;

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
			var needsInitialization = DataInitializer.NeedsDataInitialization();
			if (needsInitialization)
			{
				var dialogResult = MessageBox.Show(
					"There is no data currently initialized. That is that the DataBase currently has no data. Would you like to seed data on the database for demo purposes?",
					"Empty Database found",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Exclamation);

				if(dialogResult == DialogResult.Yes) DataInitializer.DataSeedDatabase();
			}

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			// Using lambda expression to define behavior on Core layer from the Presentation layer as this behavior
			// won't be shared throughout different presentation platforms.
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
