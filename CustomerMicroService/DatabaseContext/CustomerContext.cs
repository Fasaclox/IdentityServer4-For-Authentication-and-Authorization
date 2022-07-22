using CustomerMicroService.Database;
using Microsoft.EntityFrameworkCore;

namespace CustomerMicroService.DatabaseContext
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> options)
            : base(options) 
        { }
        public DbSet<Customer>Customers { get; set; }
    }
}
