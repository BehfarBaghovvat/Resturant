namespace Setting
{
	partial class SettingForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
			this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.menupanel = new Mbb.Windows.Forms.Panel();
			this.focusPanel = new Mbb.Windows.Forms.Panel();
			this.controlPanelPicturBox = new Mbb.Windows.Forms.PicturBox();
			this.tableLayoutPanel = new Mbb.Windows.Forms.TableLayoutPanel();
			this.button4 = new Mbb.Windows.Forms.Button();
			this.button3 = new Mbb.Windows.Forms.Button();
			this.logButton = new Mbb.Windows.Forms.Button();
			this.userControlButton = new Mbb.Windows.Forms.Button();
			this.homePanel = new Mbb.Windows.Forms.Panel();
			this.menupanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.controlPanelPicturBox)).BeginInit();
			this.tableLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// bunifuElipse2
			// 
			this.bunifuElipse2.ElipseRadius = 0;
			this.bunifuElipse2.TargetControl = this;
			// 
			// menupanel
			// 
			this.menupanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(99)))));
			this.menupanel.Controls.Add(this.focusPanel);
			this.menupanel.Controls.Add(this.controlPanelPicturBox);
			this.menupanel.Controls.Add(this.tableLayoutPanel);
			this.menupanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.menupanel.Location = new System.Drawing.Point(0, 0);
			this.menupanel.Name = "menupanel";
			this.menupanel.Size = new System.Drawing.Size(160, 540);
			this.menupanel.TabIndex = 0;
			this.menupanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
			// 
			// focusPanel
			// 
			this.focusPanel.BackColor = System.Drawing.Color.Teal;
			this.focusPanel.Location = new System.Drawing.Point(151, 160);
			this.focusPanel.Name = "focusPanel";
			this.focusPanel.Size = new System.Drawing.Size(10, 44);
			this.focusPanel.TabIndex = 5;
			// 
			// controlPanelPicturBox
			// 
			this.controlPanelPicturBox.Image = ((System.Drawing.Image)(resources.GetObject("controlPanelPicturBox.Image")));
			this.controlPanelPicturBox.Location = new System.Drawing.Point(33, 25);
			this.controlPanelPicturBox.Name = "controlPanelPicturBox";
			this.controlPanelPicturBox.Size = new System.Drawing.Size(95, 95);
			this.controlPanelPicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.controlPanelPicturBox.TabIndex = 2;
			this.controlPanelPicturBox.TabStop = false;
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(99)))));
			this.tableLayoutPanel.ColumnCount = 1;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel.Controls.Add(this.button4, 0, 3);
			this.tableLayoutPanel.Controls.Add(this.button3, 0, 2);
			this.tableLayoutPanel.Controls.Add(this.logButton, 0, 1);
			this.tableLayoutPanel.Controls.Add(this.userControlButton, 0, 0);
			this.tableLayoutPanel.Location = new System.Drawing.Point(-7, 157);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.tableLayoutPanel.RowCount = 4;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel.Size = new System.Drawing.Size(160, 200);
			this.tableLayoutPanel.TabIndex = 1;
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.button4.ForeColor = System.Drawing.Color.White;
			this.button4.Location = new System.Drawing.Point(3, 153);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(154, 44);
			this.button4.TabIndex = 3;
			this.button4.Text = "button4";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Visible = false;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.button3.ForeColor = System.Drawing.Color.White;
			this.button3.Location = new System.Drawing.Point(3, 103);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(154, 44);
			this.button3.TabIndex = 2;
			this.button3.Text = "button3";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Visible = false;
			// 
			// logButton
			// 
			this.logButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
			this.logButton.FlatAppearance.BorderSize = 0;
			this.logButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.logButton.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.logButton.ForeColor = System.Drawing.Color.White;
			this.logButton.Image = ((System.Drawing.Image)(resources.GetObject("logButton.Image")));
			this.logButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.logButton.Location = new System.Drawing.Point(3, 53);
			this.logButton.Name = "logButton";
			this.logButton.Size = new System.Drawing.Size(154, 44);
			this.logButton.TabIndex = 1;
			this.logButton.Text = "رخدادها";
			this.logButton.UseVisualStyleBackColor = false;
			this.logButton.Click += new System.EventHandler(this.LogButton_Click);
			// 
			// userControlButton
			// 
			this.userControlButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
			this.userControlButton.FlatAppearance.BorderSize = 0;
			this.userControlButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.userControlButton.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.userControlButton.ForeColor = System.Drawing.Color.White;
			this.userControlButton.Image = ((System.Drawing.Image)(resources.GetObject("userControlButton.Image")));
			this.userControlButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.userControlButton.Location = new System.Drawing.Point(3, 3);
			this.userControlButton.Name = "userControlButton";
			this.userControlButton.Size = new System.Drawing.Size(154, 44);
			this.userControlButton.TabIndex = 0;
			this.userControlButton.Text = "کنترل کاربران";
			this.userControlButton.UseVisualStyleBackColor = false;
			this.userControlButton.Click += new System.EventHandler(this.UserControlButton_Click);
			// 
			// homePanel
			// 
			this.homePanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.homePanel.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.homePanel.Location = new System.Drawing.Point(160, 0);
			this.homePanel.Name = "homePanel";
			this.homePanel.Size = new System.Drawing.Size(820, 540);
			this.homePanel.TabIndex = 1;
			// 
			// SettingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.ClientSize = new System.Drawing.Size(980, 540);
			this.Controls.Add(this.homePanel);
			this.Controls.Add(this.menupanel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "SettingForm";
			this.Opacity = 0.95D;
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Text = "SettingForm";
			this.Load += new System.EventHandler(this.SettingForm_Load);
			this.menupanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.controlPanelPicturBox)).EndInit();
			this.tableLayoutPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private Mbb.Windows.Forms.TableLayoutPanel tableLayoutPanel;
		private Mbb.Windows.Forms.Button button4;
		private Mbb.Windows.Forms.Button button3;
		private Mbb.Windows.Forms.Button logButton;
		private Mbb.Windows.Forms.Button userControlButton;
		private Mbb.Windows.Forms.Panel menupanel;
		private Mbb.Windows.Forms.PicturBox controlPanelPicturBox;
		private Mbb.Windows.Forms.Panel homePanel;
		private Mbb.Windows.Forms.Panel focusPanel;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
	}
}