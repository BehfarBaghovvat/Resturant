namespace Resturant
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.panel = new Mbb.Windows.Forms.Panel();
			this.settingButton = new Mbb.Windows.Forms.Button();
			this.homeButton = new Mbb.Windows.Forms.Button();
			this.focusPanel = new Mbb.Windows.Forms.Panel();
			this.chefMenuButton = new Mbb.Windows.Forms.Button();
			this.logOutButton = new Mbb.Windows.Forms.Button();
			this.shutDownButton = new Mbb.Windows.Forms.Button();
			this.orderButton = new Mbb.Windows.Forms.Button();
			this.deliveryButton = new Mbb.Windows.Forms.Button();
			this.clientButton = new Mbb.Windows.Forms.Button();
			this.commodityBuyButton = new Mbb.Windows.Forms.Button();
			this.menuListButton = new Mbb.Windows.Forms.Button();
			this.picturBox1 = new Mbb.Windows.Forms.PicturBox();
			this.label1 = new Mbb.Windows.Forms.Label();
			this.panel1 = new Mbb.Windows.Forms.Panel();
			this.limitButton = new Mbb.Windows.Forms.Button();
			this.minimizButton = new Mbb.Windows.Forms.Button();
			this.closeButton = new Mbb.Windows.Forms.Button();
			this.maximumButton = new Mbb.Windows.Forms.Button();
			this.restorButton = new Mbb.Windows.Forms.Button();
			this.panel2 = new Mbb.Windows.Forms.Panel();
			this.adDateLabel = new Mbb.Windows.Forms.Label();
			this.solarDateLabel = new Mbb.Windows.Forms.Label();
			this.panel3 = new Mbb.Windows.Forms.Panel();
			this.secondLabel = new Mbb.Windows.Forms.Label();
			this.minuteLabel = new Mbb.Windows.Forms.Label();
			this.hourLabel = new Mbb.Windows.Forms.Label();
			this.separatorLabel1 = new Mbb.Windows.Forms.Label();
			this.separatorLabel2 = new Mbb.Windows.Forms.Label();
			this.entryTimeLabel = new Mbb.Windows.Forms.Label();
			this.emailLabel = new Mbb.Windows.Forms.Label();
			this.fullNameLabel = new Mbb.Windows.Forms.Label();
			this.userImagePicturBox = new Mbb.Windows.Forms.PicturBox();
			this.panel4 = new Mbb.Windows.Forms.Panel();
			this.clockTimer = new System.Windows.Forms.Timer(this.components);
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picturBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.userImagePicturBox)).BeginInit();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.BackColor = System.Drawing.Color.RoyalBlue;
			this.panel.Controls.Add(this.settingButton);
			this.panel.Controls.Add(this.homeButton);
			this.panel.Controls.Add(this.focusPanel);
			this.panel.Controls.Add(this.chefMenuButton);
			this.panel.Controls.Add(this.logOutButton);
			this.panel.Controls.Add(this.shutDownButton);
			this.panel.Controls.Add(this.orderButton);
			this.panel.Controls.Add(this.deliveryButton);
			this.panel.Controls.Add(this.clientButton);
			this.panel.Controls.Add(this.commodityBuyButton);
			this.panel.Controls.Add(this.menuListButton);
			this.panel.Controls.Add(this.picturBox1);
			this.panel.Controls.Add(this.label1);
			this.panel.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel.Location = new System.Drawing.Point(0, 0);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(220, 700);
			this.panel.TabIndex = 1;
			this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
			// 
			// settingButton
			// 
			this.settingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.settingButton.AutoSize = true;
			this.settingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.settingButton.FlatAppearance.BorderSize = 0;
			this.settingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.settingButton.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.settingButton.ForeColor = System.Drawing.Color.White;
			this.settingButton.Image = ((System.Drawing.Image)(resources.GetObject("settingButton.Image")));
			this.settingButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.settingButton.Location = new System.Drawing.Point(0, 485);
			this.settingButton.Name = "settingButton";
			this.settingButton.Size = new System.Drawing.Size(208, 45);
			this.settingButton.TabIndex = 16;
			this.settingButton.Text = "تنظیمات";
			this.settingButton.UseVisualStyleBackColor = true;
			this.settingButton.Click += new System.EventHandler(this.SettingButton_Click);
			// 
			// homeButton
			// 
			this.homeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.homeButton.AutoSize = true;
			this.homeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.homeButton.FlatAppearance.BorderSize = 0;
			this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.homeButton.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.homeButton.ForeColor = System.Drawing.Color.White;
			this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
			this.homeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.homeButton.Location = new System.Drawing.Point(0, 149);
			this.homeButton.Name = "homeButton";
			this.homeButton.Size = new System.Drawing.Size(208, 45);
			this.homeButton.TabIndex = 15;
			this.homeButton.Text = "خانه";
			this.homeButton.UseVisualStyleBackColor = true;
			this.homeButton.Click += new System.EventHandler(this.HomeButton_Click);
			// 
			// focusPanel
			// 
			this.focusPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.focusPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.focusPanel.Location = new System.Drawing.Point(209, 149);
			this.focusPanel.Name = "focusPanel";
			this.focusPanel.Size = new System.Drawing.Size(11, 45);
			this.focusPanel.TabIndex = 0;
			// 
			// chefMenuButton
			// 
			this.chefMenuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.chefMenuButton.AutoSize = true;
			this.chefMenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.chefMenuButton.FlatAppearance.BorderSize = 0;
			this.chefMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.chefMenuButton.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.chefMenuButton.ForeColor = System.Drawing.Color.White;
			this.chefMenuButton.Image = ((System.Drawing.Image)(resources.GetObject("chefMenuButton.Image")));
			this.chefMenuButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.chefMenuButton.Location = new System.Drawing.Point(0, 197);
			this.chefMenuButton.Name = "chefMenuButton";
			this.chefMenuButton.Size = new System.Drawing.Size(208, 45);
			this.chefMenuButton.TabIndex = 14;
			this.chefMenuButton.Text = "منوی سرآشپز";
			this.chefMenuButton.UseVisualStyleBackColor = true;
			this.chefMenuButton.Click += new System.EventHandler(this.ChefMenuButton_Click);
			// 
			// logOutButton
			// 
			this.logOutButton.AllowDrop = true;
			this.logOutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.logOutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.logOutButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.logOutButton.FlatAppearance.BorderSize = 0;
			this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.logOutButton.Image = ((System.Drawing.Image)(resources.GetObject("logOutButton.Image")));
			this.logOutButton.Location = new System.Drawing.Point(105, 638);
			this.logOutButton.Name = "logOutButton";
			this.logOutButton.Size = new System.Drawing.Size(50, 50);
			this.logOutButton.TabIndex = 13;
			this.logOutButton.UseVisualStyleBackColor = true;
			this.logOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
			// 
			// shutDownButton
			// 
			this.shutDownButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.shutDownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.shutDownButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.shutDownButton.FlatAppearance.BorderSize = 0;
			this.shutDownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.shutDownButton.Image = ((System.Drawing.Image)(resources.GetObject("shutDownButton.Image")));
			this.shutDownButton.Location = new System.Drawing.Point(158, 638);
			this.shutDownButton.Name = "shutDownButton";
			this.shutDownButton.Size = new System.Drawing.Size(50, 50);
			this.shutDownButton.TabIndex = 12;
			this.shutDownButton.UseVisualStyleBackColor = true;
			this.shutDownButton.Click += new System.EventHandler(this.ShutDownButton_Click);
			// 
			// orderButton
			// 
			this.orderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.orderButton.AutoSize = true;
			this.orderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.orderButton.FlatAppearance.BorderSize = 0;
			this.orderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.orderButton.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.orderButton.ForeColor = System.Drawing.Color.White;
			this.orderButton.Image = ((System.Drawing.Image)(resources.GetObject("orderButton.Image")));
			this.orderButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.orderButton.Location = new System.Drawing.Point(0, 293);
			this.orderButton.Name = "orderButton";
			this.orderButton.Size = new System.Drawing.Size(208, 45);
			this.orderButton.TabIndex = 11;
			this.orderButton.Text = "دریافت سفارش";
			this.orderButton.UseVisualStyleBackColor = true;
			this.orderButton.Click += new System.EventHandler(this.OrderButton_Click);
			// 
			// deliveryButton
			// 
			this.deliveryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.deliveryButton.AutoSize = true;
			this.deliveryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.deliveryButton.FlatAppearance.BorderSize = 0;
			this.deliveryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.deliveryButton.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.deliveryButton.ForeColor = System.Drawing.Color.White;
			this.deliveryButton.Image = ((System.Drawing.Image)(resources.GetObject("deliveryButton.Image")));
			this.deliveryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.deliveryButton.Location = new System.Drawing.Point(0, 341);
			this.deliveryButton.Name = "deliveryButton";
			this.deliveryButton.Size = new System.Drawing.Size(208, 45);
			this.deliveryButton.TabIndex = 10;
			this.deliveryButton.Text = "ارسالی";
			this.deliveryButton.UseVisualStyleBackColor = true;
			this.deliveryButton.Click += new System.EventHandler(this.DeliveryButton_Click);
			// 
			// clientButton
			// 
			this.clientButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.clientButton.AutoSize = true;
			this.clientButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.clientButton.FlatAppearance.BorderSize = 0;
			this.clientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.clientButton.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.clientButton.ForeColor = System.Drawing.Color.White;
			this.clientButton.Image = ((System.Drawing.Image)(resources.GetObject("clientButton.Image")));
			this.clientButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.clientButton.Location = new System.Drawing.Point(0, 437);
			this.clientButton.Name = "clientButton";
			this.clientButton.Size = new System.Drawing.Size(208, 45);
			this.clientButton.TabIndex = 9;
			this.clientButton.Text = "مشتری";
			this.clientButton.UseVisualStyleBackColor = true;
			this.clientButton.Click += new System.EventHandler(this.ClientButton_Click);
			// 
			// commodityBuyButton
			// 
			this.commodityBuyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.commodityBuyButton.AutoSize = true;
			this.commodityBuyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.commodityBuyButton.FlatAppearance.BorderSize = 0;
			this.commodityBuyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.commodityBuyButton.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.commodityBuyButton.ForeColor = System.Drawing.Color.White;
			this.commodityBuyButton.Image = ((System.Drawing.Image)(resources.GetObject("commodityBuyButton.Image")));
			this.commodityBuyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.commodityBuyButton.Location = new System.Drawing.Point(0, 389);
			this.commodityBuyButton.Name = "commodityBuyButton";
			this.commodityBuyButton.Size = new System.Drawing.Size(208, 45);
			this.commodityBuyButton.TabIndex = 8;
			this.commodityBuyButton.Text = "خرید کالا";
			this.commodityBuyButton.UseVisualStyleBackColor = true;
			this.commodityBuyButton.Click += new System.EventHandler(this.CommodityBuyButton_Click);
			// 
			// menuListButton
			// 
			this.menuListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.menuListButton.AutoSize = true;
			this.menuListButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.menuListButton.FlatAppearance.BorderSize = 0;
			this.menuListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.menuListButton.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.menuListButton.ForeColor = System.Drawing.Color.White;
			this.menuListButton.Image = ((System.Drawing.Image)(resources.GetObject("menuListButton.Image")));
			this.menuListButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.menuListButton.Location = new System.Drawing.Point(0, 245);
			this.menuListButton.Name = "menuListButton";
			this.menuListButton.Size = new System.Drawing.Size(208, 45);
			this.menuListButton.TabIndex = 7;
			this.menuListButton.Text = "منوی اصلی";
			this.menuListButton.UseVisualStyleBackColor = true;
			this.menuListButton.Click += new System.EventHandler(this.MenuListButton_Click);
			// 
			// picturBox1
			// 
			this.picturBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picturBox1.Image = ((System.Drawing.Image)(resources.GetObject("picturBox1.Image")));
			this.picturBox1.Location = new System.Drawing.Point(150, 12);
			this.picturBox1.Name = "picturBox1";
			this.picturBox1.Size = new System.Drawing.Size(65, 65);
			this.picturBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picturBox1.TabIndex = 3;
			this.picturBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(7, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(126, 25);
			this.label1.TabIndex = 4;
			this.label1.Text = "Green Food";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.limitButton);
			this.panel1.Controls.Add(this.minimizButton);
			this.panel1.Controls.Add(this.closeButton);
			this.panel1.Controls.Add(this.maximumButton);
			this.panel1.Controls.Add(this.restorButton);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(220, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(980, 28);
			this.panel1.TabIndex = 20;
			this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
			// 
			// limitButton
			// 
			this.limitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.limitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("limitButton.BackgroundImage")));
			this.limitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.limitButton.FlatAppearance.BorderSize = 0;
			this.limitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.limitButton.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.limitButton.Location = new System.Drawing.Point(944, 7);
			this.limitButton.Name = "limitButton";
			this.limitButton.Size = new System.Drawing.Size(30, 15);
			this.limitButton.TabIndex = 9;
			this.limitButton.UseVisualStyleBackColor = true;
			this.limitButton.Click += new System.EventHandler(this.LimitButton_Click);
			// 
			// minimizButton
			// 
			this.minimizButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizButton.BackgroundImage")));
			this.minimizButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.minimizButton.FlatAppearance.BorderSize = 0;
			this.minimizButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.minimizButton.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.minimizButton.Location = new System.Drawing.Point(63, 7);
			this.minimizButton.Name = "minimizButton";
			this.minimizButton.Size = new System.Drawing.Size(15, 15);
			this.minimizButton.TabIndex = 8;
			this.minimizButton.UseVisualStyleBackColor = true;
			this.minimizButton.Click += new System.EventHandler(this.MinimizButton_Click);
			// 
			// closeButton
			// 
			this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
			this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.closeButton.FlatAppearance.BorderSize = 0;
			this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeButton.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.closeButton.Location = new System.Drawing.Point(9, 7);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(15, 15);
			this.closeButton.TabIndex = 5;
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// maximumButton
			// 
			this.maximumButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("maximumButton.BackgroundImage")));
			this.maximumButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.maximumButton.FlatAppearance.BorderSize = 0;
			this.maximumButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.maximumButton.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.maximumButton.Location = new System.Drawing.Point(37, 7);
			this.maximumButton.Name = "maximumButton";
			this.maximumButton.Size = new System.Drawing.Size(15, 15);
			this.maximumButton.TabIndex = 6;
			this.maximumButton.UseVisualStyleBackColor = true;
			this.maximumButton.Click += new System.EventHandler(this.MaximumButton_Click);
			// 
			// restorButton
			// 
			this.restorButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("restorButton.BackgroundImage")));
			this.restorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.restorButton.FlatAppearance.BorderSize = 0;
			this.restorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.restorButton.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.restorButton.Location = new System.Drawing.Point(37, 7);
			this.restorButton.Name = "restorButton";
			this.restorButton.Size = new System.Drawing.Size(15, 15);
			this.restorButton.TabIndex = 7;
			this.restorButton.UseVisualStyleBackColor = true;
			this.restorButton.Click += new System.EventHandler(this.RestorButton_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.DimGray;
			this.panel2.Controls.Add(this.adDateLabel);
			this.panel2.Controls.Add(this.solarDateLabel);
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Controls.Add(this.entryTimeLabel);
			this.panel2.Controls.Add(this.emailLabel);
			this.panel2.Controls.Add(this.fullNameLabel);
			this.panel2.Controls.Add(this.userImagePicturBox);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.panel2.Location = new System.Drawing.Point(220, 28);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(980, 120);
			this.panel2.TabIndex = 22;
			this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel2_MouseDown);
			// 
			// adDateLabel
			// 
			this.adDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.adDateLabel.ForeColor = System.Drawing.Color.White;
			this.adDateLabel.Location = new System.Drawing.Point(793, 12);
			this.adDateLabel.Name = "adDateLabel";
			this.adDateLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.adDateLabel.Size = new System.Drawing.Size(178, 17);
			this.adDateLabel.TabIndex = 24;
			this.adDateLabel.Text = "تاریخ میلادی";
			this.adDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// solarDateLabel
			// 
			this.solarDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.solarDateLabel.ForeColor = System.Drawing.Color.White;
			this.solarDateLabel.Location = new System.Drawing.Point(793, 35);
			this.solarDateLabel.Name = "solarDateLabel";
			this.solarDateLabel.Size = new System.Drawing.Size(178, 17);
			this.solarDateLabel.TabIndex = 23;
			this.solarDateLabel.Text = "تاریخ شمسی";
			this.solarDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.Controls.Add(this.secondLabel);
			this.panel3.Controls.Add(this.minuteLabel);
			this.panel3.Controls.Add(this.hourLabel);
			this.panel3.Controls.Add(this.separatorLabel1);
			this.panel3.Controls.Add(this.separatorLabel2);
			this.panel3.Location = new System.Drawing.Point(793, 57);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(181, 51);
			this.panel3.TabIndex = 22;
			this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel3_MouseDown);
			// 
			// secondLabel
			// 
			this.secondLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.secondLabel.AutoSize = true;
			this.secondLabel.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.secondLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.secondLabel.Location = new System.Drawing.Point(124, 6);
			this.secondLabel.Name = "secondLabel";
			this.secondLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.secondLabel.Size = new System.Drawing.Size(56, 42);
			this.secondLabel.TabIndex = 13;
			this.secondLabel.Text = "00";
			// 
			// minuteLabel
			// 
			this.minuteLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.minuteLabel.AutoSize = true;
			this.minuteLabel.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.minuteLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.minuteLabel.Location = new System.Drawing.Point(63, 6);
			this.minuteLabel.Name = "minuteLabel";
			this.minuteLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.minuteLabel.Size = new System.Drawing.Size(56, 42);
			this.minuteLabel.TabIndex = 11;
			this.minuteLabel.Text = "00";
			// 
			// hourLabel
			// 
			this.hourLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.hourLabel.AutoSize = true;
			this.hourLabel.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hourLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.hourLabel.Location = new System.Drawing.Point(2, 6);
			this.hourLabel.Name = "hourLabel";
			this.hourLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.hourLabel.Size = new System.Drawing.Size(56, 42);
			this.hourLabel.TabIndex = 9;
			this.hourLabel.Text = "00";
			// 
			// separatorLabel1
			// 
			this.separatorLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.separatorLabel1.AutoSize = true;
			this.separatorLabel1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.separatorLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.separatorLabel1.Location = new System.Drawing.Point(49, 3);
			this.separatorLabel1.Name = "separatorLabel1";
			this.separatorLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.separatorLabel1.Size = new System.Drawing.Size(27, 42);
			this.separatorLabel1.TabIndex = 10;
			this.separatorLabel1.Text = ":";
			// 
			// separatorLabel2
			// 
			this.separatorLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.separatorLabel2.AutoSize = true;
			this.separatorLabel2.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.separatorLabel2.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.separatorLabel2.Location = new System.Drawing.Point(110, 3);
			this.separatorLabel2.Name = "separatorLabel2";
			this.separatorLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.separatorLabel2.Size = new System.Drawing.Size(27, 42);
			this.separatorLabel2.TabIndex = 12;
			this.separatorLabel2.Text = ":";
			// 
			// entryTimeLabel
			// 
			this.entryTimeLabel.AutoEllipsis = true;
			this.entryTimeLabel.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.entryTimeLabel.ForeColor = System.Drawing.Color.White;
			this.entryTimeLabel.Location = new System.Drawing.Point(118, 81);
			this.entryTimeLabel.Name = "entryTimeLabel";
			this.entryTimeLabel.Size = new System.Drawing.Size(190, 17);
			this.entryTimeLabel.TabIndex = 21;
			this.entryTimeLabel.Text = "ساعت ورود به سیستم";
			this.entryTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// emailLabel
			// 
			this.emailLabel.AutoEllipsis = true;
			this.emailLabel.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.emailLabel.ForeColor = System.Drawing.Color.White;
			this.emailLabel.Location = new System.Drawing.Point(118, 52);
			this.emailLabel.Name = "emailLabel";
			this.emailLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.emailLabel.Size = new System.Drawing.Size(190, 17);
			this.emailLabel.TabIndex = 20;
			this.emailLabel.Text = "E-Mail";
			this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// fullNameLabel
			// 
			this.fullNameLabel.AutoEllipsis = true;
			this.fullNameLabel.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.fullNameLabel.ForeColor = System.Drawing.Color.White;
			this.fullNameLabel.Location = new System.Drawing.Point(118, 23);
			this.fullNameLabel.Name = "fullNameLabel";
			this.fullNameLabel.Size = new System.Drawing.Size(190, 17);
			this.fullNameLabel.TabIndex = 19;
			this.fullNameLabel.Text = "نام و نام خانوادگی";
			this.fullNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// userImagePicturBox
			// 
			this.userImagePicturBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userImagePicturBox.BackgroundImage")));
			this.userImagePicturBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.userImagePicturBox.Image = ((System.Drawing.Image)(resources.GetObject("userImagePicturBox.Image")));
			this.userImagePicturBox.Location = new System.Drawing.Point(12, 10);
			this.userImagePicturBox.Name = "userImagePicturBox";
			this.userImagePicturBox.Size = new System.Drawing.Size(100, 100);
			this.userImagePicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.userImagePicturBox.TabIndex = 18;
			this.userImagePicturBox.TabStop = false;
			// 
			// panel4
			// 
			this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
			this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.panel4.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.panel4.Location = new System.Drawing.Point(220, 148);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(980, 540);
			this.panel4.TabIndex = 23;
			this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel4_MouseDown);
			// 
			// clockTimer
			// 
			this.clockTimer.Interval = 50;
			this.clockTimer.Tick += new System.EventHandler(this.ClockTimer_Tick);
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 25;
			this.bunifuElipse1.TargetControl = this;
			// 
			// bunifuElipse2
			// 
			this.bunifuElipse2.ElipseRadius = 150;
			this.bunifuElipse2.TargetControl = this.userImagePicturBox;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(58)))), ((int)(((byte)(80)))));
			this.CancelButton = this.closeButton;
			this.ClientSize = new System.Drawing.Size(1200, 700);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Opacity = 0.95D;
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Text = "MainForm";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
			this.panel.ResumeLayout(false);
			this.panel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picturBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.userImagePicturBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Mbb.Windows.Forms.Panel panel;
		private Mbb.Windows.Forms.Panel focusPanel;
		private Mbb.Windows.Forms.Button chefMenuButton;
		private Mbb.Windows.Forms.Button logOutButton;
		private Mbb.Windows.Forms.Button shutDownButton;
		private Mbb.Windows.Forms.Button orderButton;
		private Mbb.Windows.Forms.Button deliveryButton;
		private Mbb.Windows.Forms.Button clientButton;
		private Mbb.Windows.Forms.Button commodityBuyButton;
		private Mbb.Windows.Forms.Button menuListButton;
		private Mbb.Windows.Forms.PicturBox picturBox1;
		private Mbb.Windows.Forms.Label label1;
		private Mbb.Windows.Forms.Panel panel1;
		private Mbb.Windows.Forms.Button limitButton;
		private Mbb.Windows.Forms.Button minimizButton;
		private Mbb.Windows.Forms.Button closeButton;
		private Mbb.Windows.Forms.Button maximumButton;
		private Mbb.Windows.Forms.Button restorButton;
		private Mbb.Windows.Forms.Panel panel2;
		private Mbb.Windows.Forms.Label adDateLabel;
		private Mbb.Windows.Forms.Label solarDateLabel;
		private Mbb.Windows.Forms.Panel panel3;
		private Mbb.Windows.Forms.Label secondLabel;
		private Mbb.Windows.Forms.Label minuteLabel;
		private Mbb.Windows.Forms.Label hourLabel;
		private Mbb.Windows.Forms.Label separatorLabel1;
		private Mbb.Windows.Forms.Label separatorLabel2;
		private Mbb.Windows.Forms.Label entryTimeLabel;
		private Mbb.Windows.Forms.Label emailLabel;
		private Mbb.Windows.Forms.Label fullNameLabel;
		private Mbb.Windows.Forms.PicturBox userImagePicturBox;
		public Mbb.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Timer clockTimer;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
		private Mbb.Windows.Forms.Button homeButton;
		private Mbb.Windows.Forms.Button settingButton;
	}
}