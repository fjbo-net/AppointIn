namespace AppointIn.DesktopApp.Gui
{
	partial class AllCitiesForm
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
			this.cityCrudPanel1 = new AppointIn.DesktopApp.Gui.Controls.CityCrudPanel();
			this.SuspendLayout();
			// 
			// cityCrudPanel1
			// 
			this.cityCrudPanel1.BackColor = System.Drawing.Color.Transparent;
			this.cityCrudPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cityCrudPanel1.Location = new System.Drawing.Point(0, 0);
			this.cityCrudPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cityCrudPanel1.Name = "cityCrudPanel1";
			this.cityCrudPanel1.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
			this.cityCrudPanel1.Size = new System.Drawing.Size(384, 361);
			this.cityCrudPanel1.TabIndex = 0;
			this.cityCrudPanel1.Text = "CrudPanel";
			// 
			// AllCitiesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 361);
			this.Controls.Add(this.cityCrudPanel1);
			this.Location = new System.Drawing.Point(0, 0);
			this.Name = "AllCitiesForm";
			this.Text = "AllCitiesForm";
			this.ResumeLayout(false);

		}

		#endregion

		private Controls.CityCrudPanel cityCrudPanel1;
	}
}