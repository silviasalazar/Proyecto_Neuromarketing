using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Algebra_Booleana;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dataGridViewrValores.Rows.Count >= 2) {
                Random num = new Random();

                double suma = 0;
                
                List<double> datos1 =  new List<double>();

                List<double> datos2 = new List<double>();

                List<double> datos12 = new List<double>();

                List<int> pol1 = new List<int>();

                List<int> pol2 = new List<int>();

                //Booleanos boleano = new Booleanos();

                for(int i = 0; i < 4; i++)
                {
                    datos1.Add(Convert.ToDouble(dataGridViewrValores.Rows[0].Cells[i].Value));
                    datos2.Add(Convert.ToDouble(dataGridViewrValores.Rows[1].Cells[i].Value));
                }

                /*
                datos1.Add(5);
                datos1.Add(6);
                datos1.Add(3);
                datos1.Add(5);
                datos2.Add(5);
                datos2.Add(5);
                datos2.Add(5);
                datos2.Add(5);
                */

                for (int i = 0; i < 4; i++)
                {
                    datos12.Add(datos1[i]);
                    datos12.Add(datos2[i]);
                }

                double media = Booleanos.Media(datos12);

                pol1 = Booleanos.Polaridad(datos1, media);

                pol2 = Booleanos.Polaridad(datos2, media);

                txt_res.Text = Booleanos.AB(pol1, pol2);

            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCalcularNuevaMedia_Click(object sender, EventArgs e)
        {
            List<List<double>> matrix = new List<List<double>>();
            matrix = DataGridViewTo.ListOfListOfDoubles(dataGridViewrValores);
            MessageBox.Show(Booleanos.Media(matrix).ToString());
        }


    }
}
