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
    public partial class FormBienvenida : Form
    {
        public FormBienvenida()
        {
            InitializeComponent();
        }

        private void FormBienvenida_Load(object sender, EventArgs e)
        {
            /*pictureBox1.Image = Image.FromFile(@"C:\Users\salaz\Downloads\giphy");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;*/
            this.Opacity = 0.0;
            timer1.Start();
        }
       // int cont = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            if (this.Opacity < 1) this.Opacity += 0.05;
            progressBar1.Value += 1;
            if(progressBar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if(this.Opacity==0)
            {
                timer2.Stop();
                this.Close();
            }
        }
    }
}
