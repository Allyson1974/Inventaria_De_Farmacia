using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.InventarioFarmacia
{
    
    public class ProductoBL
    {
        public BindingList<Producto> ListaProducto { get; set; }
        public ProductoBL()
        {
            ListaProducto = new BindingList<Producto>();

            var producto1 = new Producto();
            producto1.Id = 1;
            producto1.ProductoDescripcion = "Medicina Para La Calentura";
            producto1.ProductoNombre = "Acetaminofen";
            producto1.ProductoNombreComercial = "Farmaceutica del pacifico";
            producto1.ProductoUM = "Cajas";
            producto1.ProductoActivo = true;

            ListaProducto.Add(producto1);

            var producto2 = new Producto();
            producto2.Id = 2;
            producto2.ProductoDescripcion = "Medicina Para La Tos";
            producto2.ProductoNombre = "Dextrometrofano";
            producto2.ProductoNombreComercial = "Farmaceutica del pacifico";
            producto2.ProductoUM = "Cajas";
            producto2.ProductoActivo = true;

            ListaProducto.Add(producto2);

            var producto3 = new Producto();
            producto3.Id = 3;
            producto3.ProductoDescripcion = "Medicina Para La Gripe";
            producto3.ProductoNombre = "Loratadina";
            producto3.ProductoNombreComercial = "Farmaceutica del pacifico";
            producto3.ProductoUM = "Cajas";
            producto1.ProductoActivo = true;

            ListaProducto.Add(producto3);

        }

        public BindingList<Producto> ObtenerProducto()
        {
            return ListaProducto;
        }

        public bool GuardarProducto(Producto producto)
        {
            if (producto.Id == 0)
            {
                producto.Id = ListaProducto.Max(item => item.Id) + 1;
            }
            return true;
        }
    }

    public class Producto
    {
        public int Id { get; set; }
        public string ProductoNombre { get; set; }
        public string ProductoDescripcion { get; set; }
        public string ProductoUM { get; set; }
        public string ProductoNombreComercial { get; set; }
        public bool ProductoActivo { get; set; }
    }
}
