namespace Infrastructure
{
	partial class PopupNotificationForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopupNotificationForm));
			this.cancelButton = new Mbb.Windows.Forms.Button();
			this.alertMessageLabel = new Mbb.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.captionLabel = new Mbb.Windows.Forms.Label();
			this.alertIconPicturBox = new Mbb.Windows.Forms.PicturBox();
			this.objectpicturBox = new Mbb.Windows.Forms.PicturBox();
			((System.ComponentModel.ISupportInitialize)(this.alertIconPicturBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.objectpicturBox)).BeginInit();
			this.SuspendLayout();
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelButton.BackgroundImage")));
			this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.cancelButton.FlatAppearance.BorderSize = 0;
			this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cancelButton.Location = new System.Drawing.Point(358, 29);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(45, 34);
			this.cancelButton.TabIndex = 6;
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// alertMessageLabel
			// 
			this.alertMessageLabel.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.alertMessageLabel.Location = new System.Drawing.Point(55, 32);
			this.alertMessageLabel.Name = "alertMessageLabel";
			this.alertMessageLabel.Size = new System.Drawing.Size(241, 28);
			this.alertMessageLabel.TabIndex = 3;
			this.alertMessageLabel.Text = "پیغام خطا";
			this.alertMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// timer1
			// 
			this.timer1.Interval = 10;
			this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
			// 
			// captionLabel
			// 
			this.captionLabel.Font = new System.Drawing.Font("IRANSans", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.captionLabel.Location = new System.Drawing.Point(6, 4);
			this.captionLabel.Name = "captionLabel";
			this.captionLabel.Size = new System.Drawing.Size(98, 15);
			this.captionLabel.TabIndex = 5;
			this.captionLabel.Text = "caption";
			this.captionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// alertIconPicturBox
			// 
			this.alertIconPicturBox.Image = global::Resturant.Properties.Resources.succes_512;
			this.alertIconPicturBox.Location = new System.Drawing.Point(2, 24);
			this.alertIconPicturBox.Name = "alertIconPicturBox";
			this.alertIconPicturBox.Size = new System.Drawing.Size(47, 45);
			this.alertIconPicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.alertIconPicturBox.TabIndex = 4;
			this.alertIconPicturBox.TabStop = false;
			// 
			// objectpicturBox
			// 
			this.objectpicturBox.Location = new System.Drawing.Point(302, 21);
			this.objectpicturBox.Name = "objectpicturBox";
			this.objectpicturBox.Size = new System.Drawing.Size(50, 50);
			this.objectpicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.objectpicturBox.TabIndex = 7;
			this.objectpicturBox.TabStop = false;
			// 
			// PopupNotificationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.RoyalBlue;
			this.ClientSize = new System.Drawing.Size(410, 90);
			this.Controls.Add(this.objectpicturBox);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.alertIconPicturBox);
			this.Controls.Add(this.alertMessageLabel);
			this.Controls.Add(this.captionLabel);
			this.ForeColor = System.Drawing.Color.White;
			this.Name = "PopupNotificationForm";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Text = "PopupNotificationForm";
			((System.ComponentModel.ISupportInitialize)(this.alertIconPicturBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.objectpicturBox)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Mbb.Windows.Forms.Button cancelButton;
		private Mbb.Windows.Forms.PicturBox alertIconPicturBox;
		public Mbb.Windows.Forms.Label alertMessageLabel;
		private System.Windows.Forms.Timer timer1;
		public Mbb.Windows.Forms.Label captionLabel;
		private Mbb.Windows.Forms.PicturBox objectpicturBox;
	}
}