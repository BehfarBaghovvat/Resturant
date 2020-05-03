using System.Linq;
using System.Runtime.InteropServices;

namespace Client
{
	public partial class ClientAddForm : Infrastructure.BaseForm
	{
		public ClientAddForm()
		{
			InitializeComponent();
		}

		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

		#region Properties
		//-----
		public int SubscriptionCode { get; set; }
		public string ClientName { get; set; }
		public string ClientTel { get; set; }
		public string ClientAddress { get; set; }
		public string OrderDate { get; set; }
		public string Picture { get; set; }
		//-----
		#endregion /Properties

		//-----Begining of the codes.
		#region ClientAddForm
		//-----
		#region ClentAddForm_Load
		private void ClentAddForm_Load(object sender, System.EventArgs e)
		{
			OrderDate = "0000/00/00 00:00:00";
		}
		#endregion /ClentAddForm_Load

		#region ClientAddForm_MouseDown
		private void ClientAddForm_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		#endregion /ClientAddForm_MouseDown
		//-----
		#endregion /ClientAddForm

		#region CloseButton_Click
		private void CloseButton_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
		#endregion /CloseButton_Click

		#region MinimizeButton_Click
		private void MinimizeButton_Click(object sender, System.EventArgs e)
		{
			this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
		}
		#endregion /MinimizeButton_Click

		#region NewCodeButton_Click
		private void NewCodeButton_Click(object sender, System.EventArgs e)
		{
			this.Size = new System.Drawing.Size(490, 225);
			errorMessageLabel.Visible = false;
			int number = RandomNumbers();


			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.Client client =
					dataBaseContext.Clients
					.Where(current => string.Compare(current.SubscriptionCode.ToString(), number.ToString()) == 0)
					.FirstOrDefault();

				if (client != null)
				{
					checkPicturBox.Visible = true;
					checkPicturBox.Image = Resturant.Properties.Resources.Tik_False;
					return;
				}
				else
				{
					checkPicturBox.Visible = true;
					checkPicturBox.Image = Resturant.Properties.Resources.Tik_True;
					SubscriptionCode = number;
					subscriptionCodeLabel.Text = SubscriptionCode.ToString();
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
		#endregion /NewCodeButton_Click

		#region ClientNameTextBox
		//-----
		#region ClientNameTextBox_Enter
		private void ClientNameTextBox_Enter(object sender, System.EventArgs e)
		{
			this.Size = new System.Drawing.Size(490, 225);
			errorMessageLabel.Visible = false;

			Infrastructure.Utility.PersianLanguage();
			clientNameTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			panel1.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(clientNameTextBox.Text, "نام مشترک") == 0)
			{
				clientNameTextBox.Clear();
			}
		}
		#endregion /ClientNameTextBox_Enter

		#region ClientNameTextBox_KeyPress
		private void ClientNameTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianTyping(e);
		}
		#endregion /ClientNameTextBox_KeyPress

		#region ClientNameTextBox_Leave
		private void ClientNameTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.Compare(clientNameTextBox.Text, "نام مشترک") == 0 || string.IsNullOrWhiteSpace(clientNameTextBox.Text))
			{
				clientNameTextBox.ForeColor =
				Infrastructure.Utility.DimGrayColor();
				panel1.BackColor =
					Infrastructure.Utility.WhiteColor();
				ClientName = string.Empty;
				clientNameTextBox.Text = "نام مشترک";
			}
			else
			{
				clientNameTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();
				panel1.BackColor =
					Infrastructure.Utility.WhiteColor();
				ClientName = clientNameTextBox.Text;
			}
		}
		#endregion /ClientNameTextBox_Leave
		//-----
		#endregion /ClientNameTextBox

		#region ClientTelTextBox
		//-----
		#region ClientTelTextBox_Enter
		private void ClientTelTextBox_Enter(object sender, System.EventArgs e)
		{
			this.Size = new System.Drawing.Size(490, 225);
			errorMessageLabel.Visible = false;

			clientTelTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			panel2.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(clientTelTextBox.Text, "تلفن مشترک") == 0)
			{
				clientTelTextBox.Clear();
			}
		}
		#endregion /ClientTelTextBox_Enter

		#region ClientTelTextBox_KeyPress
		private void ClientTelTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}
		#endregion /ClientTelTextBox_KeyPress

		#region ClientTelTextBox_Leave
		private void ClientTelTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(clientTelTextBox.Text) || string.Compare(clientTelTextBox.Text, "تلفن مشترک") == 0)
			{
				clientTelTextBox.ForeColor =
					Infrastructure.Utility.DimGrayColor();
				panel2.BackColor =
					Infrastructure.Utility.WhiteColor();
				ClientTel = string.Empty;
				clientTelTextBox.Text = "تلفن مشترک";
				return;
			}
			else
			{
				clientTelTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				panel2.BackColor =
					Infrastructure.Utility.WhiteColor();

				if (clientTelTextBox.Text.Contains('-') == true)
				{
					ClientTel = clientTelTextBox.Text;
					return;
				}
				else
				{
					clientTelTextBox.Text = clientTelTextBox.Text.Insert(4, "-");
					ClientTel = clientTelTextBox.Text;
					return;
				}
			}
		}
		#endregion /ClientTelTextBox_Leave

		#region ClientTelTextBox_Validated
		private void ClientTelTextBox_Validated(object sender, System.EventArgs e)
		{
			if (string.IsNullOrEmpty(ClientTel))
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

					Models.Client client =
						dataBaseContext.Clients
						.Where(current => string.Compare(current.ClientTel, ClientTel) == 0)
						.FirstOrDefault();
					if (client != null)
					{
						Infrastructure.Utility.WindowsNotification
							(message: $"تلفن {ClientTel} در سیستم موجود میباشد!",
							caption: Infrastructure.PopupNotificationForm.Caption.اخطار);

						ClientTel = string.Empty;
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
		}
		#endregion /ClientTelTextBox_Validated
		//-----
		#endregion /ClientTelTextBox

		#region ClientAddressTextBox
		//-----
		#region ClientAddressTextBox_Enter
		private void ClientAddressTextBox_Enter(object sender, System.EventArgs e)
		{
			this.Size = new System.Drawing.Size(490, 225);
			errorMessageLabel.Visible = false;

			Infrastructure.Utility.PersianLanguage();
			clientAddressTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			panel3.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(clientAddressTextBox.Text, "آدرس مشترک") == 0)
			{
				clientAddressTextBox.Clear();
			}
		}
		#endregion /ClientAddressTextBox_Enter

		#region ClientAddressTextBox_KeyPress
		private void ClientAddressTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianAndNumberTyping(e);
		}
		#endregion /ClientAddressTextBox_KeyPress

		#region ClientAddressTextBox_Leave
		private void ClientAddressTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.Compare(clientAddressTextBox.Text, "آدرس مشترک") == 0 || string.IsNullOrWhiteSpace(clientAddressTextBox.Text))
			{
				clientAddressTextBox.ForeColor =
				Infrastructure.Utility.DimGrayColor();
				panel3.BackColor =
					Infrastructure.Utility.WhiteColor();
				ClientAddress = string.Empty;
				clientAddressTextBox.Text = "آدرس مشترک";
			}
			else
			{
				clientAddressTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();
				panel3.BackColor =
					Infrastructure.Utility.WhiteColor();
				ClientAddress = clientAddressTextBox.Text;
			}
		}
		#endregion /ClientAddressTextBox_Leave

		#region ClientAddressTextBox_Validated
		private void ClientAddressTextBox_Validated(object sender, System.EventArgs e)
		{
			if (string.IsNullOrEmpty(ClientAddress))
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

					Models.Client client =
						dataBaseContext.Clients
						.Where(current => string.Compare(current.ClientAddress, ClientAddress) == 0)
						.FirstOrDefault();
					if (client != null)
					{
						Infrastructure.Utility.WindowsNotification
							(message: $"آدرس وارد شده در سیستم موجود میباشد!",
							caption: Infrastructure.PopupNotificationForm.Caption.اخطار);
						ClientAddress = string.Empty;
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
		}
		#endregion /ClientAddressTextBox_Validated
		//-----
		#endregion /ClientAddressTextBox

		#region SaveButton_Click
		private void SaveButton_Click(object sender, System.EventArgs e)
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				#region Validation
				//===============
				int count = 0;
				string errorMessage = string.Empty;

				if (string.IsNullOrEmpty(SubscriptionCode.ToString()) || SubscriptionCode == 0)
				{
					errorMessage =
						"انتخاب کد اشتراک الزامی است!";
					count++;
				}

				if (string.IsNullOrEmpty(ClientName))
				{
					if (errorMessage != string.Empty)
					{
						errorMessage +=
							System.Environment.NewLine + "       ";
					}
					errorMessage += "فیلد نام مشترک تکمیل گردد! ";
					count++;
				}

				if (string.IsNullOrEmpty(ClientTel))
				{
					if (errorMessage != string.Empty)
					{
						errorMessage +=
							System.Environment.NewLine + "       ";
					}
					errorMessage += "فیلد تلفن مشترک تکمیل گردد! ";
					count++;
				}

				if (string.IsNullOrEmpty(ClientAddress))
				{
					if (errorMessage != string.Empty)
					{
						errorMessage +=
							System.Environment.NewLine + "       ";
					}
					errorMessage += "فیلد آدرس مشترک تکمیل گردد! ";
					count++;
				}

				if (errorMessage != string.Empty)
				{
					if (count == 1)
					{
						this.Size = new System.Drawing.Size(490, 240);
						ErrorMessage(errorMessage);
					}
					else if (count == 2)
					{
						this.Size = new System.Drawing.Size(490, 260);
						ErrorMessage(errorMessage);
					}
					else if (count == 3)
					{
						this.Size = new System.Drawing.Size(490, 280);
						ErrorMessage(errorMessage);
					}
					else if (count == 4)
					{
						this.Size = new System.Drawing.Size(490, 300);
						ErrorMessage(errorMessage);
					}
					return;
				}
				//===================
				#endregion /Validation

				System.Windows.Forms.DialogResult dialogResult;

				dialogResult = Mbb.Windows.Forms.MessageBox.QuestionMessage
					(text: "مشترک مورد نظر ثبت گردد؟",
					captiopn: "ثبت مشتری",
					buttons: System.Windows.Forms.MessageBoxButtons.YesNo,
					defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button2,
					icon: System.Windows.Forms.MessageBoxIcon.Question,
					options: System.Windows.Forms.MessageBoxOptions.RightAlign |
					 System.Windows.Forms.MessageBoxOptions.RtlReading);

				if (dialogResult == System.Windows.Forms.DialogResult.Yes)
				{
					Picture = string.Empty;
					Models.Client client =
						dataBaseContext.Clients
						.Where(current => string.Compare(current.ClientAddress, ClientAddress) == 0)
						.FirstOrDefault();

					if (client != null)
					{
						newCodeButton.Focus();
						return;
					}
					else
					{
						client =
							new Models.Client
							{
								SubscriptionCode = SubscriptionCode,
								ClientName = ClientName,
								ClientTel = ClientTel,
								ClientAddress = ClientAddress,
								OrderDate = OrderDate,
							};
						dataBaseContext.Clients.Add(client);
						dataBaseContext.SaveChanges();
					}
				}
				else
				{
					return;
				}

				string message =
							$"مشترک با کد اشتراک {SubscriptionCode} ثبت گردید.";

				Infrastructure.Utility.WindowsNotification
					(message: message,
					caption: Infrastructure.PopupNotificationForm.Caption.موفقیت);

				if (Resturant.MainForm.ClientsListForm != null)
				{
					Resturant.MainForm.ClientsListForm.ClientLoader();
				}

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

		#region Panels
		#region panel200_MouseDown
		private void panel200_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		#endregion /panel200_MouseDown

		#region panel100_MouseDown
		private void panel100_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		#endregion /panel100_MouseDown 
		#endregion /Panels
		//-----End of codes.

		#region Methods
		//-----
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
			SubscriptionCode = 0;
			subscriptionCodeLabel.Text = "کد اشتراک";
			checkPicturBox.Visible = false;

			ClientName = string.Empty;
			clientNameTextBox.Text = "نام مشترک";

			ClientTel = string.Empty;
			clientTelTextBox.Text = "تلفن مشترک";

			ClientAddress = string.Empty;
			clientAddressTextBox.Text = "آدرس مشترک";

			errorMessageLabel.Visible = false;
		}
		#endregion /AllClear

		#region RandomNumber
		public int RandomNumbers()
		{
			int number;

			System.Random generator =
				new System.Random();
			number = generator.Next(minValue: 1000, maxValue: 9999);

			return number;
		}
		#endregion RandomNumber
		//-----
		#endregion /Methods
	}
}
