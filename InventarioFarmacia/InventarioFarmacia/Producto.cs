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
    public partial class Producto : Form
    {
        ProductoBL _producto;
        public Producto()
        {
            InitializeComponent();

            _producto = new ProductoBL();
            listaProductoBindingSource.DataSource = _producto.ObtenerProducto();
        }

        private void Producto_Load(object sender, EventArgs e)
        {

        }

        private void listaProductoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            var producto = (Producto)listaProductoBindingSource.Current;
        }
    }
}
