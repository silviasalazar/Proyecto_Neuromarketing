using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    static class DataGridViewTo
    {
        public static List<List<double>> ListOfListOfDoubles(DataGridView dataGridView) // Convertir un dataGridView a una matriz de doubles
        {
            List<List<double>> matrix = new List<List<double>>();
            foreach(DataGridViewRow row in dataGridView.Rows)
            {
                List<double> doubles = new List<double>();
                foreach(DataGridViewCell cell in row.Cells)
                {
                    //Por si la última fila de la tabla está en blanco
                    if (cell.Value == null) break;
                    double doubleCellValue = Convert.ToDouble(cell.Value.ToString());
                    doubles.Add(doubleCellValue);
                }
                matrix.Add(doubles);
            }
            if(matrix[0].Count != matrix.Count)            
                matrix.RemoveAt(matrix.Count - 1);            
            return matrix;
        }
    }
}
