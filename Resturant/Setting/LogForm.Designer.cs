namespace Setting
{
	partial class LogForm
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
			this.loginControlButton = new Mbb.Windows.Forms.Button();
			this.panel100 = new Mbb.Windows.Forms.Panel();
			this.panel1 = new Mbb.Windows.Forms.Panel();
			this.activityControlButton = new Mbb.Windows.Forms.Button();
			this.homePanel = new Mbb.Windows.Forms.Panel();
			this.panel100.SuspendLayout();
			this.SuspendLayout();
			// 
			// loginControlButton
			// 
			this.loginControlButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
			this.loginControlButton.Dock = System.Windows.Forms.DockStyle.Right;
			this.loginControlButton.FlatAppearance.BorderSize = 0;
			this.loginControlButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.loginControlButton.ForeColor = System.Drawing.Color.White;
			this.loginControlButton.Location = new System.Drawing.Point(420, 0);
			this.loginControlButton.Name = "loginControlButton";
			this.loginControlButton.Size = new System.Drawing.Size(400, 45);
			this.loginControlButton.TabIndex = 0;
			this.loginControlButton.Text = "کنترل ورود و خروج کاربران";
			this.loginControlButton.UseVisualStyleBackColor = false;
			this.loginControlButton.Click += new System.EventHandler(this.loginControlButton_Click);
			// 
			// panel100
			// 
			this.panel100.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(99)))));
			this.panel100.Controls.Add(this.panel1);
			this.panel100.Controls.Add(this.activityControlButton);
			this.panel100.Controls.Add(this.loginControlButton);
			this.panel100.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel100.Location = new System.Drawing.Point(0, 0);
			this.panel100.Name = "panel100";
			this.panel100.Size = new System.Drawing.Size(820, 45);
			this.panel100.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(99)))));
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(400, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(20, 45);
			this.panel1.TabIndex = 2;
			// 
			// activityControlButton
			// 
			this.activityControlButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
			this.activityControlButton.Dock = System.Windows.Forms.DockStyle.Left;
			this.activityControlButton.FlatAppearance.BorderSize = 0;
			this.activityControlButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.activityControlButton.ForeColor = System.Drawing.Color.White;
			this.activityControlButton.Location = new System.Drawing.Point(0, 0);
			this.activityControlButton.Name = "activityControlButton";
			this.activityControlButton.Size = new System.Drawing.Size(400, 45);
			this.activityControlButton.TabIndex = 1;
			this.activityControlButton.Text = "کنترل فعالیت کاربران";
			this.activityControlButton.UseVisualStyleBackColor = false;
			this.activityControlButton.Click += new System.EventHandler(this.activityControlButton_Click);
			// 
			// homePanel
			// 
			this.homePanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.homePanel.Location = new System.Drawing.Point(0, 45);
			this.homePanel.Name = "homePanel";
			this.homePanel.Size = new System.Drawing.Size(820, 495);
			this.homePanel.TabIndex = 2;
			// 
			// LogForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.ClientSize = new System.Drawing.Size(820, 540);
			this.Controls.Add(this.homePanel);
			this.Controls.Add(this.panel100);
			this.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.Name = "LogForm";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Text = "LogForm";
			this.panel100.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Mbb.Windows.Forms.Button loginControlButton;
		private Mbb.Windows.Forms.Panel panel100;
		private Mbb.Windows.Forms.Button activityControlButton;
		private Mbb.Windows.Forms.Panel homePanel;
		private Mbb.Windows.Forms.Panel panel1;
	}
}