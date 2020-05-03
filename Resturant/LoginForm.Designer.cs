namespace Resturant
{
	partial class LoginForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			this.createAccountLinkLabel = new Mbb.Windows.Forms.LinkLabel();
			this.loginButton = new Mbb.Windows.Forms.Button();
			this.panel2 = new Mbb.Windows.Forms.Panel();
			this.passwordTextBox = new Mbb.Windows.Forms.TextBox();
			this.panel1 = new Mbb.Windows.Forms.Panel();
			this.usernameTextBox = new Mbb.Windows.Forms.TextBox();
			this.loginLabel = new Mbb.Windows.Forms.Label();
			this.panel = new Mbb.Windows.Forms.Panel();
			this.picturBox1 = new Mbb.Windows.Forms.PicturBox();
			this.label3 = new Mbb.Windows.Forms.Label();
			this.label2 = new Mbb.Windows.Forms.Label();
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.errorMessageLabel = new Mbb.Windows.Forms.Label();
			this.showPasswordPicturBox = new Mbb.Windows.Forms.PicturBox();
			this.minimizeButton = new Mbb.Windows.Forms.Button();
			this.closeButton = new Mbb.Windows.Forms.Button();
			this.panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picturBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.showPasswordPicturBox)).BeginInit();
			this.SuspendLayout();
			// 
			// createAccountLinkLabel
			// 
			this.createAccountLinkLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.createAccountLinkLabel.AutoSize = true;
			this.createAccountLinkLabel.BackColor = System.Drawing.Color.Transparent;
			this.createAccountLinkLabel.ForeColor = System.Drawing.Color.White;
			this.createAccountLinkLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.createAccountLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.createAccountLinkLabel.LinkColor = System.Drawing.Color.WhiteSmoke;
			this.createAccountLinkLabel.Location = new System.Drawing.Point(464, 263);
			this.createAccountLinkLabel.Name = "createAccountLinkLabel";
			this.createAccountLinkLabel.Size = new System.Drawing.Size(57, 19);
			this.createAccountLinkLabel.TabIndex = 11;
			this.createAccountLinkLabel.TabStop = true;
			this.createAccountLinkLabel.Text = "این قسمت";
			this.createAccountLinkLabel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.createAccountLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreateAccountLinkLabel_LinkClicked);
			// 
			// loginButton
			// 
			this.loginButton.BackColor = System.Drawing.Color.DimGray;
			this.loginButton.FlatAppearance.BorderSize = 0;
			this.loginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
			this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.loginButton.Font = new System.Drawing.Font("IRANSans", 12F);
			this.loginButton.ForeColor = System.Drawing.Color.White;
			this.loginButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.loginButton.Location = new System.Drawing.Point(297, 211);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(306, 37);
			this.loginButton.TabIndex = 9;
			this.loginButton.Text = "ورود";
			this.loginButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.loginButton.UseVisualStyleBackColor = false;
			this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.DimGray;
			this.panel2.ForeColor = System.Drawing.Color.DimGray;
			this.panel2.Location = new System.Drawing.Point(297, 143);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(306, 1);
			this.panel2.TabIndex = 7;
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.passwordTextBox.Font = new System.Drawing.Font("Century Gothic", 10F);
			this.passwordTextBox.ForeColor = System.Drawing.Color.DimGray;
			this.passwordTextBox.Location = new System.Drawing.Point(327, 120);
			this.passwordTextBox.MaxLength = 40;
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.passwordTextBox.Size = new System.Drawing.Size(275, 17);
			this.passwordTextBox.TabIndex = 6;
			this.passwordTextBox.Text = "Password";
			this.passwordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
			this.passwordTextBox.Enter += new System.EventHandler(this.PasswordTextBox_Enter);
			this.passwordTextBox.Leave += new System.EventHandler(this.PasswordTextBox_Leave);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DimGray;
			this.panel1.ForeColor = System.Drawing.Color.DimGray;
			this.panel1.Location = new System.Drawing.Point(297, 93);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(306, 1);
			this.panel1.TabIndex = 5;
			// 
			// usernameTextBox
			// 
			this.usernameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.usernameTextBox.Font = new System.Drawing.Font("Century Gothic", 10F);
			this.usernameTextBox.ForeColor = System.Drawing.Color.DimGray;
			this.usernameTextBox.Location = new System.Drawing.Point(297, 70);
			this.usernameTextBox.MaxLength = 25;
			this.usernameTextBox.Name = "usernameTextBox";
			this.usernameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.usernameTextBox.Size = new System.Drawing.Size(306, 17);
			this.usernameTextBox.TabIndex = 4;
			this.usernameTextBox.Text = "Username";
			this.usernameTextBox.TextChanged += new System.EventHandler(this.UsernameTextBox_TextChanged);
			this.usernameTextBox.Enter += new System.EventHandler(this.UsernameTextBox_Enter);
			this.usernameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UsernameTextBox_KeyPress);
			this.usernameTextBox.Leave += new System.EventHandler(this.UsernameTextBox_Leave);
			// 
			// loginLabel
			// 
			this.loginLabel.AutoSize = true;
			this.loginLabel.BackColor = System.Drawing.Color.Transparent;
			this.loginLabel.Font = new System.Drawing.Font("IRANSans", 18F);
			this.loginLabel.ForeColor = System.Drawing.Color.DarkGray;
			this.loginLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.loginLabel.Location = new System.Drawing.Point(373, 9);
			this.loginLabel.Name = "loginLabel";
			this.loginLabel.Size = new System.Drawing.Size(157, 41);
			this.loginLabel.TabIndex = 1;
			this.loginLabel.Text = "ورود به حساب";
			// 
			// panel
			// 
			this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
			this.panel.Controls.Add(this.picturBox1);
			this.panel.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel.Location = new System.Drawing.Point(0, 0);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(201, 300);
			this.panel.TabIndex = 0;
			this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
			// 
			// picturBox1
			// 
			this.picturBox1.BackColor = System.Drawing.Color.Transparent;
			this.picturBox1.Image = ((System.Drawing.Image)(resources.GetObject("picturBox1.Image")));
			this.picturBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.picturBox1.Location = new System.Drawing.Point(50, 100);
			this.picturBox1.Name = "picturBox1";
			this.picturBox1.Size = new System.Drawing.Size(100, 100);
			this.picturBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picturBox1.TabIndex = 0;
			this.picturBox1.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.Color.DimGray;
			this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label3.Location = new System.Drawing.Point(516, 263);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 19);
			this.label3.TabIndex = 12;
			this.label3.Text = "وارد شوید!";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.DimGray;
			this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label2.Location = new System.Drawing.Point(315, 263);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(152, 19);
			this.label2.TabIndex = 10;
			this.label2.Text = "برای ایجاد حساب کاربری جدید از";
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 25;
			this.bunifuElipse1.TargetControl = this;
			// 
			// errorMessageLabel
			// 
			this.errorMessageLabel.Font = new System.Drawing.Font("IRANSans", 7F);
			this.errorMessageLabel.ForeColor = System.Drawing.Color.DarkGray;
			this.errorMessageLabel.Image = ((System.Drawing.Image)(resources.GetObject("errorMessageLabel.Image")));
			this.errorMessageLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.errorMessageLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.errorMessageLabel.Location = new System.Drawing.Point(294, 147);
			this.errorMessageLabel.Name = "errorMessageLabel";
			this.errorMessageLabel.Size = new System.Drawing.Size(309, 61);
			this.errorMessageLabel.TabIndex = 8;
			this.errorMessageLabel.Text = "پیام خطا";
			this.errorMessageLabel.Visible = false;
			// 
			// showPasswordPicturBox
			// 
			this.showPasswordPicturBox.Image = global::Resturant.Properties.Resources.show_512;
			this.showPasswordPicturBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.showPasswordPicturBox.Location = new System.Drawing.Point(297, 116);
			this.showPasswordPicturBox.Name = "showPasswordPicturBox";
			this.showPasswordPicturBox.Size = new System.Drawing.Size(24, 24);
			this.showPasswordPicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.showPasswordPicturBox.TabIndex = 25;
			this.showPasswordPicturBox.TabStop = false;
			this.showPasswordPicturBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShowPasswordPicturBox_MouseDown);
			this.showPasswordPicturBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ShowPasswordPicturBox_MouseUp);
			// 
			// minimizeButton
			// 
			this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
			this.minimizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizeButton.BackgroundImage")));
			this.minimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.minimizeButton.FlatAppearance.BorderSize = 0;
			this.minimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.minimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
			this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.minimizeButton.Font = new System.Drawing.Font("IRANSans", 12F);
			this.minimizeButton.ForeColor = System.Drawing.Color.White;
			this.minimizeButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.minimizeButton.Location = new System.Drawing.Point(652, 12);
			this.minimizeButton.Name = "minimizeButton";
			this.minimizeButton.Size = new System.Drawing.Size(15, 15);
			this.minimizeButton.TabIndex = 2;
			this.minimizeButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.minimizeButton.UseVisualStyleBackColor = false;
			this.minimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
			// 
			// closeButton
			// 
			this.closeButton.BackColor = System.Drawing.Color.Transparent;
			this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
			this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.closeButton.FlatAppearance.BorderSize = 0;
			this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
			this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
			this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeButton.Font = new System.Drawing.Font("IRANSans", 12F);
			this.closeButton.ForeColor = System.Drawing.Color.White;
			this.closeButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.closeButton.Location = new System.Drawing.Point(673, 12);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(15, 15);
			this.closeButton.TabIndex = 3;
			this.closeButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.closeButton.UseVisualStyleBackColor = false;
			this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// LoginForm
			// 
			this.AcceptButton = this.loginButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.CancelButton = this.closeButton;
			this.ClientSize = new System.Drawing.Size(700, 300);
			this.Controls.Add(this.createAccountLinkLabel);
			this.Controls.Add(this.loginButton);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.usernameTextBox);
			this.Controls.Add(this.loginLabel);
			this.Controls.Add(this.panel);
			this.Controls.Add(this.errorMessageLabel);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.showPasswordPicturBox);
			this.Controls.Add(this.minimizeButton);
			this.Controls.Add(this.closeButton);
			this.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "LoginForm";
			this.Opacity = 0.85D;
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Text = "Login Form";
			this.Load += new System.EventHandler(this.LoginForm_Load);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseMove);
			this.panel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picturBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.showPasswordPicturBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Mbb.Windows.Forms.LinkLabel createAccountLinkLabel;
		private Mbb.Windows.Forms.Button loginButton;
		private Mbb.Windows.Forms.Panel panel2;
		private Mbb.Windows.Forms.TextBox passwordTextBox;
		private Mbb.Windows.Forms.Panel panel1;
		public Mbb.Windows.Forms.TextBox usernameTextBox;
		private Mbb.Windows.Forms.Label loginLabel;
		private Mbb.Windows.Forms.Panel panel;
		private Mbb.Windows.Forms.PicturBox picturBox1;
		private Mbb.Windows.Forms.Label errorMessageLabel;
		private Mbb.Windows.Forms.Label label3;
		private Mbb.Windows.Forms.Label label2;
		private Mbb.Windows.Forms.PicturBox showPasswordPicturBox;
		private Mbb.Windows.Forms.Button minimizeButton;
		private Mbb.Windows.Forms.Button closeButton;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
	}
}

