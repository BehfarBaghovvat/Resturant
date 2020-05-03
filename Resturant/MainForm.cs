using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace Resturant
{
	public partial class MainForm : Infrastructure.BaseForm
	{
		public MainForm()
		{
			InitializeComponent();
		}

		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

		#region ChefFoodForm
		private ChefMenu.ChefFoodForm chefFoodForm = null;
		public ChefMenu.ChefFoodForm ChefFoodForm
		{
			get
			{
				if (chefFoodForm == null)
				{
					chefFoodForm =
						new ChefMenu.ChefFoodForm();
				}
				return chefFoodForm;
			}
		}
		#endregion /ChefFoodForm

		#region SpecialMenuForm
		private ChefMenu.SpecialMenuForm specialMenuForm = null;

		public ChefMenu.SpecialMenuForm SpecialMenuForm
		{
			get 
			{
				if (specialMenuForm == null )
				{
					specialMenuForm =
						new ChefMenu.SpecialMenuForm();
				}
				return specialMenuForm;
			}
		}
		#endregion /SpecialMenuForm

		#region MenuListForm
		private static Foods.MenuListForm menuListForm;

		public static Foods.MenuListForm MenuListForm
		{
			get
			{
				if (menuListForm == null || menuListForm.IsDisposed == true)
				{
					menuListForm =
						new Foods.MenuListForm();
				}
				return menuListForm;
			}
		}
		#endregion /MenuListForm

		#region TakingOrdersForm
		private static TakingOrdersForm takingOrdersForm;

		public static TakingOrdersForm TakingOrdersForm
		{
			get
			{
				if (takingOrdersForm == null || takingOrdersForm.IsDisposed == true)
				{
					takingOrdersForm =
						new TakingOrdersForm();
				}
				return takingOrdersForm;
			}
		}

		#endregion /TakingOrdersForm

		#region ClientsListForm
		private static Client.ClientsListForm clientsListForm;

		public static Client.ClientsListForm ClientsListForm
		{
			get
			{
				if (clientsListForm == null || clientsListForm.IsDisposed == true)
				{
					clientsListForm =
						new Client.ClientsListForm();
				}
				return clientsListForm;
			}
		}
		#endregion /ClientsListForm

		#region ClientAddForm
		private static Client.ClientAddForm clientAddForm;

		public static Client.ClientAddForm ClientAddForm
		{
			get 
			{
				if (clientAddForm == null || clientAddForm.IsDisposed == true)
				{
					clientAddForm =
						new Client.ClientAddForm();
				}
				return clientAddForm;
			}
		}
		#endregion /ClientAddForm

		#region ClientsEditForm
		private static Client.ClientsEditForm clientsEditForm;

		public static Client.ClientsEditForm ClientsEditForm
		{
			get 
			{
				if (clientsEditForm == null || clientsEditForm.IsDisposed == true)
				{
					clientsEditForm =
						new Client.ClientsEditForm();
				}
				return clientsEditForm;
			}
		}

		#endregion /ClientsEditForm

		#region SettingForm
		private Setting.SettingForm settingForm;

		public Setting.SettingForm SettingForm
		{
			get 
			{
				if (settingForm == null || settingForm.IsDisposed ==true)
				{
					settingForm =
						new Setting.SettingForm();
				}
				return settingForm;
			}
		}
		#endregion /SettingForm

		#region Properties
		public string LogOutTime { get; set; }
		public int LX { get; set; }
		public int LY { get; set; }

		#endregion /Properties

		//-----Beginning of the code.

		#region MainForm
		//-----
		#region MainForm_FormClosed
		private void MainForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
		{
			Infrastructure.Utility.EnglishLanguage();
			SaveLogOutTime(Program.AutenticatLogHistory);
		}
		#endregion /MainForm_FormClosed

		#region MainForm_Load
		private void MainForm_Load(object sender, System.EventArgs e)
		{
			secondLabel.Text = System.DateTime.Now.Second.ToString().PadLeft(2, '0');
			minuteLabel.Text = System.DateTime.Now.Minute.ToString().PadLeft(2, '0');
			hourLabel.Text = System.DateTime.Now.Hour.ToString().PadLeft(2, '0');
			clockTimer.Start();

			solarDateLabel.Text = Infrastructure.Utility.PersianCalendar();
			adDateLabel.Text = Infrastructure.Utility.ADCalendar();
		}
		#endregion /MainForm_Load

		#region MainForm_MouseDown
		private void MainForm_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		#endregion /MainForm_MouseDown 
		//-----
		#endregion /MainForm

		#region CloseButton_Click
		private void CloseButton_Click(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.Exit();
		}
		#endregion /CloseButton_Click

		#region MaximumButton_Click
		private void MaximumButton_Click(object sender, System.EventArgs e)
		{
			LX = Location.X;
			LY = Location.Y;
			this.Size = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Size;
			this.Location = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Location;

			maximumButton.Visible = false;
			restorButton.Visible = true;
		}

		#endregion /MaximumButton_Click

		#region RestorButton_Click
		private void RestorButton_Click(object sender, System.EventArgs e)
		{
			this.Size = new System.Drawing.Size(1200, 700);
			this.Location = new System.Drawing.Point(LX, LY);
			restorButton.Visible = false;
			maximumButton.Visible = true;
		}
		#endregion /RestorButton_Click

		#region MinimizButton_Click
		private void MinimizButton_Click(object sender, System.EventArgs e)
		{
			this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
		}
		#endregion /MinimizButton_Click

		#region LimitButton_Click
		private void LimitButton_Click(object sender, System.EventArgs e)
		{
			if (panel.Width == 220)
			{
				panel.Width = 75;
				//logOutButton.Location = new System.Drawing.Point(180, 605);
				//shutDownButton.Location = new System.Drawing.Point(100, 605);
				return;
			}

			if (panel.Width == 75)
			{
				panel.Width = 220;
				//logOutButton.Location = new System.Drawing.Point(135, 655);
				//shutDownButton.Location = new System.Drawing.Point(165, 650);
				return;
			}
		}
		#endregion /LimitButton_Click

		#region HomeButton_Click
		private void HomeButton_Click(object sender, EventArgs e)
		{
			focusPanel.Height = homeButton.Height;
			focusPanel.Top = homeButton.Top;
			this.panel4.Controls.Clear();
		}
		#endregion /HomeButton_Click

		#region ChefMenuButton_Click
		private void ChefMenuButton_Click(object sender, EventArgs e)
		{
			focusPanel.Height = chefMenuButton.Height;
			focusPanel.Top = chefMenuButton.Top;

			ChefMenu.ChefFoodForm chefFoodForm =
				new ChefMenu.ChefFoodForm();

			chefFoodForm.Dock = System.Windows.Forms.DockStyle.Fill;
			chefFoodForm.TopLevel = false;
			chefFoodForm.TopMost = true;

			this.panel4.Controls.Clear();
			this.panel4.Controls.Add(chefFoodForm);
			chefFoodForm.Show();
		}
		#endregion /ChefMenuButton_Click

		#region MaineMenuButton_Click
		private void MenuListButton_Click(object sender, EventArgs e)
		{
			focusPanel.Height = menuListButton.Height;
			focusPanel.Top = menuListButton.Top;

			MenuListForm.Dock = System.Windows.Forms.DockStyle.Fill;
			MenuListForm.TopLevel = false;
			MenuListForm.TopMost = true;

			this.panel4.Controls.Clear();
			this.panel4.Controls.Add(MenuListForm);
			MenuListForm.Show();
		}
		#endregion /MaineMenuButton_Click

		#region OrderButton_Click
		private void OrderButton_Click(object sender, EventArgs e)
		{
			focusPanel.Height = orderButton.Height;
			focusPanel.Top = orderButton.Top;

			TakingOrdersForm.Dock = System.Windows.Forms.DockStyle.Fill;
			TakingOrdersForm.TopLevel = false;
			TakingOrdersForm.TopMost = true;

			this.panel4.Controls.Clear();
			this.panel4.Controls.Add(TakingOrdersForm);
			TakingOrdersForm.Show();
			

		}
		#endregion /OrderButton_Click

		#region DeliveryButton_Click
		private void DeliveryButton_Click(object sender, EventArgs e)
		{
			focusPanel.Height = deliveryButton.Height;
			focusPanel.Top = deliveryButton.Top;
		}
		#endregion /DeliveryButton_Click

		#region CommodityBuyButton_Click
		private void CommodityBuyButton_Click(object sender, EventArgs e)
		{
			focusPanel.Height = commodityBuyButton.Height;
			focusPanel.Top = commodityBuyButton.Top;
		}
		#endregion /CommodityBuyButton_Click

		#region ClientButton_Click
		private void ClientButton_Click(object sender, EventArgs e)
		{
			focusPanel.Height = clientButton.Height;
			focusPanel.Top = clientButton.Top;

			ClientsListForm.Dock = System.Windows.Forms.DockStyle.Fill;
			ClientsListForm.TopLevel = false;
			ClientsListForm.TopMost = true;

			this.panel4.Controls.Clear();
			this.panel4.Controls.Add(ClientsListForm);
			ClientsListForm.Show();

			ClientAddForm.FormClosed += ShowForm;
			ClientsEditForm.FormClosed += ShowForm;

		}
		#endregion /ClientButton_Click

		#region SettingButton_Click
		private void SettingButton_Click(object sender, EventArgs e)
		{
			focusPanel.Height = settingButton.Height;
			focusPanel.Top = settingButton.Top;

			SettingForm.Dock = System.Windows.Forms.DockStyle.Fill;
			SettingForm.TopLevel = false;
			SettingForm.TopMost = true;

			this.panel4.Controls.Clear();
			this.panel4.Controls.Add(SettingForm);
			SettingForm.Show();
		}
		#endregion /SettingButton_Click

		#region ShutDownButton_Click
		private void ShutDownButton_Click(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.Exit();
		}
		#endregion /ShutDownButton_Click

		#region LogOutButton_Click
		private void LogOutButton_Click(object sender, System.EventArgs e)
		{
			if (System.Windows.Forms.MessageBox.Show(
				text: "از حساب کاربری خارج میشوید؟",
				caption: "خروج از حساب",
				buttons: System.Windows.Forms.MessageBoxButtons.YesNo,
				defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button2,
				icon: System.Windows.Forms.MessageBoxIcon.Warning,
				options: System.Windows.Forms.MessageBoxOptions.RightAlign |
				 System.Windows.Forms.MessageBoxOptions.RtlReading) == System.Windows.Forms.DialogResult.Yes)
			{
				
				this.Close();
			}
		}
		#endregion /LogOutButton_Click

		#region Panels
		//-----
		#region Panel_MouseDown
		private void Panel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		#endregion /Panel_MouseDown

		#region Panel1_MouseDown
		private void Panel1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		#endregion /Panel1_MouseDown

		#region Panel2_MouseDown
		private void Panel2_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		#endregion /Panel2_MouseDown

		#region Panel3_MouseDown
		private void Panel3_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{

		}
		#endregion /Panel3_MouseDown

		#region Panel4_MouseDown
		private void Panel4_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		#endregion /Panel4_MouseDown
		//-----
		#endregion /Panels

		#region ClockTimer_Tick
		private void ClockTimer_Tick(object sender, System.EventArgs e)
		{
			secondLabel.Text = System.DateTime.Now.Second.ToString().PadLeft(2, '0');

			if (string.Compare(secondLabel.Text, "00") == 0)
			{
				minuteLabel.Text = System.DateTime.Now.Minute.ToString().PadLeft(2, '0');
			}

			if (string.Compare(minuteLabel.Text, "00") == 0)
			{
				hourLabel.Text = System.DateTime.Now.Hour.ToString().PadLeft(2, '0');
			}
		}
		#endregion /ClockTimer_Tick
		//-----End of the code.

		#region Methods
		//-----
		#region WndProc
		//protected override void WndProc(ref System.Windows.Forms.Message message)
		//{
		//	const int coordinateWFP = 0x84; //Location of the lower right part of the form
		//	const int left = 16;
		//	const int right = 17;

		//	if (message.Msg == coordinateWFP)
		//	{
		//		int x = (int)(message.LParam.ToInt64() & 0xFFFF);
		//		int y = (int)(message.LParam.ToInt64() & 0xFFFFF0000) >> 16;

		//		System.Drawing.Point coordinateArea = PointToClient(new System.Drawing.Point(x, y));
		//		System.Drawing.Size sizeAreaForm = ClientSize;

		//		if (coordinateArea.X >= sizeAreaForm.Width - 16 && coordinateArea.Y >= sizeAreaForm.Height - 16)
		//		{
		//			message.Result = (IntPtr)(IsMirrored ? left : right);

		//			return;

		//		}
		//	}
		//	base.WndProc(ref message);
		//}
		#endregion /WndProc

		#region Initialize
		public void Initialize()
		{
			if (Program.AuthenticatedUser.IsAdministrator == false)
			{
				settingButton.Enabled = false;
			}
			

			string name =
				Program.AuthenticatedUser.FullName;

			if (string.IsNullOrEmpty(name))
			{
				name =
					Program.AuthenticatedUser.Username;
			}

			fullNameLabel.Text = name;
			emailLabel.Text = Program.AuthenticatedUser.Email;
			entryTimeLabel.Text = Program.AutenticatLogHistory.LoginTime;

			var byteImage = Program.AuthenticatedUser.UserPicture;
			using (System.IO.MemoryStream ms = new System.IO.MemoryStream(byteImage))
			{
				userImagePicturBox.BackgroundImage = System.Drawing.Image.FromStream(ms);
			}
		}
		#endregion /Initialize

		#region ShowForm
		public void ShowForm(object sender, System.Windows.Forms.FormClosedEventArgs e)
		{
			this.Show();
		}


		#endregion /ShowForm

		#region SaveLogOutTime
		private void SaveLogOutTime(Models.LogHistory log)
		{

			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				Models.LogHistory logHistory =
					dataBaseContext.LogHistories
					.Where(curren => string.Compare(curren.Username, log.Username) == 0)
					.OrderByDescending(current => current.LoginTime)
					.SingleOrDefault(current => current.Id == log.Id);

				if (logHistory != null)
				{
					LogOutTime = $"{Infrastructure.Utility.PersianCalendar(System.DateTime.Now).ToString()} " +
						$"{Infrastructure.Utility.ShowTime().ToString()}";

					logHistory.LogoutTime = LogOutTime;
				}

				dataBaseContext.SaveChanges();
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
		#endregion /SaveLogOutTime
		//-----
		#endregion /Methods

		

		
	}
}
