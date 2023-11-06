using System.Data.Entity;

namespace DataLayer
{
	public class DatabaseContext : DbContext
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public DatabaseContext() : base()
		{
		}

		public DbSet<Page> Pages { get; set; }
		public DbSet<PageGroup> PageGroups { get; set; }
		public DbSet<PageComment> PageComments { get; set; }
	}
}