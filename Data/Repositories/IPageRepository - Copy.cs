using DataLayer;
using System.Collections.Generic;

namespace Data
{
	public interface IPageCommentRepository
	{
		IEnumerable<Page> GetAllPages();
		Page GetPageByID(int pageId);
		bool InsertPage(Page page);
		bool UpdatePage(Page page);
		bool DeletePage(Page page);
		bool DeletePage(int pageId);
		void Save();
	}
}