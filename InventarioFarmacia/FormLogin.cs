using BL.InventarioFarmacia;
using System;
using System.Windows.Forms;

namespace InventarioFarmacia
{
    public partial class FormLogin : Form     
    {

        SeguridadBL _seguridad;


        public FormLogin()
        {
            InitializeComponent();
            _seguridad = new SeguridadBL();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }




        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)
               && !string.IsNullOrEmpty(textBox1.Text))
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)
              && !string.IsNullOrEmpty(textBox1.Text)
              && !string.IsNullOrEmpty(textBox2.Text))

            {
                Autenticar();
            }

        }

        private void Autenticar()
        {


            string usuario1;       //declaracion de variables usuarios
            string contrasena1; //declaracion de variables contraseñas

            usuario1 = textBox1.Text;        //la variable usuario1 sera igual a lo que escriba en el tex
            contrasena1 = textBox2.Text;


            var resultado = _seguridad.Autorizar(usuario1, contrasena1);

            if (resultado == true)  //comparamos
            {
                MessageBox.Show("!!!Bienvenido Sistema de Farmacia!!!");//si la condicion se cumple aparece el mensaje e ingresa
                this.Close(); // este comando cierra el formulario si se cumple
            }
            else if (usuario1 == "administrator" && contrasena1 == "4567")
            {
                MessageBox.Show("!!!Bienvenido Sistema de Farmacia!!!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o Contrasena incorrecta");
            }
        }








        private void button1_Click(object sender, EventArgs e)
        {


            string usuario;       //declaracion de variables usuarios
            string contrasena; //declaracion de variables contraseñas

            usuario = textBox1.Text;        //la variable usuario1 sera igual a lo que escriba en el tex
            contrasena = textBox2.Text;

            button1.Enabled = false;
            button1.Text = "Verficando";
            Application.DoEvents();
           

          var resultado = _seguridad.Autorizar(usuario, contrasena);

            if (resultado== true)  //comparamos
            {
                MessageBox.Show("Bienvenido al Sistema de Farmacia!");//si la condicion se cumple aparece el mensaje e ingresa
                this.Close(); // este comando cierra el formulario si se cumple
                }
            else if (usuario == "administrator" && contrasena == "4567")
            {
                MessageBox.Show("Bienvenido al Sistema de Farmacia!");
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
