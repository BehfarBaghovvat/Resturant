namespace Models
{
	public class FoodOrder : BaseEntity
	{
		public FoodOrder() : base()
		{

		}

		#region SubscriptionCode
		//-----
		[System.ComponentModel.DisplayName(displayName: "کد اشتراک")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.Schema.Index
			(IsUnique = true)]

		public int SubscriptionCode { get; set; }
		//-----
		#endregion /SubscriptionCode

		#region FoodName
		//-----
		[System.ComponentModel.DisplayName(displayName: "نام غذا")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 30)]

		[System.ComponentModel.DataAnnotations.Schema.Index
			(IsUnique = true)]
		public string FoodName { get; set; }
		//-----
		#endregion /FoodName

		#region Price
		//-----
		[System.ComponentModel.DisplayName(displayName: "مبلغ غذا")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 25)]
		public string Price { get; set; }
		//-----
		#endregion /Price

		#region Number
		//-----
		[System.ComponentModel.DisplayName(displayName: "تعداد")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		public int Number { get; set; }
		//-----
		#endregion /Number

		#region SumPrice
		//-----
		[System.ComponentModel.DisplayName(displayName: "جمع مبلغ")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 30)]
		public string SumPrice { get; set; }
		//-----
		#endregion /SumPrice

		#region TotalPrice
		//-----
		[System.ComponentModel.DisplayName(displayName: "جمع کل مبلغ")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 35)]

		[System.ComponentModel.DataAnnotations.Schema.Index
			(IsUnique = true)]
		public string TotalPrice { get; set; }
		//-----
		#endregion /TotalPrice

		#region OrderDate
		//-----
		[System.ComponentModel.DisplayName(displayName: "تاریخ سفارش")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 20)]
		public string OrderDate { get; set; }
		//-----
		#endregion /OrderDate
	}
}
