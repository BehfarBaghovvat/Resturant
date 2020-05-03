namespace Setting
{
	partial class LoginControlForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginControlForm));
			this.loginDataGridView = new Mbb.Windows.Forms.DataGridView();
			this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.loginTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.logoutTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.userPictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
			this.logHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.objectsPanel = new Mbb.Windows.Forms.Panel();
			this.loginControlLlabel = new Mbb.Windows.Forms.Label();
			this.button1 = new Mbb.Windows.Forms.Button();
			this.picturBox1 = new Mbb.Windows.Forms.PicturBox();
			this.logoutRadioButton = new Mbb.Windows.Forms.RadioButton();
			this.loginRadioButton = new Mbb.Windows.Forms.RadioButton();
			this.usernameRadioButton = new Mbb.Windows.Forms.RadioButton();
			this.panel = new Mbb.Windows.Forms.Panel();
			this.searchTextBox = new Mbb.Windows.Forms.TextBox();
			this.deleteTableButton = new Mbb.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.loginDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.logHistoryBindingSource)).BeginInit();
			this.objectsPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picturBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// loginDataGridView
			// 
			this.loginDataGridView.AllowUserToAddRows = false;
			this.loginDataGridView.AllowUserToDeleteRows = false;
			this.loginDataGridView.AutoGenerateColumns = false;
			this.loginDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(99)))));
			this.loginDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.loginDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.loginDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(51)))), ((int)(((byte)(79)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.loginDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.loginDataGridView.ColumnHeadersHeight = 35;
			this.loginDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.loginDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullNameDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.loginTimeDataGridViewTextBoxColumn,
            this.logoutTimeDataGridViewTextBoxColumn,
            this.userPictureDataGridViewImageColumn});
			this.loginDataGridView.DataSource = this.logHistoryBindingSource;
			this.loginDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
			this.loginDataGridView.EnableHeadersVisualStyles = false;
			this.loginDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(51)))), ((int)(((byte)(79)))));
			this.loginDataGridView.Location = new System.Drawing.Point(0, 120);
			this.loginDataGridView.Name = "loginDataGridView";
			this.loginDataGridView.ReadOnly = true;
			this.loginDataGridView.RowHeadersVisible = false;
			this.loginDataGridView.RowHeadersWidth = 40;
			this.loginDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.loginDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.loginDataGridView.Size = new System.Drawing.Size(820, 330);
			this.loginDataGridView.TabIndex = 1;
			// 
			// fullNameDataGridViewTextBoxColumn
			// 
			this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
			this.fullNameDataGridViewTextBoxColumn.HeaderText = "نام و نام خانوادگی";
			this.fullNameDataGridViewTextBoxColumn.MaxInputLength = 55;
			this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
			this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
			this.fullNameDataGridViewTextBoxColumn.Width = 140;
			// 
			// usernameDataGridViewTextBoxColumn
			// 
			this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
			this.usernameDataGridViewTextBoxColumn.HeaderText = "شناسه کاربری";
			this.usernameDataGridViewTextBoxColumn.MaxInputLength = 25;
			this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
			this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
			this.usernameDataGridViewTextBoxColumn.Width = 140;
			// 
			// loginTimeDataGridViewTextBoxColumn
			// 
			this.loginTimeDataGridViewTextBoxColumn.DataPropertyName = "LoginTime";
			this.loginTimeDataGridViewTextBoxColumn.HeaderText = "زمان ورود";
			this.loginTimeDataGridViewTextBoxColumn.MaxInputLength = 20;
			this.loginTimeDataGridViewTextBoxColumn.Name = "loginTimeDataGridViewTextBoxColumn";
			this.loginTimeDataGridViewTextBoxColumn.ReadOnly = true;
			this.loginTimeDataGridViewTextBoxColumn.Width = 200;
			// 
			// logoutTimeDataGridViewTextBoxColumn
			// 
			this.logoutTimeDataGridViewTextBoxColumn.DataPropertyName = "LogoutTime";
			this.logoutTimeDataGridViewTextBoxColumn.HeaderText = "زمان خروج";
			this.logoutTimeDataGridViewTextBoxColumn.MaxInputLength = 20;
			this.logoutTimeDataGridViewTextBoxColumn.Name = "logoutTimeDataGridViewTextBoxColumn";
			this.logoutTimeDataGridViewTextBoxColumn.ReadOnly = true;
			this.logoutTimeDataGridViewTextBoxColumn.Width = 200;
			// 
			// userPictureDataGridViewImageColumn
			// 
			this.userPictureDataGridViewImageColumn.DataPropertyName = "UserPicture";
			this.userPictureDataGridViewImageColumn.HeaderText = "تصویر کاربر";
			this.userPictureDataGridViewImageColumn.Name = "userPictureDataGridViewImageColumn";
			this.userPictureDataGridViewImageColumn.ReadOnly = true;
			this.userPictureDataGridViewImageColumn.Width = 140;
			// 
			// logHistoryBindingSource
			// 
			this.logHistoryBindingSource.DataSource = typeof(Models.LogHistory);
			// 
			// objectsPanel
			// 
			this.objectsPanel.Controls.Add(this.loginControlLlabel);
			this.objectsPanel.Controls.Add(this.button1);
			this.objectsPanel.Controls.Add(this.picturBox1);
			this.objectsPanel.Controls.Add(this.logoutRadioButton);
			this.objectsPanel.Controls.Add(this.loginRadioButton);
			this.objectsPanel.Controls.Add(this.usernameRadioButton);
			this.objectsPanel.Controls.Add(this.panel);
			this.objectsPanel.Controls.Add(this.searchTextBox);
			this.objectsPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.objectsPanel.Location = new System.Drawing.Point(0, 0);
			this.objectsPanel.Name = "objectsPanel";
			this.objectsPanel.Size = new System.Drawing.Size(820, 120);
			this.objectsPanel.TabIndex = 0;
			// 
			// loginControlLlabel
			// 
			this.loginControlLlabel.AutoSize = true;
			this.loginControlLlabel.Font = new System.Drawing.Font("IRANSans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.loginControlLlabel.ForeColor = System.Drawing.Color.Lime;
			this.loginControlLlabel.Location = new System.Drawing.Point(299, 9);
			this.loginControlLlabel.Name = "loginControlLlabel";
			this.loginControlLlabel.Size = new System.Drawing.Size(222, 34);
			this.loginControlLlabel.TabIndex = 10;
			this.loginControlLlabel.Text = "کنترل ورود و خروج کاربران";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button1.Location = new System.Drawing.Point(12, 69);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(180, 45);
			this.button1.TabIndex = 6;
			this.button1.Text = "چاپ گزارش";
			this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button1.UseVisualStyleBackColor = false;
			// 
			// picturBox1
			// 
			this.picturBox1.Image = ((System.Drawing.Image)(resources.GetObject("picturBox1.Image")));
			this.picturBox1.Location = new System.Drawing.Point(784, 82);
			this.picturBox1.Name = "picturBox1";
			this.picturBox1.Size = new System.Drawing.Size(25, 25);
			this.picturBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picturBox1.TabIndex = 5;
			this.picturBox1.TabStop = false;
			// 
			// logoutRadioButton
			// 
			this.logoutRadioButton.AutoSize = true;
			this.logoutRadioButton.ForeColor = System.Drawing.Color.White;
			this.logoutRadioButton.Location = new System.Drawing.Point(447, 53);
			this.logoutRadioButton.Name = "logoutRadioButton";
			this.logoutRadioButton.Size = new System.Drawing.Size(115, 23);
			this.logoutRadioButton.TabIndex = 4;
			this.logoutRadioButton.Text = "بر اساس زمان خروج";
			this.logoutRadioButton.UseVisualStyleBackColor = true;
			this.logoutRadioButton.Click += new System.EventHandler(this.LogoutRadioButton_Click);
			// 
			// loginRadioButton
			// 
			this.loginRadioButton.AutoSize = true;
			this.loginRadioButton.ForeColor = System.Drawing.Color.White;
			this.loginRadioButton.Location = new System.Drawing.Point(568, 53);
			this.loginRadioButton.Name = "loginRadioButton";
			this.loginRadioButton.Size = new System.Drawing.Size(110, 23);
			this.loginRadioButton.TabIndex = 3;
			this.loginRadioButton.Text = "بر اساس زمان ورود";
			this.loginRadioButton.UseVisualStyleBackColor = true;
			this.loginRadioButton.Click += new System.EventHandler(this.LoginRadioButton_Click);
			// 
			// usernameRadioButton
			// 
			this.usernameRadioButton.AutoSize = true;
			this.usernameRadioButton.Checked = true;
			this.usernameRadioButton.ForeColor = System.Drawing.Color.White;
			this.usernameRadioButton.Location = new System.Drawing.Point(684, 53);
			this.usernameRadioButton.Name = "usernameRadioButton";
			this.usernameRadioButton.Size = new System.Drawing.Size(124, 23);
			this.usernameRadioButton.TabIndex = 2;
			this.usernameRadioButton.TabStop = true;
			this.usernameRadioButton.Text = "بر اساس شناسه کاربری";
			this.usernameRadioButton.UseVisualStyleBackColor = true;
			this.usernameRadioButton.Click += new System.EventHandler(this.UsernameRadioButton_Click);
			// 
			// panel
			// 
			this.panel.BackColor = System.Drawing.Color.White;
			this.panel.ForeColor = System.Drawing.Color.White;
			this.panel.Location = new System.Drawing.Point(528, 113);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(280, 1);
			this.panel.TabIndex = 1;
			// 
			// searchTextBox
			// 
			this.searchTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.searchTextBox.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.searchTextBox.ForeColor = System.Drawing.Color.DimGray;
			this.searchTextBox.Location = new System.Drawing.Point(528, 83);
			this.searchTextBox.MaxLength = 20;
			this.searchTextBox.Name = "searchTextBox";
			this.searchTextBox.Size = new System.Drawing.Size(250, 23);
			this.searchTextBox.TabIndex = 0;
			this.searchTextBox.Text = "جستجو...";
			this.searchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
			this.searchTextBox.Enter += new System.EventHandler(this.SearchTextBox_Enter);
			this.searchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchTextBox_KeyPress);
			this.searchTextBox.Leave += new System.EventHandler(this.SearchTextBox_Leave);
			// 
			// deleteTableButton
			// 
			this.deleteTableButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
			this.deleteTableButton.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.deleteTableButton.FlatAppearance.BorderSize = 0;
			this.deleteTableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.deleteTableButton.ForeColor = System.Drawing.Color.White;
			this.deleteTableButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteTableButton.Image")));
			this.deleteTableButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.deleteTableButton.Location = new System.Drawing.Point(0, 450);
			this.deleteTableButton.Name = "deleteTableButton";
			this.deleteTableButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.deleteTableButton.Size = new System.Drawing.Size(820, 45);
			this.deleteTableButton.TabIndex = 2;
			this.deleteTableButton.Text = "پاک کردن جدول";
			this.deleteTableButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.deleteTableButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.deleteTableButton.UseVisualStyleBackColor = false;
			this.deleteTableButton.Click += new System.EventHandler(this.DeleteTableButton_Click);
			// 
			// LoginControlForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.ClientSize = new System.Drawing.Size(820, 495);
			this.Controls.Add(this.deleteTableButton);
			this.Controls.Add(this.loginDataGridView);
			this.Controls.Add(this.objectsPanel);
			this.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.Name = "LoginControlForm";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Text = "LoginControlForm";
			this.Load += new System.EventHandler(this.LoginControlForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.loginDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.logHistoryBindingSource)).EndInit();
			this.objectsPanel.ResumeLayout(false);
			this.objectsPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picturBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Mbb.Windows.Forms.Panel objectsPanel;
		private Mbb.Windows.Forms.TextBox searchTextBox;
		private Mbb.Windows.Forms.Panel panel;
		private Mbb.Windows.Forms.DataGridView loginDataGridView;
		private Mbb.Windows.Forms.RadioButton logoutRadioButton;
		private Mbb.Windows.Forms.RadioButton loginRadioButton;
		private Mbb.Windows.Forms.RadioButton usernameRadioButton;
		private Mbb.Windows.Forms.PicturBox picturBox1;
		private Mbb.Windows.Forms.Button button1;
		private Mbb.Windows.Forms.Label loginControlLlabel;
		private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn loginTimeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn logoutTimeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewImageColumn userPictureDataGridViewImageColumn;
		private System.Windows.Forms.BindingSource logHistoryBindingSource;
		private Mbb.Windows.Forms.Button deleteTableButton;
	}
}