using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    //Context: Db tabloları ile proje classlarıni birbirine bağlamak
   public class NorthwindContext:DbContext
    {
        //override on... ile bu hale geldi sonrası için base'i kapatıyoruz
        //Burda context hangi veritabanına bağlanacağını buldu bi altta
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Ter salşın (\) c# da farklı bir anlamı olduu için @ işareti koyuyoruz ki ters salşı gerçekten ters salş olark algılasın 
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_connection=true");
        }

        
        //Burda ise hangi class hangi tabloya karşılık geliyor onu belitiyoruz
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
