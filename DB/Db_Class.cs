using Microsoft.EntityFrameworkCore;
using OnlineStore.Models;

namespace OnlineStore.DB
{
	public class Db_Class : DbContext
	{
		public Db_Class(DbContextOptions<Db_Class> options) : base(options)
		{

		}

        public DbSet<Class_UserModel> tbl_users { get; set; }
		public DbSet<Class_Categories> tbl_categories { get; set; }
		public DbSet<Class_subcategories> tbl_sub_cat { get; set; }

		public DbSet<Class_Products> tbl_products { get; set; }
	}
}
