using System.Linq;

namespace Foods
{
	public partial class FoodAddForm : Infrastructure.BaseForm
	{
		public FoodAddForm()
		{
			InitializeComponent();
		}

		#region Properties
		public string FoodName { get; set; }
		public string Price { get; set; }
		public decimal FoodPrice { get; set; }
		public string FoodImage { get; set; }
		public string Description { get; set; }
		public string RegisterTime { get; set; }
		public string RegisterDate { get; set; }
		public string UpdateTime { get; set; }
		public string NumberUpdate { get; set; }

		public MenuListForm MyMenuListForm;

		#endregion /Properties

		//-----Beginning of the codes.
		#region FoodAddForm_Load
		private void FoodAddForm_Load(object sender, System.EventArgs e)
		{
			UpdateTime = "0000/00/00 00:00:00";
			NumberUpdate = "0";

			foodNameTextBox.Text = "نام غذا";
			foodPriceTextBox.Text = "0 تومان";
			descriptionTextBox.Text = "توضیحات";
		}
		#endregion /FoodAddForm_Load

		#region CloseButton_Click
		private void CloseButton_Click(object sender, System.EventArgs e)
		{
			this.AllClear();
			this.Close();
		}
		#endregion /CloseButton_Click

		#region MinimizeButton_Click
		private void MinimizeButton_Click(object sender, System.EventArgs e)
		{
			this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
		}
		#endregion /MinimizeButton_Click

		#region FoodNameTextBox
		//-----
		#region FoodNameTextBox_Enter
		private void FoodNameTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();

			foodNameTextBox.ForeColor = Infrastructure.Utility.LimeColor();
			panel1.BackColor = Infrastructure.Utility.LimeColor();

			if (string.Compare(foodNameTextBox.Text, "نام غذا") == 0)
			{
				foodNameTextBox.Clear();
				return;
			}
		}
		#endregion /FoodNameTextBox_Enter

		#region FoodNameTextBox_KeyPress
		private void FoodNameTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianTyping(e);
		}
		#endregion /FoodNameTextBox_KeyPress

		#region FoodNameTextBox_Leave
		private void FoodNameTextBox_Leave(object sender, System.EventArgs e)
		{
			foodNameTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();
			panel1.BackColor =
				Infrastructure.Utility.DimGrayColor();
			if (string.IsNullOrWhiteSpace(foodNameTextBox.Text))
			{
				foodNameTextBox.Text = "نام غذا";
				return;
			}
		}
		#endregion /FoodNameTextBox_Leave

		#region FoodNameTextBox_MouseClick 
		private void FoodNameTextBox_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			//Infrastructure.Utility.PersianLanguage();

			//foodNameTextBox.ForeColor = Infrastructure.Utility.LimeColor();
			//panel1.BackColor = Infrastructure.Utility.LimeColor();

			//if (string.Compare(foodNameTextBox.Text, "نام غذا") == 0)
			//{
			//	foodNameTextBox.Clear();
			//	return;
			//}
		}
		#endregion /FoodNameTextBox_MouseClick

		#region FoodNameTextBox_Validated
		private void FoodNameTextBox_Validated(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(foodNameTextBox.Text) || string.Compare(foodNameTextBox.Text, "نام غذا") == 0)
			{
				FoodName = string.Empty;
				return;
			}
			else
				FoodName = foodNameTextBox.Text;
		}
		#endregion /FoodNameTextBox_Validated 
		//-----
		#endregion /FoodNameTextBox

		#region FoodPriceTextBox
		//-----
		#region FoodPriceTextBox_Enter
		private void FoodPriceTextBox_Enter(object sender, System.EventArgs e)
		{
			foodPriceTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			panel2.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(foodPriceTextBox.Text, "0 تومان") == 0)
			{
				foodPriceTextBox.Clear();
				return;
			}
		}
		#endregion /FoodPriceTextBox_Enter

		#region FoodPriceTextBox_KeyPress
		private void FoodPriceTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}

		#endregion /FoodPriceTextBox_KeyPress

		#region FoodPriceTextBox_Leave
		private void FoodPriceTextBox_Leave(object sender, System.EventArgs e)
		{
			foodPriceTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();
			panel2.BackColor =
				Infrastructure.Utility.DimGrayColor();

			if (string.IsNullOrWhiteSpace(foodPriceTextBox.Text))
			{
				foodPriceTextBox.Text = "0 تومان";
				return;
			}
			else
			{
				return;
			}
		}
		#endregion /FoodPriceTextBox_Leave

		#region FoodPriceTextBox_MouseClick
		private void FoodPriceTextBox_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			foodPriceTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			panel2.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(foodPriceTextBox.Text, "0 تومان") == 0)
			{
				foodPriceTextBox.Clear();
				return;
			}
		}
		#endregion /FoodPriceTextBox_MouseClick

		#region FoodPriceTextBox_Validated
		private void FoodPriceTextBox_Validated(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(foodPriceTextBox.Text) || string.Compare(foodPriceTextBox.Text, "0 تومان") == 0)
			{
				FoodPrice = 0;
				Price = string.Empty;
			}
			else
			{
				Price = foodPriceTextBox.Text.Replace("تومان", string.Empty).Trim();
				FoodPrice = decimal.Parse(Price);
				foodPriceTextBox.Text = $"{FoodPrice.ToString("#,0")} تومان";
				Price = $"{FoodPrice.ToString("#,0")} تومان";
			}
		}
		#endregion /FoodPriceTextBox_Validated
		//-----
		#endregion /FoodPriceTextBox

		#region DescriptionTextBox
		//-----
		#region DescriptionTextBox_Enter
		private void DescriptionTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
			descriptionTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(descriptionTextBox.Text, "توضیحات") == 0)
			{
				descriptionTextBox.Clear();
			}
		}
		#endregion /DescriptionTextBox_Enter

		#region DescriptionTextBox_KeyPress
		private void DescriptionTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianAndNumberTyping(e);
		}
		#endregion /DescriptionTextBox_KeyPress

		#region DescriptionTextBox_Leave
		private void DescriptionTextBox_Leave(object sender, System.EventArgs e)
		{
			descriptionTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();

			if (string.IsNullOrWhiteSpace(descriptionTextBox.Text))
			{
				descriptionTextBox.Text = "توضیحات";
			}
		}
		#endregion /DescriptionTextBox_Leave

		#region DescriptionTextBox_MouseClick
		private void DescriptionTextBox_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
			descriptionTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(descriptionTextBox.Text, "توضیحات") == 0)
			{
				descriptionTextBox.Clear();
			}
		}
		#endregion /DescriptionTextBox_MouseClick

		#region DescriptionTextBox_Validated
		private void DescriptionTextBox_Validated(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(descriptionTextBox.Text) || string.Compare(descriptionTextBox.Text, "توضیحات") == 0)
			{
				Description = string.Empty;
			}
			else
				Description = descriptionTextBox.Text;
		}
		#endregion /DescriptionTextBox_Validated
		//-----
		#endregion /DescriptionTextBox

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
		#endregion /FoodImagePicturBox_MouseDoubleClick

		#region ResetButton_Click
		private void ResetButton_Click(object sender, System.EventArgs e)
		{
			this.AllClear();
		}
		#endregion /ResetButton_Click

		#region SaveButton_Click
		private void SaveButton_Click(object sender, System.EventArgs e)
		{
			Models.DataBaseContext dataBaseContext = null;

			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				string errorMessage = string.Empty;

				#region Validation
				//-----
				if (string.IsNullOrWhiteSpace(foodNameTextBox.Text) ||
							string.Compare(foodNameTextBox.Text, "نام غذا") == 0)
				{
					errorMessage = "فیلد نام غذا تکمیل گردد!";
				}

				if (string.IsNullOrWhiteSpace(foodPriceTextBox.Text) ||
					string.Compare(foodPriceTextBox.Text, "مبلغ غذا") == 0)
				{
					if (errorMessage != string.Empty)
					{
						errorMessage +=
							System.Environment.NewLine + "       ";
					}
					errorMessage +=
						"فیلد مبلغ غذا تکمیل گردد!";
				}

				if (string.IsNullOrWhiteSpace(descriptionTextBox.Text) ||
					string.Compare(descriptionTextBox.Text, "توضیحات") == 0)
				{
					if (errorMessage != string.Empty)
					{
						errorMessage +=
							System.Environment.NewLine + "       ";
					}
					errorMessage +=
						"فیلد توضیحات تکمیل گردد!";
				}

				if (errorMessage != string.Empty)
				{
					if (string.IsNullOrWhiteSpace(foodNameTextBox.Text) ||
							string.Compare(foodNameTextBox.Text, "نام غذا") == 0)
					{
						foodNameTextBox.Focus();
						foodNameTextBox.Clear();
					}

					else if (string.IsNullOrWhiteSpace(foodPriceTextBox.Text) ||
						string.Compare(foodPriceTextBox.Text, "مبلغ غذا") == 0)
					{
						foodPriceTextBox.Focus();
						foodPriceTextBox.Clear();
					}

					else if (string.IsNullOrWhiteSpace(descriptionTextBox.Text) ||
						string.Compare(descriptionTextBox.Text, "توضیحات") == 0)
					{
						descriptionTextBox.Focus();
						descriptionTextBox.Clear();
					}
					ErrorMessage(errorMessage);
					return;
				}

				if (string.IsNullOrEmpty(FoodImage))
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
					return;
				}
				//-----
				#endregion /Validation

				errorMessageLabel.Visible = false;
				errorMessage = string.Empty;

				System.Windows.Forms.DialogResult dialogResult;

				dialogResult = Mbb.Windows.Forms.MessageBox.QuestionMessage
					(text: $"{FoodName} ثبت گردد؟",
					captiopn: "ثبت غذا",
					buttons: System.Windows.Forms.MessageBoxButtons.YesNo,
					defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button2,
					icon: System.Windows.Forms.MessageBoxIcon.Question,
					options: System.Windows.Forms.MessageBoxOptions.RightAlign |
					 System.Windows.Forms.MessageBoxOptions.RtlReading);

				if (dialogResult == System.Windows.Forms.DialogResult.Yes)
				{
					Models.Food food =
					dataBaseContext.Foods
					.Where(current => string.Compare(current.FoodName, FoodName, false) == 0)
					.FirstOrDefault();

					if (food != null)
					{
						errorMessage =
							$"{FoodName} در سیستم موجود است!";

						ErrorMessage(errorMessage);
						foodNameTextBox.Focus();
						foodNameTextBox.SelectAll();
						return;
					}
					else
					{
						RegisterDate = Infrastructure.Utility.PersianCalendar(System.DateTime.Now);

						RegisterTime = Infrastructure.Utility.ShowTime();

						food =
							new Models.Food
							{
								FoodName = FoodName,
								FoodPrice = $"{FoodPrice.ToString("#,0")} تومان",
								Description = Description,
								FoodImage = System.IO.File.ReadAllBytes(FoodImage),
								RegisterTime = RegisterDate + " " + RegisterTime,
								UpdateTime = UpdateTime,
								NumberUpdate = int.Parse(NumberUpdate),
							};
						dataBaseContext.Foods.Add(food);
						dataBaseContext.SaveChanges();

						//-----جهت بارگذاری اطلاعات غذا در جدول داده 
						if (Resturant.MainForm.MenuListForm != null)
						{
							Resturant.MainForm.MenuListForm.FoodLoader();
						}

						string message =
							$"{FoodName} ثبت گردید.";

						Infrastructure.Utility.WindowsNotification
							(message: message,
							caption: Infrastructure.PopupNotificationForm.Caption.موفقیت,
							picture: FoodImage);

						AllClear();
					}
				}
				else
				{
					return;
				}
			}
			catch (System.Exception ex)
			{
				Infrastructure.Utility.PopupNotification(ex);
			}
			finally
			{
				if (dataBaseContext != null)
				{
					dataBaseContext.Dispose();
					dataBaseContext = null;
				}
			}
		}
		#endregion /SaveButton_Click
		//-----Enf of the codes.

		#region Methods
		//-----
		#region AllClear
		private void AllClear()
		{
			FoodName = string.Empty;
			foodNameTextBox.Text = "نام غذا";
			Price = string.Empty;
			FoodPrice = 0;
			foodPriceTextBox.Text = "0 تومان";
			Description = string.Empty;
			descriptionTextBox.Text = "توضیحات";
			FoodImage = string.Empty;
			foodImagePicturBox.Image = Resturant.Properties.Resources.food_512;
		}
		#endregion /AllClear

		#region ErrorMessage
		private void ErrorMessage(string message)
		{
			errorMessageLabel.Text = "        " + message;
			errorMessageLabel.Visible = true;
		}
		#endregion /ErrorMessage
		//-----
		#endregion /Methods
	}
}