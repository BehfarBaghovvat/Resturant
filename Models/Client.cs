using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
	public class Client : BaseEntity
	{
		public Client() : base()
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

		#region CustomerName
		//-----
		[System.ComponentModel.DisplayName(displayName: "نام مشترک")]

		[System.ComponentModel.DataAnnotations.Required
		(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
		(maximumLength: 25)]

		public string ClientName { get; set; }
		//-----
		#endregion /CustomerName

		#region CustomerAddress
		//-----
		[System.ComponentModel.DisplayName(displayName: "آدرس مشترک")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
		(maximumLength: 3000)]

		[System.ComponentModel.DataAnnotations.Schema.Index
			(IsUnique = true)]

		public string ClientAddress { get; set; }
		//-----
		#endregion /CustomerAddress

		#region CustomerTel
		//-----
		[System.ComponentModel.DisplayName(displayName: "شماره تلفن مشترک")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 15)]

		public string ClientTel { get; set; }
		//-----
		#endregion /CustomerTel

		#region OrderData
		//-----
		[System.ComponentModel.DisplayName(displayName: "تاریخ سفارش")]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 20)]
		public string OrderDate { get; set; }
		//-----
		#endregion /OrderData

	}
}
