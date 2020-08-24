using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Activity01_NetFramework
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(string connectionString) 
            : base(connectionString)
        { 
        
        }
    }
}
