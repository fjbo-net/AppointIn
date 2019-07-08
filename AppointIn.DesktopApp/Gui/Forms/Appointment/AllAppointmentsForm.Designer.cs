namespace AppointIn.DesktopApp.Gui
{
	partial class AllAppointmentsForm
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
			this.CrudPanel = new AppointIn.DesktopApp.Gui.Controls.Appointment.AppointmentCrudPanel();
			this.SuspendLayout();
			// 
			// CrudPanel
			// 
			this.CrudPanel.BackColor = System.Drawing.Color.Transparent;
			this.CrudPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.CrudPanel.Location = new System.Drawing.Point(0, 0);
			this.CrudPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.CrudPanel.Name = "CrudPanel";
			this.CrudPanel.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
			this.CrudPanel.Size = new System.Drawing.Size(576, 500);
			this.CrudPanel.TabIndex = 0;
			this.CrudPanel.Text = "appointmentCrudPanel1";
			// 
			// AllAppointmentsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(576, 500);
			this.Controls.Add(this.CrudPanel);
			this.Location = new System.Drawing.Point(0, 0);
			this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.MinimumSize = new System.Drawing.Size(592, 539);
			this.Name = "AllAppointmentsForm";
			this.Text = "AllAppointmentsForm";
			this.ResumeLayout(false);

		}

		#endregion

		private Controls.Appointment.AppointmentCrudPanel CrudPanel;
	}
}