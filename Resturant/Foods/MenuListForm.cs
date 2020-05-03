using System.Linq;

namespace Foods
{
	public partial class MenuListForm : Infrastructure.BaseForm
	{
		#region FoodAddForm
		private static FoodAddForm foodAddForm = null;
		public static FoodAddForm FoodAddForm
		{
			get
			{
				if (foodAddForm == null || foodAddForm.IsDisposed == true)
				{
					foodAddForm =
						new FoodAddForm();
				}
				return foodAddForm;
			}
		}
		#endregion /FoodAddForm

		#region DrinkAddForm
		private static DrinkAddForm drinkAddForm = null;
		public static DrinkAddForm DrinkAddForm
		{
			get
			{
				if (drinkAddForm == null || drinkAddForm.IsDisposed == true)
				{
					drinkAddForm =
						new DrinkAddForm();
				}
				return drinkAddForm;
			}
		}
		#endregion /DrinkAddForm

		#region DessertAddForm
		private Foods.DessertAddForm dessertAddForm;

		public Foods.DessertAddForm DessertAddForm
		{
			get 
			{
				if (dessertAddForm == null || dessertAddForm.IsDisposed == true)
				{
					dessertAddForm =
						new DessertAddForm();
				}
				return dessertAddForm;
			}
		}
		#endregion /DessertAddForm

		public MenuListForm()
		{
			InitializeComponent();
		}

		//-----Beginning of the codes.
		#region MenuListForm_Load
		private void MenuListForm_Load(object sender, System.EventArgs e)
		{
			FoodLoader();
			DrinkLoader();
			DessertLoader();
		}
		#endregion /MenuListForm_Load

		#region FoodAddButton_Click
		private void FoodAddButton_Click(object sender, System.EventArgs e)
		{
			FoodAddForm.ShowDialog();
			FoodAddForm.FormClosed += ShowForm;
		}
		#endregion /foodAddFoodAddButton_ClickButton_Click

		#region DrinkAddButton_Click
		private void DrinkAddButton_Click(object sender, System.EventArgs e)
		{
			DrinkAddForm.ShowDialog();
			DrinkAddForm.FormClosed += ShowForm;
		}
		#endregion /DrinkAddButton_Click

		#region DessertAddButton_Click
		private void DessertAddButton_Click(object sender, System.EventArgs e)
		{
			DessertAddForm.ShowDialog();
			DessertAddForm.FormClosed += ShowForm;
		}
		#endregion /DessertAddButton_Click
		//-----End of the codes.

		#region Method
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
		//-----
		#endregion


	}
}
