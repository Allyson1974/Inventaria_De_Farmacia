using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.InventarioFarmacia
{
    public class Contexto: DbContext
    {
        public Contexto(): base("InventariosdeFarmacia")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public DbSet<Producto> Productos { get; set; }
       // public DbSet<Cliente> Clientes { get; set; }
    }
}
