using System.Linq;

namespace Foods
{
	public partial class DrinkAddForm : Infrastructure.BaseForm
	{
		public DrinkAddForm()
		{
			InitializeComponent();
		}

		#region Properties
		public string DrinkName { get; set; }
		public string Price { get; set; }
		public decimal DrinkPrice { get; set; }
		public string DrinkImage { get; set; }
		public string Description { get; set; }
		public string RegisterTime { get; set; }
		public string RegisterDate { get; set; }
		public string UpdateTime { get; set; }
		public string NumberUpdate { get; set; }
		#endregion /Properties

		//-----Beginning of the codes.
		#region DrinkAddForm_Load
		private void DrinkAddForm_Load(object sender, System.EventArgs e)
		{
			UpdateTime = "0000/00/00 00:00:00";
			NumberUpdate = "0";

			drinkNameTextBox.Text = "نام نوشیدنی";
			drinkPriceTextBox.Text = "0 تومان";
			descriptionTextBox.Text = "توضیحات";
		}
		#endregion /DrinkAddForm_Load

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

		#region DrinkNameTextBox
		//-----
		#region DrinkNameTextBox_Enter
		private void DrinkNameTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
			drinkNameTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			panel1.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(drinkNameTextBox.Text, "نام نوشیدنی") == 0)
			{
				drinkNameTextBox.Clear();
			}
		}

		#endregion /DrinkNameTextBox_Enter

		#region DrinkNameTextBox_KeyPress
		private void DrinkNameTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianTyping(e);
		}

		#endregion /DrinkNameTextBox_KeyPress

		#region DrinkNameTextBox_Leave
		private void DrinkNameTextBox_Leave(object sender, System.EventArgs e)
		{
			drinkNameTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();
			panel1.BackColor =
				Infrastructure.Utility.DimGrayColor();

			if (string.IsNullOrWhiteSpace(drinkNameTextBox.Text))
			{
				drinkNameTextBox.Text = "نام نوشیدنی";
			}
		}

		#endregion /DrinkNameTextBox_Leave

		#region DrinkNameTextBox_MouseClick
		private void DrinkNameTextBox_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
			drinkNameTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			panel1.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(drinkNameTextBox.Text, "نام نوشیدنی") == 0)
			{
				drinkNameTextBox.Clear();
			}
		}

		#endregion/DrinkNameTextBox_MouseClick

		#region DrinkNameTextBox_Validated
		private void DrinkNameTextBox_Validated(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(drinkNameTextBox.Text) || string.Compare(drinkNameTextBox.Text, "نام نوشیدنی") == 0)
			{
				DrinkName = string.Empty;
				return;
			}
			else
				DrinkName = drinkNameTextBox.Text;
		}

		#endregion /DrinkNameTextBox_Validated
		//-----
		#endregion /DrinkNameTextBox

		#region DrinkPriceTextBox
		//-----
		#region DrinkPriceTextBox_Enter
		private void DrinkPriceTextBox_Enter(object sender, System.EventArgs e)
		{
			drinkPriceTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			panel2.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(drinkPriceTextBox.Text, "0 تومان") == 0)
			{
				drinkPriceTextBox.Clear();
			}
		}

		#endregion /DrinkPriceTextBox_Enter

		#region DrinkPriceTextBox_KeyPress
		private void DrinkPriceTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}

		#endregion /DrinkPriceTextBox_KeyPress

		#region DrinkPriceTextBox_Leave
		private void DrinkPriceTextBox_Leave(object sender, System.EventArgs e)
		{
			drinkPriceTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();
			panel2.BackColor =
				Infrastructure.Utility.DimGrayColor();

			if (string.IsNullOrWhiteSpace(drinkPriceTextBox.Text))
			{
				drinkPriceTextBox.Text = "0 تومان";
			}
		}

		#endregion /DrinkPriceTextBox_Leave

		#region DrinkPriceTextBox_MouseClick
		private void DrinkPriceTextBox_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			drinkPriceTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			panel2.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(drinkPriceTextBox.Text, "0 تومان") == 0)
			{
				drinkPriceTextBox.Clear();
			}
		}

		#endregion /DrinkPriceTextBox_MouseClick

		#region DrinkPriceTextBox_Validated
		private void DrinkPriceTextBox_Validated(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(drinkPriceTextBox.Text) || string.Compare(drinkPriceTextBox.Text, "0 تومان") == 0)
			{
				DrinkPrice = 0;
				Price = string.Empty;
			}
			else
			{
				Price = drinkPriceTextBox.Text.Replace("تومان", string.Empty).Trim();
				DrinkPrice = decimal.Parse(Price);
				drinkPriceTextBox.Text = $"{DrinkPrice.ToString("#,0")} تومان";
				Price = $"{DrinkPrice.ToString("#,0")} تومان";
			}
		}

		#endregion /DrinkPriceTextBox_Validated
		//-----
		#endregion /DrinkPriceTextBox

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
		//-----
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

		#endregion /DescriptionTextBox

		#region DrinkImagePicturBox_MouseDoubleClick
		private void DrinkImagePicturBox_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
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
				DrinkImage = openFileDialog.FileName;

				drinkImagePicturBox.Image = System.Drawing.Image.FromFile(DrinkImage);
			}
		}
		#endregion /DrinkImagePicturBox_MouseDoubleClick

		#region ResetButton_Click
		private void ResetButton_Click(object sender, System.EventArgs e)
		{

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
				if (string.IsNullOrWhiteSpace(drinkNameTextBox.Text) ||
							string.Compare(drinkNameTextBox.Text, "نام نوشیدنی") == 0)
				{
					errorMessage = "فیلد نام نوشیدنی تکمیل گردد!";
				}

				if (string.IsNullOrWhiteSpace(drinkPriceTextBox.Text) ||
					string.Compare(drinkPriceTextBox.Text, "مبلغ نوشیدنی") == 0)
				{
					if (errorMessage != string.Empty)
					{
						errorMessage +=
							System.Environment.NewLine + "       ";
					}
					errorMessage +=
						"فیلد مبلغ نوشیدنی تکمیل گردد!";
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
					if (string.IsNullOrWhiteSpace(drinkNameTextBox.Text) ||
							string.Compare(drinkNameTextBox.Text, "نام غذا") == 0)
					{
						drinkNameTextBox.Focus();
						drinkNameTextBox.Clear();
					}

					else if (string.IsNullOrWhiteSpace(drinkPriceTextBox.Text) ||
						string.Compare(drinkPriceTextBox.Text, "مبلغ غذا") == 0)
					{
						drinkPriceTextBox.Focus();
						drinkPriceTextBox.Clear();
					}

					else if (string.IsNullOrWhiteSpace(descriptionTextBox.Text) ||
						string.Compare(descriptionTextBox.Text, "توضیحات") == 0)
					{
						descriptionTextBox.Focus();
						descriptionTextBox.Clear();
					}
					ErrorMessage(errorMessage);
				}

				if (string.IsNullOrEmpty(DrinkImage))
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
						DrinkImage = openFileDialog.FileName;

						drinkImagePicturBox.Image = System.Drawing.Image.FromFile(DrinkImage);
					}
				}
				//-----
				#endregion /Validation

				errorMessageLabel.Visible = false;
				errorMessage = string.Empty;

				System.Windows.Forms.DialogResult dialogResult;

				dialogResult = Mbb.Windows.Forms.MessageBox.QuestionMessage
					(text: $"{DrinkName} ثبت گردد؟",
					captiopn: "ثبت نوشیدنی",
					buttons: System.Windows.Forms.MessageBoxButtons.YesNo,
					defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button2,
					icon: System.Windows.Forms.MessageBoxIcon.Question,
					options: System.Windows.Forms.MessageBoxOptions.RightAlign |
					 System.Windows.Forms.MessageBoxOptions.RtlReading);

				if (dialogResult == System.Windows.Forms.DialogResult.Yes)
				{
					RegisterDate = Infrastructure.Utility.PersianCalendar(System.DateTime.Now);

					RegisterTime = Infrastructure.Utility.ShowTime();

					Models.Drink drink =
					dataBaseContext.Drinks
					.Where(current => string.Compare(current.DrinkName, DrinkName, false) == 0)
					.FirstOrDefault();

					if (drink != null)
					{
						//errorMessage =
						//	System.Environment.NewLine;

						errorMessage =
							$"{DrinkName} در سیستم موجود است!";

						ErrorMessage(errorMessage);
						drinkNameTextBox.Focus();
						drinkNameTextBox.SelectAll();
						return;
					}
					else
					{
						drink =
							new Models.Drink
							{
								DrinkName = DrinkName,
								DrinkPrice = $"{DrinkPrice.ToString("#,0")} تومان",
								Description = Description,
								DrinkImage = System.IO.File.ReadAllBytes(DrinkImage),
								RegisterTime = RegisterDate + " " + RegisterTime,
								UpdateTime = UpdateTime,
								NumberUpdate = int.Parse(NumberUpdate),
							};
						dataBaseContext.Drinks.Add(drink);
						dataBaseContext.SaveChanges();

						//-----جهت بارگذاری اطلاعات غذا در جدول داده 
						if (Resturant.MainForm.MenuListForm != null)
						{
							Resturant.MainForm.MenuListForm.DrinkLoader();
						}

						string message =
							$"{DrinkName} ثبت گردید.";

						Infrastructure.Utility.WindowsNotification
							(message: message,
							caption: Infrastructure.PopupNotificationForm.Caption.موفقیت,
							picture: DrinkImage);

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

		#region Method
		//-----
		#region AllClear
		private void AllClear()
		{
			DrinkName = string.Empty;
			drinkNameTextBox.Text = "نام غذا";
			Price = string.Empty;
			DrinkPrice = 0;
			drinkPriceTextBox.Text = "0 تومان";
			Description = string.Empty;
			descriptionTextBox.Text = "توضیحات";
			DrinkImage = string.Empty;
			drinkImagePicturBox.Image = Resturant.Properties.Resources.drink_512;
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
		#endregion /Method
	}
}