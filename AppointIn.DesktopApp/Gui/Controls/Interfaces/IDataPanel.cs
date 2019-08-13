using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointIn.DesktopApp.Gui.Controls.Interfaces
{
	public interface IDataPanel
	{
		void MakeInputsEditable();
		void MakeInputsReadOnly();
	}

	public enum DataPanelMode
	{
		Edit,
		View
	}
}
