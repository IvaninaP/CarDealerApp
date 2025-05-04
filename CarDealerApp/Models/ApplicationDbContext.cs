using System.Collections.Generic;
using System.Data.Entity;

namespace CarDealerApp.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("DefaultConnection") { }

        public DbSet<Car> Cars { get; set; }
    }
}
