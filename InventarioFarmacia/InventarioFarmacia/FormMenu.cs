using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BL.InventarioFarmacia.ProveedorBL;

namespace InventarioFarmacia
{
    public partial class FormMenu : Form
    {
      //  private object proveedorBl;

        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            var formlogin = new FormLogin();
            formlogin.ShowDialog();
        }

        private void ingresoSalidaDeMedicamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var proveedorBl = new Proveedor();
            //proveedorBl.ShowDialog();

        }

        private void transaccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
         //   var productoBl = new Producto();
           // productoBl.ShowDialog();
            //var forminventario = new FormInventario();
            //forminventario.ShowDialog();
        }

        private void perfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reporte1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var productoBl = new Producto();
            productoBl.ShowDialog();
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void reporte2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
