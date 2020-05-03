namespace Resturant
{
	partial class WelcomeForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
			this.panel1 = new Mbb.Windows.Forms.Panel();
			this.label1 = new Mbb.Windows.Forms.Label();
			this.picturBox2 = new Mbb.Windows.Forms.PicturBox();
			this.picturBox1 = new Mbb.Windows.Forms.PicturBox();
			this.fullNameLabel = new Mbb.Windows.Forms.Label();
			this.label2 = new Mbb.Windows.Forms.Label();
			this.userImagePicturBox = new Mbb.Windows.Forms.PicturBox();
			this.bunifuCircleProgressbar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picturBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picturBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userImagePicturBox)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.picturBox2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(900, 110);
			this.panel1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("IRANSans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(608, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(202, 34);
			this.label1.TabIndex = 1;
			this.label1.Text = "سامانه مدیریت رستوران";
			// 
			// picturBox2
			// 
			this.picturBox2.Image = ((System.Drawing.Image)(resources.GetObject("picturBox2.Image")));
			this.picturBox2.Location = new System.Drawing.Point(813, 18);
			this.picturBox2.Name = "picturBox2";
			this.picturBox2.Size = new System.Drawing.Size(75, 75);
			this.picturBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picturBox2.TabIndex = 0;
			this.picturBox2.TabStop = false;
			// 
			// picturBox1
			// 
			this.picturBox1.Dock = System.Windows.Forms.DockStyle.Left;
			this.picturBox1.Image = ((System.Drawing.Image)(resources.GetObject("picturBox1.Image")));
			this.picturBox1.Location = new System.Drawing.Point(0, 110);
			this.picturBox1.Name = "picturBox1";
			this.picturBox1.Size = new System.Drawing.Size(283, 390);
			this.picturBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picturBox1.TabIndex = 2;
			this.picturBox1.TabStop = false;
			// 
			// fullNameLabel
			// 
			this.fullNameLabel.Font = new System.Drawing.Font("IRANSans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.fullNameLabel.ForeColor = System.Drawing.Color.Gold;
			this.fullNameLabel.Location = new System.Drawing.Point(295, 208);
			this.fullNameLabel.Name = "fullNameLabel";
			this.fullNameLabel.Size = new System.Drawing.Size(199, 31);
			this.fullNameLabel.TabIndex = 5;
			this.fullNameLabel.Text = "نام کاربر";
			this.fullNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("IRANSans", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(299, 128);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(191, 58);
			this.label2.TabIndex = 4;
			this.label2.Text = "خوش آمدید";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// userImagePicturBox
			// 
			this.userImagePicturBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.userImagePicturBox.Image = ((System.Drawing.Image)(resources.GetObject("userImagePicturBox.Image")));
			this.userImagePicturBox.Location = new System.Drawing.Point(725, 128);
			this.userImagePicturBox.Name = "userImagePicturBox";
			this.userImagePicturBox.Size = new System.Drawing.Size(150, 150);
			this.userImagePicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.userImagePicturBox.TabIndex = 8;
			this.userImagePicturBox.TabStop = false;
			// 
			// bunifuCircleProgressbar
			// 
			this.bunifuCircleProgressbar.animated = false;
			this.bunifuCircleProgressbar.animationIterval = 10;
			this.bunifuCircleProgressbar.animationSpeed = 300;
			this.bunifuCircleProgressbar.BackColor = System.Drawing.Color.Transparent;
			this.bunifuCircleProgressbar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar.BackgroundImage")));
			this.bunifuCircleProgressbar.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCircleProgressbar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.bunifuCircleProgressbar.LabelVisible = true;
			this.bunifuCircleProgressbar.LineProgressThickness = 8;
			this.bunifuCircleProgressbar.LineThickness = 5;
			this.bunifuCircleProgressbar.Location = new System.Drawing.Point(806, 407);
			this.bunifuCircleProgressbar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
			this.bunifuCircleProgressbar.MaxValue = 100;
			this.bunifuCircleProgressbar.Name = "bunifuCircleProgressbar";
			this.bunifuCircleProgressbar.ProgressBackColor = System.Drawing.Color.Gray;
			this.bunifuCircleProgressbar.ProgressColor = System.Drawing.Color.Lime;
			this.bunifuCircleProgressbar.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.bunifuCircleProgressbar.Size = new System.Drawing.Size(75, 75);
			this.bunifuCircleProgressbar.TabIndex = 9;
			this.bunifuCircleProgressbar.Value = 0;
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
			// 
			// timer2
			// 
			this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 25;
			this.bunifuElipse1.TargetControl = this;
			// 
			// bunifuElipse2
			// 
			this.bunifuElipse2.ElipseRadius = 150;
			this.bunifuElipse2.TargetControl = this.userImagePicturBox;
			// 
			// WelcomeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(900, 500);
			this.Controls.Add(this.bunifuCircleProgressbar);
			this.Controls.Add(this.userImagePicturBox);
			this.Controls.Add(this.fullNameLabel);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.picturBox1);
			this.Controls.Add(this.panel1);
			this.Name = "WelcomeForm";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Text = "WelcomeForm";
			this.Load += new System.EventHandler(this.WelcomeForm_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picturBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picturBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.userImagePicturBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Mbb.Windows.Forms.Panel panel1;
		private Mbb.Windows.Forms.Label label1;
		private Mbb.Windows.Forms.PicturBox picturBox2;
		private Mbb.Windows.Forms.PicturBox picturBox1;
		private Mbb.Windows.Forms.Label fullNameLabel;
		private Mbb.Windows.Forms.Label label2;
		private Mbb.Windows.Forms.PicturBox userImagePicturBox;
		private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Timer timer2;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
	}
}