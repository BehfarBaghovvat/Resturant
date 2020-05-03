namespace ChefMenu
{
	partial class SpecialMenuForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpecialMenuForm));
			this.foodImagePicturBox = new Mbb.Windows.Forms.PicturBox();
			this.foodDescriptionTextBox = new Mbb.Windows.Forms.TextBox();
			this.panel2 = new Mbb.Windows.Forms.Panel();
			this.foodNameTextBox = new Mbb.Windows.Forms.TextBox();
			this.foodPriceTextBox = new Mbb.Windows.Forms.TextBox();
			this.orderButton = new Mbb.Windows.Forms.Button();
			this.label1 = new Mbb.Windows.Forms.Label();
			this.chefMenuButton = new Mbb.Windows.Forms.Button();
			this.specialMenuButton = new Mbb.Windows.Forms.Button();
			this.panel1 = new Mbb.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.foodImagePicturBox)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// foodImagePicturBox
			// 
			this.foodImagePicturBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.foodImagePicturBox.Image = ((System.Drawing.Image)(resources.GetObject("foodImagePicturBox.Image")));
			this.foodImagePicturBox.Location = new System.Drawing.Point(12, 5);
			this.foodImagePicturBox.Name = "foodImagePicturBox";
			this.foodImagePicturBox.Size = new System.Drawing.Size(288, 422);
			this.foodImagePicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.foodImagePicturBox.TabIndex = 37;
			this.foodImagePicturBox.TabStop = false;
			this.foodImagePicturBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FoodImagePicturBox_MouseDoubleClick);
			// 
			// foodDescriptionTextBox
			// 
			this.foodDescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.foodDescriptionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
			this.foodDescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.foodDescriptionTextBox.Font = new System.Drawing.Font("IRANSans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.foodDescriptionTextBox.ForeColor = System.Drawing.Color.Lime;
			this.foodDescriptionTextBox.Location = new System.Drawing.Point(306, 206);
			this.foodDescriptionTextBox.Multiline = true;
			this.foodDescriptionTextBox.Name = "foodDescriptionTextBox";
			this.foodDescriptionTextBox.ReadOnly = true;
			this.foodDescriptionTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.foodDescriptionTextBox.Size = new System.Drawing.Size(662, 221);
			this.foodDescriptionTextBox.TabIndex = 42;
			this.foodDescriptionTextBox.Text = "توضیحات";
			this.foodDescriptionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FoodDescriptionTextBox_KeyPress);
			this.foodDescriptionTextBox.Leave += new System.EventHandler(this.FoodDescriptionTextBox_Leave);
			this.foodDescriptionTextBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FoodDescriptionTextBox_MouseDoubleClick);
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Location = new System.Drawing.Point(735, 199);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(233, 1);
			this.panel2.TabIndex = 41;
			// 
			// foodNameTextBox
			// 
			this.foodNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.foodNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
			this.foodNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.foodNameTextBox.Font = new System.Drawing.Font("IRANSans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.foodNameTextBox.ForeColor = System.Drawing.Color.White;
			this.foodNameTextBox.Location = new System.Drawing.Point(735, 164);
			this.foodNameTextBox.MaxLength = 20;
			this.foodNameTextBox.Name = "foodNameTextBox";
			this.foodNameTextBox.ReadOnly = true;
			this.foodNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.foodNameTextBox.Size = new System.Drawing.Size(233, 28);
			this.foodNameTextBox.TabIndex = 40;
			this.foodNameTextBox.Text = "نام غذا";
			this.foodNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FoodNameTextBox_KeyPress);
			this.foodNameTextBox.Leave += new System.EventHandler(this.FoodNameTextBox_Leave);
			this.foodNameTextBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FoodNameTextBox_MouseDoubleClick);
			// 
			// foodPriceTextBox
			// 
			this.foodPriceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.foodPriceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
			this.foodPriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.foodPriceTextBox.Font = new System.Drawing.Font("IRANSans", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.foodPriceTextBox.ForeColor = System.Drawing.Color.Gold;
			this.foodPriceTextBox.Location = new System.Drawing.Point(306, 31);
			this.foodPriceTextBox.MaxLength = 20;
			this.foodPriceTextBox.Name = "foodPriceTextBox";
			this.foodPriceTextBox.ReadOnly = true;
			this.foodPriceTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.foodPriceTextBox.Size = new System.Drawing.Size(662, 114);
			this.foodPriceTextBox.TabIndex = 39;
			this.foodPriceTextBox.Text = "مبلغ غذا";
			this.foodPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.foodPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FoodPriceTextBox_KeyPress);
			this.foodPriceTextBox.Leave += new System.EventHandler(this.FoodPriceTextBox_Leave);
			this.foodPriceTextBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FoodPriceTextBox_MouseDoubleClick);
			// 
			// orderButton
			// 
			this.orderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
			this.orderButton.FlatAppearance.BorderSize = 0;
			this.orderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.orderButton.Font = new System.Drawing.Font("IRANSans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.orderButton.ForeColor = System.Drawing.Color.White;
			this.orderButton.Location = new System.Drawing.Point(0, 439);
			this.orderButton.Name = "orderButton";
			this.orderButton.Size = new System.Drawing.Size(980, 40);
			this.orderButton.TabIndex = 38;
			this.orderButton.Text = "ثبت سفارش";
			this.orderButton.UseVisualStyleBackColor = false;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("IRANSans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Gold;
			this.label1.Location = new System.Drawing.Point(920, 2);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 34);
			this.label1.TabIndex = 36;
			this.label1.Text = "فقط";
			// 
			// chefMenuButton
			// 
			this.chefMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
			this.chefMenuButton.Dock = System.Windows.Forms.DockStyle.Left;
			this.chefMenuButton.FlatAppearance.BorderSize = 0;
			this.chefMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.chefMenuButton.ForeColor = System.Drawing.Color.White;
			this.chefMenuButton.Location = new System.Drawing.Point(0, 0);
			this.chefMenuButton.Name = "chefMenuButton";
			this.chefMenuButton.Size = new System.Drawing.Size(250, 55);
			this.chefMenuButton.TabIndex = 35;
			this.chefMenuButton.Text = "منوی سرآشپز";
			this.chefMenuButton.UseVisualStyleBackColor = false;
			this.chefMenuButton.Click += new System.EventHandler(this.ChefMenuButton_Click);
			// 
			// specialMenuButton
			// 
			this.specialMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
			this.specialMenuButton.Dock = System.Windows.Forms.DockStyle.Right;
			this.specialMenuButton.FlatAppearance.BorderSize = 0;
			this.specialMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.specialMenuButton.ForeColor = System.Drawing.Color.White;
			this.specialMenuButton.Location = new System.Drawing.Point(730, 0);
			this.specialMenuButton.Name = "specialMenuButton";
			this.specialMenuButton.Size = new System.Drawing.Size(250, 55);
			this.specialMenuButton.TabIndex = 34;
			this.specialMenuButton.Text = "منوی ویژه";
			this.specialMenuButton.UseVisualStyleBackColor = false;
			this.specialMenuButton.Click += new System.EventHandler(this.specialMenuButton_Click_1);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.specialMenuButton);
			this.panel1.Controls.Add(this.chefMenuButton);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 485);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(980, 55);
			this.panel1.TabIndex = 43;
			// 
			// SpecialMenuForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(980, 540);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.foodImagePicturBox);
			this.Controls.Add(this.foodDescriptionTextBox);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.foodNameTextBox);
			this.Controls.Add(this.foodPriceTextBox);
			this.Controls.Add(this.orderButton);
			this.Controls.Add(this.label1);
			this.Name = "SpecialMenuForm";
			this.Text = "SpecialMenuForm";
			this.Load += new System.EventHandler(this.SpecialMenuForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.foodImagePicturBox)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Mbb.Windows.Forms.PicturBox foodImagePicturBox;
		private Mbb.Windows.Forms.TextBox foodDescriptionTextBox;
		private Mbb.Windows.Forms.Panel panel2;
		private Mbb.Windows.Forms.TextBox foodNameTextBox;
		private Mbb.Windows.Forms.TextBox foodPriceTextBox;
		private Mbb.Windows.Forms.Button orderButton;
		private Mbb.Windows.Forms.Label label1;
		private Mbb.Windows.Forms.Button chefMenuButton;
		private Mbb.Windows.Forms.Button specialMenuButton;
		private Mbb.Windows.Forms.Panel panel1;
	}
}