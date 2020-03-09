using BL.InventarioFarmacia;
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
        public Contexto(): base("Inventario")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();//permite remover tablas generalizadas
        }

        public DbSet<Producto> Productos { get; set; }
      //  public DbSet<CategoriaBL> Categorias { get; set; }
    }
}
