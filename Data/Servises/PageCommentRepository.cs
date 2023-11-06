using System;
using DataLayer;
using System.Data.Entity;
using System.Collections.Generic;

namespace Data
{
	public class PageCommentRepository : IPageCommentRepository
	{

		DatabaseContext databaseContext = new DatabaseContext();

		public bool DeleteComment(PageComment Comment)
		{
			throw new NotImplementedException();
		}

		public bool DeleteComment(int commentId)
		{
			throw new NotImplementedException();
		}

		public bool DeletePage(Page page)
		{
			throw new NotImplementedException();
		}

		public bool DeletePage(int pageId)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<PageComment> GetAllComments()
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Page> GetAllPages()
		{
			throw new NotImplementedException();
		}

		public PageComment GetCommentByID(int CommentId)
		{
			throw new NotImplementedException();
		}

		public Page GetPageByID(int pageId)
		{
			throw new NotImplementedException();
		}

		public bool InsertComment(PageComment Comment)
		{
			throw new NotImplementedException();
		}

		public bool InsertPage(Page page)
		{
			throw new NotImplementedException();
		}

		public void Save()
		{
			throw new NotImplementedException();
		}

		public bool UpdateComment(PageComment Comment)
		{
			throw new NotImplementedException();
		}

		public bool UpdatePage(Page page)
		{
			throw new NotImplementedException();
		}
	}
}