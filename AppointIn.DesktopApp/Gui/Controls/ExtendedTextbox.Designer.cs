namespace AppointIn.DesktopApp.Gui
{
	partial class ExtendedTextbox
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
			this.Label = new System.Windows.Forms.Label();
			this.TextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// Label
			// 
			this.Label.Dock = System.Windows.Forms.DockStyle.Left;
			this.Label.Location = new System.Drawing.Point(0, 0);
			this.Label.Name = "Label";
			this.Label.Size = new System.Drawing.Size(150, 20);
			this.Label.TabIndex = 0;
			this.Label.Text = "label1";
			this.Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// TextBox
			// 
			this.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TextBox.Location = new System.Drawing.Point(150, 0);
			this.TextBox.Name = "TextBox";
			this.TextBox.Size = new System.Drawing.Size(250, 17);
			this.TextBox.TabIndex = 1;
			// 
			// ExtendedTextbox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.TextBox);
			this.Controls.Add(this.Label);
			this.Name = "ExtendedTextbox";
			this.Size = new System.Drawing.Size(400, 20);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label Label;
		private System.Windows.Forms.TextBox TextBox;
	}
}
