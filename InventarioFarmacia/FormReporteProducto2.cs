using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL.InventarioFarmacia;

namespace InventarioFarmacia
{
    public partial class FormReporteProducto2 : Form
    {
        public FormReporteProducto2()
        {
            InitializeComponent();
            var _productoBL = new productosBL();//Creamos la variable productosBL
            var bindingSource = new BindingSource();//Enlasar Reportes bindingSource
            bindingSource.DataSource = _productoBL.ObtenerProducto();//

            var reporte = new ReporteProductos();//Archivo que se creo que se diseno en Crystal Report
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();//Refresh genera el Reporte
        
    }
    }
}
