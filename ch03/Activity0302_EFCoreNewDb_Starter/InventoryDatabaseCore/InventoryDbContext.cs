using Microsoft.EntityFrameworkCore;

namespace InventoryDatabaseCore
{
    public class InventoryDbContext : DbContext
    {
        public InventoryDbContext(DbContextOptions options)
            : base()
        {

        }
    }
}
