using System.Linq;
using System.Runtime.InteropServices;

namespace Resturant
{
	public partial class LoginForm : Infrastructure.BaseForm
	{
		public LoginForm()
		{
			InitializeComponent();
		}

		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

		#region Properties
		//-----
		public string Username { get; set; }
		public string Password { get; set; }
		public string LoginTime { get; set; }
		public string LogOutTime { get; set; }
		//-----
		#endregion /Properties

		//-----Beginning of the codes.

		#region LoginForm
		//-----
		#region LoginForm_Load
		private void LoginForm_Load(object sender, System.EventArgs e)
		{
			loginLabel.Focus();
		}
		#endregion /LoginForm_Load

		#region LoginForm_MouseMove
		private void LoginForm_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

		#endregion /LoginForm_MouseMove
		//-----
		#endregion /LoginForm

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

		#region UsernameTextBox
		//-----
		#region UsernameTextBox_Enter
		private void UsernameTextBox_Enter(object sender, System.EventArgs e)
		{
			usernameTextBox.ForeColor = Infrastructure.Utility.LimeColor();
			usernameTextBox.Font = Infrastructure.Utility.CenturyGothicFont(usernameTextBox.Font.Size);
			panel1.BackColor = Infrastructure.Utility.LimeColor();

			Infrastructure.Utility.EnglishLanguage();

			if (string.Compare(usernameTextBox.Text, "Username") == 0)
			{
				usernameTextBox.Clear();
			}
		}
		#endregion /UsernameTextBox_Enter
		
		#region UsernameTextBox_KeyPress
		private void UsernameTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.EnglishAndNumberTyping(e);
		}
		#endregion /UsernameTextBox_KeyPress

		#region UsernameTextBox_Leave
		private void UsernameTextBox_Leave(object sender, System.EventArgs e)
		{
			usernameTextBox.ForeColor = Infrastructure.Utility.DimGrayColor();
			panel1.BackColor = Infrastructure.Utility.DimGrayColor();

			if (string.IsNullOrWhiteSpace(usernameTextBox.Text))
			{
				usernameTextBox.Text = "Username";
			}
		}
		#endregion /UsernameTextBox_Leave

		#region UsernameTextBox_TextChanged
		private void UsernameTextBox_TextChanged(object sender, System.EventArgs e)
		{
			Username = usernameTextBox.Text;

			if (string.Compare(usernameTextBox.Text, "Username", ignoreCase: true) == 0 || string.IsNullOrWhiteSpace(usernameTextBox.Text))
			{
				return;
			}
		}
		#endregion /UsernameTextBox_TextChanged
		//-----
		#endregion /UsernameTextBox

		#region PasswordTextBox
		//-----
		#region PasswordTextBox_Enter
		private void PasswordTextBox_Enter(object sender, System.EventArgs e)
		{
			passwordTextBox.ForeColor = Infrastructure.Utility.LimeColor();
			passwordTextBox.Font = Infrastructure.Utility.CenturyGothicFont(passwordTextBox.Font.Size);
			panel2.BackColor = Infrastructure.Utility.LimeColor();

			Infrastructure.Utility.EnglishLanguage();

			if (string.Compare(passwordTextBox.Text, "Password") == 0)
			{
				passwordTextBox.Clear();
				passwordTextBox.UseSystemPasswordChar = true;
			}
		}
		#endregion /PasswordTextBox_Enter

		#region PasswordTextBox_Leave
		private void PasswordTextBox_Leave(object sender, System.EventArgs e)
		{
			passwordTextBox.ForeColor = Infrastructure.Utility.DimGrayColor();
			panel2.BackColor = Infrastructure.Utility.DimGrayColor();

			if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
			{
				passwordTextBox.Text = "Password";
				passwordTextBox.UseSystemPasswordChar = false;
			}
		}
		#endregion /PasswordTextBox_Leave

		#region PasswordTextBox_TextChanged
		private void PasswordTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.Compare(Username, "Password", ignoreCase: true) == 0 || string.IsNullOrWhiteSpace(Password))
			{
				return;
			}
			else
			{
				Password = passwordTextBox.Text;
			}
		}
		#endregion /PasswordTextBox_TextChanged
		//-----
		#endregion /PasswordTextBox

		#region ShowPasswordPicturBox
		#region ShowPasswordPicturBox_MouseDown
		private void ShowPasswordPicturBox_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			showPasswordPicturBox.Image = Properties.Resources.hide_512;

			if (string.Compare(passwordTextBox.Text,"Password")!=0)
			{
				passwordTextBox.UseSystemPasswordChar = false;
			}
		}
		#endregion /ShowPasswordPicturBox_MouseDown

		#region ShowPasswordPicturBox_MouseUp
		private void ShowPasswordPicturBox_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			showPasswordPicturBox.Image = Properties.Resources.show_512;

			if (string.Compare(passwordTextBox.Text, "Password")!=0)
			{
				passwordTextBox.UseSystemPasswordChar = true;
			}
			
		}
		#endregion /ShowPasswordPicturBox_MouseUp
		#endregion /ShowPasswordPicturBox

		#region LoginButton_Click
		private void LoginButton_Click(object sender, System.EventArgs e)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				string errorMessage = string.Empty;

				if (string.IsNullOrWhiteSpace(usernameTextBox.Text) ||
					string.Compare(usernameTextBox.Text, "Username") == 0)
				{
					errorMessage =
						"شناسه کاربری را وارد نمایید!";
				}

				if (string.IsNullOrWhiteSpace(passwordTextBox.Text) ||
					string.Compare(passwordTextBox.Text, "Password") == 0)
				{
					if (errorMessage != string.Empty)
					{
						errorMessage +=
							System.Environment.NewLine + "       ";
					}

					errorMessage +=
						"رمز عبور را وارد نمایید!";
				}

				if (errorMessage != string.Empty)
				{
					if (string.IsNullOrWhiteSpace(usernameTextBox.Text) ||
					string.Compare(usernameTextBox.Text, "Username") == 0)
					{
						usernameTextBox.Focus();
					}

					else if (string.IsNullOrWhiteSpace(passwordTextBox.Text) ||
					string.Compare(passwordTextBox.Text, "Password") == 0)
					{
						passwordTextBox.Focus();
					}
					ErrorMessage(errorMessage);
					return;
				}

				Models.User foundUser =
					dataBaseContext.Users
					.Where(current => string.Compare(current.Username, usernameTextBox.Text, true) == 0)
					.FirstOrDefault();

				if (foundUser == null)
				{
					errorMessage =
						"شناسه کاربری و/یا رمز عبور صحیح نمی باشد!";

					ErrorMessage(errorMessage);
					usernameTextBox.Focus();
					return;
				}

				if (string.Compare(foundUser.Password, passwordTextBox.Text, false) != 0)
				{
					errorMessage =
						"شناسه کاربری و/یا رمز عبور صحیح نمی باشد!";
					ErrorMessage(errorMessage);
					passwordTextBox.Focus();
					return;
				}
				this.Hide();
				Program.AuthenticatedUser = foundUser;
				SaveLoginHistory(foundUser);

				WelcomeForm welcomeForm =
					new WelcomeForm();

				welcomeForm.ShowDialog();

				Program.MainForm.FormClosed += LogOut;

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
		#endregion /LoginButton_Click

		#region CreateAccountLinkLabel_LinkClicked
		private void CreateAccountLinkLabel_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			this.Hide();
			Program.RegistrShow();
		}
		#endregion /CreateAccountLinkLabel_LinkClicked

		#region Panel_MouseDown
		private void Panel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		#endregion /Panel_MouseDown

		//-----End of the codes.

		#region Methods
		//-----
		#region Initialize
		public void Initialize()
		{
			Infrastructure.Utility.EnglishLanguage();
			Username = string.Empty;
			usernameTextBox.Text = "Username";
			Password = string.Empty;
			passwordTextBox.Text = "Password";
			passwordTextBox.UseSystemPasswordChar = false;
		}
		#endregion /Initialize

		#region ErrorMessage
		private void ErrorMessage(string message)
		{
			errorMessageLabel.Text = "        " + message;
			errorMessageLabel.Visible = true;
		}


		#endregion /ErrorMessage

		#region SaveLoginHistory
		//private void SaveLoginHistory(Models.User user)
		//{
		//	LoginTime = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now).ToString()} " +
		//		$"{Infrastructure.Utility.ShowTime().ToString()}";

		//	LogOutTime = $"Null";

		//	string fullName;
		//	Models.DataBaseContext dataBaseContext = null;
		//	try
		//	{
		//		if (string.IsNullOrWhiteSpace(user.FullName))
		//		{
		//			fullName = "Null";
		//		}
		//		else
		//		{
		//			fullName = user.FullName;
		//		}

		//		dataBaseContext =
		//			new Models.DataBaseContext();
		//		Models.LogHistory logHistory =
		//			dataBaseContext.LogHistories
		//			.OrderBy(current => current.LoginTime)
		//			.FirstOrDefault();

		//		logHistory =
		//			new Models.LogHistory
		//			{
		//				FullName = fullName,
		//				Username = user.Username,
		//				UserPicture = user.UserPicture,
		//				LoginTime = LoginTime,
		//				LogoutTime = LogOutTime,
		//			};

		//		dataBaseContext.LogHistories.Add(logHistory);
		//		dataBaseContext.SaveChanges();

		//		Program.AutenticatLogHistory = logHistory;
		//	}
		//	catch (System.Exception ex)
		//	{
		//		Infrastructure.Utility.PopupNotification(ex);
		//	}
		//	if (dataBaseContext != null)
		//	{
		//		dataBaseContext.Dispose();
		//		dataBaseContext = null;
		//	}
		//}
		#endregion /SaveLoginHistory

		#region GetUserByUsername
		private Models.User GetUserByUsername(string username)
		{
			username = username.ToUpper();

			Models.DataBaseContext databaseContext = null;

			databaseContext =
				new Models.DataBaseContext();
			Models.User users =
				databaseContext.Users
				.Where(current => string.Compare(current.Username, username, true) == 0)
				.FirstOrDefault();

			if (users != null)
			{
				return users;
			}
			else
			{
				return null;
			}
		}
		#endregion /GetUserByUsername

		#region LogOut
		public void LogOut(object sender, System.Windows.Forms.FormClosedEventArgs e)
		{
			Program.AuthenticatedUser = null;
			usernameTextBox.Text = "Username";

			passwordTextBox.Text = "Password";
			passwordTextBox.UseSystemPasswordChar = false;

			errorMessageLabel.Visible = false;
			this.Show();
		}
		#endregion /LogOut

		#region SaveLoginHistory
		private void SaveLoginHistory(Models.User user)
		{
			LoginTime = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now)} " +
				$"{Infrastructure.Utility.ShowTime().ToString()}";

			LogOutTime = $"Null";

			string fullName;
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				if (string.IsNullOrWhiteSpace(user.FullName))
				{
					fullName = "Null";
				}
				else
				{
					fullName = user.FullName;
				}

				dataBaseContext =
					new Models.DataBaseContext();
				Models.LogHistory logHistory =
					dataBaseContext.LogHistories
					.OrderBy(current => current.LoginTime)
					.FirstOrDefault();

				logHistory =
					new Models.LogHistory
					{
						FullName = fullName,
						Username = user.Username,
						UserPicture = user.UserPicture,
						LoginTime = LoginTime,
						LogoutTime = LogOutTime,
					};

				dataBaseContext.LogHistories.Add(logHistory);
				dataBaseContext.SaveChanges();

				Program.AutenticatLogHistory = logHistory;
			}
			catch (System.Exception ex)
			{
				Infrastructure.Utility.PopupNotification(ex);
			}
			if (dataBaseContext != null)
			{
				dataBaseContext.Dispose();
				dataBaseContext = null;
			}
		}
		#endregion /SaveLoginHistory
		//-----
		#endregion /Methods


	}
}
