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
        public FormLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario1, usuario2;
            string contrasena1, contrasena2;

            usuario1 = textBox1.Text;
            contrasena1 = textBox2.Text;
            usuario2 = textBox1.Text;
            contrasena2 = textBox2.Text;


            if (usuario1 == "admin" && contrasena1 == "1234")
            {
                MessageBox.Show("!!!Bienvenido!!!");
                this.Close();
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
            Application.Exit();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

    }
}
