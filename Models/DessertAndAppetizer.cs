namespace Models
{
	public class DessertAndAppetizer : BaseEntity
	{
		public DessertAndAppetizer() : base()
		{

		}

		#region DessertName
		[System.ComponentModel.DisplayName(displayName: "نام دسر")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 35)]

		[System.ComponentModel.DataAnnotations.Schema.Index
			(IsUnique = true)]
		public string DessertName { get; set; }
		#endregion /DessertName
		//-----
		#region DessertPrice
		[System.ComponentModel.DisplayName(displayName: "مبلغ دسر")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 25)]
		public string DessertPrice { get; set; }
		#endregion /DessertPrice
		//-----
		#region Description
		[System.ComponentModel.DisplayName(displayName: "توضیحات")]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 3000)]
		public string Description { get; set; }
		#endregion /Description
		//-----
		#region DessertImage
		[System.ComponentModel.DisplayName(displayName: "تصویر دسر")]
		public byte[] DessertImage { get; set; }
		#endregion /DessertImage
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
