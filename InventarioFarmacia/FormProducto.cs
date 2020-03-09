using BL.InventarioFarmacia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

            if (fotoPictureBox.Image != null)
            {
                productos.Foto = Program.imageToByteArray(fotoPictureBox.Image);
            }
            else
            {
                productos.Foto = null;
            }


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

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var productos = (Producto)listaProductosBindingSource.Current;

            if (productos !=null)
            {
                openFileDialog1.ShowDialog();
                var archivo = openFileDialog1.FileName;

                if (archivo != "")

                {
                    var fileInfo = new FileInfo(archivo);
                    var fileStream = fileInfo.OpenRead();//leer archivo por partes

                    fotoPictureBox.Image = Image.FromStream(fileStream);

                }
            }

            else
            {
                MessageBox.Show("CREE UN PRODUCTO ANTES DE ASIGNARLE UNA IMAGEN");
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fotoPictureBox.Image = null;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }

}
