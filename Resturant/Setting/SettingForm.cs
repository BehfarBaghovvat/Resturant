namespace Setting
{
	public partial class SettingForm : Infrastructure.BaseForm
	{
		public SettingForm()
		{
			InitializeComponent();
		}

		#region UserControlForm
		private UserControlForm userControlForm;

		public UserControlForm UserControlForm
		{
			get 
			{
				if (userControlForm == null || userControlForm.IsDisposed == true)
				{
					userControlForm =
						new UserControlForm();
				}
				return userControlForm;
			}
		}
		#endregion /UserControlForm

		#region LogForm
		private LogForm logForm;

		public LogForm LogForm
		{
			get 
			{
				if (logForm == null || logForm.IsDisposed == true)
				{
					logForm =
						new LogForm();
				}
				return logForm;
			}
		}
		#endregion /LogForm

		private void SettingForm_Load(object sender, System.EventArgs e)
		{

		}

		private void UserControlButton_Click(object sender, System.EventArgs e)
		{
			focusPanel.Location = new System.Drawing.Point(x: 151, y: 160);

			UserControlForm.Dock = System.Windows.Forms.DockStyle.Fill;
			UserControlForm.TopLevel = false;
			UserControlForm.TopMost = true;

			this.homePanel.Controls.Clear();
			this.homePanel.Controls.Add(UserControlForm);
			UserControlForm.Show();
		}

		private void LogButton_Click(object sender, System.EventArgs e)
		{
			focusPanel.Location = new System.Drawing.Point(x: 151, y: 210);

			LogForm.Dock = System.Windows.Forms.DockStyle.Fill;
			LogForm.TopLevel = false;
			LogForm.TopMost = true;

			this.homePanel.Controls.Clear();
			this.homePanel.Controls.Add(LogForm);
			LogForm.Show();
		}

		private void panel_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{

		}
	}
}
