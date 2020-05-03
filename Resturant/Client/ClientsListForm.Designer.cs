namespace Client
{
	partial class ClientsListForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientsListForm));
			this.myDataGridView = new Mbb.Windows.Forms.DataGridView();
			this.subscriptionCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clientAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clientTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.clientEditButton = new Mbb.Windows.Forms.Button();
			this.clientAddButton = new Mbb.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.myDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// myDataGridView
			// 
			this.myDataGridView.AutoGenerateColumns = false;
			this.myDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.myDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.myDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.myDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.myDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.myDataGridView.ColumnHeadersHeight = 30;
			this.myDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.myDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subscriptionCodeDataGridViewTextBoxColumn,
            this.clientNameDataGridViewTextBoxColumn,
            this.clientAddressDataGridViewTextBoxColumn,
            this.clientTelDataGridViewTextBoxColumn});
			this.myDataGridView.DataSource = this.clientBindingSource;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.myDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
			this.myDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
			this.myDataGridView.EnableHeadersVisualStyles = false;
			this.myDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.myDataGridView.Location = new System.Drawing.Point(0, 0);
			this.myDataGridView.Name = "myDataGridView";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.myDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.myDataGridView.RowHeadersVisible = false;
			this.myDataGridView.RowHeadersWidth = 10;
			this.myDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.myDataGridView.RowTemplate.ReadOnly = true;
			this.myDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.myDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.myDataGridView.Size = new System.Drawing.Size(980, 444);
			this.myDataGridView.TabIndex = 1;
			this.myDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MyDataGridView_CellDoubleClick);
			// 
			// subscriptionCodeDataGridViewTextBoxColumn
			// 
			this.subscriptionCodeDataGridViewTextBoxColumn.DataPropertyName = "SubscriptionCode";
			this.subscriptionCodeDataGridViewTextBoxColumn.HeaderText = "کد اشتراک";
			this.subscriptionCodeDataGridViewTextBoxColumn.MaxInputLength = 4;
			this.subscriptionCodeDataGridViewTextBoxColumn.Name = "subscriptionCodeDataGridViewTextBoxColumn";
			this.subscriptionCodeDataGridViewTextBoxColumn.Width = 150;
			// 
			// clientNameDataGridViewTextBoxColumn
			// 
			this.clientNameDataGridViewTextBoxColumn.DataPropertyName = "ClientName";
			this.clientNameDataGridViewTextBoxColumn.HeaderText = "نام مشترک";
			this.clientNameDataGridViewTextBoxColumn.MaxInputLength = 25;
			this.clientNameDataGridViewTextBoxColumn.Name = "clientNameDataGridViewTextBoxColumn";
			this.clientNameDataGridViewTextBoxColumn.Width = 225;
			// 
			// clientAddressDataGridViewTextBoxColumn
			// 
			this.clientAddressDataGridViewTextBoxColumn.DataPropertyName = "ClientAddress";
			this.clientAddressDataGridViewTextBoxColumn.HeaderText = "آدرس مشترک";
			this.clientAddressDataGridViewTextBoxColumn.MaxInputLength = 300;
			this.clientAddressDataGridViewTextBoxColumn.Name = "clientAddressDataGridViewTextBoxColumn";
			this.clientAddressDataGridViewTextBoxColumn.Width = 400;
			// 
			// clientTelDataGridViewTextBoxColumn
			// 
			this.clientTelDataGridViewTextBoxColumn.DataPropertyName = "ClientTel";
			this.clientTelDataGridViewTextBoxColumn.HeaderText = "شماره تلفن مشترک";
			this.clientTelDataGridViewTextBoxColumn.MaxInputLength = 9;
			this.clientTelDataGridViewTextBoxColumn.Name = "clientTelDataGridViewTextBoxColumn";
			this.clientTelDataGridViewTextBoxColumn.Width = 205;
			// 
			// clientBindingSource
			// 
			this.clientBindingSource.DataSource = typeof(Models.Client);
			// 
			// clientEditButton
			// 
			this.clientEditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(99)))));
			this.clientEditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.clientEditButton.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.clientEditButton.FlatAppearance.BorderSize = 0;
			this.clientEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.clientEditButton.ForeColor = System.Drawing.Color.White;
			this.clientEditButton.Image = ((System.Drawing.Image)(resources.GetObject("clientEditButton.Image")));
			this.clientEditButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.clientEditButton.Location = new System.Drawing.Point(0, 495);
			this.clientEditButton.Name = "clientEditButton";
			this.clientEditButton.Size = new System.Drawing.Size(980, 45);
			this.clientEditButton.TabIndex = 3;
			this.clientEditButton.Text = "ویرایش مشترک";
			this.clientEditButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.clientEditButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.clientEditButton.UseCompatibleTextRendering = true;
			this.clientEditButton.UseVisualStyleBackColor = false;
			this.clientEditButton.Click += new System.EventHandler(this.ClientEditButton_Click);
			// 
			// clientAddButton
			// 
			this.clientAddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(71)))), ((int)(((byte)(99)))));
			this.clientAddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.clientAddButton.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.clientAddButton.FlatAppearance.BorderSize = 0;
			this.clientAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.clientAddButton.ForeColor = System.Drawing.Color.White;
			this.clientAddButton.Image = ((System.Drawing.Image)(resources.GetObject("clientAddButton.Image")));
			this.clientAddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.clientAddButton.Location = new System.Drawing.Point(0, 450);
			this.clientAddButton.Name = "clientAddButton";
			this.clientAddButton.Size = new System.Drawing.Size(980, 45);
			this.clientAddButton.TabIndex = 4;
			this.clientAddButton.Text = "مشترک جدید";
			this.clientAddButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.clientAddButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.clientAddButton.UseCompatibleTextRendering = true;
			this.clientAddButton.UseVisualStyleBackColor = false;
			this.clientAddButton.Click += new System.EventHandler(this.ClientAddButton_Click);
			// 
			// ClientsListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.ClientSize = new System.Drawing.Size(980, 540);
			this.Controls.Add(this.clientAddButton);
			this.Controls.Add(this.clientEditButton);
			this.Controls.Add(this.myDataGridView);
			this.Font = new System.Drawing.Font("IRANSans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.Name = "ClientsListForm";
			this.Opacity = 0.95D;
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Text = "ClientsListForm";
			this.Load += new System.EventHandler(this.ClientsListForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.myDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private Mbb.Windows.Forms.DataGridView myDataGridView;
		private System.Windows.Forms.BindingSource clientBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn subscriptionCodeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn clientAddressDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn clientTelDataGridViewTextBoxColumn;
		private Mbb.Windows.Forms.Button clientEditButton;
		private Mbb.Windows.Forms.Button clientAddButton;
	}
}