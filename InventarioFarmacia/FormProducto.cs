using BL.InventarioFarmacia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioFarmacia
{
    public partial class FormProducto : Form
    {
        ProductoBL _productos;
        public FormProducto()
        {
            InitializeComponent();

            _productos = new ProductoBL();
            listaProductosBindingSource.DataSource = _productos.ObtenerProducto();
        }

        private void FormProducto_Load(object sender, EventArgs e)
        {
            
        }

        private void listaProductosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaProductosBindingSource.EndEdit();
            var productos = (Producto)listaProductosBindingSource.Current;
            var resultado = _productos.GuardarProducto(productos);


            if(resultado.Exitoso == true)
            {
                listaProductosBindingSource.ResetBindings(false);

            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
            
           
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _productos.AgregarProducto();
            listaProductosBindingSource.MoveLast();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(idTextBox.Text);//convirte a numerico el string del texto

            var resultado = _productos.EliminarProducto(id);

            if(resultado == true)
            {
                listaProductosBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un Errror al eliminar un producto");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listaProductosBindingSource.DataSource = _productos.BuscarProducto(textBox1.Text);

            listaProductosBindingSource.ResetBindings(false);
        }

    }

}
