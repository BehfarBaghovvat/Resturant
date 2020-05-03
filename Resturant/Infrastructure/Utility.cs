﻿using Tulpep.NotificationWindow;

namespace Infrastructure
{
	public class Utility
	{
		public Utility() : base()
		{

		}

		#region Properties
		//-----
		private static string[] formatEmail1 = new string[4];
		private static bool Status { get; set; }
		private static bool TrueStatus { get; set; }
		//-----
		#endregion /Properties

		//-----Beginig of the code.

		#region ADCalendar
		/// <summary>
		/// AD calendar with month names...
		/// </summary>
		/// <returns></returns>
		public static string ADCalendar()
		{
			string adCalendar;
			string nameMonth = string.Empty;

			System.Globalization.GregorianCalendar gregorianCalendar =
				new System.Globalization.GregorianCalendar();

			int years = gregorianCalendar.GetYear(System.DateTime.Now);
			int months = gregorianCalendar.GetMonth(System.DateTime.Now);
			int day = gregorianCalendar.GetDayOfMonth(System.DateTime.Now);

			switch (months)
			{
				case 1:
				nameMonth = "January";
				break;
				case 2:
				nameMonth = "February";
				break;
				case 3:
				nameMonth = "March";
				break;
				case 4:
				nameMonth = "April";
				break;
				case 5:
				nameMonth = "May";
				break;
				case 6:
				nameMonth = "June";
				break;
				case 7:
				nameMonth = "Julay";
				break;
				case 8:
				nameMonth = "August";
				break;
				case 9:
				nameMonth = "September";
				break;
				case 10:
				nameMonth = "October";
				break;
				case 11:
				nameMonth = "November";
				break;
				case 12:
				nameMonth = "Decemder";
				break;

				default:
				break;
			}

			adCalendar =
				nameMonth + " / " +
				day.ToString().PadLeft(2, '0') + " / " +
				years.ToString();

			return adCalendar;

		}

		#endregion /ADCalendar

		#region ADCalendar
		/// <summary>
		/// This function has an input value that is the date of your device's system.
		/// So try to keep your system up to date.
		/// </summary>
		/// <param name="dateTime"></param>
		/// <returns>Gregorian date</returns>
		public static string ADCalendar(System.DateTime dateTime)
		{
			string adCalendar;

			System.Globalization.GregorianCalendar gregorianCalendar =
				new System.Globalization.GregorianCalendar();

			int years = gregorianCalendar.GetYear(dateTime);
			int months = gregorianCalendar.GetMonth(dateTime);
			int day = gregorianCalendar.GetDayOfMonth(dateTime);

			adCalendar =
				months.ToString().PadLeft(2, '0') + " / " +
				day.ToString().PadLeft(2, '0') + " / " +
				years.ToString();

			return adCalendar;

		}
		#endregion /ADCalendar

		#region CenturyGothicFont
		/// <summary>
		/// This function returns one font.
		/// </summary>
		/// <param name="emSize"></param>
		/// <returns>CenturyGothic Font</returns>
		public static System.Drawing.Font CenturyGothicFont(float emSize)
		{
			System.Drawing.Font font = new System.Drawing.Font(familyName: "Century Gothic", emSize: emSize);
			return font;
		}
		#endregion /CenturyGothicFont

		#region DimGrayColor
		/// <summary>
		/// This function returns a color.
		/// </summary>
		/// <returns>DimGray Color</returns>
		public static System.Drawing.Color DimGrayColor()
		{
			System.Drawing.Color color = System.Drawing.Color.DimGray;

			return color;
		}
		#endregion /DimGrayColor

		#region EmailChecker
		/// <summary>
		/// Check incoming emails.
		/// According to the defined templates, if the input email is not correct,
		/// the appropriate message will be displayed
		/// </summary>
		/// <param name="email"></param>
		/// <returns>A Bool value is returned to confirm the email</returns>
		public static bool EmailChecker(string email)
		{
			formatEmail1[0] = ".com";
			formatEmail1[1] = ".org";
			formatEmail1[2] = ".ir";
			formatEmail1[3] = ".net";

			if ((email).Contains("@") == true)
			{
				for (int i = 0; i < formatEmail1.Length; i++)
				{
					Status = email.EndsWith(formatEmail1[i]);

					if (Status == true)
					{
						TrueStatus = Status;
						break;
					}
					else if (Status == false)
					{
						TrueStatus = Status;
						break;
					}
				}
			}
			else
			{
				TrueStatus = false;
			}

			return TrueStatus;
		}
		#endregion /EmailChecker

		#region Exit
		/// <summary>
		/// You will receive a message to exit the program.
		/// </summary>
		public static void Exit()
		{
			System.Windows.Forms.DialogResult dialogResult;

			dialogResult = System.Windows.Forms.MessageBox.Show(
				text: "آیا قصد خروج از برنامه را دارید؟",
				caption: "اطلاع",
				buttons: System.Windows.Forms.MessageBoxButtons.YesNo,
				defaultButton: System.Windows.Forms.MessageBoxDefaultButton.Button2,
				icon: System.Windows.Forms.MessageBoxIcon.Question,
				options: System.Windows.Forms.MessageBoxOptions.RightAlign |
				System.Windows.Forms.MessageBoxOptions.RtlReading);

			if (dialogResult == System.Windows.Forms.DialogResult.Yes)
			{
				System.Windows.Forms.Application.Exit();
			}
		}
		#endregion /Exit

		#region EnglishAndNumberTyping
		/// <summary>
		/// It is a function that allows only English and numeric characters to be typed while typing.
		/// </summary>
		/// <param name="e"></param>
		public static void EnglishAndNumberTyping(System.Windows.Forms.KeyPressEventArgs e)
		{
			if ((e.KeyChar > 'آ' && e.KeyChar <= 'ی'))
			{
				e.Handled = true;
			}
		}
		#endregion EnglishAndNumberTyping

		#region EnglishLanguage
		/// <summary>
		/// Function to change Persian to English
		/// </summary>
		public static void EnglishLanguage()
		{
			System.Threading.Thread.CurrentThread.CurrentCulture =
				new System.Globalization.CultureInfo("en-us");

			System.Threading.Thread.CurrentThread.CurrentUICulture =
				System.Threading.Thread.CurrentThread.CurrentCulture;

			System.Windows.Forms.InputLanguage.CurrentInputLanguage =
				System.Windows.Forms.InputLanguage.FromCulture(new System.Globalization.CultureInfo("en-us"));
		}
		#endregion /EnglishLanguage

		#region EnglishTyping
		/// <summary>
		/// A function used to type English
		/// </summary>
		/// <param name="e"></param>
		public static void EnglishTyping(System.Windows.Forms.KeyPressEventArgs e)
		{
			if ((e.KeyChar > 'آ' && e.KeyChar <= 'ی') || (e.KeyChar >= '0' && e.KeyChar <= '9'))
			{
				e.Handled = true;
			}
		}
		#endregion /EnglishTyping

		#region InsertDcimalNumbers
		/// <summary>
		/// Function for inserting decimal numbers
		/// </summary>
		/// <param name="e"></param>
		/// <param name="text"></param>
		public static void InsertDcimalNumbers(System.Windows.Forms.KeyPressEventArgs e, string text)
		{
			char ch = e.KeyChar;

			if (ch == 47 && text.IndexOf('/') != -1)
			{
				e.Handled = true;
				return;
			}

			if (!char.IsDigit(ch) && ch != 8 && ch != 47)
			{
				e.Handled = true;
			}
		}
		#endregion /InsertDcimalNumbers

		#region InsertOnlyNumber
		/// <summary>
		/// A function used to type a Number
		/// </summary>
		/// <param name="e"></param>
		public static void InsertOnlyNumber(System.Windows.Forms.KeyPressEventArgs e)
		{
			if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
			{
				e.Handled = true;
			}
		}
		#endregion /InsertOnlyNumber

		#region IranSansFont
		/// <summary>
		/// A function that returns the Persian font of Iran Sense.
		/// </summary>
		/// <param name="emSize"></param>
		/// <returns>IranSans Font</returns>
		public static System.Drawing.Font IranSansFont(float emSize)
		{
			System.Drawing.Font font = new System.Drawing.Font(familyName: "IRANSans", emSize: emSize);

			return font;
		}
		#endregion /IranSansFont

		#region LimeColor
		/// <summary>
		/// This function returns a color.
		/// </summary>
		/// <returns>Lime Color</returns>
		public static System.Drawing.Color LimeColor()
		{
			System.Drawing.Color color = System.Drawing.Color.Lime;
			return color;
		}
		#endregion /LimeColor

		#region PasswordSet
		/// <summary>
		/// This function will be used when you want to make sure that the two passwords are correct.
		/// </summary>
		/// <param name="password"></param>
		/// <param name="passwordConfirm"></param>
		/// <returns>The return value is a boolean value</returns>
		public static bool PasswordSet (string password, string passwordConfirm)
		{
			bool statusPawword;
			if (string.Compare(password, passwordConfirm, true)==0)
			{
				statusPawword = true;
			}
			else
			{
				statusPawword = false;
			}
			return statusPawword;
		}
		#endregion /PasswordSet

		#region Payment
		/// <summary>
		///  Calculate the cost of purchasing commodity.
		/// </summary>
		/// <param name="quatity"></param>
		/// <param name="price"></param>
		/// <returns></returns>
		public static decimal Payment(decimal quatity, decimal price)
		{
			decimal payment;

			payment = quatity * price;

			return payment;
		}
		#endregion /Payment

		#region PersianAndNumberTyping
		/// <summary>
		/// A function used to type Farsi
		/// </summary>
		/// <param name="e"></param>
		public static void PersianAndNumberTyping(System.Windows.Forms.KeyPressEventArgs e)
		{
			if ((e.KeyChar > 'a' && e.KeyChar <= 'z') || (e.KeyChar > 'A' && e.KeyChar <= 'Z'))
			{
				e.Handled = true;
			}
		}
		#endregion /PersianAndNumberTyping

		#region PersianCalendar
		/// <summary>
		/// View Persian calendar with month names.
		/// </summary>
		/// <returns></returns>
		public static string PersianCalendar()
		{
			string farsiCalendar;
			string nameMonth = string.Empty;

			System.Globalization.PersianCalendar persianCalendar =
				new System.Globalization.PersianCalendar();

			int years = persianCalendar.GetYear(System.DateTime.Now);
			int month = persianCalendar.GetMonth(System.DateTime.Now);
			int day = persianCalendar.GetDayOfMonth(System.DateTime.Now);

			switch (month)
			{
				case 1:
				nameMonth = "فروردین";
				break;
				case 2:
				nameMonth = "اردیبهشت";
				break;
				case 3:
				nameMonth = "خرداد";
				break;
				case 4:
				nameMonth = "تیر";
				break;
				case 5:
				nameMonth = "مرداد";
				break;
				case 6:
				nameMonth = "شهریور";
				break;
				case 7:
				nameMonth = "مهر";
				break;
				case 8:
				nameMonth = "آبان";
				break;
				case 9:
				nameMonth = "آذر";
				break;
				case 10:
				nameMonth = "دی";
				break;
				case 11:
				nameMonth = "بهمن";
				break;
				case 12:
				nameMonth = "اسفند";
				break;

				default:
				break;
			}

			farsiCalendar =
				day.ToString().PadLeft(2, '0') + " / " + nameMonth + " / " + years.ToString();

			return farsiCalendar;
		}
		#endregion /PersianCalendar

		#region PersianCalendar
		/// <summary>
		/// View Persian Calendar.
		/// </summary>
		/// <param name="dateTime">Calendar entry</param>
		/// <returns></returns>
		public static string PersianCalendar(System.DateTime dateTime)
		{
			System.Globalization.PersianCalendar persianCalendar =
				new System.Globalization.PersianCalendar();

			int year = persianCalendar.GetYear(dateTime);
			int month = persianCalendar.GetMonth(dateTime);
			int day = persianCalendar.GetDayOfMonth(dateTime);

			string showCalendar =
				year.ToString() + "/" +
				month.ToString().PadLeft(2, '0') + "/" +
				day.ToString().PadLeft(2, '0');

			return showCalendar;
		}
		#endregion / PersianCalendar

		#region PersianLanguage
		/// <summary>
		/// Function to change English to Persian
		/// </summary>
		public static void PersianLanguage()
		{
			System.Threading.Thread.CurrentThread.CurrentCulture =
				new System.Globalization.CultureInfo("fa-ir");

			System.Threading.Thread.CurrentThread.CurrentUICulture =
				System.Threading.Thread.CurrentThread.CurrentCulture;

			System.Windows.Forms.InputLanguage.CurrentInputLanguage =
				System.Windows.Forms.InputLanguage.FromCulture(new System.Globalization.CultureInfo("fa-ir"));
		}
		#endregion /PersianLanguage

		#region PersianTyping
		/// <summary>
		/// A function used to type Farsi
		/// </summary>
		/// <param name="e"></param>
		public static void PersianTyping(System.Windows.Forms.KeyPressEventArgs e)
		{
			if ((e.KeyChar > 'a' && e.KeyChar <= 'z') || (e.KeyChar > 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= '0' && e.KeyChar <= '9'))
			{
				e.Handled = true;
			}
		}
		#endregion /PersianTyping		

		#region PopupNotification
		/// <summary>
		/// This function receives input from the class Exception and displays a related message in the form of a notification.
		/// </summary>
		/// <param name="ex"></param>
		public static void PopupNotification(System.Exception ex)
		{
			PopupNotifier popup =
				new PopupNotifier();
			//popup.Image = Resturant.Properties.Resources.info_00;
			popup.TitleText = "Exception Error";
			popup.ContentText = ex.Message;
			popup.Popup();
		}
		#endregion /PopupNotification

		#region TextFixed
		/// <summary>
		/// A function that removes the excess distance of a text from both sides.
		/// </summary>
		/// <param name="text"></param>
		/// <returns>The output is a spaceless text.</returns>
		public static string TextFixed(string text)
		{
			if (text == null)
			{
				return string.Empty;
			}

			text.Trim();

			if (text == string.Empty)
			{
				return string.Empty;
			}

			while (text == "  ")
			{
				text =
					text.Replace("  ", " ");
			}
			return text;
		}
		#endregion

		#region UserCheck
		/// <summary>
		/// This function can be used to create a username with a specific form.
		/// This function allows you to have two digits of your username.
		/// </summary>
		/// <param name="text"></param>
		/// <returns>The output value is a boolean value.</returns>
		public static bool UserCheck(string text)
		{
			int length = text.Length;
			int num = 0;
			string[] textAray = new string[length];
			string firstValue;

			bool statusCheck;

			for (int i = 0; i <= length - 1; i++)
			{
				textAray[i] = text.Substring(i, 1);
			}

			for (int i = 0; i <= length - 1; i++)
			{
				firstValue = textAray[i];

				for (int y = 0; y <= 9; y++)
				{
					if (string.Compare(firstValue, y.ToString(), false) == 0)
					{
						num++;
					}
				}
			}

			if (num < 2)
			{
				Mbb.Windows.Forms.MessageBox.ErrorMessage
				("شناسه کاربری باید دارای حداقل 2 عدد باشد!");
				statusCheck = false;
			}
			else
			{
				statusCheck = true;
			}

			return statusCheck;
		}
		#endregion /UserCheck

		#region ShowTime
		/// <summary>
		/// A function that displays the clock.
		/// </summary>
		/// <returns>The device's system clock output</returns>
		public static string ShowTime()
		{
			string timeNow =
				System.DateTime.Now.TimeOfDay.ToString().Substring(0, 8);

			return timeNow;

		}
		#endregion /ShowTime

		#region WindowsNotification
		/// <summary>
		/// A nice notification to display short messages that have three inputs.
		/// Message, Caption and Picture
		/// </summary>
		/// <param name="message"></param>
		/// <param name="caption"></param>
		/// <param name="picture"></param>
		public static void WindowsNotification(string message, Infrastructure.PopupNotificationForm.Caption caption, string picture)
		{
			Infrastructure.PopupNotificationForm popupNotification =
				new Infrastructure.PopupNotificationForm();

			popupNotification.ShowAlert(message: message, caption: caption, picture: picture );
		}
		#endregion /WindowsNotification

		#region WindowsNotification
		/// <summary>
		/// A nice notification to display short messages that have three inputs.
		/// Message and Caption.
		/// </summary>
		/// <param name="message"></param>
		/// <param name="caption"></param>
		public static void WindowsNotification(string message, Infrastructure.PopupNotificationForm.Caption caption)
		{
			Infrastructure.PopupNotificationForm popupNotification =
				new Infrastructure.PopupNotificationForm();

			popupNotification.ShowAlert(message: message, caption: caption);
		}
		#endregion /WindowsNotification

		#region WhiteColor
		/// <summary>
		/// This function returns a color.
		/// </summary>
		/// <returns>White Color</returns>
		public static System.Drawing.Color WhiteColor()
		{
			System.Drawing.Color color = System.Drawing.Color.White;
			return color;
		}
		#endregion /WhiteColor

		//-----Enf of the codes.
	}
}
