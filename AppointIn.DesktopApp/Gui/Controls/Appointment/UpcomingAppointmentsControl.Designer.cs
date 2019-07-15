namespace AppointIn.DesktopApp.Gui.Controls.Appointment
{
	partial class UpcomingAppointmentsControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.TabControl = new System.Windows.Forms.TabControl();
			this.MonthPage = new System.Windows.Forms.TabPage();
			this.WeekPage = new System.Windows.Forms.TabPage();
			this.appointmentCrudPanel1 = new AppointIn.DesktopApp.Gui.Controls.Appointment.AppointmentCrudPanel();
			this.appointmentCrudPanel2 = new AppointIn.DesktopApp.Gui.Controls.Appointment.AppointmentCrudPanel();
			this.TabControl.SuspendLayout();
			this.MonthPage.SuspendLayout();
			this.WeekPage.SuspendLayout();
			this.SuspendLayout();
			// 
			// TabControl
			// 
			this.TabControl.Controls.Add(this.MonthPage);
			this.TabControl.Controls.Add(this.WeekPage);
			this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TabControl.Location = new System.Drawing.Point(0, 0);
			this.TabControl.Name = "TabControl";
			this.TabControl.SelectedIndex = 0;
			this.TabControl.Size = new System.Drawing.Size(502, 293);
			this.TabControl.TabIndex = 0;
			// 
			// MonthPage
			// 
			this.MonthPage.Controls.Add(this.appointmentCrudPanel1);
			this.MonthPage.Location = new System.Drawing.Point(4, 22);
			this.MonthPage.Name = "MonthPage";
			this.MonthPage.Padding = new System.Windows.Forms.Padding(3);
			this.MonthPage.Size = new System.Drawing.Size(494, 267);
			this.MonthPage.TabIndex = 0;
			this.MonthPage.Text = "MonthPage";
			this.MonthPage.UseVisualStyleBackColor = true;
			// 
			// WeekPage
			// 
			this.WeekPage.Controls.Add(this.appointmentCrudPanel2);
			this.WeekPage.Location = new System.Drawing.Point(4, 22);
			this.WeekPage.Name = "WeekPage";
			this.WeekPage.Padding = new System.Windows.Forms.Padding(3);
			this.WeekPage.Size = new System.Drawing.Size(494, 267);
			this.WeekPage.TabIndex = 1;
			this.WeekPage.Text = "WeekPage";
			this.WeekPage.UseVisualStyleBackColor = true;
			// 
			// appointmentCrudPanel1
			// 
			this.appointmentCrudPanel1.BackColor = System.Drawing.Color.Transparent;
			this.appointmentCrudPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.appointmentCrudPanel1.Location = new System.Drawing.Point(3, 3);
			this.appointmentCrudPanel1.Name = "appointmentCrudPanel1";
			this.appointmentCrudPanel1.Padding = new System.Windows.Forms.Padding(7);
			this.appointmentCrudPanel1.Size = new System.Drawing.Size(488, 261);
			this.appointmentCrudPanel1.TabIndex = 0;
			this.appointmentCrudPanel1.Text = "AppointmentsByMonth";
			// 
			// appointmentCrudPanel2
			// 
			this.appointmentCrudPanel2.BackColor = System.Drawing.Color.Transparent;
			this.appointmentCrudPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.appointmentCrudPanel2.Location = new System.Drawing.Point(3, 3);
			this.appointmentCrudPanel2.Name = "appointmentCrudPanel2";
			this.appointmentCrudPanel2.Padding = new System.Windows.Forms.Padding(7);
			this.appointmentCrudPanel2.Size = new System.Drawing.Size(488, 261);
			this.appointmentCrudPanel2.TabIndex = 0;
			this.appointmentCrudPanel2.Text = "AppointmentsByWeek";
			// 
			// UpcomingAppointmentsControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.TabControl);
			this.Name = "UpcomingAppointmentsControl";
			this.Size = new System.Drawing.Size(502, 293);
			this.TabControl.ResumeLayout(false);
			this.MonthPage.ResumeLayout(false);
			this.WeekPage.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl TabControl;
		private System.Windows.Forms.TabPage MonthPage;
		private System.Windows.Forms.TabPage WeekPage;
		private AppointmentCrudPanel appointmentCrudPanel1;
		private AppointmentCrudPanel appointmentCrudPanel2;
	}
}
