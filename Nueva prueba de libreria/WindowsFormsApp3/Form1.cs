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
            List<List<double>> matrix = new List<List<double>>();
            matrix = DataGridViewTo.ListOfListOfDoubles(dataGridViewrValores);
            double media = Booleanos.Media(matrix);
            MessageBox.Show(media.ToString());
            try
            {
                BooleanExpresionList bel = new BooleanExpresionList();
                for (int i = 0; i < matrix.Count; i++)
                {
                    BooleanExpresion be = new BooleanExpresion(Booleanos2.Polaridad(matrix[i], media));
                    //be.SetValues();
                    bel.Add(be);
                }
                bel.IterativeSimplify();
                // bel.IterativeSimplify();
                txt_res.Text = bel.ToString();
            }
            catch(Exception exception)
            {
                MessageBox.Show("Ocurrió un error inesperado");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCalcularNuevaMedia_Click(object sender, EventArgs e)
        {
            List<List<double>> matrix = new List<List<double>>();
            matrix = DataGridViewTo.ListOfListOfDoubles(dataGridViewrValores);
            double media = Booleanos.Media(matrix);
            MessageBox.Show(media.ToString());
            if (dataGridViewrValores.Rows.Count >= 2)
            {
                BooleanExpresionList bel = new BooleanExpresionList();
                for(int i = 0; i < matrix.Count; i++)
                {
                    BooleanExpresion be = new BooleanExpresion(Booleanos2.Polaridad(matrix[i], media));
                    //be.SetValues();
                    bel.Add(be);
                }
                bel.IterativeSimplify();
                // bel.IterativeSimplify();
                txt_res.Text = bel.ToString();
            }

        }


    }
}
