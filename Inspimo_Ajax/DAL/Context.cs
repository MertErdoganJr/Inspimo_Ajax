using Microsoft.EntityFrameworkCore;

namespace Inspimo_Ajax.DAL
{

    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-JNJNVEQ\\MERTSQL;initial Catalog=AjaxDb; integrated Security=true");
        }
        public DbSet<Customer> Customers { get; set; }
    }
}
