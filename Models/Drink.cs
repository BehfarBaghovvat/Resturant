namespace Models
{
	public class Drink : BaseEntity
	{
		public Drink() : base()
		{

		}

		#region DrinkName
		[System.ComponentModel.DisplayName(displayName: "نام نوشیدنی")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 20)]

		[System.ComponentModel.DataAnnotations.Schema.Index
			(IsUnique = true)]
		public string DrinkName { get; set; }
		#endregion /DessertName
		//-----
		#region DrinkPrice
		[System.ComponentModel.DisplayName(displayName: " مبلغ نوشیدنی")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 25)]
		public string DrinkPrice { get; set; }
		#endregion /DrinkPrice
		//-----
		#region Description
		[System.ComponentModel.DisplayName(displayName: "توضیحات")]

		[System.ComponentModel.DataAnnotations.StringLength
		(maximumLength: 3000)]
		public string Description { get; set; }
		#endregion /Description
		//-----
		#region DrinkImage
		[System.ComponentModel.DisplayName(displayName: "تصویر نوشیدنی")]
		public byte[] DrinkImage { get; set; }
		#endregion /DrinkImage
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
