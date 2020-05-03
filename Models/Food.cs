namespace Models
{
	public class Food : BaseEntity
	{
		public Food() : base()
		{

		}

		#region FoodName
		[System.ComponentModel.DisplayName(displayName: "نام غذا")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 30)]

		[System.ComponentModel.DataAnnotations.Schema.Index
			(IsUnique = true)]
		public string FoodName { get; set; }
		#endregion /FoodName
		//-----
		#region FoodPrice
		[System.ComponentModel.DisplayName(displayName: "مبلغ غذا")]

		[System.ComponentModel.DataAnnotations.Required
		(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
		(maximumLength: 25)]
		public string FoodPrice { get; set; }
		#endregion /FoodPrice
		//-----
		#region Description
		[System.ComponentModel.DisplayName(displayName: "توضیحات")]

		[System.ComponentModel.DataAnnotations.Required
		(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
		(maximumLength: 3000)]
		public string Description { get; set; }
		#endregion /Description
		//-----
		#region FoodImage
		public byte[] FoodImage { get; set; }
		#endregion /FoodImage
		//-----
		#region UpdateTime
		[System.ComponentModel.DisplayName(displayName: "اخرین به روز رسانی")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = true)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 20)]

		public string UpdateTime { get; set; }
		#endregion /UpdateTime
		//-----
		#region NumberUpdate
		[System.ComponentModel.DisplayName(displayName: "تعداد به روز رسانی")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = true)]

		public int NumberUpdate { get; set; }
		#endregion /NumberUpdate
		//-----
		#region RegisterTime

		[System.ComponentModel.DisplayName(displayName: "زمان ثبت")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 20)]

		public string RegisterTime { get; set; }
		#endregion /RegisterTime
	}
}
