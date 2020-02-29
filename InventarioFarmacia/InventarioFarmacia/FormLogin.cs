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
    public partial class FormLogin : Form
    {
        ClienteBL _cliente;
        ProveedorBL _proveedor;
        SeguridadBL _seguridad;
        public FormLogin()
        {
            InitializeComponent();

            _cliente = new ClienteBL();
            _proveedor = new ProveedorBL();
            _seguridad = new SeguridadBL();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string usuario;         //declaracion de variables usuarios
            string contrasena;   //declaracion de variables contraseñas

            usuario = textBox1.Text;        //la variable usuario1 sera igual a lo que escriba en el tex
            contrasena = textBox2.Text;

            var resultado = _seguridad.Autorizar(usuario, contrasena);


            if (resultado == true)  //comparamos
            {
                MessageBox.Show("!!!Bienvenido Al Sistema De Inventarios!!!");//si la condicion se cumple aparece el mensaje e ingresa
                this.Close(); // este comando cierra el formulario si se cumple
                }
            
            else
                {
                    MessageBox.Show("Usuario o Contrasena incorrecta");
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit(); //cierra el sistema completamente
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
