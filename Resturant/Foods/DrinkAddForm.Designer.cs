namespace Foods
{
	partial class DrinkAddForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrinkAddForm));
			this.groupPanel = new Mbb.Windows.Forms.Panel();
			this.errorMessageLabel = new Mbb.Windows.Forms.Label();
			this.resetButton = new Mbb.Windows.Forms.Button();
			this.saveButton = new Mbb.Windows.Forms.Button();
			this.drinkImagePicturBox = new Mbb.Windows.Forms.PicturBox();
			this.descriptionTextBox = new Mbb.Windows.Forms.TextBox();
			this.panel2 = new Mbb.Windows.Forms.Panel();
			this.drinkPriceTextBox = new Mbb.Windows.Forms.TextBox();
			this.panel1 = new Mbb.Windows.Forms.Panel();
			this.drinkNameTextBox = new Mbb.Windows.Forms.TextBox();
			this.panel3 = new Mbb.Windows.Forms.Panel();
			this.foodRegisterLabel = new Mbb.Windows.Forms.Label();
			this.minimizeButton = new Mbb.Windows.Forms.Button();
			this.closeButton = new Mbb.Windows.Forms.Button();
			this.groupPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.drinkImagePicturBox)).BeginInit();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupPanel
			// 
			this.groupPanel.Controls.Add(this.errorMessageLabel);
			this.groupPanel.Controls.Add(this.resetButton);
			this.groupPanel.Controls.Add(this.saveButton);
			this.groupPanel.Controls.Add(this.drinkImagePicturBox);
			this.groupPanel.Controls.Add(this.descriptionTextBox);
			this.groupPanel.Controls.Add(this.panel2);
			this.groupPanel.Controls.Add(this.drinkPriceTextBox);
			this.groupPanel.Controls.Add(this.panel1);
			this.groupPanel.Controls.Add(this.drinkNameTextBox);
			this.groupPanel.Location = new System.Drawing.Point(15, 40);
			this.groupPanel.Name = "groupPanel";
			this.groupPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.groupPanel.Size = new System.Drawing.Size(644, 431);
			this.groupPanel.TabIndex = 5;
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
			this.errorMessageLabel.Size = new System.Drawing.Size(280, 119);
			this.errorMessageLabel.TabIndex = 7;
			this.errorMessageLabel.Text = "پیام خطا";
			this.errorMessageLabel.Visible = false;
			// 
			// resetButton
			// 
			this.resetButton.BackColor = System.Drawing.Color.Gray;
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
			this.saveButton.BackColor = System.Drawing.Color.Gray;
			this.saveButton.FlatAppearance.BorderSize = 0;
			this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.saveButton.ForeColor = System.Drawing.Color.White;
			this.saveButton.Location = new System.Drawing.Point(20, 329);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(300, 35);
			this.saveButton.TabIndex = 6;
			this.saveButton.Text = "ثبت نوشیدنی";
			this.saveButton.UseVisualStyleBackColor = false;
			this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// drinkImagePicturBox
			// 
			this.drinkImagePicturBox.Image = global::Resturant.Properties.Resources.drink_512;
			this.drinkImagePicturBox.Location = new System.Drawing.Point(20, 23);
			this.drinkImagePicturBox.Name = "drinkImagePicturBox";
			this.drinkImagePicturBox.Size = new System.Drawing.Size(300, 300);
			this.drinkImagePicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.drinkImagePicturBox.TabIndex = 29;
			this.drinkImagePicturBox.TabStop = false;
			this.drinkImagePicturBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DrinkImagePicturBox_MouseDoubleClick);
			// 
			// descriptionTextBox
			// 
			this.descriptionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
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
			// drinkPriceTextBox
			// 
			this.drinkPriceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
			this.drinkPriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.drinkPriceTextBox.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.drinkPriceTextBox.ForeColor = System.Drawing.Color.White;
			this.drinkPriceTextBox.Location = new System.Drawing.Point(337, 75);
			this.drinkPriceTextBox.MaxLength = 25;
			this.drinkPriceTextBox.Name = "drinkPriceTextBox";
			this.drinkPriceTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.drinkPriceTextBox.Size = new System.Drawing.Size(280, 23);
			this.drinkPriceTextBox.TabIndex = 2;
			this.drinkPriceTextBox.Text = "0 تومان";
			this.drinkPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.drinkPriceTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DrinkPriceTextBox_MouseClick);
			this.drinkPriceTextBox.Enter += new System.EventHandler(this.DrinkPriceTextBox_Enter);
			this.drinkPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DrinkPriceTextBox_KeyPress);
			this.drinkPriceTextBox.Leave += new System.EventHandler(this.DrinkPriceTextBox_Leave);
			this.drinkPriceTextBox.Validated += new System.EventHandler(this.DrinkPriceTextBox_Validated);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DimGray;
			this.panel1.Location = new System.Drawing.Point(334, 52);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(280, 1);
			this.panel1.TabIndex = 1;
			// 
			// drinkNameTextBox
			// 
			this.drinkNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
			this.drinkNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.drinkNameTextBox.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.drinkNameTextBox.ForeColor = System.Drawing.Color.White;
			this.drinkNameTextBox.Location = new System.Drawing.Point(334, 23);
			this.drinkNameTextBox.MaxLength = 20;
			this.drinkNameTextBox.Name = "drinkNameTextBox";
			this.drinkNameTextBox.Size = new System.Drawing.Size(280, 23);
			this.drinkNameTextBox.TabIndex = 0;
			this.drinkNameTextBox.Text = "نام نوشیدنی";
			this.drinkNameTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DrinkNameTextBox_MouseClick);
			this.drinkNameTextBox.Enter += new System.EventHandler(this.DrinkNameTextBox_Enter);
			this.drinkNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DrinkNameTextBox_KeyPress);
			this.drinkNameTextBox.Leave += new System.EventHandler(this.DrinkNameTextBox_Leave);
			this.drinkNameTextBox.Validated += new System.EventHandler(this.DrinkNameTextBox_Validated);
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
			this.panel3.TabIndex = 4;
			// 
			// foodRegisterLabel
			// 
			this.foodRegisterLabel.AutoSize = true;
			this.foodRegisterLabel.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.foodRegisterLabel.ForeColor = System.Drawing.Color.White;
			this.foodRegisterLabel.Location = new System.Drawing.Point(596, 8);
			this.foodRegisterLabel.Name = "foodRegisterLabel";
			this.foodRegisterLabel.Size = new System.Drawing.Size(67, 19);
			this.foodRegisterLabel.TabIndex = 0;
			this.foodRegisterLabel.Text = "ثبت نوشیدنی";
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
			// DrinkAddForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
			this.ClientSize = new System.Drawing.Size(675, 490);
			this.Controls.Add(this.groupPanel);
			this.Controls.Add(this.panel3);
			this.Name = "DrinkAddForm";
			this.Text = "DrinkAddForm";
			this.Load += new System.EventHandler(this.DrinkAddForm_Load);
			this.groupPanel.ResumeLayout(false);
			this.groupPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.drinkImagePicturBox)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Mbb.Windows.Forms.Panel groupPanel;
		private Mbb.Windows.Forms.Label errorMessageLabel;
		private Mbb.Windows.Forms.Button resetButton;
		private Mbb.Windows.Forms.Button saveButton;
		private Mbb.Windows.Forms.PicturBox drinkImagePicturBox;
		private Mbb.Windows.Forms.TextBox descriptionTextBox;
		private Mbb.Windows.Forms.Panel panel2;
		private Mbb.Windows.Forms.TextBox drinkPriceTextBox;
		private Mbb.Windows.Forms.Panel panel1;
		private Mbb.Windows.Forms.TextBox drinkNameTextBox;
		private Mbb.Windows.Forms.Panel panel3;
		private Mbb.Windows.Forms.Label foodRegisterLabel;
		private Mbb.Windows.Forms.Button minimizeButton;
		private Mbb.Windows.Forms.Button closeButton;
	}
}