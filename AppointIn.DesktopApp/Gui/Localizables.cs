using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AppointIn.DesktopApp.Gui
{
	internal static class Localizables
	{
		internal static ICollection<Interfaces.ILocalizable> All = new List<Interfaces.ILocalizable>();

		internal static void LocalizeAll(string culture)
		{
			foreach (var localizable in All) localizable.LocalizeText(culture);
		}

		internal static string TargetCulture {
			get => CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
			set {
				Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(value);
				LocalizeAll(value);
			}
		}
	}
}
