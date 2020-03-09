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
            _contexto.Productos.Load(); // Productos es una lista de la base de datos, le decimos que a la tabla cargue los datos
            ListaProductos = _contexto.Productos.Local.ToBindingList();//transforma los datos que traiga productos hacia un baindinlist

            return ListaProductos;                                                                             

        }

        public BindingList<Producto> BuscarProducto(string nombre)
        {
            var resultado = _contexto.Productos
            .Where(a => a.Descripcion.ToLower().Contains(nombre.ToLower()) == true)
            .ToList();

            ListaProductos = new BindingList<Producto>(resultado);

            return ListaProductos;

        }

        public Resultado GuardarProducto(Producto productos)
        {
            var resultado = Validar(productos);
            if (resultado.Exitoso == false)

            {
                return resultado;
            }

            _contexto.SaveChanges();

            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarProducto()
        {
            var nuevoProducto = new Producto();
            ListaProductos.Add(nuevoProducto);

           
        }

        public bool EliminarProducto(int id)
        {
            foreach(var Producto in ListaProductos)
            {
                if(Producto.Id == id)
                {
                    ListaProductos.Remove(Producto);
                    _contexto.SaveChanges();
                    return true;
                }
            }

            return false;
        }

        private Resultado Validar(Producto producto)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (string.IsNullOrEmpty(producto.Descripcion) == true)
            {
                resultado.Mensaje = "Ingrese una Descripcion";
                resultado.Exitoso = false;
            }


            if (producto.Existencia < 0)
            {
                resultado.Mensaje = "La existencia tiene que ser mayor que cero";
                resultado.Exitoso = false;
            }


            if (producto.Precio < 0)
            {
                resultado.Mensaje = "El precio tiene que ser mayor que cero";
                resultado.Exitoso = false;
            }

            return resultado;
        }
    }

    public class Producto
    {
        public int Id { get; set; }
        public string Medicamento { get; set; }//tipo de presentacion del medicamento, pastillas
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public string Litera { get; set; }
        public int Existencia { get; set; }
        public bool Disponible { get; set; }

    }

    public class Resultado
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }

    }
}
