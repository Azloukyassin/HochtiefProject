

/*using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;


namespace HochtiefProject.Models
{
   public class HochtiefDBContext : DbContext
    {
        public HochtiefDBContext(DbContextOptions<HochtiefDBContext> options):base(options)
        {
                
    
        }
        public System.Data.Entity.DbSet<Labour_Test> labours { get; set; }
    }


}*/
using HochtiefProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;

namespace HochtiefProject.Models
{
    public class HochtiefDBContext : DbContext
    {
        public HochtiefDBContext(DbContextOptions<HochtiefDBContext> options) : base(options)
        {
        }
        public DbSet<Labour_Test> Authors { get; set; }
    
    }
}
