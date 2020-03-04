using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.InventarioFarmacia
{
public  class ClienteBL
    {
        Contexto _contexto;

        public BindingList<Cliente> ListadeClientes{ get; set; }

        public ClienteBL()
        {
            _contexto = new Contexto();
            ListadeClientes = new BindingList<Cliente>();
            
        }

        public BindingList<Cliente> ObtenerCliente()
        {
           // _contexto.Clientes.load();
            //ListadeClientes = _contexto.Clientes.Local.ToBindingList();

            return ListadeClientes;
        }

        public class Cliente
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public string Direccion { get; set; }
            public string Edad { get; set; }
           

        }
    }

}
