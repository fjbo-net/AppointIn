namespace AppointIn.DesktopApp.Gui
{
	partial class CrudPanel
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
			this.HeaderPanel = new System.Windows.Forms.Panel();
			this.HeadingLabel = new System.Windows.Forms.Label();
			this.ListView = new System.Windows.Forms.ListView();
			this.ButtonPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.RemoveButton = new AppointIn.DesktopApp.Gui.ActionButton();
			this.EditButton = new AppointIn.DesktopApp.Gui.ActionButton();
			this.AddButton = new AppointIn.DesktopApp.Gui.ActionButton();
			this.HeaderPanel.SuspendLayout();
			this.ButtonPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// HeaderPanel
			// 
			this.HeaderPanel.Controls.Add(this.HeadingLabel);
			this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.HeaderPanel.Location = new System.Drawing.Point(7, 7);
			this.HeaderPanel.Name = "HeaderPanel";
			this.HeaderPanel.Size = new System.Drawing.Size(386, 50);
			this.HeaderPanel.TabIndex = 0;
			// 
			// HeadingLabel
			// 
			this.HeadingLabel.AutoSize = true;
			this.HeadingLabel.Location = new System.Drawing.Point(3, 18);
			this.HeadingLabel.Name = "HeadingLabel";
			this.HeadingLabel.Size = new System.Drawing.Size(68, 13);
			this.HeadingLabel.TabIndex = 0;
			this.HeadingLabel.Text = "CRUD Panel";
			// 
			// ListView
			// 
			this.ListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ListView.FullRowSelect = true;
			this.ListView.GridLines = true;
			this.ListView.Location = new System.Drawing.Point(7, 57);
			this.ListView.Margin = new System.Windows.Forms.Padding(3, 3, 3, 9);
			this.ListView.Name = "ListView";
			this.ListView.Size = new System.Drawing.Size(386, 236);
			this.ListView.TabIndex = 1;
			this.ListView.UseCompatibleStateImageBehavior = false;
			this.ListView.View = System.Windows.Forms.View.Details;
			// 
			// ButtonPanel
			// 
			this.ButtonPanel.Controls.Add(this.RemoveButton);
			this.ButtonPanel.Controls.Add(this.EditButton);
			this.ButtonPanel.Controls.Add(this.AddButton);
			this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.ButtonPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.ButtonPanel.Location = new System.Drawing.Point(7, 233);
			this.ButtonPanel.Name = "ButtonPanel";
			this.ButtonPanel.Size = new System.Drawing.Size(386, 60);
			this.ButtonPanel.TabIndex = 2;
			// 
			// RemoveButton
			// 
			this.RemoveButton.AutoSize = true;
			this.RemoveButton.Enabled = false;
			this.RemoveButton.Location = new System.Drawing.Point(295, 3);
			this.RemoveButton.Name = "RemoveButton";
			this.RemoveButton.Size = new System.Drawing.Size(88, 23);
			this.RemoveButton.TabIndex = 2;
			this.RemoveButton.Text = "RemoveButton";
			this.RemoveButton.UseVisualStyleBackColor = true;
			// 
			// EditButton
			// 
			this.EditButton.AutoSize = true;
			this.EditButton.Enabled = false;
			this.EditButton.Location = new System.Drawing.Point(214, 3);
			this.EditButton.Name = "EditButton";
			this.EditButton.Size = new System.Drawing.Size(75, 23);
			this.EditButton.TabIndex = 1;
			this.EditButton.Text = "EditButton";
			this.EditButton.UseVisualStyleBackColor = true;
			// 
			// AddButton
			// 
			this.AddButton.AutoSize = true;
			this.AddButton.Enabled = false;
			this.AddButton.Location = new System.Drawing.Point(133, 3);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(75, 23);
			this.AddButton.TabIndex = 0;
			this.AddButton.Text = "AddButton";
			this.AddButton.UseVisualStyleBackColor = true;
			// 
			// CrudPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.ButtonPanel);
			this.Controls.Add(this.ListView);
			this.Controls.Add(this.HeaderPanel);
			this.Name = "CrudPanel";
			this.Padding = new System.Windows.Forms.Padding(7);
			this.Size = new System.Drawing.Size(400, 300);
			this.HeaderPanel.ResumeLayout(false);
			this.HeaderPanel.PerformLayout();
			this.ButtonPanel.ResumeLayout(false);
			this.ButtonPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel HeaderPanel;
		private System.Windows.Forms.Label HeadingLabel;
		protected System.Windows.Forms.FlowLayoutPanel ButtonPanel;
		protected ActionButton AddButton;
		protected ActionButton EditButton;
		protected ActionButton RemoveButton;
		public System.Windows.Forms.ListView ListView;
	}
}
