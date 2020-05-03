namespace Setting
{
	partial class ActivityControlForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivityControlForm));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.objectsPanel = new Mbb.Windows.Forms.Panel();
			this.label1 = new Mbb.Windows.Forms.Label();
			this.picturBox1 = new Mbb.Windows.Forms.PicturBox();
			this.button1 = new Mbb.Windows.Forms.Button();
			this.panel2 = new Mbb.Windows.Forms.Panel();
			this.searchTextBox = new Mbb.Windows.Forms.TextBox();
			this.activityTimeRadioButton = new Mbb.Windows.Forms.RadioButton();
			this.activityDateRadioButton = new Mbb.Windows.Forms.RadioButton();
			this.dataGridView1 = new Mbb.Windows.Forms.DataGridView();
			this.activityHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.typeActivityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ActivityDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.activityTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.userPictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
			this.objectsPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picturBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.activityHistoryBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// objectsPanel
			// 
			this.objectsPanel.Controls.Add(this.label1);
			this.objectsPanel.Controls.Add(this.picturBox1);
			this.objectsPanel.Controls.Add(this.button1);
			this.objectsPanel.Controls.Add(this.panel2);
			this.objectsPanel.Controls.Add(this.searchTextBox);
			this.objectsPanel.Controls.Add(this.activityTimeRadioButton);
			this.objectsPanel.Controls.Add(this.activityDateRadioButton);
			this.objectsPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.objectsPanel.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.objectsPanel.Location = new System.Drawing.Point(0, 0);
			this.objectsPanel.Name = "objectsPanel";
			this.objectsPanel.Size = new System.Drawing.Size(820, 120);
			this.objectsPanel.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("IRANSans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label1.ForeColor = System.Drawing.Color.Lime;
			this.label1.Location = new System.Drawing.Point(324, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(172, 34);
			this.label1.TabIndex = 9;
			this.label1.Text = "کنترل فعالیت کابران";
			// 
			// picturBox1
			// 
			this.picturBox1.Image = ((System.Drawing.Image)(resources.GetObject("picturBox1.Image")));
			this.picturBox1.Location = new System.Drawing.Point(784, 82);
			this.picturBox1.Name = "picturBox1";
			this.picturBox1.Size = new System.Drawing.Size(25, 25);
			this.picturBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picturBox1.TabIndex = 8;
			this.picturBox1.TabStop = false;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(52)))), ((int)(((byte)(74)))));
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.Location = new System.Drawing.Point(12, 69);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(180, 45);
			this.button1.TabIndex = 7;
			this.button1.Text = "چاپ گزارش";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Location = new System.Drawing.Point(528, 113);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(280, 1);
			this.panel2.TabIndex = 3;
			// 
			// searchTextBox
			// 
			this.searchTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.searchTextBox.Font = new System.Drawing.Font("IRANSans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.searchTextBox.ForeColor = System.Drawing.Color.DimGray;
			this.searchTextBox.Location = new System.Drawing.Point(528, 83);
			this.searchTextBox.Name = "searchTextBox";
			this.searchTextBox.Size = new System.Drawing.Size(250, 23);
			this.searchTextBox.TabIndex = 2;
			this.searchTextBox.Text = "جستجو...";
			// 
			// activityTimeRadioButton
			// 
			this.activityTimeRadioButton.AutoSize = true;
			this.activityTimeRadioButton.ForeColor = System.Drawing.Color.White;
			this.activityTimeRadioButton.Location = new System.Drawing.Point(548, 53);
			this.activityTimeRadioButton.Name = "activityTimeRadioButton";
			this.activityTimeRadioButton.Size = new System.Drawing.Size(126, 23);
			this.activityTimeRadioButton.TabIndex = 1;
			this.activityTimeRadioButton.Text = "جستجوی زمان فعالیت";
			this.activityTimeRadioButton.UseVisualStyleBackColor = true;
			// 
			// activityDateRadioButton
			// 
			this.activityDateRadioButton.AutoSize = true;
			this.activityDateRadioButton.Checked = true;
			this.activityDateRadioButton.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.activityDateRadioButton.ForeColor = System.Drawing.Color.White;
			this.activityDateRadioButton.Location = new System.Drawing.Point(680, 53);
			this.activityDateRadioButton.Name = "activityDateRadioButton";
			this.activityDateRadioButton.Size = new System.Drawing.Size(128, 23);
			this.activityDateRadioButton.TabIndex = 0;
			this.activityDateRadioButton.TabStop = true;
			this.activityDateRadioButton.Text = "جستجوی تاریخ فعالیت";
			this.activityDateRadioButton.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(58)))), ((int)(((byte)(80)))));
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(68)))), ((int)(((byte)(90)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("IRANSans", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.ColumnHeadersHeight = 35;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullNameDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.typeActivityDataGridViewTextBoxColumn,
            this.ActivityDate,
            this.activityTimeDataGridViewTextBoxColumn,
            this.userPictureDataGridViewImageColumn});
			this.dataGridView1.DataSource = this.activityHistoryBindingSource;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.EnableHeadersVisualStyles = false;
			this.dataGridView1.Location = new System.Drawing.Point(0, 120);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowHeadersWidth = 30;
			this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(820, 375);
			this.dataGridView1.TabIndex = 1;
			// 
			// activityHistoryBindingSource
			// 
			this.activityHistoryBindingSource.DataSource = typeof(Models.ActivityHistory);
			// 
			// fullNameDataGridViewTextBoxColumn
			// 
			this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
			this.fullNameDataGridViewTextBoxColumn.HeaderText = "نام و نام خانوادگی";
			this.fullNameDataGridViewTextBoxColumn.MaxInputLength = 50;
			this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
			this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
			this.fullNameDataGridViewTextBoxColumn.Width = 120;
			// 
			// usernameDataGridViewTextBoxColumn
			// 
			this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
			this.usernameDataGridViewTextBoxColumn.HeaderText = "شناسه کاربری";
			this.usernameDataGridViewTextBoxColumn.MaxInputLength = 25;
			this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
			this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
			this.usernameDataGridViewTextBoxColumn.Width = 120;
			// 
			// typeActivityDataGridViewTextBoxColumn
			// 
			this.typeActivityDataGridViewTextBoxColumn.DataPropertyName = "TypeActivity";
			this.typeActivityDataGridViewTextBoxColumn.HeaderText = "نوع فعالیت";
			this.typeActivityDataGridViewTextBoxColumn.MaxInputLength = 300;
			this.typeActivityDataGridViewTextBoxColumn.Name = "typeActivityDataGridViewTextBoxColumn";
			this.typeActivityDataGridViewTextBoxColumn.ReadOnly = true;
			this.typeActivityDataGridViewTextBoxColumn.Width = 280;
			// 
			// ActivityDate
			// 
			this.ActivityDate.DataPropertyName = "ActivityDate";
			this.ActivityDate.HeaderText = "تاریخ فعالیت";
			this.ActivityDate.Name = "ActivityDate";
			this.ActivityDate.ReadOnly = true;
			// 
			// activityTimeDataGridViewTextBoxColumn
			// 
			this.activityTimeDataGridViewTextBoxColumn.DataPropertyName = "ActivityTime";
			this.activityTimeDataGridViewTextBoxColumn.HeaderText = "زمان فعالیت";
			this.activityTimeDataGridViewTextBoxColumn.MaxInputLength = 10;
			this.activityTimeDataGridViewTextBoxColumn.Name = "activityTimeDataGridViewTextBoxColumn";
			this.activityTimeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// userPictureDataGridViewImageColumn
			// 
			this.userPictureDataGridViewImageColumn.DataPropertyName = "UserPicture";
			this.userPictureDataGridViewImageColumn.HeaderText = "عکس کاربری";
			this.userPictureDataGridViewImageColumn.Name = "userPictureDataGridViewImageColumn";
			this.userPictureDataGridViewImageColumn.ReadOnly = true;
			// 
			// ActivityControlForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.ClientSize = new System.Drawing.Size(820, 495);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.objectsPanel);
			this.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.Name = "ActivityControlForm";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Text = "ActivityControlForm";
			this.objectsPanel.ResumeLayout(false);
			this.objectsPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picturBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.activityHistoryBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Mbb.Windows.Forms.Panel objectsPanel;
		private Mbb.Windows.Forms.DataGridView dataGridView1;
		private Mbb.Windows.Forms.TextBox searchTextBox;
		private Mbb.Windows.Forms.RadioButton activityTimeRadioButton;
		private Mbb.Windows.Forms.RadioButton activityDateRadioButton;
		private Mbb.Windows.Forms.Panel panel2;
		private Mbb.Windows.Forms.Button button1;
		private Mbb.Windows.Forms.PicturBox picturBox1;
		private System.Windows.Forms.BindingSource activityHistoryBindingSource;
		private Mbb.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn typeActivityDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ActivityDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn activityTimeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewImageColumn userPictureDataGridViewImageColumn;
	}
}