using System;
using DataLayer;
using System.Data.Entity;
using System.Collections.Generic;

namespace Data
{
	public class PageGroupRepository : IPageGroupRepository
	{
		public PageGroupRepository() : base()
		{
		}

		DatabaseContext databaseContext = new DatabaseContext();

		public IEnumerable<PageGroup> GetAllGroups()
		{
			return databaseContext.PageGroups;
		}

		public PageGroup GetGroupByID(int groupId)
		{
			return databaseContext.PageGroups.Find(groupId);
		}

		public bool InsertGroup(PageGroup pageGroup)
		{
			try
			{
				databaseContext.PageGroups.Add(pageGroup);

				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public bool UpdateGroup(PageGroup pageGroup)
		{
			try
			{
				databaseContext.Entry(pageGroup).State = EntityState.Modified;

				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public bool DeleteGroup(PageGroup pageGroup)
		{
			try
			{
				databaseContext.Entry(pageGroup).State = EntityState.Deleted;

				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public bool DeleteGroup(int groupId)
		{
			try
			{
				var group = GetGroupByID(groupId);
				DeleteGroup(group);

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