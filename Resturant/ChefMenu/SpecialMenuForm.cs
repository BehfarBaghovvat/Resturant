namespace ChefMenu
{
	public partial class SpecialMenuForm : Infrastructure.BaseForm
	{
		public SpecialMenuForm()
		{
			InitializeComponent();
		}

		#region Peroperties
		public string Price { get; set; }
		public decimal FoodPrice { get; set; }
		public string FoodImage { get; set; }
		#endregion /Peroperties

		//-----Beginning of the codes.
		#region SpecialMenuForm_Load
		private void SpecialMenuForm_Load(object sender, System.EventArgs e)
		{
			//this.Location = new System.Drawing.Point(0, 0);
		}
		#endregion /SpecialMenuForm_Load

		#region FoodPriceTextBox
		//-----
		#region FoodPriceTextBox_KeyPress
		private void FoodPriceTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}
		#endregion /FoodPriceTextBox_KeyPress

		#region FoodPriceTextBox_Leave
		private void FoodPriceTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(foodPriceTextBox.Text))
			{
				foodPriceTextBox.Text =
					"مبلغ غذا";
				foodPriceTextBox.ReadOnly = true;
			}
			else
			{
				foodPriceTextBox.ReadOnly = true;
				Price = foodPriceTextBox.Text.Replace("تومان", string.Empty).Trim();
				FoodPrice = decimal.Parse(Price);
				foodPriceTextBox.Text = $"{FoodPrice.ToString("#,0")} تومان";
			}
		}
		#endregion /FoodPriceTextBox_Leave

		#region FoodPriceTextBox_MouseDoubleClick
		private void FoodPriceTextBox_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			foodPriceTextBox.ReadOnly = false;
			foodPriceTextBox.Clear();
		}
		#endregion /FoodPriceTextBox_MouseDoubleClick
		//-----
		#endregion /FoodPriceTextBox

		#region FoodNameTextBox
		//-----
		#region FoodNameTextBox_KeyPress
		private void FoodNameTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianTyping(e);
		}

		#endregion /FoodNameTextBox_KeyPress

		#region FoodNameTextBox_Leave
		private void FoodNameTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(foodNameTextBox.Text))
			{
				foodNameTextBox.Text =
					"نام غذا";
				foodNameTextBox.ReadOnly = true;
			}
			else
				foodNameTextBox.ReadOnly = true;

		}

		#endregion /FoodNameTextBox_Leave

		#region FoodNameTextBox_MouseDoubleClick
		private void FoodNameTextBox_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			foodNameTextBox.ReadOnly = false;
			Infrastructure.Utility.PersianLanguage();
			foodNameTextBox.Clear();
		}

		#endregion /FoodNameTextBox_MouseDoubleClick
		//-----
		#endregion /FoodNameTextBox

		#region FoodDescriptionTextBox
		//-----
		#region FoodDescriptionTextBox_KeyPress
		private void FoodDescriptionTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianAndNumberTyping(e);
		}

		#endregion FoodDescriptionTextBox_KeyPress

		#region FoodDescriptionTextBox_Leave
		private void FoodDescriptionTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(foodDescriptionTextBox.Text))
			{
				foodDescriptionTextBox.Text =
					"توضیحات";
				foodDescriptionTextBox.ReadOnly = true;
			}
			else
				foodDescriptionTextBox.ReadOnly = true;
		}

		#endregion /FoodDescriptionTextBox_Leave

		#region FoodDescriptionTextBox_MouseDoubleClick
		private void FoodDescriptionTextBox_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
			foodDescriptionTextBox.ReadOnly = false;
			foodDescriptionTextBox.Clear();
		}

		#endregion /FoodDescriptionTextBox_MouseDoubleClick 
		//-----
		#endregion /FoodDescriptionTextBox

		#region FoodImagePicturBox_MouseDoubleClick
		private void FoodImagePicturBox_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			System.Windows.Forms.OpenFileDialog openFileDialog =
				new System.Windows.Forms.OpenFileDialog
				{
					Filter = "JPEP (*.jpg)|*.jpg|" +
							"PNG (*.png)|*.png|" +
							"BMP (*.bmp)|*.bmp",
					Title = "Load user picture ",
				};

			if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				FoodImage = openFileDialog.FileName;

				foodImagePicturBox.Image = System.Drawing.Image.FromFile(FoodImage);
			}
		}
		#endregion FoodImagePicturBox_MouseDoubleClick

		#region SpecialMenuButton_Click
		private void SpecialMenuButton_Click(object sender, System.EventArgs e)
		{

		}
		#endregion /SpecialMenuButton_Click

		#region ChefMenuButton_Click
		private void ChefMenuButton_Click(object sender, System.EventArgs e)
		{
			Resturant.Program.MainForm.panel4.Controls.Clear();
			ChefFoodForm chefFoodForm =
				new ChefFoodForm();
			chefFoodForm.Dock = System.Windows.Forms.DockStyle.Fill;
			chefFoodForm.TopLevel = false;
			chefFoodForm.TopMost = true;

			Resturant.Program.MainForm.panel4.Controls.Add(chefFoodForm);
			chefFoodForm.Show();
		}

		#endregion /ChefMenuButton_Click

		private void specialMenuButton_Click_1(object sender, System.EventArgs e)
		{

		}
	}
}
