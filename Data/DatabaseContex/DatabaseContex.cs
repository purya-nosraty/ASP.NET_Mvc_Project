using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DataLayer
{
	public class DatabaseContex : DbContext
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public DatabaseContex() : base()
		{
		}

		public DbSet<Page> Pages { get; set; }
		public DbSet<PageGroup> PageGroups { get; set; }
		public DbSet<PageComment> PageComments { get; set; }
	}
}
