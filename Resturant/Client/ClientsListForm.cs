using System.Linq;

namespace Client
{
	public partial class ClientsListForm : Infrastructure.BaseForm
	{
		public ClientsListForm()
		{
			InitializeComponent();
		}

		#region ClientAddForm
		private Client.ClientAddForm clientAddForm;

		public Client.ClientAddForm ClientAddForm
		{
			get 
			{
				if (clientAddForm == null || clientAddForm.IsDisposed == true)
				{

					clientAddForm =
						new ClientAddForm();
				}
				return clientAddForm;
			}
		}

		#endregion /ClientAddForm

		#region ClientsEditForm
		//private ClientsEditForm clientsEditForm;

		//public ClientsEditForm ClientsEditForm
		//{
		//	get 
		//	{
		//		if (clientsEditForm == null || clientsEditForm.IsDisposed == true)
		//		{
		//			clientsEditForm =
		//				new ClientsEditForm();
		//		}
		//		return clientsEditForm;
		//	}
		//}
		#endregion /ClientsEditForm

		#region Properties

		#endregion /Properties

		//-----Beginning of the codes.

		#region ClientsListForm_Load
		private void ClientsListForm_Load(object sender, System.EventArgs e)
		{
			ClientLoader();
		}
		#endregion /ClientsListForm_Load

		#region MyDataGridView_CellDoubleClick
		private void MyDataGridView_CellDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			if (e.RowIndex == -1)
			{
				return;
			}

			if (e.ColumnIndex == -1)
			{
				return;
			}

			Models.DataBaseContext dataBaseContext = null;

			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				string selectedClient =
					myDataGridView.CurrentRow.Cells[0].Value.ToString();

				Models.Client client =
					dataBaseContext.Clients
					.Where(current => string.Compare(current.SubscriptionCode.ToString(), selectedClient) == 0)
					.FirstOrDefault();

				if (client != null)
				{
					string message = $"آیا کد {selectedClient} حذف گردد؟";

					System.Windows.Forms.DialogResult dialogResult =
						Mbb.Windows.Forms.MessageBox.QuestionMessage
						(text: message,
						captiopn: "حذف مشترک",
						buttons: System.Windows.Forms.MessageBoxButtons.YesNo,
						icon: System.Windows.Forms.MessageBoxIcon.Question,
						defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button2,
						options: System.Windows.Forms.MessageBoxOptions.RightAlign |
						System.Windows.Forms.MessageBoxOptions.RtlReading);

					if (dialogResult == System.Windows.Forms.DialogResult.Yes)
					{
						dataBaseContext.Clients.Remove(client);
						dataBaseContext.SaveChanges();
					}
					else
					{
						return;
					}
				}

				ClientLoader();

				Infrastructure.Utility.WindowsNotification
					(message: "مشترک حذف گردید!", caption: Infrastructure.PopupNotificationForm.Caption.اطلاع);

			}
			catch (System.Exception ex)
			{
				Infrastructure.Utility.PopupNotification(ex);
			}
			finally
			{
				if (dataBaseContext != null)
				{
					dataBaseContext.Dispose();
					dataBaseContext = null;
				}
			}
		}
		#endregion /MyDataGridView_CellDoubleClick

		private void ClientAddButton_Click(object sender, System.EventArgs e)
		{
			ClientAddForm.Show();
		}

		private void ClientEditButton_Click(object sender, System.EventArgs e)
		{
			string selectClient =
				myDataGridView.CurrentRow.Cells[0].Value.ToString();

			ClientsEditForm clientsEditForm = new ClientsEditForm
			{
				MyClientsListForm = this,
				SubscriptionCode = int.Parse(selectClient),
			};
			
			clientsEditForm.Show();
		}
		//-----Ent of the codes.

		#region Method
		//-----
		#region ClientLoader
		public void ClientLoader()
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.Client> client = null;

				client =
					dataBaseContext.Clients
					.OrderBy(current => current.ClientName)
					.ToList();

				myDataGridView.DataSource = client;
			}
			catch (System.Exception ex)
			{
				Infrastructure.Utility.PopupNotification(ex);
			}
		}



		#endregion /ClientLoader
		//-----
		#endregion /Method

		
	}
}
