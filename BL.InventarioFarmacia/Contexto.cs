using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BL.InventarioFarmacia.ProveedorBL;

namespace BL.InventarioFarmacia
{
    public class Contexto: DbContext
    {
        public Contexto(): base("Inventario")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)//plurarizar
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();//permite remover tablas generalizadas
        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
    }
}
