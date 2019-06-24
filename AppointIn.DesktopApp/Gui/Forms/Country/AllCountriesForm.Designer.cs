namespace AppointIn.DesktopApp.Gui
{
	partial class AllCountriesForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.CountriesCrudPanel = new AppointIn.DesktopApp.Gui.Controls.CountryCrudPanel();
			this.SuspendLayout();
			// 
			// CountriesCrudPanel
			// 
			this.CountriesCrudPanel.BackColor = System.Drawing.Color.Transparent;
			this.CountriesCrudPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.CountriesCrudPanel.Location = new System.Drawing.Point(0, 0);
			this.CountriesCrudPanel.Name = "CountriesCrudPanel";
			this.CountriesCrudPanel.Padding = new System.Windows.Forms.Padding(7);
			this.CountriesCrudPanel.Size = new System.Drawing.Size(384, 361);
			this.CountriesCrudPanel.TabIndex = 0;
			this.CountriesCrudPanel.Text = "All Countries";
			// 
			// AllCountriesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 361);
			this.Controls.Add(this.CountriesCrudPanel);
			this.Location = new System.Drawing.Point(0, 0);
			this.Name = "AllCountriesForm";
			this.Text = "AllCountriesForm";
			this.ResumeLayout(false);

		}

		#endregion

		private AppointIn.DesktopApp.Gui.Controls.CountryCrudPanel CountriesCrudPanel;
	}
}