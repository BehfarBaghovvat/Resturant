namespace Setting
{
	public partial class LogForm : Infrastructure.BaseForm
	{
		public LogForm()
		{
			InitializeComponent();
		}

		#region LoginControlForm
		private LoginControlForm loginControlForm;
		public LoginControlForm LoginControlForm
		{
			get 
			{
				if (loginControlForm == null || loginControlForm.IsDisposed ==true)
				{
					loginControlForm =
						new LoginControlForm();
				}
				return loginControlForm;
			}
		}

		#endregion /LoginControlForm

		#region ActivityControlForm
		private ActivityControlForm activityControlForm;
		public ActivityControlForm ActivityControlForm
		{
			get
			{
				if (activityControlForm == null || activityControlForm.IsDisposed == true)
				{
					activityControlForm =
						new ActivityControlForm();
				}
				return activityControlForm;
			}
		}
		#endregion /ActivityControlForm

		private void loginControlButton_Click(object sender, System.EventArgs e)
		{
			LoginControlForm.Dock = System.Windows.Forms.DockStyle.Fill;
			LoginControlForm.TopLevel = false;
			LoginControlForm.TopMost = true;

			this.homePanel.Controls.Clear();
			this.homePanel.Controls.Add(LoginControlForm);
			LoginControlForm.Show();
		}

		private void activityControlButton_Click(object sender, System.EventArgs e)
		{
			ActivityControlForm.Dock = System.Windows.Forms.DockStyle.Fill;
			ActivityControlForm.TopLevel = false;
			ActivityControlForm.TopMost = true;

			this.homePanel.Controls.Clear();
			this.homePanel.Controls.Add(ActivityControlForm);
			ActivityControlForm.Show();
		}
	}
}
