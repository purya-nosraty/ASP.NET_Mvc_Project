using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataLayer
{
	public class PageGroup : Object
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public PageGroup() : base()
		{
		}

		#region Properties
		/// <summary>
		/// Primary Key
		/// </summary>
		[Key]
		public int GroupID { get; set; }


		/// <summary>
		/// Title of Group
		/// </summary>
		[Display(Name = "عنوان گروه")]
		[Required(ErrorMessage = "{0} را وارد نمایید.")]
		[MaxLength(150)]
		public string GroupTilte { get; set; }
		#endregion /Properties

		#region Navigation Property
		public virtual List<Page> Pages { get; set; }
		#endregion /Navigation Property
	}
}