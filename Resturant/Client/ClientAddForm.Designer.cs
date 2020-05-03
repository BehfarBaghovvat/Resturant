namespace Client
{
	partial class ClientAddForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientAddForm));
			this.panel100 = new Mbb.Windows.Forms.Panel();
			this.label1 = new Mbb.Windows.Forms.Label();
			this.minimizeButton = new Mbb.Windows.Forms.Button();
			this.closeButton = new Mbb.Windows.Forms.Button();
			this.saveButton = new Mbb.Windows.Forms.Button();
			this.resetButton = new Mbb.Windows.Forms.Button();
			this.errorMessageLabel = new Mbb.Windows.Forms.Label();
			this.panel200 = new Mbb.Windows.Forms.Panel();
			this.clientTelTextBox = new Mbb.Windows.Forms.TextBox();
			this.checkPicturBox = new Mbb.Windows.Forms.PicturBox();
			this.panel2 = new Mbb.Windows.Forms.Panel();
			this.panel1 = new Mbb.Windows.Forms.Panel();
			this.clientNameTextBox = new Mbb.Windows.Forms.TextBox();
			this.panel = new Mbb.Windows.Forms.Panel();
			this.subscriptionCodeLabel = new Mbb.Windows.Forms.Label();
			this.newCodeButton = new Mbb.Windows.Forms.Button();
			this.panel3 = new Mbb.Windows.Forms.Panel();
			this.clientAddressTextBox = new Mbb.Windows.Forms.TextBox();
			this.panel100.SuspendLayout();
			this.panel200.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.checkPicturBox)).BeginInit();
			this.SuspendLayout();
			// 
			// panel100
			// 
			this.panel100.Controls.Add(this.label1);
			this.panel100.Controls.Add(this.minimizeButton);
			this.panel100.Controls.Add(this.closeButton);
			this.panel100.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel100.Location = new System.Drawing.Point(0, 0);
			this.panel100.Name = "panel100";
			this.panel100.Size = new System.Drawing.Size(490, 30);
			this.panel100.TabIndex = 0;
			this.panel100.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel100_MouseDown);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(425, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 19);
			this.label1.TabIndex = 2;
			this.label1.Text = "ثبت مشترک";
			// 
			// minimizeButton
			// 
			this.minimizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizeButton.BackgroundImage")));
			this.minimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.minimizeButton.FlatAppearance.BorderSize = 0;
			this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.minimizeButton.Location = new System.Drawing.Point(31, 7);
			this.minimizeButton.Name = "minimizeButton";
			this.minimizeButton.Size = new System.Drawing.Size(15, 15);
			this.minimizeButton.TabIndex = 1;
			this.minimizeButton.UseVisualStyleBackColor = true;
			this.minimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
			// 
			// closeButton
			// 
			this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
			this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.closeButton.FlatAppearance.BorderSize = 0;
			this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeButton.Location = new System.Drawing.Point(10, 8);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(15, 15);
			this.closeButton.TabIndex = 0;
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// saveButton
			// 
			this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(120)))));
			this.saveButton.FlatAppearance.BorderSize = 0;
			this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.saveButton.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.saveButton.ForeColor = System.Drawing.Color.White;
			this.saveButton.Location = new System.Drawing.Point(70, 190);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(150, 26);
			this.saveButton.TabIndex = 10;
			this.saveButton.Text = "ذخیره";
			this.saveButton.UseVisualStyleBackColor = false;
			this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// resetButton
			// 
			this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.resetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(120)))));
			this.resetButton.FlatAppearance.BorderSize = 0;
			this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.resetButton.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.resetButton.ForeColor = System.Drawing.Color.White;
			this.resetButton.Location = new System.Drawing.Point(270, 190);
			this.resetButton.Name = "resetButton";
			this.resetButton.Size = new System.Drawing.Size(150, 26);
			this.resetButton.TabIndex = 11;
			this.resetButton.Text = "حالت اولیه";
			this.resetButton.UseVisualStyleBackColor = false;
			this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
			// 
			// errorMessageLabel
			// 
			this.errorMessageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.errorMessageLabel.ForeColor = System.Drawing.Color.DimGray;
			this.errorMessageLabel.Image = ((System.Drawing.Image)(resources.GetObject("errorMessageLabel.Image")));
			this.errorMessageLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.errorMessageLabel.Location = new System.Drawing.Point(36, 183);
			this.errorMessageLabel.Name = "errorMessageLabel";
			this.errorMessageLabel.Size = new System.Drawing.Size(384, 76);
			this.errorMessageLabel.TabIndex = 12;
			this.errorMessageLabel.Text = "       کد اشتراک الزامی است!\r\n       نام اشتراک الزامی است!\r\n       تلفن اشتراک ا" +
    "لزامی است!\r\n       آدرس اشتراک الزامی است!";
			this.errorMessageLabel.Visible = false;
			// 
			// panel200
			// 
			this.panel200.Controls.Add(this.clientTelTextBox);
			this.panel200.Controls.Add(this.checkPicturBox);
			this.panel200.Controls.Add(this.panel2);
			this.panel200.Controls.Add(this.panel1);
			this.panel200.Controls.Add(this.clientNameTextBox);
			this.panel200.Controls.Add(this.panel);
			this.panel200.Controls.Add(this.subscriptionCodeLabel);
			this.panel200.Controls.Add(this.newCodeButton);
			this.panel200.Controls.Add(this.panel3);
			this.panel200.Controls.Add(this.clientAddressTextBox);
			this.panel200.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel200.Location = new System.Drawing.Point(0, 30);
			this.panel200.Name = "panel200";
			this.panel200.Size = new System.Drawing.Size(490, 150);
			this.panel200.TabIndex = 13;
			this.panel200.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel200_MouseDown);
			// 
			// clientTelTextBox
			// 
			this.clientTelTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.clientTelTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
			this.clientTelTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.clientTelTextBox.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.clientTelTextBox.ForeColor = System.Drawing.Color.DimGray;
			this.clientTelTextBox.Location = new System.Drawing.Point(320, 82);
			this.clientTelTextBox.MaxLength = 25;
			this.clientTelTextBox.Name = "clientTelTextBox";
			this.clientTelTextBox.Size = new System.Drawing.Size(130, 23);
			this.clientTelTextBox.TabIndex = 38;
			this.clientTelTextBox.Text = "تلفن مشترک";
			this.clientTelTextBox.Enter += new System.EventHandler(this.ClientTelTextBox_Enter);
			this.clientTelTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ClientTelTextBox_KeyPress);
			this.clientTelTextBox.Leave += new System.EventHandler(this.ClientTelTextBox_Leave);
			this.clientTelTextBox.Validated += new System.EventHandler(this.ClientTelTextBox_Validated);
			// 
			// checkPicturBox
			// 
			this.checkPicturBox.Image = global::Resturant.Properties.Resources.Tik_True;
			this.checkPicturBox.Location = new System.Drawing.Point(452, 6);
			this.checkPicturBox.Name = "checkPicturBox";
			this.checkPicturBox.Size = new System.Drawing.Size(20, 20);
			this.checkPicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.checkPicturBox.TabIndex = 42;
			this.checkPicturBox.TabStop = false;
			this.checkPicturBox.Visible = false;
			this.checkPicturBox.WaitOnLoad = true;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Location = new System.Drawing.Point(320, 111);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(130, 1);
			this.panel2.TabIndex = 39;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Location = new System.Drawing.Point(319, 70);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(131, 1);
			this.panel1.TabIndex = 37;
			// 
			// clientNameTextBox
			// 
			this.clientNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.clientNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
			this.clientNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.clientNameTextBox.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.clientNameTextBox.ForeColor = System.Drawing.Color.DimGray;
			this.clientNameTextBox.Location = new System.Drawing.Point(319, 41);
			this.clientNameTextBox.MaxLength = 25;
			this.clientNameTextBox.Name = "clientNameTextBox";
			this.clientNameTextBox.Size = new System.Drawing.Size(130, 23);
			this.clientNameTextBox.TabIndex = 36;
			this.clientNameTextBox.Text = "نام مشترک";
			this.clientNameTextBox.Enter += new System.EventHandler(this.ClientNameTextBox_Enter);
			this.clientNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ClientNameTextBox_KeyPress);
			this.clientNameTextBox.Leave += new System.EventHandler(this.ClientNameTextBox_Leave);
			// 
			// panel
			// 
			this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.panel.BackColor = System.Drawing.Color.White;
			this.panel.Location = new System.Drawing.Point(317, 33);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(130, 1);
			this.panel.TabIndex = 35;
			// 
			// subscriptionCodeLabel
			// 
			this.subscriptionCodeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.subscriptionCodeLabel.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.subscriptionCodeLabel.ForeColor = System.Drawing.Color.DimGray;
			this.subscriptionCodeLabel.Location = new System.Drawing.Point(345, 5);
			this.subscriptionCodeLabel.Name = "subscriptionCodeLabel";
			this.subscriptionCodeLabel.Size = new System.Drawing.Size(101, 22);
			this.subscriptionCodeLabel.TabIndex = 34;
			this.subscriptionCodeLabel.Text = "کد اشتراک";
			this.subscriptionCodeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// newCodeButton
			// 
			this.newCodeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.newCodeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("newCodeButton.BackgroundImage")));
			this.newCodeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.newCodeButton.FlatAppearance.BorderSize = 0;
			this.newCodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.newCodeButton.Location = new System.Drawing.Point(317, 5);
			this.newCodeButton.Name = "newCodeButton";
			this.newCodeButton.Size = new System.Drawing.Size(22, 22);
			this.newCodeButton.TabIndex = 33;
			this.newCodeButton.UseVisualStyleBackColor = true;
			this.newCodeButton.Click += new System.EventHandler(this.NewCodeButton_Click);
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.BackColor = System.Drawing.Color.White;
			this.panel3.Location = new System.Drawing.Point(70, 141);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(380, 1);
			this.panel3.TabIndex = 41;
			// 
			// clientAddressTextBox
			// 
			this.clientAddressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.clientAddressTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
			this.clientAddressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.clientAddressTextBox.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.clientAddressTextBox.ForeColor = System.Drawing.Color.DimGray;
			this.clientAddressTextBox.Location = new System.Drawing.Point(70, 117);
			this.clientAddressTextBox.MaxLength = 300;
			this.clientAddressTextBox.Name = "clientAddressTextBox";
			this.clientAddressTextBox.Size = new System.Drawing.Size(380, 19);
			this.clientAddressTextBox.TabIndex = 40;
			this.clientAddressTextBox.Text = "آدرس مشترک";
			this.clientAddressTextBox.Enter += new System.EventHandler(this.ClientAddressTextBox_Enter);
			this.clientAddressTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ClientAddressTextBox_KeyPress);
			this.clientAddressTextBox.Leave += new System.EventHandler(this.ClientAddressTextBox_Leave);
			this.clientAddressTextBox.Validated += new System.EventHandler(this.ClientAddressTextBox_Validated);
			// 
			// ClientAddForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(490, 225);
			this.Controls.Add(this.panel200);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.resetButton);
			this.Controls.Add(this.panel100);
			this.Controls.Add(this.errorMessageLabel);
			this.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.Name = "ClientAddForm";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Text = "ClentAddForm";
			this.Load += new System.EventHandler(this.ClentAddForm_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClientAddForm_MouseDown);
			this.panel100.ResumeLayout(false);
			this.panel100.PerformLayout();
			this.panel200.ResumeLayout(false);
			this.panel200.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.checkPicturBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Mbb.Windows.Forms.Panel panel100;
		private Mbb.Windows.Forms.Label label1;
		private Mbb.Windows.Forms.Button minimizeButton;
		private Mbb.Windows.Forms.Button closeButton;
		private Mbb.Windows.Forms.Button saveButton;
		private Mbb.Windows.Forms.Button resetButton;
		private Mbb.Windows.Forms.Label errorMessageLabel;
		private Mbb.Windows.Forms.Panel panel200;
		private Mbb.Windows.Forms.TextBox clientTelTextBox;
		private Mbb.Windows.Forms.PicturBox checkPicturBox;
		private Mbb.Windows.Forms.Panel panel2;
		private Mbb.Windows.Forms.Panel panel1;
		private Mbb.Windows.Forms.TextBox clientNameTextBox;
		private Mbb.Windows.Forms.Panel panel;
		private Mbb.Windows.Forms.Label subscriptionCodeLabel;
		private Mbb.Windows.Forms.Button newCodeButton;
		private Mbb.Windows.Forms.Panel panel3;
		private Mbb.Windows.Forms.TextBox clientAddressTextBox;
	}
}