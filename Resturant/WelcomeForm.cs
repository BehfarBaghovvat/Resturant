﻿namespace Resturant
{
	public partial class WelcomeForm : Infrastructure.BaseForm
	{
		public WelcomeForm()
		{
			InitializeComponent();
		}

		#region Properties
		int number;
		System.Random random =
			new System.Random(0);
		#endregion /Properties

		//-----Beginning of the cods.
		#region WelcomeForm_Load
		private void WelcomeForm_Load(object sender, System.EventArgs e)
		{
			Initialize();
			bunifuCircleProgressbar.Value = 0;
			bunifuCircleProgressbar.MaxValue = 100;

			this.Opacity = 0.0;
			timer1.Start();
		}
		#endregion /WelcomeForm_Load

		#region Timer1_Tick
		private void Timer1_Tick(object sender, System.EventArgs e)
		{
			if (this.Opacity < 0.85) this.Opacity += 0.05;

			bunifuCircleProgressbar.Value += NumberLoadRandom();

			if (bunifuCircleProgressbar.Value >= 100)
			{
				timer1.Stop();
				timer2.Start();
			}
		}
		#endregion /Timer1_Tick

		#region Timer2_Tick
		private void Timer2_Tick(object sender, System.EventArgs e)
		{
			this.Opacity -= 0.05;

			if (this.Opacity == 0)
			{
				timer2.Stop();
				this.Close();
				Program.MainShow();
			}
		}
		#endregion /Timer2_Tick
		//-----End of the codes.

		#region Methods
		//-----
		#region Initialize
		public void Initialize()
		{
			string name =
				Program.AuthenticatedUser.FullName;

			if (string.IsNullOrEmpty(name))
			{
				name =
					Program.AuthenticatedUser.Username;
			}
			fullNameLabel.Text = name;

			var byteImage =
				Program.AuthenticatedUser.UserPicture;

			using (System.IO.MemoryStream ms = new System.IO.MemoryStream(byteImage))
			{
				userImagePicturBox.BackgroundImage =
					System.Drawing.Image.FromStream(ms);
			}
		}
		#endregion /Initialize

		#region NumberLoadRandom
		public int NumberLoadRandom()
		{
			for (int i = 1; i <= 100; i++)
			{
				number = random.Next(6);
			}
			return number;
		}
		#endregion /NumberLoadRandom
		//-----
		#endregion /Methods
	}
}
