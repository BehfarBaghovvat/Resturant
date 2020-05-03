using System.Linq;

namespace Setting
{
	public partial class UserControlForm : Infrastructure.BaseForm
	{
		public UserControlForm()
		{
			InitializeComponent();
		}

		#region Properties

		#endregion /Properties

		//-----Beginning of the code.
		private void UserControlForm_Load(object sender, System.EventArgs e)
		{
			UserLoader();

			userDataGridView.CellMouseDoubleClick += UserDataGridView_CellMouseDoubleClick;
		}


		//-----End of the code.

		#region Methods
		//-----
		#region UserLoader
		public void UserLoader()
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();
				System.Collections.Generic.List<Models.User> users = null;

				users =
					dataBaseContext.Users
					.OrderBy(current => current.FullName)
					.ToList();

				userDataGridView.DataSource = users;

				//userDataGridView.AutoResizeColumns
				//	(autoSizeColumnsMode: System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells);
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
		#endregion /UserLoader

		#region UserSearch
		private void UserSearch(string username)
		{
			if (string.Compare(username, "admin") == 0 || string.IsNullOrEmpty(username))
			{
				return;
			}
			else
			{
				Models.DataBaseContext dataBaseContext = null;
				try
				{
					dataBaseContext =
						new Models.DataBaseContext();

					Models.User user =
						dataBaseContext.Users
						.Where(current => string.Compare(current.Username, username) == 0)
						.FirstOrDefault();

					if (user == null)
					{
						Infrastructure.Utility.WindowsNotification
							(message: "کاربر مورد نظر موجود نیست!", caption: Infrastructure.PopupNotificationForm.Caption.اخطار);
						return;
					}

					else
					{
						fullNameLabel.Text = user.FullName;
						usernameLabel.Text = user.Username;

						administratorCheckBox.Checked = user.IsAdministrator;
						activeCheckBox.Checked = user.IsActive;

						var byteImage = user.UserPicture;
						using (System.IO.MemoryStream ms = new System.IO.MemoryStream(byteImage))
						{
							userPicturBox.BackgroundImage = System.Drawing.Image.FromStream(ms);
						}
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
		}
		#endregion /UserSearch
		//-----
		#endregion / Methods

		#region UpdateButton_Click
		private void UpdateButton_Click(object sender, System.EventArgs e)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				if (string.Compare(usernameLabel.Text, "شناسه کاربری") == 0)
				{
					return;
				}

				Models.User user =
				dataBaseContext.Users
				.Where(current => string.Compare(current.Username, usernameLabel.Text) == 0)
				.FirstOrDefault();

				if (user == null)
				{
					Infrastructure.Utility.WindowsNotification
						(message: "کاربر مورد نظر حذف گردیده!", caption: Infrastructure.PopupNotificationForm.Caption.اخطار);
					return;
				}

				user.IsAdministrator = administratorCheckBox.Checked;
				user.IsActive = activeCheckBox.Checked;

				dataBaseContext.SaveChanges();

				Infrastructure.Utility.WindowsNotification
					(message: $" کاربر {usernameLabel.Text} به روز گردید", caption: Infrastructure.PopupNotificationForm.Caption.اطلاع);

				UserLoader();
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
		#endregion /UpdateButton_Click

		#region UserDataGridView_CellMouseDoubleClick
		private void UserDataGridView_CellMouseDoubleClick(object sender, System.Windows.Forms.DataGridViewCellMouseEventArgs e)
		{
			if (e.RowIndex == -1)
			{
				return;
			}
			if (e.ColumnIndex == -1)
			{
				return;
			}

			string username = userDataGridView.CurrentRow.Cells[2].Value.ToString();

			UserSearch(username: username);
		}
		#endregion /UserDataGridView_CellMouseDoubleClick
	}
}
