namespace Models
{
	public class ActivityHistory : BaseEntity
	{
		public ActivityHistory() : base()
		{

		}

		#region FullName
		[System.ComponentModel.DataAnnotations.Schema.Index
			(IsUnique = false)]

		//--Not allowed to be empty Username
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		//--Lenght Username
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 55)]
		public string FullName { get; set; }
		#endregion /FullName

		#region Username
		//--Username is not Unique
		[System.ComponentModel.DataAnnotations.Schema.Index
			(IsUnique = false)]

		//--Not allowed to be empty Username
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		//--Lenght Username
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 25)]
		public string Username { get; set; }
		#endregion /Username

		#region UserPicture
		//--Empty User Picture
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		public byte[] UserPicture { get; set; }

		#endregion /UserPicture

		#region TypeActivity
		//--Not allowed to be empty TypeActivity
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = true)]

		//--Lenght TypeActivity
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 20)]

		public string TypeActivity { get; set; }
		#endregion /TypeActivity

		#region ActivityTime
		//--Not allowed to be empty ActivityTime
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = true)]

		//--Lenght ActivityTime
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 10)]

		public string ActivityTime { get; set; }
		#endregion /ActivityTime

		#region ActivityTime
		//--Not allowed to be empty ActivityTime
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = true)]

		//--Lenght ActivityTime
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 10)]

		public string ActivityDate { get; set; }
		#endregion /ActivityTime
	}
}
