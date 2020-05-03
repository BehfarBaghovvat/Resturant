using System.Linq;
using System.Runtime.InteropServices;

namespace Resturant
{
	public partial class RegisterForm : Infrastructure.BaseForm
	{
		public RegisterForm()
		{
			InitializeComponent();
		}

		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

		#region Properties
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string FullName { get; set; }
		public string Username { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string PasswordConfirm { get; set; }
		public string UserImage { get; set; }
		public string RegisterDate { get; set; }
		public string RegisterTime { get; set; }
		#endregion /Properties

		//-----Beginning of the Code.
		#region RegisterForm_MouseDown
		private void RegisterForm_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		#endregion /RegisterForm_MouseDown

		#region CloseButton_Click
		private void CloseButton_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.Application.Exit();
		}
		#endregion /CloseButton_Click

		#region MinimizeButton_Click
		private void MinimizeButton_Click(object sender, System.EventArgs e)
		{
			this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
		}
		#endregion /MinimizeButton_Click

		#region FirstNameTextBox
		//-----
		#region FirstNameTextBox_Enter
		private void FirstNameTextBox_Enter(object sender, System.EventArgs e)
		{
			firstNameTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			panel1.BackColor =
				Infrastructure.Utility.LimeColor();

			firstNamePicturBox.Image =
				Properties.Resources.man_512_lim;

			Infrastructure.Utility.PersianLanguage();

			if (string.Compare(firstNameTextBox.Text, "نام") == 0)
			{
				firstNameTextBox.Clear();
			}
		}
		#endregion /FirstNameTextBox_Enter

		#region FirstNameTextBox_KeyPress
		private void FirstNameTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianTyping(e);
		}
		#endregion /FirstNameTextBox_KeyPress

		#region FirstNameTextBox_Leave
		private void FirstNameTextBox_Leave(object sender, System.EventArgs e)
		{
			firstNameTextBox.ForeColor = Infrastructure.Utility.DimGrayColor();
			panel1.BackColor = Infrastructure.Utility.DimGrayColor();
			firstNamePicturBox.Image =
				Properties.Resources.man_512;

			if (string.IsNullOrWhiteSpace(firstNameTextBox.Text))
			{
				firstNameTextBox.Text = "نام";
			}
		}
		#endregion /FirstNameTextBox_Leave

		#region FirstNameTextBox_TextChanged
		private void FirstNameTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.Compare(firstNameTextBox.Text, string.Empty) == 0 || string.IsNullOrWhiteSpace(firstNameTextBox.Text))
			{
				FirstName = string.Empty;
			}
			else
			{
				FirstName = Infrastructure.Utility.TextFixed(firstNameTextBox.Text);
			}
		}
		#endregion /FirstNameTextBox_TextChanged
		//-----
		#endregion /FirstNameTextBox

		#region LastNameTextBox
		//-----
		#region LastNameTextBox_Enter
		private void LastNameTextBox_Enter(object sender, System.EventArgs e)
		{
			lastNameTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			panel2.BackColor =
				Infrastructure.Utility.LimeColor();

			lastNamePicturBox.Image =
				Properties.Resources.family_parents_kids_children_512_lim;

			Infrastructure.Utility.PersianLanguage();

			if (string.Compare(lastNameTextBox.Text, "نام خانوادگی") == 0)
			{
				lastNameTextBox.Clear();
			}
		}
		#endregion /LastNameTextBox_Enter

		#region LastNameTextBox_KeyPress
		private void LastNameTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianTyping(e);
		}
		#endregion /LastNameTextBox_KeyPress

		#region LastNameTextBox_Leave
		private void LastNameTextBox_Leave(object sender, System.EventArgs e)
		{
			lastNameTextBox.ForeColor =
				Infrastructure.Utility.DimGrayColor();
			panel2.BackColor =
				Infrastructure.Utility.DimGrayColor();

			lastNamePicturBox.Image =
			Properties.Resources.family_parents_kids_children_512;

			if (string.IsNullOrWhiteSpace(lastNameTextBox.Text))
			{
				lastNameTextBox.Text = "نام خانوادگی";
			}
		}
		#endregion /LastNameTextBox_Leave

		#region LastNameTextBox_TextChanged
		private void LastNameTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.Compare(lastNameTextBox.Text, "") == 0 || string.IsNullOrWhiteSpace(lastNameTextBox.Text))
			{
				LastName = string.Empty;
			}
			else
			{
				LastName = Infrastructure.Utility.TextFixed(lastNameTextBox.Text);
			}
		}
		#endregion /LastNameTextBox_TextChanged
		//-----
		#endregion /LastNameTextBox

		#region  UsernameTextBox
		//-----
		#region UsernameTextBox_Enter
		private void UsernameTextBox_Enter(object sender, System.EventArgs e)
		{
			usernameTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			usernameTextBox.Font =
				Infrastructure.Utility.CenturyGothicFont(usernameTextBox.Font.Size);
			panel3.BackColor =
				Infrastructure.Utility.LimeColor();

			usernamePicturBox.Image =
				Properties.Resources.username_512_lim;

			usernameTextBox.RightToLeft =
				System.Windows.Forms.RightToLeft.No;
			usernameTextBox.TextAlign =
				System.Windows.Forms.HorizontalAlignment.Left;

			Infrastructure.Utility.EnglishLanguage();

			if (string.Compare(usernameTextBox.Text, "شناسه کاربری") == 0)
			{
				usernameTextBox.Clear();

				usernameTextBox.RightToLeft =
					System.Windows.Forms.RightToLeft.No;

				usernameTextBox.TextAlign =
					System.Windows.Forms.HorizontalAlignment.Left;
			}
		}
		#endregion /UsernameTextBox_Enter

		#region UsernameTextBox_KeyPress
		private void UsernameTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.EnglishAndNumberTyping(e);
		}
		#endregion UsernameTextBox_KeyPress

		#region UsernameTextBox_Leave
		private void UsernameTextBox_Leave(object sender, System.EventArgs e)
		{
			usernameTextBox.ForeColor =
				Infrastructure.Utility.DimGrayColor();

			panel3.BackColor =
				Infrastructure.Utility.DimGrayColor();

			usernamePicturBox.Image =
				Properties.Resources.username_512;

			if (string.IsNullOrWhiteSpace(usernameTextBox.Text))
			{
				usernameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				usernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				usernameTextBox.Font =
				Infrastructure.Utility.IranSansFont(usernameTextBox.Font.Size);
				usernameTextBox.Text = "شناسه کاربری";
			}
		}
		#endregion /UsernameTextBox_Leave

		#region UsernameTextBox_Validated
		private void UsernameTextBox_Validated(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(usernameTextBox.Text) || (string.Compare(usernameTextBox.Text, "شناسه کاربری") == 0))
			{
				tickPicturBox1.Visible = false;
				Username = string.Empty;
				emailTextBox.Focus();
				//return;
			}
			else if (Infrastructure.Utility.UserCheck(usernameTextBox.Text) == true)
			{
				tickPicturBox1.Image = Properties.Resources.Tik_True;
				tickPicturBox1.Visible = true;
				Username = usernameTextBox.Text;
				return;
			}
			else
			{
				tickPicturBox1.Image = Properties.Resources.Tik_False;
				tickPicturBox1.Visible = true;
				Username = string.Empty;
				return;
			}
		}
		#endregion /UsernameTextBox_Validated
		//-----
		#endregion /UsernameTextBox

		#region EmailTextBox
		//-----
		#region EmailTextBox_Enter
		private void EmailTextBox_Enter(object sender, System.EventArgs e)
		{
			emailTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			emailTextBox.Font =
				Infrastructure.Utility.CenturyGothicFont(emailTextBox.Font.Size);
			panel4.BackColor =
				Infrastructure.Utility.LimeColor();

			emailPicturBox.Image =
				Properties.Resources.mail_512_lim;

			emailTextBox.RightToLeft =
				System.Windows.Forms.RightToLeft.No;

			emailTextBox.TextAlign =
				System.Windows.Forms.HorizontalAlignment.Left;

			Infrastructure.Utility.EnglishLanguage();

			if (string.Compare(emailTextBox.Text, "پست الکترونیکی") == 0)
			{
				emailTextBox.Clear();
			}

		}
		#endregion /EmailTextBox_Enter

		#region EmailTextBox_KeyPress
		private void EmailTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.EnglishAndNumberTyping(e);
		}
		#endregion /EmailTextBox_KeyPress

		#region EmailTextBox_Leave
		private void EmailTextBox_Leave(object sender, System.EventArgs e)
		{
			emailTextBox.ForeColor =
				Infrastructure.Utility.DimGrayColor();
			panel4.BackColor =
				Infrastructure.Utility.DimGrayColor();

			emailPicturBox.Image =
				Properties.Resources.mail_512;

			if (string.IsNullOrWhiteSpace(emailTextBox.Text))
			{
				emailTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				emailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
				emailTextBox.Font = Infrastructure.Utility.IranSansFont(emailTextBox.Font.Size);
				emailTextBox.Text = "پست الکترونیکی";
			}
		}
		#endregion /EmailTextBox_Leave

		#region EmailTextBox_Validated
		private void EmailTextBox_Validated(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(emailTextBox.Text) || string.Compare(emailTextBox.Text, "پست الکترونیکی") == 0)
			{
				tickPicturBox2.Visible = false;
				Email = string.Empty;
				return;
			}
			else if (Infrastructure.Utility.EmailChecker(email: emailTextBox.Text) == true)
			{
				tickPicturBox2.Image = Properties.Resources.Tik_True;
				tickPicturBox2.Visible = true;
				Email = emailTextBox.Text;
				return;
			}
			else
			{
				tickPicturBox2.Image = Properties.Resources.Tik_False;
				tickPicturBox2.Visible = true;
				Email = string.Empty;
				emailTextBox.SelectAll();
				emailTextBox.Focus();
				return;
			}
		}
		#endregion /EmailTextBox_Validated
		//-----
		#endregion /EmailTextBox

		#region PasswrodTextBox
		//-----
		#region PasswordTextBox_Enter
		private void PasswordTextBox_Enter(object sender, System.EventArgs e)
		{
			passwordTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			panel5.BackColor =
				Infrastructure.Utility.LimeColor();

			passwordPicturBox.Image =
				Properties.Resources.password_512_lim;

			passwordTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
			passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;

			Infrastructure.Utility.EnglishLanguage();

			if (string.Compare(passwordTextBox.Text, "رمز عبور") == 0)
			{
				passwordTextBox.Clear();
				passwordTextBox.UseSystemPasswordChar = true;
			}
		}
		#endregion /PasswordTextBox_Enter

		#region PasswordTextBox_Leave
		private void PasswordTextBox_Leave(object sender, System.EventArgs e)
		{
			passwordTextBox.ForeColor =
				Infrastructure.Utility.DimGrayColor();
			panel5.BackColor =
				Infrastructure.Utility.DimGrayColor();

			passwordPicturBox.Image =
				Properties.Resources.password_512;

			if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
			{
				passwordTextBox.Text = "رمز عبور";
				passwordTextBox.UseSystemPasswordChar = false;
				passwordTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			}
		}
		#endregion /PasswordTextBox_Leave

		#region PasswordShowPicturBox1_MouseDown
		private void PasswordShowPicturBox1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			passwordShowPicturBox1.Image =
				Properties.Resources.hide_512;

			if (string.Compare(passwordTextBox.Text, "رمز عبور") != 0)
			{
				passwordTextBox.UseSystemPasswordChar = false;
			}
		}
		#endregion /PasswordShowPicturBox1_MouseDown

		#region PasswordShowPicturBox1_MouseUp
		private void PasswordShowPicturBox1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			passwordShowPicturBox1.Image =
			Properties.Resources.show_512;
			if (string.Compare(passwordTextBox.Text, "رمز عبور") != 0)
			{
				passwordTextBox.UseSystemPasswordChar = true;
			}
		}
		#endregion /PasswordShowPicturBox1_MouseUp

		#region PasswordTextBox_TextChanged
		private void PasswordTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(passwordTextBox.Text) || string.Compare(passwordTextBox.Text, "رمز عبور") == 0)
			{
				Password = string.Empty;
			}
			else
				Password = passwordTextBox.Text;
		}
		#endregion /PasswordTextBox_TextChanged
		//-----
		#endregion /PasswrodTextBox

		#region PasswordConfirmTextBox
		//-----
		#region PasswordConfirmTextBox_Enter
		private void PasswordConfirmTextBox_Enter(object sender, System.EventArgs e)
		{
			passwordConfirmTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();

			panel6.BackColor =
				Infrastructure.Utility.LimeColor();

			passwordConfirmPicturBox.Image =
			Properties.Resources.password_confirm_512_lim;

			passwordConfirmTextBox.RightToLeft =
				System.Windows.Forms.RightToLeft.No;

			passwordConfirmTextBox.TextAlign =
				System.Windows.Forms.HorizontalAlignment.Left;

			Infrastructure.Utility.EnglishLanguage();

			if (string.Compare(passwordConfirmTextBox.Text, "تایید رمز عبور") == 0)
			{
				passwordConfirmTextBox.Clear();
				passwordConfirmTextBox.UseSystemPasswordChar = true;
			}
		}
		#endregion /PasswordConfirmTextBox_Enter

		#region PasswordConfirmTextBox_Leave
		private void PasswordConfirmTextBox_Leave(object sender, System.EventArgs e)
		{
			passwordConfirmTextBox.ForeColor =
				Infrastructure.Utility.DimGrayColor();

			panel6.BackColor =
				Infrastructure.Utility.DimGrayColor();

			passwordConfirmPicturBox.Image =
				Properties.Resources.password_confirm_512;

			if (string.IsNullOrWhiteSpace(passwordConfirmTextBox.Text))
			{
				passwordConfirmTextBox.Text =
					"تایید رمز عبور";

				passwordConfirmTextBox.UseSystemPasswordChar = false;

				passwordConfirmTextBox.RightToLeft =
					System.Windows.Forms.RightToLeft.Yes;

				passwordConfirmTextBox.TextAlign =
					System.Windows.Forms.HorizontalAlignment.Left;
			}
		}
		#endregion /PasswordConfirmTextBox_Leave

		#region PasswordShowPicturBox2_MouseDown
		private void PasswordShowPicturBox2_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			passwordShowPicturBox2.Image =
				Properties.Resources.hide_512;

			if (string.Compare(passwordConfirmTextBox.Text, "تایید رمز عبور") != 0)
			{
				passwordConfirmTextBox.UseSystemPasswordChar = false;
			}
		}
		#endregion /PasswordShowPicturBox2_MouseDown

		#region PasswordShowPicturBox2_MouseUp
		private void PasswordShowPicturBox2_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			passwordShowPicturBox2.Image =
				Properties.Resources.show_512;
			if (string.Compare(passwordConfirmTextBox.Text, "تایید رمز عبور") != 0)
			{
				passwordConfirmTextBox.UseSystemPasswordChar = true;
			}
		}
		#endregion /PasswordShowPicturBox2_MouseUp

		#region PasswordConfirmTextBox_TextChanged
		private void PasswordConfirmTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(passwordConfirmTextBox.Text) || string.Compare(passwordConfirmTextBox.Text, "تایید رمز عبور") == 0)
			{
				PasswordConfirm = string.Empty;
			}
			else
				PasswordConfirm = passwordConfirmTextBox.Text;
		}
		#endregion /PasswordConfirmTextBox_TextChanged
		//-----
		#endregion /passwordConfirmTextBox

		#region UserImagePicturBox_MouseDoubleClick
		private void UserImagePicturBox_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			System.Windows.Forms.OpenFileDialog openFileDialog =
				new System.Windows.Forms.OpenFileDialog
				{
					Filter = "JPG (*.jpg)|*.jpg|" +
							"PNG (*.png)|*.png|" +
							"BMP (*.bmp)|*.bmp",
					Title = "Load user picture ",
				};

			if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				UserImage = openFileDialog.FileName;
				userImagePicturBox.Image =
				System.Drawing.Image.FromFile(UserImage);
			}
			if (UserImage != string.Empty)
			{
				deleteImagePicturBox.Visible = true;
			}
			else
			{
				deleteImagePicturBox.Visible = false;
			}
		}
		#endregion /UserImagePicturBox_MouseDoubleClick

		#region DeleteImagePicturBox_Click
		private void DeleteImagePicturBox_Click(object sender, System.EventArgs e)
		{
			UserImage = string.Empty;
			userImagePicturBox.Image =
				Properties.Resources.userpicture_512;
			deleteImagePicturBox.Visible = false;
		}
		#endregion /DeleteImagePicturBox_Click

		#region SaveButton_Click
		private void SaveButton_Click(object sender, System.EventArgs e)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				string errorMessage = string.Empty;

				if (string.IsNullOrEmpty(Username))
				{
					errorMessage =
						"وارد کردن شناسه کاربری الزامی است!";
				}
				if (string.IsNullOrEmpty(Email))
				{
					if (errorMessage != string.Empty)
					{
						errorMessage +=
							System.Environment.NewLine + "       ";
					}

					errorMessage +=
						"وارد کردن ایمیل الزامی است!";
				}
				if (string.IsNullOrEmpty(Password))
				{
					if (errorMessage != string.Empty)
					{
						errorMessage +=
							System.Environment.NewLine + "       ";
					}
					errorMessage +=
							"وارد کردن رمز عبور الزامی است!";
				}
				if (string.IsNullOrEmpty(PasswordConfirm))
				{
					if (errorMessage != string.Empty)
					{
						errorMessage +=
							System.Environment.NewLine + "       ";
					}
					errorMessage +=
							"وارد کردن تایید رمز عبور الزامی است!";
				}
				if (errorMessage != string.Empty)
				{
					if (string.IsNullOrEmpty(Username))
					{
						usernameTextBox.Focus();
					}
					else if (string.IsNullOrEmpty(Email))
					{
						emailTextBox.Focus();
					}
					else if (string.IsNullOrEmpty(Password))
					{
						passwordTextBox.Focus();
					}
					else if (string.IsNullOrEmpty(PasswordConfirm))
					{
						passwordConfirmTextBox.Focus();
					}
					ErrorMessage(errorMessage);
					return;
				}
				if (Infrastructure.Utility.PasswordSet(password: Password, passwordConfirm: PasswordConfirm) == false)
				{
					errorMessage =
						"عدم تطابق رمز!";
					ErrorMessage(errorMessage);
					passwordTextBox.Focus();
					return;
				}
				else
				{
					errorMessageLabel.Visible = false;
				}

				if (string.IsNullOrEmpty(UserImage))
				{
					UserImage =
						"D:\\Visual Studio Project\\C# Project\\Resturant\\Resturant\\Resources\\default_picture_512.png";
				}

				System.Windows.Forms.DialogResult dialogResult;

				dialogResult = Mbb.Windows.Forms.MessageBox.QuestionMessage
					(text: "کاربر مورد نظر ثبت گردد؟",
					captiopn: "ثبت کاربری",
					buttons: System.Windows.Forms.MessageBoxButtons.YesNo,
					defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button2,
					icon: System.Windows.Forms.MessageBoxIcon.Question,
					options: System.Windows.Forms.MessageBoxOptions.RightAlign |
					 System.Windows.Forms.MessageBoxOptions.RtlReading);

				if (dialogResult == System.Windows.Forms.DialogResult.Yes)
				{
					Models.User user =
								dataBaseContext.Users
								.Where(current => string.Compare(current.Username, Username) == 0)
								.FirstOrDefault();

					if (user != null)
					{
						errorMessage =
							$"شناسه مورد نظر {Username} در سیستم موجود می باشد! لطفااز شناسه دیگری استفاده نمایید. ";

						Mbb.Windows.Forms.MessageBox.InformationMessage(errorMessage);
						return;
					}
					else
					{
						RegisterDate = Infrastructure.Utility.PersianCalendar(System.DateTime.Now);

						RegisterTime = Infrastructure.Utility.ShowTime();

						FullName = string.Concat(Infrastructure.Utility.TextFixed(FirstName) + " " + Infrastructure.Utility.TextFixed(LastName));
						user =
							new Models.User
							{
								IsActive = true,
								IsAdministrator = false,
								FullName = FullName,
								Username = Username,
								Email = Email,
								Password = Password,
								UserPicture = System.IO.File.ReadAllBytes(UserImage),
								RegistrationTime = RegisterTime + " " + RegisterDate,
							};
						dataBaseContext.Users.Add(user);
						dataBaseContext.SaveChanges();
					}
				}
				else
				{
					return;
				}

				string message =
					$"شناسه کاربری با نام {Username} ثبت گردید.";

				Infrastructure.Utility.WindowsNotification
					(message: message,
					caption: Infrastructure.PopupNotificationForm.Caption.موفقیت,
					picture: UserImage);

				AllClear();
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

		#region ResetButton_Click
		private void ResetButton_Click(object sender, System.EventArgs e)
		{
			AllClear();
		}
		#endregion /ResetButton_Click

		#region LoginButton_Click
		private void LoginButton_Click(object sender, System.EventArgs e)
		{
			this.Hide();
			Program.LoginShow();
		}
		#endregion /LoginButton_Click

		#region Panel_MouseDown
		private void Panel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

		#endregion /Panel_MouseDown

		#region Timer1_Tick
		private void Timer1_Tick(object sender, System.EventArgs e)
		{
			if (string.IsNullOrEmpty(FirstName) ||
				string.IsNullOrEmpty(LastName) ||
				string.IsNullOrEmpty(Username) ||
				string.IsNullOrEmpty(Email) ||
				string.IsNullOrEmpty(Password) ||
				string.IsNullOrEmpty(PasswordConfirm) ||
				string.IsNullOrEmpty(UserImage))
			{
				resetButton.Enabled = false;
			}
			else
				resetButton.Enabled = true;
		}
		#endregion /Timer1_Tick
		//-----End of the codes.

		#region Methods
		//*****
		#region ErrorMessage
		public void ErrorMessage(string message)
		{
			errorMessageLabel.Visible = true;
			errorMessageLabel.Text = "       " + message;
		}
		#endregion /ErrorMessage

		#region AllClear
		private void AllClear()
		{
			UserImage = string.Empty;
			userImagePicturBox.Image =
				Properties.Resources.userpicture_512;

			FirstName = string.Empty;
			firstNameTextBox.Text = "نام";
			firstNameTextBox.TextAlign =
				System.Windows.Forms.HorizontalAlignment.Left;

			LastName = string.Empty;
			lastNameTextBox.Text =
				"نام خانوادگی";
			lastNameTextBox.TextAlign =
				System.Windows.Forms.HorizontalAlignment.Left;

			Username = string.Empty;
			usernameTextBox.Text =
				"شناسه کاربری";
			usernameTextBox.Font =
				Infrastructure.Utility.IranSansFont(usernameTextBox.Font.Size);

			usernameTextBox.TextAlign =
				System.Windows.Forms.HorizontalAlignment.Right;

			tickPicturBox1.Visible = false;

			Email = string.Empty;
			emailTextBox.Text =
				"پست الکترونیکی";

			emailTextBox.Font =
				Infrastructure.Utility.IranSansFont(emailTextBox.Font.Size);

			emailTextBox.TextAlign =
				System.Windows.Forms.HorizontalAlignment.Right;
			tickPicturBox2.Visible = false;

			Password = string.Empty;
			passwordTextBox.Text = "رمز عبور";
			passwordTextBox.TextAlign =
				System.Windows.Forms.HorizontalAlignment.Right;
			passwordTextBox.UseSystemPasswordChar = false;

			passwordConfirmTextBox.Text = "تایید رمز عبور";
			passwordConfirmTextBox.TextAlign =
				System.Windows.Forms.HorizontalAlignment.Right;
			passwordConfirmTextBox.UseSystemPasswordChar = false;
		}
		#endregion /AllClear
		//*****
		#endregion /Methods
	}
}
