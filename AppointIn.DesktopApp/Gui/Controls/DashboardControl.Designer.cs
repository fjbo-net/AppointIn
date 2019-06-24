namespace AppointIn.DesktopApp.Gui
{
	partial class DashboardControl
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
			this.Header = new System.Windows.Forms.FlowLayoutPanel();
			this.TitleLabel = new System.Windows.Forms.Label();
			this.Header.SuspendLayout();
			this.SuspendLayout();
			// 
			// Header
			// 
			this.Header.Controls.Add(this.TitleLabel);
			this.Header.Dock = System.Windows.Forms.DockStyle.Top;
			this.Header.Location = new System.Drawing.Point(0, 0);
			this.Header.Name = "Header";
			this.Header.Size = new System.Drawing.Size(400, 60);
			this.Header.TabIndex = 0;
			// 
			// TitleLabel
			// 
			this.TitleLabel.AutoSize = true;
			this.TitleLabel.Location = new System.Drawing.Point(3, 0);
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Size = new System.Drawing.Size(35, 13);
			this.TitleLabel.TabIndex = 0;
			this.TitleLabel.Text = "label1";
			// 
			// DashboardControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.Header);
			this.MaximumSize = new System.Drawing.Size(400, 0);
			this.MinimumSize = new System.Drawing.Size(400, 200);
			this.Name = "DashboardControl";
			this.Size = new System.Drawing.Size(400, 200);
			this.Header.ResumeLayout(false);
			this.Header.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel Header;
		protected System.Windows.Forms.Label TitleLabel;
	}
}
