namespace Foods
{
	partial class FoodAddForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodAddForm));
			this.groupPanel = new Mbb.Windows.Forms.Panel();
			this.errorMessageLabel = new Mbb.Windows.Forms.Label();
			this.resetButton = new Mbb.Windows.Forms.Button();
			this.saveButton = new Mbb.Windows.Forms.Button();
			this.foodImagePicturBox = new Mbb.Windows.Forms.PicturBox();
			this.descriptionTextBox = new Mbb.Windows.Forms.TextBox();
			this.panel2 = new Mbb.Windows.Forms.Panel();
			this.foodPriceTextBox = new Mbb.Windows.Forms.TextBox();
			this.panel1 = new Mbb.Windows.Forms.Panel();
			this.foodNameTextBox = new Mbb.Windows.Forms.TextBox();
			this.panel3 = new Mbb.Windows.Forms.Panel();
			this.foodRegisterLabel = new Mbb.Windows.Forms.Label();
			this.minimizeButton = new Mbb.Windows.Forms.Button();
			this.closeButton = new Mbb.Windows.Forms.Button();
			this.groupPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.foodImagePicturBox)).BeginInit();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupPanel
			// 
			this.groupPanel.Controls.Add(this.errorMessageLabel);
			this.groupPanel.Controls.Add(this.resetButton);
			this.groupPanel.Controls.Add(this.saveButton);
			this.groupPanel.Controls.Add(this.foodImagePicturBox);
			this.groupPanel.Controls.Add(this.descriptionTextBox);
			this.groupPanel.Controls.Add(this.panel2);
			this.groupPanel.Controls.Add(this.foodPriceTextBox);
			this.groupPanel.Controls.Add(this.panel1);
			this.groupPanel.Controls.Add(this.foodNameTextBox);
			this.groupPanel.Location = new System.Drawing.Point(15, 40);
			this.groupPanel.Name = "groupPanel";
			this.groupPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.groupPanel.Size = new System.Drawing.Size(644, 431);
			this.groupPanel.TabIndex = 3;
			// 
			// errorMessageLabel
			// 
			this.errorMessageLabel.Font = new System.Drawing.Font("IRANSans", 7F);
			this.errorMessageLabel.ForeColor = System.Drawing.Color.DarkGray;
			this.errorMessageLabel.Image = ((System.Drawing.Image)(resources.GetObject("errorMessageLabel.Image")));
			this.errorMessageLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.errorMessageLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.errorMessageLabel.Location = new System.Drawing.Point(337, 326);
			this.errorMessageLabel.Name = "errorMessageLabel";
			this.errorMessageLabel.Size = new System.Drawing.Size(280, 115);
			this.errorMessageLabel.TabIndex = 7;
			this.errorMessageLabel.Text = "پیام خطا";
			this.errorMessageLabel.Visible = false;
			// 
			// resetButton
			// 
			this.resetButton.BackColor = System.Drawing.Color.SteelBlue;
			this.resetButton.FlatAppearance.BorderSize = 0;
			this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.resetButton.ForeColor = System.Drawing.Color.White;
			this.resetButton.Location = new System.Drawing.Point(20, 370);
			this.resetButton.Name = "resetButton";
			this.resetButton.Size = new System.Drawing.Size(300, 35);
			this.resetButton.TabIndex = 5;
			this.resetButton.Text = "حالت اولیه";
			this.resetButton.UseVisualStyleBackColor = false;
			this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
			// 
			// saveButton
			// 
			this.saveButton.BackColor = System.Drawing.Color.SteelBlue;
			this.saveButton.FlatAppearance.BorderSize = 0;
			this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.saveButton.ForeColor = System.Drawing.Color.White;
			this.saveButton.Location = new System.Drawing.Point(20, 329);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(300, 35);
			this.saveButton.TabIndex = 6;
			this.saveButton.Text = "ثبت غذا";
			this.saveButton.UseVisualStyleBackColor = false;
			this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// foodImagePicturBox
			// 
			this.foodImagePicturBox.Image = global::Resturant.Properties.Resources.food_512;
			this.foodImagePicturBox.Location = new System.Drawing.Point(20, 23);
			this.foodImagePicturBox.Name = "foodImagePicturBox";
			this.foodImagePicturBox.Size = new System.Drawing.Size(300, 300);
			this.foodImagePicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.foodImagePicturBox.TabIndex = 29;
			this.foodImagePicturBox.TabStop = false;
			this.foodImagePicturBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FoodImagePicturBox_MouseDoubleClick);
			// 
			// descriptionTextBox
			// 
			this.descriptionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
			this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.descriptionTextBox.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.descriptionTextBox.ForeColor = System.Drawing.Color.White;
			this.descriptionTextBox.Location = new System.Drawing.Point(337, 111);
			this.descriptionTextBox.MaxLength = 3000;
			this.descriptionTextBox.Multiline = true;
			this.descriptionTextBox.Name = "descriptionTextBox";
			this.descriptionTextBox.Size = new System.Drawing.Size(280, 200);
			this.descriptionTextBox.TabIndex = 4;
			this.descriptionTextBox.Text = "توضیحات";
			this.descriptionTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DescriptionTextBox_MouseClick);
			this.descriptionTextBox.Enter += new System.EventHandler(this.DescriptionTextBox_Enter);
			this.descriptionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DescriptionTextBox_KeyPress);
			this.descriptionTextBox.Leave += new System.EventHandler(this.DescriptionTextBox_Leave);
			this.descriptionTextBox.Validated += new System.EventHandler(this.DescriptionTextBox_Validated);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.DimGray;
			this.panel2.Location = new System.Drawing.Point(337, 104);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(280, 1);
			this.panel2.TabIndex = 3;
			// 
			// foodPriceTextBox
			// 
			this.foodPriceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
			this.foodPriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.foodPriceTextBox.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.foodPriceTextBox.ForeColor = System.Drawing.Color.White;
			this.foodPriceTextBox.Location = new System.Drawing.Point(337, 75);
			this.foodPriceTextBox.MaxLength = 25;
			this.foodPriceTextBox.Name = "foodPriceTextBox";
			this.foodPriceTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.foodPriceTextBox.Size = new System.Drawing.Size(280, 23);
			this.foodPriceTextBox.TabIndex = 2;
			this.foodPriceTextBox.Text = "0 تومان";
			this.foodPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.foodPriceTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FoodPriceTextBox_MouseClick);
			this.foodPriceTextBox.Enter += new System.EventHandler(this.FoodPriceTextBox_Enter);
			this.foodPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FoodPriceTextBox_KeyPress);
			this.foodPriceTextBox.Leave += new System.EventHandler(this.FoodPriceTextBox_Leave);
			this.foodPriceTextBox.Validated += new System.EventHandler(this.FoodPriceTextBox_Validated);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DimGray;
			this.panel1.Location = new System.Drawing.Point(337, 52);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(280, 1);
			this.panel1.TabIndex = 1;
			// 
			// foodNameTextBox
			// 
			this.foodNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
			this.foodNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.foodNameTextBox.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.foodNameTextBox.ForeColor = System.Drawing.Color.White;
			this.foodNameTextBox.Location = new System.Drawing.Point(337, 23);
			this.foodNameTextBox.MaxLength = 30;
			this.foodNameTextBox.Name = "foodNameTextBox";
			this.foodNameTextBox.Size = new System.Drawing.Size(280, 23);
			this.foodNameTextBox.TabIndex = 0;
			this.foodNameTextBox.Text = "نام غذا";
			this.foodNameTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FoodNameTextBox_MouseClick);
			this.foodNameTextBox.Enter += new System.EventHandler(this.FoodNameTextBox_Enter);
			this.foodNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FoodNameTextBox_KeyPress);
			this.foodNameTextBox.Leave += new System.EventHandler(this.FoodNameTextBox_Leave);
			this.foodNameTextBox.Validated += new System.EventHandler(this.FoodNameTextBox_Validated);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.foodRegisterLabel);
			this.panel3.Controls.Add(this.minimizeButton);
			this.panel3.Controls.Add(this.closeButton);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(675, 34);
			this.panel3.TabIndex = 2;
			// 
			// foodRegisterLabel
			// 
			this.foodRegisterLabel.AutoSize = true;
			this.foodRegisterLabel.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.foodRegisterLabel.ForeColor = System.Drawing.Color.White;
			this.foodRegisterLabel.Location = new System.Drawing.Point(619, 8);
			this.foodRegisterLabel.Name = "foodRegisterLabel";
			this.foodRegisterLabel.Size = new System.Drawing.Size(44, 19);
			this.foodRegisterLabel.TabIndex = 0;
			this.foodRegisterLabel.Text = "ثبت غذا";
			// 
			// minimizeButton
			// 
			this.minimizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizeButton.BackgroundImage")));
			this.minimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.minimizeButton.FlatAppearance.BorderSize = 0;
			this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.minimizeButton.Location = new System.Drawing.Point(33, 10);
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
			this.closeButton.Location = new System.Drawing.Point(12, 10);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(15, 15);
			this.closeButton.TabIndex = 2;
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// FoodAddForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
			this.ClientSize = new System.Drawing.Size(675, 490);
			this.Controls.Add(this.groupPanel);
			this.Controls.Add(this.panel3);
			this.Name = "FoodAddForm";
			this.Text = "FoodAddForm";
			this.Load += new System.EventHandler(this.FoodAddForm_Load);
			this.groupPanel.ResumeLayout(false);
			this.groupPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.foodImagePicturBox)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Mbb.Windows.Forms.Panel groupPanel;
		private Mbb.Windows.Forms.Label errorMessageLabel;
		private Mbb.Windows.Forms.Button resetButton;
		private Mbb.Windows.Forms.Button saveButton;
		private Mbb.Windows.Forms.PicturBox foodImagePicturBox;
		private Mbb.Windows.Forms.TextBox descriptionTextBox;
		private Mbb.Windows.Forms.Panel panel2;
		private Mbb.Windows.Forms.TextBox foodPriceTextBox;
		private Mbb.Windows.Forms.Panel panel1;
		private Mbb.Windows.Forms.TextBox foodNameTextBox;
		private Mbb.Windows.Forms.Panel panel3;
		private Mbb.Windows.Forms.Label foodRegisterLabel;
		private Mbb.Windows.Forms.Button minimizeButton;
		private Mbb.Windows.Forms.Button closeButton;
	}
}