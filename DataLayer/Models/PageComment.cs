using System;
using System.ComponentModel.DataAnnotations;

namespace DataLayer
{
	public class PageComment : Object
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public PageComment() : base()
		{
		}

		#region Properties
		/// <summary>
		/// Primary Key of PageComment
		/// </summary>
		[Key]
		public int CommentID { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "خبر")]
		[Required(ErrorMessage = "{0} را وارد نمایید.")]
		public int PageID { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "نام")]
		[Required(ErrorMessage = "{0} را وارد نمایید.")]
		[MaxLength(150)]
		public string Name { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "ایمیل")]
		[MaxLength(200)]
		public string Email { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "وب سایت")]
		[MaxLength(200)]
		public string WebSite { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "نظر")]
		[MaxLength(500)]
		public string Comment { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "تاریخ ثبت")]
		public string CreateDate { get; set; }
		#endregion /Properties

		#region Navigation Property
		public virtual Page Page { get; set; }
		#endregion /Navigation Property
	}
}
