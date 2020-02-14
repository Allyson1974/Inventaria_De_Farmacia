using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioFarmacia
{
    public class ProveedoresBL
    {
        List<Proveedorclas> Lista = new List<Proveedorclas>();
        public void Agregar(int rtn)
        {
            Proveedorclas prov = new Proveedorclas();

            prov.rtn = 1;

            Lista.Add(prov);
        }


    }
}
