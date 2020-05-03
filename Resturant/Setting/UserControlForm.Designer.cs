namespace Setting
{
	partial class UserControlForm
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
			Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlForm));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.userPicturBox = new Mbb.Windows.Forms.PicturBox();
			this.panel100 = new Mbb.Windows.Forms.Panel();
			this.updateButton = new Mbb.Windows.Forms.Button();
			this.activeCheckBox = new Mbb.Windows.Forms.CheckBox();
			this.administratorCheckBox = new Mbb.Windows.Forms.CheckBox();
			this.panel3 = new Mbb.Windows.Forms.Panel();
			this.usernameLabel = new Mbb.Windows.Forms.Label();
			this.panel2 = new Mbb.Windows.Forms.Panel();
			this.fullNameLabel = new Mbb.Windows.Forms.Label();
			this.panel200 = new Mbb.Windows.Forms.Panel();
			this.userDataGridView = new Mbb.Windows.Forms.DataGridView();
			this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.panel1 = new Mbb.Windows.Forms.Panel();
			this.userListLabel = new Mbb.Windows.Forms.Label();
			this.isAdministratorDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.userPictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
			this.registrationTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel4 = new Mbb.Windows.Forms.Panel();
			bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			((System.ComponentModel.ISupportInitialize)(this.userPicturBox)).BeginInit();
			this.panel100.SuspendLayout();
			this.panel200.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// bunifuElipse1
			// 
			bunifuElipse1.ElipseRadius = 150;
			bunifuElipse1.TargetControl = this.userPicturBox;
			// 
			// userPicturBox
			// 
			this.userPicturBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.userPicturBox.Image = ((System.Drawing.Image)(resources.GetObject("userPicturBox.Image")));
			this.userPicturBox.Location = new System.Drawing.Point(132, 12);
			this.userPicturBox.Name = "userPicturBox";
			this.userPicturBox.Size = new System.Drawing.Size(120, 120);
			this.userPicturBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.userPicturBox.TabIndex = 5;
			this.userPicturBox.TabStop = false;
			// 
			// panel100
			// 
			this.panel100.Controls.Add(this.userPicturBox);
			this.panel100.Controls.Add(this.updateButton);
			this.panel100.Controls.Add(this.activeCheckBox);
			this.panel100.Controls.Add(this.administratorCheckBox);
			this.panel100.Controls.Add(this.panel3);
			this.panel100.Controls.Add(this.usernameLabel);
			this.panel100.Controls.Add(this.panel2);
			this.panel100.Controls.Add(this.fullNameLabel);
			this.panel100.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel100.Location = new System.Drawing.Point(420, 0);
			this.panel100.Name = "panel100";
			this.panel100.Size = new System.Drawing.Size(380, 450);
			this.panel100.TabIndex = 0;
			// 
			// updateButton
			// 
			this.updateButton.BackColor = System.Drawing.Color.SlateGray;
			this.updateButton.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.updateButton.FlatAppearance.BorderSize = 0;
			this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.updateButton.ForeColor = System.Drawing.Color.White;
			this.updateButton.Location = new System.Drawing.Point(0, 398);
			this.updateButton.Name = "updateButton";
			this.updateButton.Size = new System.Drawing.Size(380, 52);
			this.updateButton.TabIndex = 9;
			this.updateButton.Text = "به روز رسانی";
			this.updateButton.UseVisualStyleBackColor = false;
			this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
			// 
			// activeCheckBox
			// 
			this.activeCheckBox.AutoSize = true;
			this.activeCheckBox.ForeColor = System.Drawing.Color.White;
			this.activeCheckBox.Location = new System.Drawing.Point(268, 275);
			this.activeCheckBox.Name = "activeCheckBox";
			this.activeCheckBox.Size = new System.Drawing.Size(59, 23);
			this.activeCheckBox.TabIndex = 7;
			this.activeCheckBox.Text = "فعالیت";
			this.activeCheckBox.UseVisualStyleBackColor = true;
			// 
			// administratorCheckBox
			// 
			this.administratorCheckBox.AutoSize = true;
			this.administratorCheckBox.ForeColor = System.Drawing.Color.White;
			this.administratorCheckBox.Location = new System.Drawing.Point(264, 246);
			this.administratorCheckBox.Name = "administratorCheckBox";
			this.administratorCheckBox.Size = new System.Drawing.Size(63, 23);
			this.administratorCheckBox.TabIndex = 6;
			this.administratorCheckBox.Text = "مدیریت";
			this.administratorCheckBox.UseVisualStyleBackColor = true;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.White;
			this.panel3.Location = new System.Drawing.Point(61, 228);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(266, 1);
			this.panel3.TabIndex = 3;
			// 
			// usernameLabel
			// 
			this.usernameLabel.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.usernameLabel.ForeColor = System.Drawing.Color.DimGray;
			this.usernameLabel.Location = new System.Drawing.Point(57, 202);
			this.usernameLabel.Name = "usernameLabel";
			this.usernameLabel.Size = new System.Drawing.Size(270, 23);
			this.usernameLabel.TabIndex = 2;
			this.usernameLabel.Text = "شناسه کاربری";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Location = new System.Drawing.Point(61, 179);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(266, 1);
			this.panel2.TabIndex = 1;
			// 
			// fullNameLabel
			// 
			this.fullNameLabel.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.fullNameLabel.ForeColor = System.Drawing.Color.DimGray;
			this.fullNameLabel.Location = new System.Drawing.Point(57, 153);
			this.fullNameLabel.Name = "fullNameLabel";
			this.fullNameLabel.Size = new System.Drawing.Size(270, 23);
			this.fullNameLabel.TabIndex = 0;
			this.fullNameLabel.Text = "نام و نام خانوادگی";
			// 
			// panel200
			// 
			this.panel200.Controls.Add(this.userDataGridView);
			this.panel200.Controls.Add(this.panel1);
			this.panel200.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel200.Location = new System.Drawing.Point(0, 0);
			this.panel200.Name = "panel200";
			this.panel200.Size = new System.Drawing.Size(380, 450);
			this.panel200.TabIndex = 1;
			// 
			// userDataGridView
			// 
			this.userDataGridView.AllowUserToAddRows = false;
			this.userDataGridView.AllowUserToDeleteRows = false;
			this.userDataGridView.AutoGenerateColumns = false;
			this.userDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(39)))), ((int)(((byte)(75)))));
			this.userDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.userDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.userDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(39)))), ((int)(((byte)(115)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.userDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.userDataGridView.ColumnHeadersHeight = 30;
			this.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.userDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isAdministratorDataGridViewCheckBoxColumn,
            this.isActiveDataGridViewCheckBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.userPictureDataGridViewImageColumn,
            this.registrationTimeDataGridViewTextBoxColumn});
			this.userDataGridView.DataSource = this.userBindingSource;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ScrollBar;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.userDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
			this.userDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.userDataGridView.EnableHeadersVisualStyles = false;
			this.userDataGridView.Location = new System.Drawing.Point(0, 54);
			this.userDataGridView.Name = "userDataGridView";
			this.userDataGridView.ReadOnly = true;
			this.userDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.userDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.userDataGridView.RowHeadersVisible = false;
			this.userDataGridView.RowHeadersWidth = 30;
			this.userDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(44)))), ((int)(((byte)(84)))));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
			this.userDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.userDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.userDataGridView.Size = new System.Drawing.Size(380, 396);
			this.userDataGridView.TabIndex = 1;
			this.userDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.UserDataGridView_CellMouseDoubleClick);
			// 
			// userBindingSource
			// 
			this.userBindingSource.DataSource = typeof(Models.User);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.userListLabel);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(380, 54);
			this.panel1.TabIndex = 0;
			// 
			// userListLabel
			// 
			this.userListLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.userListLabel.AutoSize = true;
			this.userListLabel.Font = new System.Drawing.Font("IRANSans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.userListLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.userListLabel.Location = new System.Drawing.Point(134, 10);
			this.userListLabel.Name = "userListLabel";
			this.userListLabel.Size = new System.Drawing.Size(121, 34);
			this.userListLabel.TabIndex = 0;
			this.userListLabel.Text = "لیست کاربران";
			// 
			// isAdministratorDataGridViewCheckBoxColumn
			// 
			this.isAdministratorDataGridViewCheckBoxColumn.DataPropertyName = "IsAdministrator";
			this.isAdministratorDataGridViewCheckBoxColumn.HeaderText = "مدیریت";
			this.isAdministratorDataGridViewCheckBoxColumn.Name = "isAdministratorDataGridViewCheckBoxColumn";
			this.isAdministratorDataGridViewCheckBoxColumn.ReadOnly = true;
			this.isAdministratorDataGridViewCheckBoxColumn.Width = 75;
			// 
			// isActiveDataGridViewCheckBoxColumn
			// 
			this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
			this.isActiveDataGridViewCheckBoxColumn.HeaderText = "فعالیت";
			this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
			this.isActiveDataGridViewCheckBoxColumn.ReadOnly = true;
			this.isActiveDataGridViewCheckBoxColumn.Width = 75;
			// 
			// usernameDataGridViewTextBoxColumn
			// 
			this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
			this.usernameDataGridViewTextBoxColumn.HeaderText = "شناسه کاربری";
			this.usernameDataGridViewTextBoxColumn.MaxInputLength = 25;
			this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
			this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
			this.usernameDataGridViewTextBoxColumn.Width = 105;
			// 
			// fullNameDataGridViewTextBoxColumn
			// 
			this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
			this.fullNameDataGridViewTextBoxColumn.HeaderText = "نام و نام خانوادگی";
			this.fullNameDataGridViewTextBoxColumn.MaxInputLength = 55;
			this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
			this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
			this.fullNameDataGridViewTextBoxColumn.Width = 125;
			// 
			// emailDataGridViewTextBoxColumn
			// 
			this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
			this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
			this.emailDataGridViewTextBoxColumn.MaxInputLength = 60;
			this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
			this.emailDataGridViewTextBoxColumn.ReadOnly = true;
			this.emailDataGridViewTextBoxColumn.Visible = false;
			// 
			// passwordDataGridViewTextBoxColumn
			// 
			this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
			this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
			this.passwordDataGridViewTextBoxColumn.MaxInputLength = 40;
			this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
			this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
			this.passwordDataGridViewTextBoxColumn.Visible = false;
			// 
			// userPictureDataGridViewImageColumn
			// 
			this.userPictureDataGridViewImageColumn.DataPropertyName = "UserPicture";
			this.userPictureDataGridViewImageColumn.HeaderText = "UserPicture";
			this.userPictureDataGridViewImageColumn.Name = "userPictureDataGridViewImageColumn";
			this.userPictureDataGridViewImageColumn.ReadOnly = true;
			this.userPictureDataGridViewImageColumn.Visible = false;
			// 
			// registrationTimeDataGridViewTextBoxColumn
			// 
			this.registrationTimeDataGridViewTextBoxColumn.DataPropertyName = "RegistrationTime";
			this.registrationTimeDataGridViewTextBoxColumn.HeaderText = "RegistrationTime";
			this.registrationTimeDataGridViewTextBoxColumn.MaxInputLength = 20;
			this.registrationTimeDataGridViewTextBoxColumn.Name = "registrationTimeDataGridViewTextBoxColumn";
			this.registrationTimeDataGridViewTextBoxColumn.ReadOnly = true;
			this.registrationTimeDataGridViewTextBoxColumn.Visible = false;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.DarkCyan;
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(380, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(40, 450);
			this.panel4.TabIndex = 2;
			// 
			// UserControlForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel200);
			this.Controls.Add(this.panel100);
			this.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.Name = "UserControlForm";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Text = "UserControlForm";
			this.Load += new System.EventHandler(this.UserControlForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.userPicturBox)).EndInit();
			this.panel100.ResumeLayout(false);
			this.panel100.PerformLayout();
			this.panel200.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Mbb.Windows.Forms.Panel panel100;
		private Mbb.Windows.Forms.Panel panel200;
		private Mbb.Windows.Forms.DataGridView userDataGridView;
		private Mbb.Windows.Forms.Panel panel1;
		private Mbb.Windows.Forms.Label userListLabel;
		private Mbb.Windows.Forms.Panel panel2;
		private Mbb.Windows.Forms.Label fullNameLabel;
		private Mbb.Windows.Forms.Button updateButton;
		private Mbb.Windows.Forms.CheckBox activeCheckBox;
		private Mbb.Windows.Forms.CheckBox administratorCheckBox;
		private Mbb.Windows.Forms.Panel panel3;
		private Mbb.Windows.Forms.Label usernameLabel;
		private Mbb.Windows.Forms.PicturBox userPicturBox;
		private System.Windows.Forms.BindingSource userBindingSource;
		private System.Windows.Forms.DataGridViewCheckBoxColumn isAdministratorDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewImageColumn userPictureDataGridViewImageColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn registrationTimeDataGridViewTextBoxColumn;
		private Mbb.Windows.Forms.Panel panel4;
	}
}