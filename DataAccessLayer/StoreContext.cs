using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ClothingStore.Core;

namespace DataAccessLayer
{
    public class StoreContext : DbContext
    {
        public DbSet<Clothing> Clothes {  get; set; }
    }
}
