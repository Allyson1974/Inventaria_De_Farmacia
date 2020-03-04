using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.InventarioFarmacia
{
   public class ProductoBL
    {
        Contexto _contexto;

       public BindingList<Producto> ListaProductos { get; set; }

        public ProductoBL()
        {
            _contexto = new Contexto();
            ListaProductos = new BindingList<Producto>();

        }

        public BindingList<Producto> ObtenerProducto()
        {
            _contexto.Productos.Load();
            ListaProductos = _contexto.Productos.Local.ToBindingList();

            return ListaProductos;

        }

        public bool GuardarProducto(Producto productos)
        {
            if (productos.Id == 0)
            {
                productos.Id = ListaProductos.Max(item => item.Id) + 1;
            }
            return true;
        }

        public void AgregarProducto()
        {
            var nuevoProducto = new Producto();
            ListaProductos.Add(nuevoProducto);
        }
    }

    public class Producto
    {
        public int Id { get; set; }
        public string Medicamento { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public string Litera { get; set; }
        public int Existencia { get; set; }
        public bool Disponible { get; set; }

    }
}
