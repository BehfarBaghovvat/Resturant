namespace ChefMenu
{
	public partial class ChefFoodForm : Infrastructure.BaseForm
	{
		public ChefFoodForm()
		{
			InitializeComponent();
		}

		#region Properties
		public string BoxName1 { get; set; }
		public string BoxName2 { get; set; }
		public string BoxName3 { get; set; }
		public string FoodImage1 { get; set; }
		public string FoodImage2 { get; set; }
		public string FoodImage3 { get; set; }
		public string Description1 { get; set; }
		public string Description2 { get; set; }
		public string Description3 { get; set; }
		#endregion /Properties

		//-----Beginning of the codes.

		#region ChefFoodForm_Load
		private void ChefFoodForm_Load(object sender, System.EventArgs e)
		{
			this.Location = new System.Drawing.Point(0, 0);
		}
		#endregion /ChefFoodForm_Load

		#region SpecialMenuButton_Click
		private void SpecialMenuButton_Click(object sender, System.EventArgs e)
		{
			Resturant.Program.MainForm.panel4.Controls.Clear();

			SpecialMenuForm specialMenuForm = 
				new SpecialMenuForm();

			specialMenuForm.Dock = System.Windows.Forms.DockStyle.Fill;
			specialMenuForm.TopLevel = false;
			specialMenuForm.TopMost = true;

			Resturant.Program.MainForm.panel4.Controls.Add(specialMenuForm);
			specialMenuForm.Show();
			//.Close();


		}
		#endregion /SpecialMenuButton_Click

		#region Box1
		//=============
		#region BoxNameTextBox1
		//-----
		#region BoxNameTextBox1_KeyPress
		private void BoxNameTextBox1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianTyping(e);
		}

		#endregion /BoxNameTextBox1_KeyPress

		#region BoxNameTextBox1_Leave
		private void BoxNameTextBox1_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(boxNameTextBox1.Text))
			{
				boxNameTextBox1.Text =
					"نام سبد";
				boxNameTextBox1.ReadOnly = true;
			}
			else
			{
				boxNameTextBox1.ReadOnly = true;
				BoxName1 = boxNameTextBox1.Text;
			}

		}

		#endregion /BoxNameTextBox1_Leave

		#region BoxNameTextBox1_MouseDoubleClick
		private void BoxNameTextBox1_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			boxNameTextBox1.ReadOnly = false;
			Infrastructure.Utility.PersianLanguage();
			boxNameTextBox1.Clear();
		}
		#endregion /BoxNameTextBox1_MouseDoubleClick
		//-----
		#endregion /BoxNameTextBox1

		#region BoxFoodImagePicturBox1_MouseDoubleClick
		private void BoxFoodImagePicturBox1_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
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
				FoodImage1 = openFileDialog.FileName;
				boxFoodImagePicturBox1.Image = System.Drawing.Image.FromFile(FoodImage3);
			}
		}

		#endregion /BoxFoodImagePicturBox1_MouseDoubleClick

		#region DescriptionTextBox1
		//-----
		#region DescriptionTextBox1_KeyPress
		private void DescriptionTextBox1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianTyping(e);
		}

		#endregion /DescriptionTextBox1_KeyPress

		#region DescriptionTextBox1_Leave
		private void DescriptionTextBox1_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(descriptionTextBox3.Text))
			{
				descriptionTextBox2.Text =
					"توضیحات";
				descriptionTextBox2.ReadOnly = true;
			}
			else
			{
				descriptionTextBox2.ReadOnly = true;
				Description1 = descriptionTextBox1.Text;
			}

		}

		#endregion /DescriptionTextBox1_Leave

		#region DescriptionTextBox1_MouseDoubleClick
		private void DescriptionTextBox1_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
			descriptionTextBox1.ReadOnly = false;
			descriptionTextBox1.Clear();
		}

		#endregion /DescriptionTextBox1_MouseDoubleClick
		//-----
		#endregion /DescriptionTextBox1 

		#region SaveButton1_Click
		private void SaveButton1_Click(object sender, System.EventArgs e)
		{

		}
		#endregion /SaveButton1_Click
		//=============
		#endregion Box1

		#region Box2
		//=============
		#region BoxNameTextBox2
		//-----
		#region BoxNameTextBox2_KeyPress
		private void BoxNameTextBox2_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianTyping(e);
		}

		#endregion /BoxNameTextBox2_KeyPress

		#region BoxNameTextBox2_Leave
		private void BoxNameTextBox2_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(boxNameTextBox2.Text))
			{
				boxNameTextBox2.Text =
					"نام سبد";
				boxNameTextBox2.ReadOnly = true;
			}
			else
			{
				boxNameTextBox2.ReadOnly = true;
				BoxName2 = boxNameTextBox2.Text;
			}

		}

		#endregion /BoxNameTextBox2_Leave

		#region BoxNameTextBox2_MouseDoubleClick
		private void BoxNameTextBox2_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			boxNameTextBox2.ReadOnly = false;
			Infrastructure.Utility.PersianLanguage();
			boxNameTextBox2.Clear();
		}

		#endregion /BoxNameTextBox2_MouseDoubleClick
		//-----
		#endregion /BoxNameTextBox2

		#region BoxFoodImagePicturBox2_MouseDoubleClick
		private void BoxFoodImagePicturBox2_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
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
				FoodImage2 = openFileDialog.FileName;
				boxFoodImagePicturBox2.Image = System.Drawing.Image.FromFile(FoodImage3);
			}
		}

		#endregion /BoxFoodImagePicturBox2_MouseDoubleClick

		#region DescriptionTextBox2
		//-----
		#region DescriptionTextBox2_KeyPress
		private void DescriptionTextBox2_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianTyping(e);
		}

		#endregion DescriptionTextBox2_KeyPress

		#region DescriptionTextBox2_Leave
		private void DescriptionTextBox2_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(descriptionTextBox2.Text))
			{
				descriptionTextBox2.Text =
					"توضیحات";
				descriptionTextBox2.ReadOnly = true;
			}
			else
			{
				descriptionTextBox2.ReadOnly = true;
				Description2 = descriptionTextBox2.Text;
			}

		}
		#endregion /DescriptionTextBox2_Leave

		#region DescriptionTextBox2_MouseDoubleClick
		private void DescriptionTextBox2_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
			descriptionTextBox2.ReadOnly = false;
			descriptionTextBox2.Clear();
		}

		#endregion /DescriptionTextBox2_MouseDoubleClick
		//-----
		#endregion /DescriptionTextBox2

		#region SaveButton2_Click
		private void SaveButton2_Click(object sender, System.EventArgs e)
		{

		}
		#endregion /SaveButton2_Click
		//=============
		#endregion /Box2

		#region Box3
		//=============
		#region BoxNameTextBox3
		//-----
		#region BoxNameTextBox3_KeyPress
		private void BoxNameTextBox3_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianTyping(e);
		}

		#endregion /BoxNameTextBox3_KeyPress

		#region BoxNameTextBox3_Leave
		private void BoxNameTextBox3_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(boxNameTextBox3.Text))
			{
				boxNameTextBox3.Text =
					"نام سبد";
				boxNameTextBox3.ReadOnly = true;
			}
			else
			{
				boxNameTextBox3.ReadOnly = true;
				BoxName3 = boxNameTextBox3.Text;
			}
		}
		#endregion /BoxNameTextBox3_Leave

		#region BoxNameTextBox3_MouseDoubleClick
		private void BoxNameTextBox3_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			boxNameTextBox3.ReadOnly = false;
			Infrastructure.Utility.PersianLanguage();
			boxNameTextBox3.Clear();
		}

		#endregion /BoxNameTextBox3_MouseDoubleClick
		//-----
		#endregion /BoxNameTextBox3

		#region BoxFoodImagePicturBox3_MouseDoubleClick
		private void BoxFoodImagePicturBox3_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
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
				FoodImage3 = openFileDialog.FileName;
				boxFoodImagePicturBox3.Image = System.Drawing.Image.FromFile(FoodImage3);
			}
		}

		#endregion /BoxFoodImagePicturBox3_MouseDoubleClick

		#region DescriptionTextBox3
		//-----
		#region DescriptionTextBox3_KeyPress
		private void DescriptionTextBox3_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianTyping(e);
		}

		#endregion /DescriptionTextBox3_KeyPress

		#region DescriptionTextBox3_Leave
		private void DescriptionTextBox3_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(descriptionTextBox3.Text))
			{
				descriptionTextBox3.Text =
					"توضیحات";
				descriptionTextBox3.ReadOnly = true;
			}
			else
			{
				descriptionTextBox3.ReadOnly = true;
				Description3 = descriptionTextBox3.Text;
			}
		}
		#endregion /DescriptionTextBox3_Leave

		#region DescriptionTextBox3_MouseDoubleClick
		private void DescriptionTextBox3_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
			descriptionTextBox3.ReadOnly = false;
			descriptionTextBox3.Clear();
		}
		#endregion /DescriptionTextBox3_MouseDoubleClick
		//-----
		#endregion /DescriptionTextBox3

		#region SaveButton3_Click
		private void SaveButton3_Click(object sender, System.EventArgs e)
		{

		}

		#endregion /SaveButton3_Click
		//=============
		#endregion /Box3

	}
}
