using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp3
{
    class BooleanExpresionList
    {
        public List<BooleanExpresion> Expresions;

        public BooleanExpresionList()
        {
            Expresions = new List<BooleanExpresion>();
        }

        public void Add(BooleanExpresion booleanExpresion)
        {
            List<BooleanExpresion> temp = Expresions;
            for (int i = 0; i < Expresions.Count; i++)
            {
                if (BooleanLibrary.AreReducible(Expresions[i], booleanExpresion))
                {
                    temp[i] = BooleanLibrary.Reduction(Expresions[i], booleanExpresion);
                    return;
                }
            }
            Expresions.Add(booleanExpresion);
        }
        public void Add2(BooleanExpresion booleanExpresion)
        {
            Expresions.Add(booleanExpresion);
        }

        public void SimplificaExpRepetidas()
        {
            List<BooleanExpresion> Temp = new List<BooleanExpresion>();
            Temp.Add(Expresions[0]);
            bool ExpRepetida = false;

            for (int i = 1; i < Expresions.Count; i++)
            {
                for(int k = 0; k < Temp.Count; k++)
                {
                    if (BooleanLibrary.BothEqual(Expresions[i].ValueList , Temp[k].ValueList))
                    {
                        ExpRepetida = true;
                        break;
                    }
                }
                if (ExpRepetida==false) Temp.Add(Expresions[i]);
                ExpRepetida = false;
            }
            Expresions = Temp;
            MessageBox.Show("Expresiones reducidas a: "+Expresions.Count.ToString());
        }

        public void Simplify()
        {
            for (int i = 0; i < Expresions.Count - 1; i++)
            {
                for (int j = i + 1; j < Expresions.Count; j++)
                {
                    if (BooleanLibrary.AreReducible(Expresions[i], Expresions[j]))
                    {
                        Expresions[i] = BooleanLibrary.Reduction(Expresions[i], Expresions[j]);
                        Expresions.RemoveAt(j);
                    }
                }
            }
        }

        public void SimplifyFromArchive(string fileRoute, int limit)
        {
            StreamReader sr = new StreamReader(fileRoute);
            for (int i = 0; i < Expresions.Count - 1; i++)
            {
                for (int j = i + 1; j < Expresions.Count; j++)
                {
                    if (BooleanLibrary.AreReducible(Expresions[i], Expresions[j]))
                    {
                        Expresions[i] = BooleanLibrary.Reduction(Expresions[i], Expresions[j]);
                        Expresions.RemoveAt(j);
                    }
                }
            }
        }

        public void IterativeSimplify()
        {
            int error, previus = Expresions.Count;
            Simplify();
            error = Expresions.Count - previus;
            while (error != 0)
            {
                previus = Expresions.Count;
                Simplify();
                error = Expresions.Count - previus;
            }
        }

        public override string ToString()
        {
            string text = "";
            for(int i = 0; i < Expresions.Count - 1; i++)
            {
                text += Expresions[i].ToString();
                text += " + ";
            }
            text += Expresions[Expresions.Count - 1];
            return text;
        }
    }
}
