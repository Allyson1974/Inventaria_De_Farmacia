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

        }
        public BindingList<Proveedor> ObtenerProveedor()
        {
            return ListaProveedor;
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
