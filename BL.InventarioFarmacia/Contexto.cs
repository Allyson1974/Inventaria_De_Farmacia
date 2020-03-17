﻿using BL.InventarioFarmacia;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BL.InventarioFarmacia.ClienteBL;
using static BL.InventarioFarmacia.ProveedorBL;

namespace BL.InventarioFarmacia
{
    public class Contexto: DbContext
    {
        public Contexto(): base("Inventario")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)//plurarizar las palabras al espanol
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();//permite remover tablas 
            Database.SetInitializer(new DatosdeInicio());//Agrega datos de Inicio que es una clase,de B.D despues que se hayan eliminado.
        }

        public DbSet<Producto> Productos { get; set; }//Cada una de estas 
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Usurario> Usuarios { get; set; }
        public DbSet<Tipo> Tipos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Proveedor> Proveedor { get; set; }
    }
}
