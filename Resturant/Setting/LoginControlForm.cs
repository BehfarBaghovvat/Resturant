using System.Linq;

namespace Setting
{
	public partial class LoginControlForm : Infrastructure.BaseForm
	{
		public LoginControlForm()
		{
			InitializeComponent();
		}

		#region Properties
		public string Username { get; set; }
		public string Login { get; set; }
		public string Logout { get; set; }
		#endregion /Properties

		//-----Beginning of the code.
		#region LoginControlForm_Load
		private void LoginControlForm_Load(object sender, System.EventArgs e)
		{
			LoginControlLoaded();
		}
		#endregion /LoginControlForm_Load

		#region SearchTextBox
		//-----
		#region SearchTextBox_Enter
		private void SearchTextBox_Enter(object sender, System.EventArgs e)
		{
			searchTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			panel.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(searchTextBox.Text, "جستجو...") == 0)
			{
				searchTextBox.Clear();
			}
		}
		#endregion /SearchTextBox_Enter

		#region SearchTextBox_KeyPress
		private void SearchTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			//if (usernameRadioButton.Checked == true)
			//{
			//	Infrastructure.Utility.EnglishAndNumberTyping(e);
			//	return;
			//}
			//if (loginRadioButton.Checked == true)
			//{
			//	Infrastructure.Utility.PersianTyping(e);
			//	return;
			//}
			//if (logoutRadioButton.Checked == true)
			//{
			//	Infrastructure.Utility.PersianTyping(e);
			//	return;
			//}
		}

		#endregion /SearchTextBox_KeyPress

		#region SearchTextBox_Leave
		private void SearchTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(searchTextBox.Text) || string.Compare(searchTextBox.Text, "جستجو...") == 0)
			{
				searchTextBox.ForeColor =
				Infrastructure.Utility.DimGrayColor();
				panel.BackColor =
					Infrastructure.Utility.WhiteColor();

				Username = string.Empty;
				Login = string.Empty;
				Logout = string.Empty;
				searchTextBox.Text = "جستجو...";
			}
			else
			{
				searchTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();
				panel.BackColor =
					Infrastructure.Utility.WhiteColor();
			}
		}

		#endregion /SearchTextBox_Leave

		#region SearchTextBox_TextChanged
		private void SearchTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.Compare(searchTextBox.Text,"جستجو...")==0)
			{
				return;
			}
			if (usernameRadioButton.Checked == true)
			{
				Username = searchTextBox.Text;

				UserSearch(username: Username);
				return;
			}

			if (loginRadioButton.Checked == true)
			{
				Login = searchTextBox.Text;

				LoginSearch(login: Login);
				return;
			}

			if (logoutRadioButton.Checked == true)
			{
				Logout = searchTextBox.Text;

				LogoutSearch(logout: Logout);
				return;
			}
		}

		#endregion /SearchTextBox_TextChanged 
		//-----
		#endregion /SearchTextBox

		#region DeleteTableButton_Click
		private void DeleteTableButton_Click(object sender, System.EventArgs e)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.LogHistory> logHistories = null;

				System.Windows.Forms.DialogResult dialogResult = Mbb.Windows.Forms.MessageBox.QuestionMessage(
					text: "آیا گزارش پاک گردد؟",
					captiopn: "پاک کردن گزارش",
					buttons: System.Windows.Forms.MessageBoxButtons.YesNo,
					icon: System.Windows.Forms.MessageBoxIcon.Question,
					defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button2,
					options: System.Windows.Forms.MessageBoxOptions.RightAlign |
					System.Windows.Forms.MessageBoxOptions.RtlReading);

				if (dialogResult == System.Windows.Forms.DialogResult.Yes)
				{
					var rows = from o in dataBaseContext.LogHistories select o;

					foreach (var row in rows)
					{
						dataBaseContext.LogHistories.Remove(row);
					}

					dataBaseContext.SaveChanges();
					LoginControlLoaded();
					return;
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
		#endregion /DeleteTableButton_Click

		//-----End of the code.

		#region Method
		//-----
		#region LoginControlLoaded
		public void LoginControlLoaded()
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.LogHistory> logHistories = null;

				logHistories =
					dataBaseContext.LogHistories
					.OrderByDescending(current => current.LoginTime)
					.ToList();

				loginDataGridView.DataSource = logHistories;

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
		#endregion /LoginControlLoaded

		#region UserSearch
		private void UserSearch(string username)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.LogHistory> logHistories = null;

				if (string.IsNullOrEmpty(username))
				{
					logHistories =
						dataBaseContext.LogHistories
						.OrderBy(current => current.Username)
						.ToList();
				}

				else
				{
					logHistories =
						dataBaseContext.LogHistories
						.Where(current => current.Username.Contains(username))
						.OrderBy(current => current.Username)
						.ToList();
				}

				loginDataGridView.DataSource = logHistories;
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
		#endregion /UserSearch

		#region LoginSearch
		private void LoginSearch (string login)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.LogHistory> logHistories = null;

				if (string.IsNullOrEmpty(login))
				{
					logHistories =
						dataBaseContext.LogHistories
						.OrderBy(current => current.LoginTime)
						.ToList();
				}

				else
				{
					logHistories =
						dataBaseContext.LogHistories
						.Where(current => current.Username.Contains(login))
						.OrderBy(current => current.LoginTime)
						.ToList();
				}

				loginDataGridView.DataSource = logHistories;
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
		#endregion /LoginSearch

		#region LogoutSearch
		private	void LogoutSearch(string logout)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.LogHistory> logHistories = null;

				if (string.IsNullOrEmpty(logout))
				{
					logHistories =
						dataBaseContext.LogHistories
						.OrderBy(current => current.LogoutTime)
						.ToList();
				}

				else
				{
					logHistories =
						dataBaseContext.LogHistories
						.Where(current => current.Username.Contains(logout))
						.OrderBy(current => current.LogoutTime)
						.ToList();
				}

				loginDataGridView.DataSource = logHistories;
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




		#endregion /LogoutSearch
		//-----
		#endregion /Method

		private void UsernameRadioButton_Click(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.EnglishLanguage();
		}

		private void LoginRadioButton_Click(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
		}

		private void LogoutRadioButton_Click(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
		}
	}
}
