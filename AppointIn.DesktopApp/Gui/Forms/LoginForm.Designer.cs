namespace AppointIn.DesktopApp.Gui.Forms
{
	partial class LoginForm
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
			this.usernameTextbox = new System.Windows.Forms.TextBox();
			this.usernameLabel = new System.Windows.Forms.Label();
			this.passwordTextbox = new System.Windows.Forms.TextBox();
			this.passwordLabel = new System.Windows.Forms.Label();
			this.LoginButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// usernameTextbox
			// 
			this.usernameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.usernameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.usernameTextbox.Location = new System.Drawing.Point(12, 34);
			this.usernameTextbox.Name = "usernameTextbox";
			this.usernameTextbox.Size = new System.Drawing.Size(360, 19);
			this.usernameTextbox.TabIndex = 0;
			this.usernameTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// usernameLabel
			// 
			this.usernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.usernameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.usernameLabel.Location = new System.Drawing.Point(12, 9);
			this.usernameLabel.Name = "usernameLabel";
			this.usernameLabel.Size = new System.Drawing.Size(360, 22);
			this.usernameLabel.TabIndex = 1;
			this.usernameLabel.Text = "usernameLabel";
			this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// passwordTextbox
			// 
			this.passwordTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.passwordTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.passwordTextbox.Location = new System.Drawing.Point(12, 81);
			this.passwordTextbox.Name = "passwordTextbox";
			this.passwordTextbox.Size = new System.Drawing.Size(360, 19);
			this.passwordTextbox.TabIndex = 1;
			this.passwordTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.passwordTextbox.UseSystemPasswordChar = true;
			// 
			// passwordLabel
			// 
			this.passwordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.passwordLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.passwordLabel.Location = new System.Drawing.Point(12, 56);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(360, 22);
			this.passwordLabel.TabIndex = 1;
			this.passwordLabel.Text = "passwordLabel";
			this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LoginButton
			// 
			this.LoginButton.BackColor = System.Drawing.SystemColors.Highlight;
			this.LoginButton.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.LoginButton.ForeColor = System.Drawing.SystemColors.Control;
			this.LoginButton.Location = new System.Drawing.Point(0, 129);
			this.LoginButton.Name = "LoginButton";
			this.LoginButton.Size = new System.Drawing.Size(384, 32);
			this.LoginButton.TabIndex = 2;
			this.LoginButton.Text = "Log In";
			this.LoginButton.UseVisualStyleBackColor = false;
			// 
			// LoginForm
			// 
			this.AcceptButton = this.LoginButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 161);
			this.Controls.Add(this.LoginButton);
			this.Controls.Add(this.passwordLabel);
			this.Controls.Add(this.passwordTextbox);
			this.Controls.Add(this.usernameLabel);
			this.Controls.Add(this.usernameTextbox);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Location = new System.Drawing.Point(0, 0);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximumSize = new System.Drawing.Size(400, 200);
			this.MinimumSize = new System.Drawing.Size(400, 200);
			this.Name = "LoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.WindowState = System.Windows.Forms.FormWindowState.Normal;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox usernameTextbox;
		private System.Windows.Forms.Label usernameLabel;
		private System.Windows.Forms.TextBox passwordTextbox;
		private System.Windows.Forms.Label passwordLabel;
		private System.Windows.Forms.Button LoginButton;
	}
}