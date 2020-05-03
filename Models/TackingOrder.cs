namespace Models
{
	public class TackingOrder : BaseEntity
	{
		public TackingOrder() : base()
		{

		}

		#region ItemName
		//-----
		[System.ComponentModel.DisplayName(displayName: "نام غذا")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 40)]

		[System.ComponentModel.DataAnnotations.Schema.Index
			(IsUnique = true)]

		public string ItemName { get; set; }
		//------
		#endregion /ItemName

		#region ItemPrice
		//-----
		[System.ComponentModel.DisplayName(displayName: "مبلغ غذا")]

		[System.ComponentModel.DataAnnotations.Required
		(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
		(maximumLength: 30)]

		public string ItemPrice { get; set; }
		//-----
		#endregion /ItemPrice

		#region ItemNumber
		//-----
		[System.ComponentModel.DisplayName(displayName: "تعداد")]

		[System.ComponentModel.DataAnnotations.Required
		(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
		(maximumLength: 5)]
		public string ItemNumber { get; set; }
		//-----
		#endregion /ItemNumber

		#region ItemSumPrice
		//-----
		[System.ComponentModel.DisplayName(displayName: "مجموع مبلغ غذا")]

		[System.ComponentModel.DataAnnotations.Required
		(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
		(maximumLength: 35)]
		public string ItemSumPrice { get; set; }
		//-----
		#endregion /ItemSumPrice

		#region TotalPrice
		//-----
		[System.ComponentModel.DisplayName(displayName: "مبلغ کل")]

		[System.ComponentModel.DataAnnotations.Required
		(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
		(maximumLength: 40)]

		public string TotalPrice { get; set; }
		//-----
		#endregion /TotalPrice

		#region OrderDate
		//-----
		[System.ComponentModel.DisplayName(displayName: "تاریخ ثبت سفارش")]

		[System.ComponentModel.DataAnnotations.Required
		(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
		(maximumLength: 40)]
		public string OrderDate { get; set; }
		//-----
		#endregion /OrderDate
	}
}
