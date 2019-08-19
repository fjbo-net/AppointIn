namespace AppointIn.DesktopApp.Gui
{
	partial class Dashboard
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
			this.UpcomingAppointmentsGroupbox = new System.Windows.Forms.GroupBox();
			this.upcomingAppointmentsControl1 = new AppointIn.DesktopApp.Gui.Controls.Appointment.UpcomingAppointmentsControl();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.ManageRecordsMenuButton = new System.Windows.Forms.ToolStripMenuItem();
			this.ManageCountriesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ManageCitiesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ManageAddressesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ManageCustomersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ManageAppointmentsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ReportsMenuButton = new System.Windows.Forms.ToolStripMenuItem();
			this.AppointmentsPerMonthReportMenuButton = new System.Windows.Forms.ToolStripMenuItem();
			this.UserScheduleReportMenuButton = new System.Windows.Forms.ToolStripMenuItem();
			this.CustomerCountrySummaryMenuButton = new System.Windows.Forms.ToolStripMenuItem();
			this.UpcomingAppointmentsGroupbox.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// UpcomingAppointmentsGroupbox
			// 
			this.UpcomingAppointmentsGroupbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.UpcomingAppointmentsGroupbox.BackColor = System.Drawing.Color.Transparent;
			this.UpcomingAppointmentsGroupbox.Controls.Add(this.upcomingAppointmentsControl1);
			this.UpcomingAppointmentsGroupbox.Location = new System.Drawing.Point(15, 40);
			this.UpcomingAppointmentsGroupbox.Name = "UpcomingAppointmentsGroupbox";
			this.UpcomingAppointmentsGroupbox.Size = new System.Drawing.Size(354, 309);
			this.UpcomingAppointmentsGroupbox.TabIndex = 3;
			this.UpcomingAppointmentsGroupbox.TabStop = false;
			this.UpcomingAppointmentsGroupbox.Text = "UpcomingAppointmentsLabel";
			// 
			// upcomingAppointmentsControl1
			// 
			this.upcomingAppointmentsControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.upcomingAppointmentsControl1.BackColor = System.Drawing.Color.Transparent;
			this.upcomingAppointmentsControl1.Location = new System.Drawing.Point(8, 24);
			this.upcomingAppointmentsControl1.Margin = new System.Windows.Forms.Padding(4);
			this.upcomingAppointmentsControl1.Name = "upcomingAppointmentsControl1";
			this.upcomingAppointmentsControl1.Size = new System.Drawing.Size(344, 278);
			this.upcomingAppointmentsControl1.TabIndex = 0;
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManageRecordsMenuButton,
            this.ReportsMenuButton});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(384, 24);
			this.menuStrip1.TabIndex = 4;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// ManageRecordsMenuButton
			// 
			this.ManageRecordsMenuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ManageCountriesMenuItem,
            this.ManageCitiesMenuItem,
            this.ManageAddressesMenuItem,
            this.ManageCustomersMenuItem,
            this.ManageAppointmentsMenuItem});
			this.ManageRecordsMenuButton.Name = "ManageRecordsMenuButton";
			this.ManageRecordsMenuButton.Size = new System.Drawing.Size(107, 20);
			this.ManageRecordsMenuButton.Text = "Manage Records";
			// 
			// ManageCountriesMenuItem
			// 
			this.ManageCountriesMenuItem.Name = "ManageCountriesMenuItem";
			this.ManageCountriesMenuItem.Size = new System.Drawing.Size(214, 22);
			this.ManageCountriesMenuItem.Text = "ManageCountriesText";
			// 
			// ManageCitiesMenuItem
			// 
			this.ManageCitiesMenuItem.Name = "ManageCitiesMenuItem";
			this.ManageCitiesMenuItem.Size = new System.Drawing.Size(214, 22);
			this.ManageCitiesMenuItem.Text = "ManageCitiesText";
			// 
			// ManageAddressesMenuItem
			// 
			this.ManageAddressesMenuItem.Name = "ManageAddressesMenuItem";
			this.ManageAddressesMenuItem.Size = new System.Drawing.Size(214, 22);
			this.ManageAddressesMenuItem.Text = "ManageAddressesText";
			// 
			// ManageCustomersMenuItem
			// 
			this.ManageCustomersMenuItem.Name = "ManageCustomersMenuItem";
			this.ManageCustomersMenuItem.Size = new System.Drawing.Size(214, 22);
			this.ManageCustomersMenuItem.Text = "ManageCustomersText";
			// 
			// ManageAppointmentsMenuItem
			// 
			this.ManageAppointmentsMenuItem.Name = "ManageAppointmentsMenuItem";
			this.ManageAppointmentsMenuItem.Size = new System.Drawing.Size(214, 22);
			this.ManageAppointmentsMenuItem.Text = "ManageAppointmentsText";
			// 
			// ReportsMenuButton
			// 
			this.ReportsMenuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AppointmentsPerMonthReportMenuButton,
            this.UserScheduleReportMenuButton,
            this.CustomerCountrySummaryMenuButton});
			this.ReportsMenuButton.Name = "ReportsMenuButton";
			this.ReportsMenuButton.Size = new System.Drawing.Size(80, 20);
			this.ReportsMenuButton.Text = "ReportsText";
			// 
			// AppointmentsPerMonthReportMenuButton
			// 
			this.AppointmentsPerMonthReportMenuButton.Name = "AppointmentsPerMonthReportMenuButton";
			this.AppointmentsPerMonthReportMenuButton.Size = new System.Drawing.Size(241, 22);
			this.AppointmentsPerMonthReportMenuButton.Text = "AppointmentsPerMonthText";
			// 
			// UserScheduleReportMenuButton
			// 
			this.UserScheduleReportMenuButton.Name = "UserScheduleReportMenuButton";
			this.UserScheduleReportMenuButton.Size = new System.Drawing.Size(241, 22);
			this.UserScheduleReportMenuButton.Text = "UserScheduleText";
			// 
			// CustomerCountrySummaryMenuButton
			// 
			this.CustomerCountrySummaryMenuButton.Name = "CustomerCountrySummaryMenuButton";
			this.CustomerCountrySummaryMenuButton.Size = new System.Drawing.Size(241, 22);
			this.CustomerCountrySummaryMenuButton.Text = "CustomerCountrySummaryText";
			// 
			// Dashboard
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::AppointIn.DesktopApp.Properties.Resources.White_Abstract_Wallpapers_Gallery_89_Plus_PIC_WPW405898_1_1_;
			this.ClientSize = new System.Drawing.Size(384, 361);
			this.Controls.Add(this.UpcomingAppointmentsGroupbox);
			this.Controls.Add(this.menuStrip1);
			this.Location = new System.Drawing.Point(0, 0);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Dashboard";
			this.Text = "Dashboard";
			this.UpcomingAppointmentsGroupbox.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.GroupBox UpcomingAppointmentsGroupbox;
		private Controls.Appointment.UpcomingAppointmentsControl upcomingAppointmentsControl1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem ManageRecordsMenuButton;
		private System.Windows.Forms.ToolStripMenuItem ManageCountriesMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ManageCitiesMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ManageAddressesMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ManageCustomersMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ManageAppointmentsMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ReportsMenuButton;
		private System.Windows.Forms.ToolStripMenuItem AppointmentsPerMonthReportMenuButton;
		private System.Windows.Forms.ToolStripMenuItem UserScheduleReportMenuButton;
		private System.Windows.Forms.ToolStripMenuItem CustomerCountrySummaryMenuButton;
	}
}