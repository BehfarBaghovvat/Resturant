using System.Linq;

namespace Foods
{
	public partial class DessertAddForm : Infrastructure.BaseForm
	{
		public DessertAddForm()
		{
			InitializeComponent();
		}

		#region Properties
		//-----
		public string DessertName { get; set; }
		public string Price { get; set; }
		public decimal DessertPrice { get; set; }
		public string DessertImage { get; set; }
		public string Description { get; set; }
		public string RegisterTime { get; set; }
		public string RegisterDate { get; set; }
		public string UpdateTime { get; set; }
		public string NumberUpdate { get; set; }
		//-----
		#endregion /Properties

		//-----Beginning of the codes.

		#region DessertAddForm_Load
		private void DessertAddForm_Load(object sender, System.EventArgs e)
		{
			UpdateTime = "0000/00/00 00:00:00";
			NumberUpdate = "0";

			dessertNameTextBox.Text = "نام دسر";
			dessertPriceTextBox.Text = "0 تومان";
			descriptionTextBox.Text = "توضیحات";
		}
		#endregion /DessertAddForm_Load

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

		}
		#endregion MinimizeButton_Click

		#region DessertNameTextBox
		//-----
		#region DessertNameTextBox_Enter
		private void DessertNameTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
			dessertNameTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			panel1.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(dessertNameTextBox.Text, "نام دسر") == 0)
			{
				dessertNameTextBox.Clear();
			}
		}
		#endregion /DessertNameTextBox_Enter

		#region DessertNameTextBox_KeyPress
		private void DessertNameTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianTyping(e);
		}
		#endregion /DessertNameTextBox_KeyPress

		#region DessertNameTextBox_Leave
		private void DessertNameTextBox_Leave(object sender, System.EventArgs e)
		{
			dessertNameTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();
			panel1.BackColor =
				Infrastructure.Utility.WhiteColor();

			if (string.IsNullOrWhiteSpace(dessertNameTextBox.Text))
			{
				dessertNameTextBox.Text = "نام دسر";
			}
		}
		#endregion /DessertNameTextBox_Leave

		#region DessertNameTextBox_MouseClick
		private void DessertNameTextBox_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
			dessertNameTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			panel1.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(dessertNameTextBox.Text, "نام دسر") == 0)
			{
				dessertNameTextBox.Clear();
			}
		}
		#endregion /DessertNameTextBox_MouseClick

		#region DessertNameTextBox_Validated
		private void DessertNameTextBox_Validated(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(dessertNameTextBox.Text) || string.Compare(dessertNameTextBox.Text, "نام دسر") == 0)
			{
				DessertName = string.Empty;
				return;
			}
			else
				DessertName = dessertNameTextBox.Text;
		}
		#endregion /DessertNameTextBox_Validated
		//-----
		#endregion /DessertNameTextBox

		#region DessertPriceTextBox
		//-----
		#region DessertPriceTextBox_Enter
		private void DessertPriceTextBox_Enter(object sender, System.EventArgs e)
		{
			dessertPriceTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			panel2.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(dessertPriceTextBox.Text, "0 تومان") == 0)
			{
				dessertPriceTextBox.Clear();
			}
		}
		#endregion /DessertPriceTextBox_Enter

		#region DessertPriceTextBox_KeyPress
		private void DessertPriceTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}
		#endregion /DessertPriceTextBox_KeyPress

		#region DescriptionTextBox_Leave
		private void DessertPriceTextBox_Leave(object sender, System.EventArgs e)
		{
			dessertPriceTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();
			panel2.BackColor =
				Infrastructure.Utility.WhiteColor();

			if (string.IsNullOrWhiteSpace(dessertPriceTextBox.Text))
			{
				dessertPriceTextBox.Text = "0 تومان";
			}
		}
		#endregion /DescriptionTextBox_Leave

		#region DessertPriceTextBox_MouseClick
		private void DessertPriceTextBox_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			dessertPriceTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			panel2.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(dessertPriceTextBox.Text, "0 تومان") == 0)
			{
				dessertPriceTextBox.Clear();
			}
		}
		#endregion /DessertPriceTextBox_MouseClick

		#region DessertPriceTextBox_Validated
		private void DessertPriceTextBox_Validated(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(dessertPriceTextBox.Text) || string.Compare(dessertPriceTextBox.Text, "0 تومان") == 0)
			{
				DessertPrice = 0;
				Price = string.Empty;
			}
			else
			{
				Price = dessertPriceTextBox.Text.Replace("تومان", string.Empty).Trim();
				DessertPrice = decimal.Parse(Price);
				dessertPriceTextBox.Text = $"{DessertPrice.ToString("#,0")} تومان";
				Price = $"{DessertPrice.ToString("#,0")} تومان";
			}
		}
		#endregion /DessertPriceTextBox_Validated
		//-----
		#endregion /DessertPriceTextBox

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

		#region DessertImagePicturBox_MouseDoubleClick
		private void DessertImagePicturBox_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
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
				DessertImage = openFileDialog.FileName;

				dessertImagePicturBox.Image = System.Drawing.Image.FromFile(DessertImage);
			}
		}
		#endregion /DessertImagePicturBox_MouseDoubleClick

		#region ResetButton_Click
		private void ResetButton_Click(object sender, System.EventArgs e)
		{
			AllClear();
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
				if (string.IsNullOrWhiteSpace(dessertNameTextBox.Text) ||
							string.Compare(dessertNameTextBox.Text, "نام دسر") == 0)
				{
					errorMessage = "فیلد دسر تکمیل گردد!";
				}

				if (string.IsNullOrWhiteSpace(dessertPriceTextBox.Text) ||
					string.Compare(dessertPriceTextBox.Text, "0 تومان") == 0)
				{
					if (errorMessage != string.Empty)
					{
						errorMessage +=
							System.Environment.NewLine + "       ";
					}

					errorMessage +=
						"فیلد مبلغ پیش غذا تکمیل گردد!";
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
					if (string.IsNullOrWhiteSpace(dessertNameTextBox.Text) ||
							string.Compare(dessertNameTextBox.Text, "نام غذا") == 0)
					{
						dessertNameTextBox.Focus();
						dessertNameTextBox.Clear();
					}

					else if (string.IsNullOrWhiteSpace(dessertPriceTextBox.Text) ||
						string.Compare(dessertPriceTextBox.Text, "مبلغ غذا") == 0)
					{
						dessertPriceTextBox.Focus();
						dessertPriceTextBox.Clear();
					}

					else if (string.IsNullOrWhiteSpace(descriptionTextBox.Text) ||
						string.Compare(descriptionTextBox.Text, "توضیحات") == 0)
					{
						descriptionTextBox.Focus();
						descriptionTextBox.Clear();
					}

					ErrorMessage(errorMessage);
				}

				if (string.IsNullOrEmpty(DessertImage))
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
						DessertImage = openFileDialog.FileName;

						dessertImagePicturBox.Image = System.Drawing.Image.FromFile(DessertImage);
					}
					return;
				}
				//-----
				#endregion /Validation

				errorMessageLabel.Visible = false;
				errorMessage = string.Empty;

				System.Windows.Forms.DialogResult dialogResult;

				dialogResult = Mbb.Windows.Forms.MessageBox.QuestionMessage
					(text: $"{DessertName} ثبت گردد؟",
					captiopn: "ثبت نوشیدنی",
					buttons: System.Windows.Forms.MessageBoxButtons.YesNo,
					defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button2,
					icon: System.Windows.Forms.MessageBoxIcon.Question,
					options: System.Windows.Forms.MessageBoxOptions.RightAlign |
					 System.Windows.Forms.MessageBoxOptions.RtlReading);

				if (dialogResult == System.Windows.Forms.DialogResult.Yes)
				{
					Models.DessertAndAppetizer dessertAndAppetizer =
					dataBaseContext.DessertAndAppetizers
					.Where(current => string.Compare(current.DessertName, DessertName, false) == 0)
					.FirstOrDefault();

					if (dessertAndAppetizer != null)
					{
						//errorMessage =
						//	System.Environment.NewLine;

						errorMessage =
							$"{DessertName} در سیستم موجود است!";

						ErrorMessage(errorMessage);
						dessertNameTextBox.Focus();
						dessertNameTextBox.SelectAll();
						return;
					}

					else
					{
						RegisterDate = Infrastructure.Utility.PersianCalendar(System.DateTime.Now);

						RegisterTime = Infrastructure.Utility.ShowTime();

						dessertAndAppetizer =
							new Models.DessertAndAppetizer
							{
								DessertName = DessertName,
								DessertPrice = $"{DessertPrice.ToString("#,0")} تومان",
								Description = Description,
								DessertImage = System.IO.File.ReadAllBytes(DessertImage),
								RegisterTime = RegisterDate + " " + RegisterTime,
								UpdateTime = UpdateTime,
								NumberUpdate = int.Parse(NumberUpdate),
							};
						dataBaseContext.DessertAndAppetizers.Add(dessertAndAppetizer);
						dataBaseContext.SaveChanges();

						//-----جهت بارگذاری اطلاعات غذا در جدول داده 
						if (Resturant.MainForm.MenuListForm != null)
						{
							Resturant.MainForm.MenuListForm.DessertLoader();
						}

						string message =
							$"{DessertName} ثبت گردید.";

						Infrastructure.Utility.WindowsNotification
							(message: message,
							caption: Infrastructure.PopupNotificationForm.Caption.موفقیت,
							picture: DessertImage);

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
			DessertName = string.Empty;
			dessertNameTextBox.Text = "نام غذا";
			Price = string.Empty;
			DessertPrice = 0;
			dessertPriceTextBox.Text = "0 تومان";
			Description = string.Empty;
			descriptionTextBox.Text = "توضیحات";
			DessertImage = string.Empty;
			dessertImagePicturBox.Image = Resturant.Properties.Resources.ice_cream_sundae_512px;
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
