namespace Client
{
	partial class ClientsEditForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientsEditForm));
			this.panel100 = new Mbb.Windows.Forms.Panel();
			this.titleLabel = new Mbb.Windows.Forms.Label();
			this.minimizeButton = new Mbb.Windows.Forms.Button();
			this.closeButton = new Mbb.Windows.Forms.Button();
			this.panel200 = new Mbb.Windows.Forms.Panel();
			this.errorMessageLabel = new Mbb.Windows.Forms.Label();
			this.panel3 = new Mbb.Windows.Forms.Panel();
			this.clientAddressTextBox = new Mbb.Windows.Forms.TextBox();
			this.panel2 = new Mbb.Windows.Forms.Panel();
			this.clientTelTextBox = new Mbb.Windows.Forms.TextBox();
			this.panel1 = new Mbb.Windows.Forms.Panel();
			this.panel = new Mbb.Windows.Forms.Panel();
			this.subscriptionCodeLabel = new Mbb.Windows.Forms.Label();
			this.clientNameTextBox = new Mbb.Windows.Forms.TextBox();
			this.saveEditButton = new Mbb.Windows.Forms.Button();
			this.panel100.SuspendLayout();
			this.panel200.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel100
			// 
			this.panel100.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.panel100.Controls.Add(this.titleLabel);
			this.panel100.Controls.Add(this.minimizeButton);
			this.panel100.Controls.Add(this.closeButton);
			this.panel100.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel100.Location = new System.Drawing.Point(0, 0);
			this.panel100.Name = "panel100";
			this.panel100.Size = new System.Drawing.Size(490, 30);
			this.panel100.TabIndex = 0;
			this.panel100.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel100_MouseDown);
			// 
			// titleLabel
			// 
			this.titleLabel.AutoSize = true;
			this.titleLabel.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.titleLabel.ForeColor = System.Drawing.Color.White;
			this.titleLabel.Location = new System.Drawing.Point(400, 6);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(78, 19);
			this.titleLabel.TabIndex = 2;
			this.titleLabel.Text = "ویرایش مشترک";
			// 
			// minimizeButton
			// 
			this.minimizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizeButton.BackgroundImage")));
			this.minimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.minimizeButton.FlatAppearance.BorderSize = 0;
			this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.minimizeButton.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.minimizeButton.Location = new System.Drawing.Point(33, 8);
			this.minimizeButton.Name = "minimizeButton";
			this.minimizeButton.Size = new System.Drawing.Size(15, 15);
			this.minimizeButton.TabIndex = 1;
			this.minimizeButton.UseVisualStyleBackColor = true;
			this.minimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
			// 
			// closeButton
			// 
			this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
			this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.closeButton.FlatAppearance.BorderSize = 0;
			this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeButton.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.closeButton.Location = new System.Drawing.Point(12, 8);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(15, 15);
			this.closeButton.TabIndex = 0;
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// panel200
			// 
			this.panel200.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.panel200.Controls.Add(this.errorMessageLabel);
			this.panel200.Controls.Add(this.panel3);
			this.panel200.Controls.Add(this.clientAddressTextBox);
			this.panel200.Controls.Add(this.panel2);
			this.panel200.Controls.Add(this.clientTelTextBox);
			this.panel200.Controls.Add(this.panel1);
			this.panel200.Controls.Add(this.panel);
			this.panel200.Controls.Add(this.subscriptionCodeLabel);
			this.panel200.Controls.Add(this.clientNameTextBox);
			this.panel200.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel200.Location = new System.Drawing.Point(0, 30);
			this.panel200.Name = "panel200";
			this.panel200.Size = new System.Drawing.Size(490, 184);
			this.panel200.TabIndex = 1;
			this.panel200.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel200_MouseDown);
			// 
			// errorMessageLabel
			// 
			this.errorMessageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.errorMessageLabel.ForeColor = System.Drawing.Color.DimGray;
			this.errorMessageLabel.Image = ((System.Drawing.Image)(resources.GetObject("errorMessageLabel.Image")));
			this.errorMessageLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.errorMessageLabel.Location = new System.Drawing.Point(53, 160);
			this.errorMessageLabel.Name = "errorMessageLabel";
			this.errorMessageLabel.Size = new System.Drawing.Size(384, 76);
			this.errorMessageLabel.TabIndex = 13;
			this.errorMessageLabel.Text = "       کد اشتراک الزامی است!\r\n       نام اشتراک الزامی است!\r\n       تلفن اشتراک ا" +
    "لزامی است!\r\n       آدرس اشتراک الزامی است!";
			this.errorMessageLabel.Visible = false;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.White;
			this.panel3.Location = new System.Drawing.Point(25, 156);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(450, 1);
			this.panel3.TabIndex = 7;
			// 
			// clientAddressTextBox
			// 
			this.clientAddressTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.clientAddressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.clientAddressTextBox.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.clientAddressTextBox.ForeColor = System.Drawing.Color.DimGray;
			this.clientAddressTextBox.Location = new System.Drawing.Point(25, 131);
			this.clientAddressTextBox.MaxLength = 300;
			this.clientAddressTextBox.Name = "clientAddressTextBox";
			this.clientAddressTextBox.Size = new System.Drawing.Size(450, 19);
			this.clientAddressTextBox.TabIndex = 6;
			this.clientAddressTextBox.Text = "آدرس مشترک";
			this.clientAddressTextBox.DoubleClick += new System.EventHandler(this.clientAddressTextBox_DoubleClick);
			this.clientAddressTextBox.Enter += new System.EventHandler(this.ClientAddressTextBox_Enter);
			this.clientAddressTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ClientAddressTextBox_KeyPress);
			this.clientAddressTextBox.Leave += new System.EventHandler(this.ClientAddressTextBox_Leave);
			this.clientAddressTextBox.Validated += new System.EventHandler(this.ClientAddressTextBox_Validated);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Location = new System.Drawing.Point(325, 119);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(150, 1);
			this.panel2.TabIndex = 5;
			// 
			// clientTelTextBox
			// 
			this.clientTelTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.clientTelTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.clientTelTextBox.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.clientTelTextBox.ForeColor = System.Drawing.Color.DimGray;
			this.clientTelTextBox.Location = new System.Drawing.Point(325, 92);
			this.clientTelTextBox.MaxLength = 9;
			this.clientTelTextBox.Name = "clientTelTextBox";
			this.clientTelTextBox.Size = new System.Drawing.Size(150, 21);
			this.clientTelTextBox.TabIndex = 4;
			this.clientTelTextBox.Text = "تلفن مشترک";
			this.clientTelTextBox.DoubleClick += new System.EventHandler(this.clientTelTextBox_DoubleClick);
			this.clientTelTextBox.Enter += new System.EventHandler(this.ClientTelTextBox_Enter);
			this.clientTelTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ClientTelTextBox_KeyPress);
			this.clientTelTextBox.Leave += new System.EventHandler(this.ClientTelTextBox_Leave);
			this.clientTelTextBox.Validated += new System.EventHandler(this.ClientTelTextBox_Validated);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Location = new System.Drawing.Point(325, 80);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(150, 1);
			this.panel1.TabIndex = 3;
			// 
			// panel
			// 
			this.panel.BackColor = System.Drawing.Color.White;
			this.panel.Location = new System.Drawing.Point(375, 41);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(100, 1);
			this.panel.TabIndex = 1;
			// 
			// subscriptionCodeLabel
			// 
			this.subscriptionCodeLabel.ForeColor = System.Drawing.Color.DimGray;
			this.subscriptionCodeLabel.Location = new System.Drawing.Point(375, 13);
			this.subscriptionCodeLabel.Name = "subscriptionCodeLabel";
			this.subscriptionCodeLabel.Size = new System.Drawing.Size(100, 25);
			this.subscriptionCodeLabel.TabIndex = 0;
			this.subscriptionCodeLabel.Text = "کد اشتراک";
			this.subscriptionCodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// clientNameTextBox
			// 
			this.clientNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.clientNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.clientNameTextBox.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.clientNameTextBox.ForeColor = System.Drawing.Color.DimGray;
			this.clientNameTextBox.Location = new System.Drawing.Point(325, 53);
			this.clientNameTextBox.MaxLength = 25;
			this.clientNameTextBox.Name = "clientNameTextBox";
			this.clientNameTextBox.Size = new System.Drawing.Size(150, 21);
			this.clientNameTextBox.TabIndex = 2;
			this.clientNameTextBox.Text = "نام مشترک";
			this.clientNameTextBox.DoubleClick += new System.EventHandler(this.clientNameTextBox_DoubleClick);
			this.clientNameTextBox.Enter += new System.EventHandler(this.ClientNameTextBox_Enter);
			this.clientNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ClientNameTextBox_KeyPress);
			this.clientNameTextBox.Leave += new System.EventHandler(this.ClientNameTextBox_Leave);
			// 
			// saveEditButton
			// 
			this.saveEditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(99)))));
			this.saveEditButton.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.saveEditButton.FlatAppearance.BorderSize = 0;
			this.saveEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.saveEditButton.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.saveEditButton.ForeColor = System.Drawing.Color.White;
			this.saveEditButton.Location = new System.Drawing.Point(0, 213);
			this.saveEditButton.Name = "saveEditButton";
			this.saveEditButton.Size = new System.Drawing.Size(490, 37);
			this.saveEditButton.TabIndex = 2;
			this.saveEditButton.Text = "ثبت ویرایش";
			this.saveEditButton.UseVisualStyleBackColor = false;
			this.saveEditButton.Click += new System.EventHandler(this.SaveEditButton_Click);
			// 
			// ClientsEditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(490, 250);
			this.Controls.Add(this.saveEditButton);
			this.Controls.Add(this.panel200);
			this.Controls.Add(this.panel100);
			this.Name = "ClientsEditForm";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Text = "ClientsEditForm";
			this.Load += new System.EventHandler(this.ClientsEditForm_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClientsEditForm_MouseDown);
			this.panel100.ResumeLayout(false);
			this.panel100.PerformLayout();
			this.panel200.ResumeLayout(false);
			this.panel200.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Mbb.Windows.Forms.Panel panel100;
		private Mbb.Windows.Forms.Panel panel200;
		private Mbb.Windows.Forms.Button closeButton;
		private Mbb.Windows.Forms.Button saveEditButton;
		private Mbb.Windows.Forms.Button minimizeButton;
		private Mbb.Windows.Forms.Label titleLabel;
		private Mbb.Windows.Forms.TextBox clientNameTextBox;
		private Mbb.Windows.Forms.Panel panel3;
		private Mbb.Windows.Forms.TextBox clientAddressTextBox;
		private Mbb.Windows.Forms.Panel panel2;
		private Mbb.Windows.Forms.TextBox clientTelTextBox;
		private Mbb.Windows.Forms.Panel panel1;
		private Mbb.Windows.Forms.Panel panel;
		private Mbb.Windows.Forms.Label subscriptionCodeLabel;
		private Mbb.Windows.Forms.Label errorMessageLabel;
	}
}