namespace Foods
{
	partial class DessertAddForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DessertAddForm));
			this.groupPanel = new Mbb.Windows.Forms.Panel();
			this.groupBox1 = new Mbb.Windows.Forms.GroupBox();
			this.descriptionTextBox = new Mbb.Windows.Forms.TextBox();
			this.errorMessageLabel = new Mbb.Windows.Forms.Label();
			this.resetButton = new Mbb.Windows.Forms.Button();
			this.saveButton = new Mbb.Windows.Forms.Button();
			this.dessertImagePicturBox = new Mbb.Windows.Forms.PicturBox();
			this.panel2 = new Mbb.Windows.Forms.Panel();
			this.dessertPriceTextBox = new Mbb.Windows.Forms.TextBox();
			this.panel1 = new Mbb.Windows.Forms.Panel();
			this.dessertNameTextBox = new Mbb.Windows.Forms.TextBox();
			this.panel3 = new Mbb.Windows.Forms.Panel();
			this.foodRegisterLabel = new Mbb.Windows.Forms.Label();
			this.minimizeButton = new Mbb.Windows.Forms.Button();
			this.closeButton = new Mbb.Windows.Forms.Button();
			this.groupPanel.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dessertImagePicturBox)).BeginInit();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupPanel
			// 
			this.groupPanel.Controls.Add(this.groupBox1);
			this.groupPanel.Controls.Add(this.errorMessageLabel);
			this.groupPanel.Controls.Add(this.resetButton);
			this.groupPanel.Controls.Add(this.saveButton);
			this.groupPanel.Controls.Add(this.dessertImagePicturBox);
			this.groupPanel.Controls.Add(this.panel2);
			this.groupPanel.Controls.Add(this.dessertPriceTextBox);
			this.groupPanel.Controls.Add(this.panel1);
			this.groupPanel.Controls.Add(this.dessertNameTextBox);
			this.groupPanel.Location = new System.Drawing.Point(15, 40);
			this.groupPanel.Name = "groupPanel";
			this.groupPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.groupPanel.Size = new System.Drawing.Size(644, 431);
			this.groupPanel.TabIndex = 5;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.descriptionTextBox);
			this.groupBox1.Location = new System.Drawing.Point(334, 111);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(280, 200);
			this.groupBox1.TabIndex = 30;
			this.groupBox1.TabStop = false;
			// 
			// descriptionTextBox
			// 
			this.descriptionTextBox.BackColor = System.Drawing.Color.Green;
			this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.descriptionTextBox.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.descriptionTextBox.ForeColor = System.Drawing.Color.White;
			this.descriptionTextBox.Location = new System.Drawing.Point(5, 10);
			this.descriptionTextBox.MaxLength = 3000;
			this.descriptionTextBox.Multiline = true;
			this.descriptionTextBox.Name = "descriptionTextBox";
			this.descriptionTextBox.Size = new System.Drawing.Size(269, 180);
			this.descriptionTextBox.TabIndex = 8;
			this.descriptionTextBox.Text = "توضیحات";
			this.descriptionTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DescriptionTextBox_MouseClick);
			this.descriptionTextBox.Enter += new System.EventHandler(this.DescriptionTextBox_Enter);
			this.descriptionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DescriptionTextBox_KeyPress);
			this.descriptionTextBox.Leave += new System.EventHandler(this.DescriptionTextBox_Leave);
			this.descriptionTextBox.Validated += new System.EventHandler(this.DescriptionTextBox_Validated);
			// 
			// errorMessageLabel
			// 
			this.errorMessageLabel.Font = new System.Drawing.Font("IRANSans", 7F);
			this.errorMessageLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.errorMessageLabel.Image = ((System.Drawing.Image)(resources.GetObject("errorMessageLabel.Image")));
			this.errorMessageLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.errorMessageLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.errorMessageLabel.Location = new System.Drawing.Point(337, 326);
			this.errorMessageLabel.Name = "errorMessageLabel";
			this.errorMessageLabel.Size = new System.Drawing.Size(283, 115);
			this.errorMessageLabel.TabIndex = 7;
			this.errorMessageLabel.Text = "پیام خطا";
			this.errorMessageLabel.Visible = false;
			// 
			// resetButton
			// 
			this.resetButton.BackColor = System.Drawing.Color.YellowGreen;
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
			this.saveButton.BackColor = System.Drawing.Color.YellowGreen;
			this.saveButton.FlatAppearance.BorderSize = 0;
			this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.saveButton.ForeColor = System.Drawing.Color.White;
			this.saveButton.Location = new System.Drawing.Point(20, 329);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(300, 35);
			this.saveButton.TabIndex = 6;
			this.saveButton.Text = "ثبت دسر و پیش غذا";
			this.saveButton.UseVisualStyleBackColor = false;
			this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// dessertImagePicturBox
			// 
			this.dessertImagePicturBox.Image = global::Resturant.Properties.Resources.ice_cream_sundae_512px;
			this.dessertImagePicturBox.Location = new System.Drawing.Point(20, 23);
			this.dessertImagePicturBox.Name = "dessertImagePicturBox";
			this.dessertImagePicturBox.Size = new System.Drawing.Size(300, 300);
			this.dessertImagePicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.dessertImagePicturBox.TabIndex = 29;
			this.dessertImagePicturBox.TabStop = false;
			this.dessertImagePicturBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DessertImagePicturBox_MouseDoubleClick);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Location = new System.Drawing.Point(334, 104);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(280, 1);
			this.panel2.TabIndex = 3;
			// 
			// dessertPriceTextBox
			// 
			this.dessertPriceTextBox.BackColor = System.Drawing.Color.Green;
			this.dessertPriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dessertPriceTextBox.Font = new System.Drawing.Font("IRANSans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.dessertPriceTextBox.ForeColor = System.Drawing.Color.White;
			this.dessertPriceTextBox.Location = new System.Drawing.Point(337, 75);
			this.dessertPriceTextBox.MaxLength = 25;
			this.dessertPriceTextBox.Name = "dessertPriceTextBox";
			this.dessertPriceTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dessertPriceTextBox.Size = new System.Drawing.Size(280, 23);
			this.dessertPriceTextBox.TabIndex = 2;
			this.dessertPriceTextBox.Text = "0 تومان";
			this.dessertPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.dessertPriceTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DessertPriceTextBox_MouseClick);
			this.dessertPriceTextBox.Enter += new System.EventHandler(this.DessertPriceTextBox_Enter);
			this.dessertPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DessertPriceTextBox_KeyPress);
			this.dessertPriceTextBox.Leave += new System.EventHandler(this.DessertPriceTextBox_Leave);
			this.dessertPriceTextBox.Validated += new System.EventHandler(this.DessertPriceTextBox_Validated);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Location = new System.Drawing.Point(334, 52);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(280, 1);
			this.panel1.TabIndex = 1;
			// 
			// dessertNameTextBox
			// 
			this.dessertNameTextBox.BackColor = System.Drawing.Color.Green;
			this.dessertNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dessertNameTextBox.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.dessertNameTextBox.ForeColor = System.Drawing.Color.White;
			this.dessertNameTextBox.Location = new System.Drawing.Point(334, 23);
			this.dessertNameTextBox.MaxLength = 30;
			this.dessertNameTextBox.Name = "dessertNameTextBox";
			this.dessertNameTextBox.Size = new System.Drawing.Size(280, 23);
			this.dessertNameTextBox.TabIndex = 0;
			this.dessertNameTextBox.Text = "نام دسر";
			this.dessertNameTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DessertNameTextBox_MouseClick);
			this.dessertNameTextBox.Enter += new System.EventHandler(this.DessertNameTextBox_Enter);
			this.dessertNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DessertNameTextBox_KeyPress);
			this.dessertNameTextBox.Leave += new System.EventHandler(this.DessertNameTextBox_Leave);
			this.dessertNameTextBox.Validated += new System.EventHandler(this.DessertNameTextBox_Validated);
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
			this.foodRegisterLabel.Location = new System.Drawing.Point(575, 8);
			this.foodRegisterLabel.Name = "foodRegisterLabel";
			this.foodRegisterLabel.Size = new System.Drawing.Size(97, 19);
			this.foodRegisterLabel.TabIndex = 0;
			this.foodRegisterLabel.Text = "ثبت پیش غذا و دسر";
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
			// DessertAddForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Green;
			this.ClientSize = new System.Drawing.Size(675, 490);
			this.Controls.Add(this.groupPanel);
			this.Controls.Add(this.panel3);
			this.Name = "DessertAddForm";
			this.Text = "DessertAddForm";
			this.Load += new System.EventHandler(this.DessertAddForm_Load);
			this.groupPanel.ResumeLayout(false);
			this.groupPanel.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dessertImagePicturBox)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Mbb.Windows.Forms.Panel groupPanel;
		private Mbb.Windows.Forms.GroupBox groupBox1;
		private Mbb.Windows.Forms.Label errorMessageLabel;
		private Mbb.Windows.Forms.Button resetButton;
		private Mbb.Windows.Forms.Button saveButton;
		private Mbb.Windows.Forms.PicturBox dessertImagePicturBox;
		private Mbb.Windows.Forms.Panel panel2;
		private Mbb.Windows.Forms.TextBox dessertPriceTextBox;
		private Mbb.Windows.Forms.Panel panel1;
		private Mbb.Windows.Forms.TextBox dessertNameTextBox;
		private Mbb.Windows.Forms.Panel panel3;
		private Mbb.Windows.Forms.Label foodRegisterLabel;
		private Mbb.Windows.Forms.Button minimizeButton;
		private Mbb.Windows.Forms.Button closeButton;
		private Mbb.Windows.Forms.TextBox descriptionTextBox;
	}
}