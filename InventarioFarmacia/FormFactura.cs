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
    public partial class FormFactura : Form
    {
        FacturaBL _facturasBL;
        ClienteBL _clientesBL;
        productosBL _productosBL;
        

        public FormFactura()
        {
            InitializeComponent();
            _facturasBL = new FacturaBL();
            listadeFacturasBindingSource.DataSource = _facturasBL.ObtenerFacturas();

            _clientesBL = new ClienteBL();
            listadeClientesBindingSource.DataSource = _clientesBL.ObtenerClientes();

            _productosBL = new productosBL();
            listaProductosBindingSource.DataSource = _productosBL.ObtenerProducto();

        }

        private void subtotalTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void subtotalLabel_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _facturasBL.AgregarFattura();
            listadeFacturasBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);
        }

        private void DeshabilitarHabilitarBotones (bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;

            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            toolStripButtonCancelar.Visible = !valor;
        }

        private void listadeFacturasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listadeFacturasBindingSource.EndEdit();

            var factura = (Factura)listadeFacturasBindingSource.Current;
            var resultado = _facturasBL.GuardarFactura(factura);

            if (resultado.Exitoso == true)
            {
                listadeFacturasBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Factura Guardada Exitosamente");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarHabilitarBotones(true);
            _facturasBL.CancelarCambios();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var factura = (Factura)listadeFacturasBindingSource.Current;

            _facturasBL.AgregarFacturaDetalle(factura);

            DeshabilitarHabilitarBotones(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var factura = (Factura)listadeFacturasBindingSource.Current;
            var facturaDetalle = (FacturaDetalle)facturaDetalleBindingSource.Current;

            _facturasBL.RemoverFacturaDetalle(factura, facturaDetalle);

            DeshabilitarHabilitarBotones(false);
        }

        private void facturaDetalleDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void facturaDetalleDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var factura = (Factura)listadeFacturasBindingSource.Current;
            _facturasBL.CalcularFactura(factura);

            listadeFacturasBindingSource.ResetBindings(false);
        }
    }
}
