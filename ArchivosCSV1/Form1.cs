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
using System.Data.OleDb;




namespace ArchivosCSV1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Abre la carpeta de archivos para que se puedan buscar
            openFileDialog1.ShowDialog();
            //si se quiere introducir de forma manual
            textBox1.Text = openFileDialog1.FileName;
            BindDataCSV(textBox1.Text);
        }
        private void BindDataCSV(string ubicacion)
        {
            DataTable dt = new DataTable();
            string[] lineas = System.IO.File.ReadAllLines(ubicacion);
            if(lineas.Length>0)
            {
                //Primera linea (Encabezado)
                string linea = lineas[0];
                string[] encabezados = linea.Split(',');
                foreach(string encabezado in encabezados)
                {
                    dt.Columns.Add(new DataColumn(encabezado));
                }
                //Para los datos
                for(int i=1;i<lineas.Length;i++)
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
            if(dt.Rows.Count>0)
            {
                dataGridView1.DataSource = dt;
            }
            
        }
    }
}
