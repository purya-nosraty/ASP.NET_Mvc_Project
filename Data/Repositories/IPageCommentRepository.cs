using DataLayer;
using System.Collections.Generic;

namespace Data
{
	public interface IPageCommentRepository
	{
		IEnumerable<PageComment> GetAllComments();
		PageComment GetCommentByID(int CommentId);
		bool InsertComment(PageComment Comment);
		bool UpdateComment(PageComment Comment);
		bool DeleteComment(PageComment Comment);
		bool DeleteComment(int commentId);
		void Save();
	}
}