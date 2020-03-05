using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
//using System.Data.Entity;

namespace BL.InventarioFarmacia
{
    public class ClienteBL
    {
        

        public BindingList<Cliente> ListaCliente { get; set; }

        public ClienteBL()
        {
        
            ListaCliente = new BindingList<Cliente>();
            var Cliente1 = new Cliente();
            Cliente1.Id = 1;
            Cliente1.ClienteNombre = "Allyson";
            Cliente1.ClienteCorreo = "alreyes@cemcol.com";
            Cliente1.ClienteDireccion = "Col. Montefresco";
            Cliente1.ClienteTelefono = "+50499044889";
            

            ListaCliente.Add(Cliente1);
        }

        public BindingList<Cliente> ObtenerClientes()
        {
            return ListaCliente;
        }


    }


    public class Cliente
    {
        public int Id { get; set; }
        public string ClienteNombre { get; set; }
        public string ClienteDireccion { get; set; }
        public string ClienteTelefono { get; set; }
        public string ClienteCorreo { get; set; }

    }
}
