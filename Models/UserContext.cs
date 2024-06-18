using Microsoft.EntityFrameworkCore;
using projectTest.Models;

namespace projectTest.Contexts;


public class UserContext : DbContext
{

   public UserContext(DbContextOptions<UserContext> options) : base(options)
   {
   }

   public DbSet<User> users { get; set; }

   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
   {
	  if (!optionsBuilder.IsConfigured)
	  {
		 optionsBuilder.UseSqlServer("Server=tcp:userserverbdd.database.windows.net,1433;Initial Catalog=userbdd;Persist Security Info=False;User ID=chris;Password=rose230323!!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
	  }
   }
}
