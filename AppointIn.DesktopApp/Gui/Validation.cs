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
		public static DialogResult ShowValidationError(string message)
			=> MessageBox.Show(
				message,
				Resources.ValidationStrings.InvalidDataFoundCaption,
				MessageBoxButtons.OK,
				MessageBoxIcon.Error);
	}
}
