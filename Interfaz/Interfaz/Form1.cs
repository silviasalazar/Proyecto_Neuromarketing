using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtusuario_Enter(object sender, EventArgs e)
        {
            if (txtusuario.Text == "USUARIO")
            {
                txtusuario.Text = "";
                txtusuario.ForeColor = Color.DimGray;
            }

        }

        private void txtusuario_Leave(object sender, EventArgs e)
        {
            if(txtusuario.Text=="")
            {
                txtusuario.Text = "USUARIO";
                txtusuario.ForeColor = Color.DimGray;

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttongenerar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            
            int Numero1 = random.Next(0,10);
            int Numero2 = random.Next(0,10);
            int Numero3 = random.Next(0,10);
            int Numero4 = random.Next(0, 10);
            int Numero5 = random.Next(0, 10);
            int Numero6 = random.Next(0, 10);
            int Numero7 = random.Next(0, 10);
            int Numero8 = random.Next(0, 10);

            
            string[] letras = { "a", "b","c" ,"d","e","f","g","h","i","j","k","l","m","n","o","p","q","r",
            "s","t","u","v","w","x","y","z"};

            txtusuario.Text = Numero1.ToString() + Numero2.ToString() + Numero3.ToString() + Numero4.ToString() +
                Numero5.ToString() + Numero6.ToString() + Numero7.ToString() + Numero8.ToString() + letras[random.Next(0, 25)].ToString() +
                letras[random.Next(0, 25)].ToString()+ letras[random.Next(0, 25)].ToString();

        }

        private void continuar1_Click(object sender, EventArgs e)
        {
            Form formulario2 = new FormBienvenida();
            formulario2.Show();
            
        }
    }
}
