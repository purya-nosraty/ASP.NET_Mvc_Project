using DataLayer;
using System.Collections.Generic;

namespace Data
{
	public interface IPageGroupRepository
	{
		IEnumerable<PageGroup> GetAllGroups();
		PageGroup GetGroupByID(int groupId);
		bool InsertGroup(PageGroup pageGroup);
		bool UpdateGroup(PageGroup pageGroup);
		bool DeleteGroup(PageGroup pageGroup);
		bool DeleteGroup(int groupId);
		void Save();
	}
}