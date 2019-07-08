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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.actionButton1 = new AppointIn.DesktopApp.Gui.ActionButton();
			this.ManageCountriesButton = new AppointIn.DesktopApp.Gui.ActionButton();
			this.ManageCitiesButton = new AppointIn.DesktopApp.Gui.ActionButton();
			this.ManageAddressesButton = new AppointIn.DesktopApp.Gui.ActionButton();
			this.ManageAppointmentsButton = new AppointIn.DesktopApp.Gui.ActionButton();
			this.groupBox1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.flowLayoutPanel1);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(360, 60);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Customers";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.actionButton1);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 20);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(354, 37);
			this.flowLayoutPanel1.TabIndex = 0;
			// 
			// actionButton1
			// 
			this.actionButton1.AutoSize = true;
			this.actionButton1.Location = new System.Drawing.Point(242, 3);
			this.actionButton1.Name = "actionButton1";
			this.actionButton1.Size = new System.Drawing.Size(109, 28);
			this.actionButton1.TabIndex = 0;
			this.actionButton1.Text = "View All";
			this.actionButton1.UseVisualStyleBackColor = true;
			// 
			// ManageCountriesButton
			// 
			this.ManageCountriesButton.AutoSize = true;
			this.ManageCountriesButton.Location = new System.Drawing.Point(15, 78);
			this.ManageCountriesButton.Name = "ManageCountriesButton";
			this.ManageCountriesButton.Size = new System.Drawing.Size(139, 28);
			this.ManageCountriesButton.TabIndex = 2;
			this.ManageCountriesButton.Text = "Manage Countries";
			this.ManageCountriesButton.UseVisualStyleBackColor = true;
			// 
			// ManageCitiesButton
			// 
			this.ManageCitiesButton.AutoSize = true;
			this.ManageCitiesButton.Location = new System.Drawing.Point(160, 78);
			this.ManageCitiesButton.Name = "ManageCitiesButton";
			this.ManageCitiesButton.Size = new System.Drawing.Size(139, 28);
			this.ManageCitiesButton.TabIndex = 2;
			this.ManageCitiesButton.Text = "Manage Cities";
			this.ManageCitiesButton.UseVisualStyleBackColor = true;
			// 
			// ManageAddressesButton
			// 
			this.ManageAddressesButton.AutoSize = true;
			this.ManageAddressesButton.Location = new System.Drawing.Point(15, 112);
			this.ManageAddressesButton.Name = "ManageAddressesButton";
			this.ManageAddressesButton.Size = new System.Drawing.Size(145, 28);
			this.ManageAddressesButton.TabIndex = 2;
			this.ManageAddressesButton.Text = "Manage Addresses";
			this.ManageAddressesButton.UseVisualStyleBackColor = true;
			// 
			// ManageAppointmentsButton
			// 
			this.ManageAppointmentsButton.AutoSize = true;
			this.ManageAppointmentsButton.Location = new System.Drawing.Point(166, 112);
			this.ManageAppointmentsButton.Name = "ManageAppointmentsButton";
			this.ManageAppointmentsButton.Size = new System.Drawing.Size(165, 28);
			this.ManageAppointmentsButton.TabIndex = 2;
			this.ManageAppointmentsButton.Text = "Manage Appointments";
			this.ManageAppointmentsButton.UseVisualStyleBackColor = true;
			// 
			// Dashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::AppointIn.DesktopApp.Properties.Resources.White_Abstract_Wallpapers_Gallery_89_Plus_PIC_WPW405898_1_1_;
			this.ClientSize = new System.Drawing.Size(384, 361);
			this.Controls.Add(this.ManageAppointmentsButton);
			this.Controls.Add(this.ManageAddressesButton);
			this.Controls.Add(this.ManageCitiesButton);
			this.Controls.Add(this.ManageCountriesButton);
			this.Controls.Add(this.groupBox1);
			this.Location = new System.Drawing.Point(0, 0);
			this.Name = "Dashboard";
			this.Text = "Dashboard";
			this.groupBox1.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private ActionButton actionButton1;
		private ActionButton ManageCountriesButton;
		private ActionButton ManageCitiesButton;
		private ActionButton ManageAddressesButton;
		private ActionButton ManageAppointmentsButton;
	}
}