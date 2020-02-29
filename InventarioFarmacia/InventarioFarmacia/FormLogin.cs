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
        public FormLogin()
        {
            InitializeComponent();
            _cliente = new ClienteBL();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string usuario1, usuario2;         //declaracion de variables usuarios
            string contrasena1, contrasena2;   //declaracion de variables contraseñas

            usuario1 = textBox1.Text;        //la variable usuario1 sera igual a lo que escriba en el tex
            contrasena1 = textBox2.Text;
            usuario2 = textBox1.Text;
            contrasena2 = textBox2.Text;


            if (usuario1 == "admin" && contrasena1 == "1234")  //comparamos
            {
                MessageBox.Show("!!!Bienvenido!!!");//si la condicion se cumple aparece el mensaje e ingresa
                this.Close(); // este comando cierra el formulario si se cumple
                }
            else if (usuario2 == "administrator" && contrasena2 == "4567")
            {
                MessageBox.Show("!!!Bienvenido!!!");
                this.Close();
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
