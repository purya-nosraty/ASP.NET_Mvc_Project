using System;
using DataLayer;
using System.Data.Entity;
using System.Collections.Generic;

namespace Data
{
	public class PageRepository : IPageCommentRepository
	{
		public PageRepository() : base()
		{
		}

		DatabaseContext databaseContext = new DatabaseContext();

		public IEnumerable<Page> GetAllPages()
		{
			return databaseContext.Pages;
		}

		public Page GetPageByID(int pageId)
		{
			return databaseContext.Pages.Find(pageId);
		}

		public bool InsertPage(Page page)
		{
			try
			{
				databaseContext.Pages.Add(page);

				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public bool UpdatePage(Page page)
		{
			try
			{
				databaseContext.Entry(page).State = EntityState.Modified;

				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public bool DeletePage(Page page)
		{
			try
			{
				databaseContext.Entry(page).State = EntityState.Deleted;

				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public bool DeletePage(int pageId)
		{
			try
			{
				var group = GetPageByID(pageId);
				DeletePage(group);

				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public void Save()
		{
			databaseContext.SaveChanges();
		}
	}
}