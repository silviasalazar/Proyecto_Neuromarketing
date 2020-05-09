using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//using Algebra_Booleana;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        string fileRute;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fileRute.Length > 0){
                GenerateDataGridOutput();
            }else{
                GenerateDataGrid();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void GenerateDataGrid()
        {
            List<List<double>> matrix = new List<List<double>>();
            matrix = DataGridViewTo.ListOfListOfDoubles(dataGridViewrValores);
            double media = Booleanos2.Media(matrix);
            MessageBox.Show(media.ToString());
            //Si se selecciona un archivo de salida            
            try
            {
                pgsBarDesarrollo.Maximum = matrix.Count;
                pgsBarDesarrollo.Value = 0;
                pgsBarDesarrollo.Step = 1;
                BooleanExpresionList bel = new BooleanExpresionList();
                for (int i = 0; i < matrix.Count; i++)
                {
                    BooleanExpresion be = new BooleanExpresion(Booleanos2.Polaridad(matrix[i], media));
                    //be.SetValues();
                    bel.Add(be);
                    pgsBarDesarrollo.PerformStep();

                }
                bel.IterativeSimplify();
                // bel.IterativeSimplify();
                txt_res.Text = bel.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.StackTrace);
            }
        }

        private void GenerateDataGridOutput()
        {
            List<List<double>> matrix = new List<List<double>>();
            matrix = DataGridViewTo.ListOfListOfDoubles(dataGridViewrValores);
            double media = Booleanos2.Media(matrix);
            MessageBox.Show(media.ToString());
            //Si se selecciona un archivo de salida            
            try
            {
                pgsBarDesarrollo.Maximum = matrix.Count;
                pgsBarDesarrollo.Value = 0;
                pgsBarDesarrollo.Step = 1;
                BooleanExpresionList bel = new BooleanExpresionList();
                StreamWriter sw = new StreamWriter(fileRute);
                for (int i = 0; i < matrix.Count; i++)
                {
                    BooleanExpresion be = new BooleanExpresion(Booleanos2.Polaridad(matrix[i], media));
                    //be.SetValues();
                    bel.Add(be);
                    sw.WriteLine(be.ToString());
                    pgsBarDesarrollo.PerformStep();

                }
                //bel.SimplifyFromArchive(fileRute, matrix.Count);
                //bel.IterativeSimplify();
                //bel.IterativeSimplify();
                //txt_res.Text = bel.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.StackTrace);
            }
        }

        private void btnCalcularNuevaMedia_Click(object sender, EventArgs e)
        {
            List<List<double>> matrix = new List<List<double>>();
            matrix = DataGridViewTo.ListOfListOfDoubles(dataGridViewrValores);
            double media = Booleanos2.Media(matrix);
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

        private void btnLeerExcel_Click(object sender, EventArgs e)
        {
            try
            {
                //Abre la carpeta de archivos para que se puedan buscar
                openFileDialog1.ShowDialog();
                //si se quiere introducir de forma manual
                textBox1.Text = openFileDialog1.FileName;
                BindDataCSV(textBox1.Text);
            }
            catch (Exception) { }
        }
        private void BindDataCSV(string ubicacion)
        {
            DataTable dt = new DataTable();
            string[] lineas = System.IO.File.ReadAllLines(ubicacion);
            if (lineas.Length > 0)
            {
                //Primera linea (Encabezado)
                string linea = lineas[0];
                string[] encabezados = linea.Split(',');
                foreach (string encabezado in encabezados)
                {
                    dt.Columns.Add(new DataColumn(encabezado));
                }
                //Para los datos
                for (int i = 1; i < lineas.Length; i++)
                {
                    string[] dataWords = lineas[i].Split(',');
                    DataRow dr = dt.NewRow();
                    int columnasContador = 0;
                    foreach (string encabezado in encabezados)
                    {

                        dr[encabezado] = dataWords[columnasContador++];
                    }
                    dt.Rows.Add(dr);
                }
            }
            if (dt.Rows.Count > 0)
            {                
                dataGridViewrValores.DataSource = dt;
            }

        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            fileRute = openFileDialog1.FileName;
            txtBoxOut.Text = fileRute;
        }
    }
}
