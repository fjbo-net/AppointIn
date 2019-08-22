using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointIn.DesktopApp.Gui
{
	internal static class Validation
	{
		// Using lambda expression to simplify function definition due to simplicity
		public static DialogResult ShowValidationError(string message)
			=> MessageBox.Show(
				message,
				Resources.ValidationStrings.InvalidDataFoundCaption,
				MessageBoxButtons.OK,
				MessageBoxIcon.Error);
	}
}
