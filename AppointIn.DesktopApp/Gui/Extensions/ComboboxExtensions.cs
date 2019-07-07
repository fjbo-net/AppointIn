using System.Collections.Generic;
using System.Windows.Forms;

namespace AppointIn.DesktopApp.Gui.Extensions
{
	public static class ComboboxExtensions
	{
		public static void Bind(this ComboBox combobox, Dictionary<string, string> dictionary)
		{
			combobox.DataSource = new BindingSource(dictionary, null);
			combobox.DisplayMember = "Value";
			combobox.ValueMember = "Key";
		}

		public static void Bind<TypeOfList>(this ComboBox comboBox, IEnumerable<TypeOfList> dataSource, string displayMember, string valueMember = "")
		{
			comboBox.DataSource = dataSource;
			comboBox.DisplayMember = displayMember;
			comboBox.ValueMember = string.IsNullOrWhiteSpace(valueMember) ? null : valueMember;
		}
	}
}
