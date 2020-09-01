using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace DataAccessLayer
{
	public class VSOFTDBEntities : DbContext
	{
		public VSOFTDBEntities()		
		{ }


		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=35.225.75.188;Initial Catalog=VSOFTDB;persist security info=True;user id=sqlserver;password=Chuspa191217");
		}
		public DbSet<Savings_balance> Savings_balance { get; set; }
		public DbSet<Currencies> Currencies { get; set; }
		public DbSet<Savings_Type> Savings_Type { get; set; }
	}
}
