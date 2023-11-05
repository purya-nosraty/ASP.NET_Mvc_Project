using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataLayer
{
	public class Page : Object
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public Page() : base()
		{
		}

		#region Properties
		/// <summary>
		/// 
		/// </summary>
		[Key]
		public int PageID { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "گروه صفحه")]
		[Required(ErrorMessage = "{0} را وارد نمایید.")]
		public int GroupID { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "عنوان")]
		[Required(ErrorMessage = "{0} را وارد نمایید.")]
		[MaxLength(200)]
		public string Title { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "توضیح مختصر")]
		[Required(ErrorMessage = "{0} را وارد نمایید.")]
		[MaxLength(350)]
		public string ShortDescription { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "متن")]
		[Required(ErrorMessage = "{0} را وارد نمایید.")]
		public string Text { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "بازدید")]
		public int Visit { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "تصویر")]
		public int ImageName { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "اسلایدر")]
		public bool ShowSlider { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[Display(Name = "تاریخ ایجاد")]
		public bool Datetime { get; set; }
		#endregion /Properties

		#region	Navigation Property
		public virtual PageGroup PageGroup { get; set; }
		public virtual List<PageComment> PageComments { get; set; }
		#endregion /Navigation Property
	}
}
