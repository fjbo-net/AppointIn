namespace AppointIn.DesktopApp.Gui
{
	partial class AllCustomersForm
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
			this.customerCrudPanel1 = new AppointIn.DesktopApp.Gui.Controls.CustomerCrudPanel();
			this.SuspendLayout();
			// 
			// customerCrudPanel1
			// 
			this.customerCrudPanel1.BackColor = System.Drawing.Color.Transparent;
			this.customerCrudPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.customerCrudPanel1.Location = new System.Drawing.Point(0, 0);
			this.customerCrudPanel1.Name = "customerCrudPanel1";
			this.customerCrudPanel1.Padding = new System.Windows.Forms.Padding(14);
			this.customerCrudPanel1.Size = new System.Drawing.Size(384, 361);
			this.customerCrudPanel1.TabIndex = 0;
			this.customerCrudPanel1.Text = "All Customers";
			// 
			// AllCustomersForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 361);
			this.Controls.Add(this.customerCrudPanel1);
			this.Location = new System.Drawing.Point(0, 0);
			this.Name = "AllCustomersForm";
			this.Text = "All Customers";
			this.ResumeLayout(false);

		}

		#endregion

		private AppointIn.DesktopApp.Gui.Controls.CustomerCrudPanel customerCrudPanel1;
	}
}