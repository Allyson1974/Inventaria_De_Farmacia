using BL.InventarioFarmacia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.InventarioFarmacia
{
    public class ProveedorBL
    {
        public BindingList<Proveedor> ListaProveedor { get; set; }

        public ProveedorBL()
        {
            ListaProveedor = new BindingList<Proveedor>();

            var Proveedor1 = new Proveedor();
            Proveedor1.Id = 1;
            Proveedor1.ProveedorNIC = "0190-0005-014523";
            Proveedor1.ClienteCorreo = "alreyes@cemcol.com";
            Proveedor1.ClienteDireccion = "Col. Montefresco";
            Proveedor1.ClienteTelefono = "+50499044889";

            ListaProveedor.Add(Proveedor1);

            var Proveedor2 = new Proveedor();
            Proveedor2.Id = 2;
            Proveedor2.ProveedorNIC = "0189-0045-0122153";
            Proveedor2.ClienteCorreo = "alreyes23@hotmail.com";
            Proveedor2.ClienteDireccion = "Col. Montefresco #2";
            Proveedor2.ClienteTelefono = "+50499055485";

            ListaProveedor.Add(Proveedor2);

            var Proveedor3 = new Proveedor();
            Proveedor3.Id = 3;
            Proveedor3.ProveedorNIC = "0105-04856-152268";
            Proveedor3.ClienteCorreo = "alreyes@unah.hn";
            Proveedor3.ClienteDireccion = "Col. Montefresco #3";
            Proveedor3.ClienteTelefono = "+504990445479";

            ListaProveedor.Add(Proveedor3);
        }
        public BindingList<Proveedor> ObtenerProveedor()
        {
            return ListaProveedor;
        }

        public bool GuardarProducto(Producto producto)
        {
            if (producto.Id == 0)
            {
                producto.Id = ListaProveedor.Max(item => item.Id) + 1;
            }
            return true;
        }

        public class Proveedor
        {
            public int Id { get; set; }
            public string ProveedorNIC { get; set; }
            public string ClienteDireccion { get; set; }
            public string ClienteTelefono { get; set; }
            public string ClienteCorreo { get; set; }
        }
    }

}
