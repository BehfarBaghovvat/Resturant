using System.Collections.Generic;
using System.Data;
using System.Linq;
using Stimulsoft.Report.Dictionary;
using Stimulsoft.Report;
using Stimulsoft.Report.Components;

namespace Resturant
{
	public partial class TakingOrdersForm : Infrastructure.BaseForm
	{
		public TakingOrdersForm()
		{
			InitializeComponent();
		}

		#region Properties
		public string NameItem { get; set; }
		public int Number { get; set; }
		public int IndexRow { get; set; }
		public string WarePrice { get; set; }
		public decimal ObjectPrice { get; set; }
		public decimal SumPriceItem { get; set; }
		public string TotalPrice { get; set; }
		//-------------------------------------------------------
		public int SubscriptionCode { get; set; }
		public string ClientName { get; set; }
		public string ClientTel { get; set; }
		public string ClientAddress { get; set; }
		public string InternalClientName { get; set; }
		public string DeskNumber { get; set; }
		#endregion /Properties

		//-----Beginning of the codes.

		#region TakingOrdersForm_Load
		private void TakingOrdersForm_Load(object sender, System.EventArgs e)
		{
			FoodLoader();
			DrinkLoader();
			DessertLoader();
		}
		#endregion /TakingOrdersForm_Load

		#region SearchTextBox
		//-----
		#region SearchTextBox_Enter
		private void SearchTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();

			searchTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			panel.BackColor =
				Infrastructure.Utility.LimeColor();
			searchTextBox.Select(0, 0);
		}
		#endregion /SearchTextBox_Enter

		#region SearchTextBox_KeyPress
		private void SearchTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianTyping(e);
			if (string.Compare(searchTextBox.Text, "جستجو...") == 0)
			{
				searchTextBox.Clear();
			}
		}
		#endregion /SearchTextBox_KeyPress

		#region SearchTextBox_Leave
		private void SearchTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.Compare(searchTextBox.Text,"جستجو...")==0 || string.IsNullOrWhiteSpace(searchTextBox.Text))
			{
				searchTextBox.ForeColor =
					Infrastructure.Utility.DimGrayColor();
				panel.BackColor =
					Infrastructure.Utility.WhiteColor();

				searchTextBox.Text = "جستجو...";
				return;
			}
			else
			{
				searchTextBox.ForeColor =
					Infrastructure.Utility.WhiteColor();
				panel.BackColor =
					Infrastructure.Utility.WhiteColor();
				return;
			}
		}
		#endregion /SearchTextBox_Leave

		#region SearchTextBox_TextChanged
		private void SearchTextBox_TextChanged(object sender, System.EventArgs e)
		{
			#region foodSearchRadioButton
			//-----
			if (foodSearchRadioButton.Checked == true)
			{
				if (searchTextBox.Text.Contains("جستجو..."))
				{
					return;
				}
				else
				{
					Models.DataBaseContext dataBaseContext = null;

					try
					{
						dataBaseContext =
							new Models.DataBaseContext();

						System.Collections.Generic.List<Models.Food> foods = null;

						if (string.IsNullOrWhiteSpace(searchTextBox.Text))
						{
							foods =
								dataBaseContext.Foods
								.OrderBy(current => current.FoodName)
								.ToList();
						}
						else
						{
							foods =
								dataBaseContext.Foods
								.Where(current => current.FoodName.Contains(searchTextBox.Text))
								.OrderBy(current => current.FoodName)
								.ToList();
						}

						foodDataGridView.DataSource = foods;
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
				return;
			}
			//-----
			#endregion /foodSearchRadioButton

			#region drinkSearchRadioButton
			//-----
			if (drinkSearchRadioButton.Checked == true)
			{
				if (searchTextBox.Text.Contains("جستجو ..."))
				{
					return;
				}
				else
				{
					Models.DataBaseContext dataBaseContext = null;

					try
					{
						dataBaseContext =
							new Models.DataBaseContext();

						System.Collections.Generic.List<Models.Drink> drinks = null;

						if (string.IsNullOrWhiteSpace(searchTextBox.Text))
						{
							drinks =
								dataBaseContext.Drinks
								.OrderBy(current => current.DrinkName)
								.ToList();
						}
						else
						{
							drinks =
								dataBaseContext.Drinks
								.Where(current => current.DrinkName.Contains(searchTextBox.Text))
								.OrderBy(current => current.DrinkName)
								.ToList();
						}

						drinkDataGridView.DataSource = drinks;
						drinkDataGridView.AutoResizeColumns
							(autoSizeColumnsMode: System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells);
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
				return;
			}
			//-----
			#endregion /drinkSearchRadioButton

			#region dessertSearchRadioButton
			//-----
			if (dessertSearchRadioButton.Checked == true)
			{
				if (searchTextBox.Text.Contains("جستجو ..."))
				{
					return;
				}
				else
				{
					Models.DataBaseContext dataBaseContext = null;

					try
					{
						dataBaseContext =
							new Models.DataBaseContext();

						System.Collections.Generic.List<Models.DessertAndAppetizer> desserts = null;

						if (string.IsNullOrWhiteSpace(searchTextBox.Text))
						{
							desserts =
								dataBaseContext.DessertAndAppetizers
								.OrderBy(current => current.DessertName)
								.ToList();
						}
						else
						{
							desserts =
								dataBaseContext.DessertAndAppetizers
								.Where(current => current.DessertName.Contains(searchTextBox.Text))
								.OrderBy(current => current.DessertName)
								.ToList();
						}

						dessertDataGridView.DataSource = desserts;
						dessertDataGridView.AutoResizeColumns
							(autoSizeColumnsMode: System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells);
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
				return;
			}
			//-----
			#endregion /dessertSearchRadioButton
		}
		#endregion /SearchTextBox_TextChanged
		//-----
		#endregion /SearchTextBox

		#region FoodDataGridView_CellDoubleClick
		private void FoodDataGridView_CellDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			Models.DataBaseContext dataBaseContext =
				new Models.DataBaseContext();

			if (e.RowIndex == -1)
			{
				return;
			}

			if (e.ColumnIndex == -1)
			{
				return;
			};

			NameItem =
				foodDataGridView.CurrentRow.Cells[0].Value.ToString();

			if (orderDataGridView.Rows.Count > 0)
			{
				for (int i = 0; i < orderDataGridView.Rows.Count; i++)
				{
					if (orderDataGridView.Rows[i].Cells[0].Value.ToString() == NameItem)
					{
						WarePrice =
							foodDataGridView.CurrentRow.Cells[1].Value.ToString().Replace("تومان", string.Empty).Trim();

						ObjectPrice =
							decimal.Parse(WarePrice);

						orderDataGridView.Rows[i].Cells[1].Value =
							foodDataGridView.CurrentRow.Cells[1].Value.ToString();

						orderDataGridView.Rows[i].Cells[2].Value =
							int.Parse(orderDataGridView.Rows[i].Cells[2].Value.ToString()) + 1;

						SumPriceItem =
							ObjectPrice * int.Parse(orderDataGridView.Rows[i].Cells[2].Value.ToString());

						WarePrice =
							$"{SumPriceItem.ToString("#,0")} تومان";

						orderDataGridView.Rows[i].Cells[3].Value = WarePrice;
						return;
					}
				}
				Number = 1;
				WarePrice =
					foodDataGridView.CurrentRow.Cells[1].Value.ToString();

				orderDataGridView.Rows.Add
					(foodDataGridView.CurrentRow.Cells[0].Value.ToString(),
					foodDataGridView.CurrentRow.Cells[1].Value.ToString(),
					Number++,
					WarePrice);
				return;
			}
			else
			{
				Number = 1;
				WarePrice =
					foodDataGridView.CurrentRow.Cells[1].Value.ToString();

				orderDataGridView.Rows.Add
					(foodDataGridView.CurrentRow.Cells[0].Value.ToString(),
					foodDataGridView.CurrentRow.Cells[1].Value.ToString(),
					Number++,
					WarePrice);
				reduceRequestButton.Enabled = true;
				return;
			}
		}

		#endregion /FoodDataGridView_CellDoubleClick

		#region DrinkDataGridView_CellDoubleClick
		private void DrinkDataGridView_CellDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			Models.DataBaseContext dataBaseContext =
				new Models.DataBaseContext();

			if (e.RowIndex == -1)
			{
				return;
			}

			if (e.ColumnIndex == -1)
			{
				return;
			};

			NameItem =
				drinkDataGridView.CurrentRow.Cells[0].Value.ToString();

			if (orderDataGridView.Rows.Count > 0)
			{
				for (int i = 0; i < orderDataGridView.Rows.Count; i++)
				{
					if (orderDataGridView.Rows[i].Cells[0].Value.ToString() == NameItem)
					{
						WarePrice =
							drinkDataGridView.CurrentRow.Cells[1].Value.ToString().Replace("تومان", string.Empty).Trim();

						ObjectPrice =
							decimal.Parse(WarePrice);

						orderDataGridView.Rows[i].Cells[1].Value =
							drinkDataGridView.CurrentRow.Cells[1].Value.ToString();

						orderDataGridView.Rows[i].Cells[2].Value =
							int.Parse(orderDataGridView.Rows[i].Cells[2].Value.ToString()) + 1;

						SumPriceItem =
							ObjectPrice * int.Parse(orderDataGridView.Rows[i].Cells[2].Value.ToString());

						WarePrice =
							$"{SumPriceItem.ToString("#,0")} تومان";

						orderDataGridView.Rows[i].Cells[3].Value = WarePrice;
						return;
					}
				}
				Number = 1;
				WarePrice =
					drinkDataGridView.CurrentRow.Cells[1].Value.ToString();

				orderDataGridView.Rows.Add
					(drinkDataGridView.CurrentRow.Cells[0].Value.ToString(),
					drinkDataGridView.CurrentRow.Cells[1].Value.ToString(),
					Number++,
					WarePrice);
				return;
			}
			else
			{
				Number = 1;
				WarePrice =
					drinkDataGridView.CurrentRow.Cells[1].Value.ToString();

				orderDataGridView.Rows.Add
					(drinkDataGridView.CurrentRow.Cells[0].Value.ToString(),
					drinkDataGridView.CurrentRow.Cells[1].Value.ToString(),
					Number++,
					WarePrice);
				reduceRequestButton.Enabled = true;
				return;
			}
		}

		#endregion /DrinkDataGridView_CellDoubleClick

		#region DessertDataGridView_CellDoubleClick
		private void DessertDataGridView_CellDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			Models.DataBaseContext dataBaseContext =
				new Models.DataBaseContext();

			if (e.RowIndex == -1)
			{
				return;
			}

			if (e.ColumnIndex == -1)
			{
				return;
			};

			NameItem =
				dessertDataGridView.CurrentRow.Cells[0].Value.ToString();

			if (orderDataGridView.Rows.Count > 0)
			{
				for (int i = 0; i < orderDataGridView.Rows.Count; i++)
				{
					if (orderDataGridView.Rows[i].Cells[0].Value.ToString() == NameItem)
					{
						WarePrice =
							dessertDataGridView.CurrentRow.Cells[1].Value.ToString().Replace("تومان", string.Empty).Trim();

						ObjectPrice =
							decimal.Parse(WarePrice);

						orderDataGridView.Rows[i].Cells[1].Value =
							dessertDataGridView.CurrentRow.Cells[1].Value.ToString();

						orderDataGridView.Rows[i].Cells[2].Value =
							int.Parse(orderDataGridView.Rows[i].Cells[2].Value.ToString()) + 1;

						SumPriceItem =
							ObjectPrice * int.Parse(orderDataGridView.Rows[i].Cells[2].Value.ToString());

						WarePrice =
							$"{SumPriceItem.ToString("#,0")} تومان";

						orderDataGridView.Rows[i].Cells[3].Value = WarePrice;
						return;
					}
				}
				Number = 1;
				WarePrice =
					dessertDataGridView.CurrentRow.Cells[1].Value.ToString();

				orderDataGridView.Rows.Add
					(dessertDataGridView.CurrentRow.Cells[0].Value.ToString(),
					dessertDataGridView.CurrentRow.Cells[1].Value.ToString(),
					Number++,
					WarePrice);
				return;
			}
			else
			{
				reduceRequestButton.Enabled = true;
				Number = 1;
				WarePrice =
					dessertDataGridView.CurrentRow.Cells[1].Value.ToString();

				orderDataGridView.Rows.Add
					(dessertDataGridView.CurrentRow.Cells[0].Value.ToString(),
					dessertDataGridView.CurrentRow.Cells[1].Value.ToString(),
					Number++,
					WarePrice);
				return;
			}
		}

		#endregion /DessertDataGridView_CellDoubleClick

		#region OrderDataGridView_CellValueChanged
		private void OrderDataGridView_CellValueChanged(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			string value;
			int newPrice;
			int totalSumPrice = 0;
			if (e.RowIndex >= -1)
			{
				if (orderDataGridView.RowCount >= 1)
				{
					for (int i = 0; i < orderDataGridView.Rows.Count; i++)
					{
						value = orderDataGridView.Rows[i].Cells[3].Value.ToString().Replace("تومان", string.Empty).Trim();
						newPrice = int.Parse(value.Replace(",", string.Empty).Trim());
						totalSumPrice += newPrice;
					}
					value =
						$"{totalSumPrice.ToString("#,0")} تومان";
					totalPrice.Text = value;
				}
				else
				{
					return;
				}
			}
			else
			{
				return;
			}
		}
		#endregion /OrderDataGridView_CellValueChanged

		#region OrderDataGridView_RowsAdded
		private void OrderDataGridView_RowsAdded(object sender, System.Windows.Forms.DataGridViewRowsAddedEventArgs e)
		{
			string value;
			int newPrice = 0;
			int totalSumPrice = 0;
			if (e.RowIndex != -1)
			{
				if (orderDataGridView.RowCount >= 1)
				{
					for (int i = 0; i < orderDataGridView.Rows.Count; i++)
					{
						value = orderDataGridView.Rows[i].Cells[3].Value.ToString().Replace("تومان", string.Empty).Trim();
						newPrice = int.Parse(value.Replace(",", string.Empty).Trim());
						totalSumPrice += newPrice;
					}
					value =
						$"{totalSumPrice.ToString("#,0")} تومان";
					totalPrice.Text = value;
				}
				else
				{
					return;
				}
			}
			else
			{
				return;
			}
		}

		#endregion /OrderDataGridView_RowsAdded

		#region ReduceRequestButton_Click
		private void ReduceRequestButton_Click(object sender, System.EventArgs e)
		{
			//System.Windows.Forms.MessageBox.Show(orderDataGridView.Rows.Count.ToString());
			if (orderDataGridView.Rows.Count >= 1)
			{
				int value = int.Parse(orderDataGridView.CurrentRow.Cells[2].Value.ToString());

				if (value <= 1)
				{
					#region Validate
					string totalPrice =
									this.totalPrice.Text.Replace("تومان", string.Empty).Trim();
					string WarePrice =
						orderDataGridView.CurrentRow.Cells[1].Value.ToString().Replace("تومان", string.Empty).Trim();

					decimal itemTotalPrice =
						decimal.Parse(totalPrice.Replace(",", string.Empty).Trim());
					decimal itemPrice =
							decimal.Parse(WarePrice.Replace(",", string.Empty).Trim());

					itemTotalPrice -= itemPrice;
					value--;
					orderDataGridView.CurrentRow.Cells[2].Value = value;

					decimal SumPriceItem =
							itemPrice * value;
					WarePrice =
						$"{SumPriceItem.ToString("#,0")} تومان";

					orderDataGridView.CurrentRow.Cells[3].Value = WarePrice;

					if (itemTotalPrice == 0)
					{
						this.totalPrice.Text =
							"0 تومان";
					}
					else
					{
						totalPrice =
							$"{itemTotalPrice.ToString("#,0")} تومان";
						this.totalPrice.Text = totalPrice;
					}
					#endregion /Validate

					foreach (System.Windows.Forms.DataGridViewRow row in this.orderDataGridView.SelectedRows)
					{
						orderDataGridView.Rows.RemoveAt(row.Index);

						if (orderDataGridView.Rows.Count == 0)
						{
							reduceRequestButton.Enabled = false;
							return;
						}
					}
					return;
				}
				else
				{
					string totalPrice =
						this.totalPrice.Text.Replace("تومان", string.Empty).Trim();
					string WarePrice =
						orderDataGridView.CurrentRow.Cells[1].Value.ToString().Replace("تومان", string.Empty).Trim();

					decimal itemTotalPrice =
						decimal.Parse(totalPrice.Replace(",", string.Empty).Trim());
					decimal itemPrice =
							decimal.Parse(WarePrice.Replace(",", string.Empty).Trim());

					itemTotalPrice -= itemPrice;
					value--;
					orderDataGridView.CurrentRow.Cells[2].Value = value;

					decimal SumPriceItem =
							itemPrice * value;
					WarePrice =
						$"{SumPriceItem.ToString("#,0")} تومان";

					orderDataGridView.CurrentRow.Cells[3].Value = WarePrice;

					if (itemTotalPrice == 0)
					{
						this.totalPrice.Text =
							"0 تومان";
					}
					else
					{
						totalPrice =
							$"{itemTotalPrice.ToString("#,0")} تومان";
						this.totalPrice.Text = totalPrice;
					}
					return;
				}
			}
		}
		#endregion /ReduceRequestButton_Click

		#region OrderInsideRadioButton_CheckedChanged
		private void OrderInsideRadioButton_CheckedChanged(object sender, System.EventArgs e)
		{
			if (orderInsideRadioButton.Checked == true)
			{
				subscriptionCodeTextBox.Enabled = false;
				outsideCustomerPanel.Visible = false;
			}
		}
		#endregion /OrderInsideRadioButton_CheckedChanged

		#region OrderOutsideRadioButton_CheckedChanged
		private void OrderOutsideRadioButton_CheckedChanged(object sender, System.EventArgs e)
		{
			if (orderOutsideRadioButton.Checked == true)
			{
				subscriptionCodeTextBox.Enabled = true;
				outsideCustomerPanel.Visible = true;
			}
		}
		#endregion /OrderOutsideRadioButton_CheckedChanged

		#region TotalPrice_TextChanged
		private void TotalPrice_TextChanged(object sender, System.EventArgs e)
		{
			if (string.Compare(totalPrice.Text, "0 تومان") == 0)
			{
				saveAndPrintButton.Enabled = false;
				TotalPrice = string.Empty;
				return;
			}
			else
			{
				saveAndPrintButton.Enabled = true;
				TotalPrice = totalPrice.Text;
			}
		}
		#endregion /TotalPrice_TextChanged

		#region SubscriptionCodeTextBox
		//-----
		#region SubscriptionCodeTextBox_Enter
		private void SubscriptionCodeTextBox_Enter(object sender, System.EventArgs e)
		{
			subscriptionCodeTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			panel1.BackColor =
				Infrastructure.Utility.LimeColor();

			subscriptionCodeTextBox.Select(0, 0);

		}
		#endregion /SubscriptionCodeTextBox_Enter

		#region SubscriptionCodeTextBox_KeyPress
		private void SubscriptionCodeTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
			if (subscriptionCodeTextBox.Text.Contains("کد اشتراک"))
			{
				subscriptionCodeTextBox.Clear();
			}
		}
		#endregion /SubscriptionCodeTextBox_KeyPress

		#region SubscriptionCodeTextBox_Leave
		private void SubscriptionCodeTextBox_Leave(object sender, System.EventArgs e)
		{
			subscriptionCodeTextBox.ForeColor =
				Infrastructure.Utility.DimGrayColor();
			panel1.BackColor =
				Infrastructure.Utility.WhiteColor();

			if (string.IsNullOrWhiteSpace(subscriptionCodeTextBox.Text) || string.Compare(subscriptionCodeTextBox.Text, "کد اشتراک") == 0)
			{
				subscriptionCodeTextBox.Text = "کد اشتراک";
			}
		}
		#endregion /SubscriptionCodeTextBox_Leave

		#region SubscriptionCodeTextBox_TextChanged
		private void SubscriptionCodeTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if (string.Compare(subscriptionCodeTextBox.Text, "کد اشتراک") == 0)
			{
				return;
			}
			else
			{
				if (subscriptionCodeTextBox.Text.Length < 4)
				{
					clearButton.Visible = false;
					return;
				}
				else
				{
					clearButton.Visible = true;
					SubscriptionCode = int.Parse(subscriptionCodeTextBox.Text);
					Models.DataBaseContext dataBaseContext = null;
					try
					{
						dataBaseContext =
							new Models.DataBaseContext();

						Models.Client client =
							dataBaseContext.Clients
							.Where(current => string.Compare(current.SubscriptionCode.ToString(), SubscriptionCode.ToString()) == 0)
							.FirstOrDefault();

						if (client == null)
						{
							Infrastructure.Utility.WindowsNotification
								(message: $" کد اشتراک {SubscriptionCode} موجود نیست!",
								caption: Infrastructure.PopupNotificationForm.Caption.خطا);
						}
						else
						{
							clientName.Text = client.ClientName;
							clientTel.Text = client.ClientTel;
							clientAddress.Text = client.ClientAddress;
						}
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
			}
		}
		#endregion /SubscriptionCodeTextBox_TextChanged
		//-----
		#endregion /SubscriptionCodeTextBox

		#region ClearButton_Click
		private void ClearButton_Click(object sender, System.EventArgs e)
		{
			SubscriptionCode = 0;
			subscriptionCodeTextBox.Text = "کد اشتراک";
			subscriptionCodeTextBox.Focus();
			clientName.Text = "نام مشترک";
			clientTel.Text = "تلفن مشترک";
			clientAddress.Text = "آدرس مشرک";

			clearButton.Visible = false;
		}
		#endregion /ClearButton_Click

		#region ClientName_TextChanged
		private void ClientName_TextChanged(object sender, System.EventArgs e)
		{
			if (string.Compare(clientName.Text, "نام مشترک") == 0)
			{
				ClientName = string.Empty;
			}
			else
				ClientName = clientName.Text;
		}
		#endregion /ClientName_TextChanged

		#region ClientTel_TextChanged
		private void ClientTel_TextChanged(object sender, System.EventArgs e)
		{
			if (string.Compare(clientTel.Text, "تلفن مشترک") == 0)
			{
				ClientTel = string.Empty;
			}
			else
				ClientTel = clientTel.Text;
		}
		#endregion /ClientTel_TextChanged

		#region ClientAddress_TextChanged
		private void ClientAddress_TextChanged(object sender, System.EventArgs e)
		{
			if (string.Compare(clientAddress.Text, "آدرس مشترک") == 0)
			{
				ClientAddress = string.Empty;
			}
			else
				ClientAddress = clientAddress.Text;
		}
		#endregion /ClientAddress_TextChanged

		#region InternalClientNameTextBox
		//-----
		#region InternalClientNameTextBox_Enter
		private void InternalClientNameTextBox_Enter(object sender, System.EventArgs e)
		{
			Infrastructure.Utility.PersianLanguage();
			internalClientNameTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			panel2.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(internalClientNameTextBox.Text, "نام مشتری") == 0)
			{
				internalClientNameTextBox.Clear();
			}
		}
		#endregion /InternalClientNameTextBox_Enter

		#region InternalClientNameTextBox_KeyPress
		private void InternalClientNameTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.PersianTyping(e);
		}
		#endregion /InternalClientNameTextBox_KeyPress

		#region InternalClientNameTextBox_Leave
		private void InternalClientNameTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(internalClientNameTextBox.Text) || string.Compare(internalClientNameTextBox.Text, "نام مشتری") == 0)
			{
				internalClientNameTextBox.ForeColor =
				Infrastructure.Utility.DimGrayColor();
				panel2.BackColor =
					Infrastructure.Utility.WhiteColor();
				internalClientNameTextBox.Text = "نام مشتری";
				InternalClientName = string.Empty;
			}
			else
			{
				internalClientNameTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();
				panel2.BackColor =
					Infrastructure.Utility.WhiteColor();
				InternalClientName = internalClientNameTextBox.Text;
			}
		}
		#endregion /InternalClientNameTextBox_Leave
		//------
		#endregion /InternalClientNameTextBox

		#region DeskNumberTextBox
		//-----
		#region DeskNumberTextBox_Enter
		private void DeskNumberTextBox_Enter(object sender, System.EventArgs e)
		{
			deskNumberTextBox.ForeColor =
				Infrastructure.Utility.LimeColor();
			panel3.BackColor =
				Infrastructure.Utility.LimeColor();

			if (string.Compare(deskNumberTextBox.Text, "میز شماره 15") == 0)
			{
				deskNumberTextBox.Clear();
			}
		}
		#endregion /DeskNumberTextBox_Enter

		#region DeskNumberTextBox_KeyPress
		private void DeskNumberTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Infrastructure.Utility.InsertOnlyNumber(e);
		}
		#endregion /DeskNumberTextBox_KeyPress

		#region DeskNumberTextBox_Leave
		private void DeskNumberTextBox_Leave(object sender, System.EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(deskNumberTextBox.Text) || string.Compare(deskNumberTextBox.Text, "میز شماره 15") == 0)
			{
				deskNumberTextBox.ForeColor =
				Infrastructure.Utility.DimGrayColor();
				panel3.BackColor =
					Infrastructure.Utility.WhiteColor();
				deskNumberTextBox.Text = "میز شماره 15";
				DeskNumber = string.Empty;
			}
			else
			{
				deskNumberTextBox.ForeColor =
				Infrastructure.Utility.WhiteColor();
				panel3.BackColor =
					Infrastructure.Utility.WhiteColor();
				DeskNumber = deskNumberTextBox.Text;
			}
		}
		#endregion/DeskNumberTextBox_Leave
		//-----
		#endregion /DeskNumberTextBox

		#region SaveAndPrintButton_Click
		private void SaveAndPrintButton_Click(object sender, System.EventArgs e)
		{
			string orderDate =
				Infrastructure.Utility.PersianCalendar(System.DateTime.Now);
			string orderTime =
				Infrastructure.Utility.ShowTime();

			if (orderInsideRadioButton.Checked == false && orderOutsideRadioButton.Checked == false)
			{
				Infrastructure.Utility.WindowsNotification(message: "نوع پذیرش را تعیین کنید!", caption: Infrastructure.PopupNotificationForm.Caption.اطلاع);
				return;
			}
			else
			{
				if (orderInsideRadioButton.Checked == true)
				{
					#region orderInsideRadioButton
					List<FoodOrderList> lists = new List<FoodOrderList>();
					foreach (System.Windows.Forms.DataGridViewRow rows in orderDataGridView.Rows)
					{
						FoodOrderList foodOrderList = new FoodOrderList
						{
							FoodName = rows.Cells[0].Value.ToString(),
							Price = rows.Cells[1].Value.ToString(),
							Number = int.Parse(rows.Cells[2].Value.ToString()),
							SumPrice = rows.Cells[3].Value.ToString(),
						};
						lists.Add(foodOrderList);
					}

					string ordeRegisterDate =
						$"{orderDate} | {orderTime}";

					StiReport report = new StiReport();

					report.Load("Internal order.mrt");
					report.RegBusinessObject("FoodOrder", lists);

					(report.GetComponentByName("orderRegisterDateText") as StiText).Text = ordeRegisterDate;
					(report.GetComponentByName("totalPriceText") as StiText).Text = TotalPrice;
					(report.GetComponentByName("deskNumberText") as StiText).Text = DeskNumber;
					(report.GetComponentByName("clientNameText") as StiText).Text = InternalClientName;

					report.Show();
					//----- 
					#endregion /orderInsideRadioButton
					return;
				}

				if (orderOutsideRadioButton.Checked == true)
				{
					#region orderOutsideRadioButton
					//-----
					List<FoodOrderList> lists = new List<FoodOrderList>();
					foreach (System.Windows.Forms.DataGridViewRow rows in orderDataGridView.Rows)
					{
						FoodOrderList foodOrderList = new FoodOrderList
						{
							FoodName = rows.Cells[0].Value.ToString(),
							Price = rows.Cells[1].Value.ToString(),
							Number = int.Parse(rows.Cells[2].Value.ToString()),
							SumPrice = rows.Cells[3].Value.ToString(),
						};
						lists.Add(foodOrderList);
					}

					string ordeRegisterDate =
						$"{orderDate} | {orderTime}";

					StiReport report = new StiReport();

					report.Load("Exterior order.mrt");
					report.RegBusinessObject("FoodOrder", lists);

					(report.GetComponentByName("orderRegisterDateText") as StiText).Text = ordeRegisterDate;
					(report.GetComponentByName("totalPriceText") as StiText).Text = TotalPrice;
					(report.GetComponentByName("subscriptionCodeText") as StiText).Text = SubscriptionCode.ToString();
					(report.GetComponentByName("clientNameText") as StiText).Text = ClientName;
					(report.GetComponentByName("clientTelText") as StiText).Text = ClientTel;
					(report.GetComponentByName("clientAddressText") as StiText).Text = ClientAddress;

					report.Show();
					//-----
					#endregion /orderOutsideRadioButton
					return;
				}
			}
		}
		#endregion /SaveAndPrintButton_Click

		//-----Enf of the codes.

		#region Method&Class
		//-----
		#region ShowForm
		/// <summary>
		/// توسط این تابع این امکان فراهم میشود، 
		/// زمانی که فرم ثانویه به طور کامل بسته شد، 
		/// کل برنامه بسته نشود و فرم مبدا اجرا گردد.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void ShowForm(object sender, System.Windows.Forms.FormClosedEventArgs e)
		{
			this.Show();
		}
		#endregion /ShowForm

		#region FoodLoader
		public void FoodLoader()
		{
			Models.DataBaseContext databaseContext = null;
			try
			{
				databaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.Food> foods = null;

				foods =
					databaseContext.Foods
					.OrderBy(current => current.FoodName)
					.ToList();

				foodDataGridView.DataSource = foods;
			}
			catch (System.Exception ex)
			{
				Infrastructure.Utility.PopupNotification(ex);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					databaseContext = null;
				}
			}
		}
		#endregion /FoodLoader

		#region DrinkLoader
		public void DrinkLoader()
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.Drink> drinks = null;

				drinks =
					dataBaseContext.Drinks
					.OrderBy(current => current.DrinkName)
					.ToList();

				drinkDataGridView.DataSource = drinks;
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
		#endregion /DrinkLoader

		#region DessertLoader
		public void DessertLoader()
		{
			Models.DataBaseContext dataBaseContext = null;
			try
			{
				dataBaseContext =
					new Models.DataBaseContext();

				System.Collections.Generic.List<Models.DessertAndAppetizer> desserts = null;

				desserts =
					dataBaseContext.DessertAndAppetizers
					.OrderBy(current => current.DessertName)
					.ToList();

				dessertDataGridView.DataSource = desserts;
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



		#endregion /DessertLoader

		#region FoodOrderList
		private class FoodOrderList
		{
			public string FoodName { get; set; }
			public string Price { get; set; }
			public int Number { get; set; }
			public string SumPrice { get; set; }
		}





		#endregion /FoodOrderList
		//-----
		#endregion /Method&Class

		#region ButtonNewOrder_Click
		private void ButtonNewOrder_Click(object sender, System.EventArgs e)
		{

		}
		#endregion /ButtonNewOrder_Click
	}
}