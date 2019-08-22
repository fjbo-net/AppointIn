using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointIn.DesktopApp.Gui
{
	internal class FontStyles
	{
		internal static string FontFamilyName = "Microsoft Sans Serif";

		// Using lambda expression to simplify function definition due to simplicity
		internal static Font GetFont(float size, FontStyle style = FontStyle.Regular)
			=> new Font(
				FontFamilyName,
				size,
				style,
				GraphicsUnit.Point,
				(byte) 0);

		internal static Font Heading1 = GetFont(18F);
	}
}
