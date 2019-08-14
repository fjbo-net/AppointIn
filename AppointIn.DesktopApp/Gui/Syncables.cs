using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppointIn.DesktopApp.Gui.Interfaces;

namespace AppointIn.DesktopApp.Gui
{
	internal static class Syncables
	{
		public static ICollection<ISyncable> All = new List<ISyncable>();

		public static void SyncAll()
		{
			foreach (var syncable in All) syncable.SyncData();
		}
	}
}
