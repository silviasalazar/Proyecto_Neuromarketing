using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public static class Booleanos
    {
        public static double Media(List<double> datos)
        {
            double Mayor = 0, Menor = 0, Media;
            /*
             * Aquí me pareció que para evitar el if 
             * mejor asigna los valores antes y empieza
             * el ciclo desde 1 en vez de 0
             */
            /*
           for (int i = 0; i < datos.Count; i++)
           {
               if (i == 0)
               {
                   Mayor = datos[i];
                   Menor = datos[i];
               }
               else if (datos[i] > Mayor)
                   Mayor = datos[i];
               else if (datos[i] < Menor)
                   Menor = datos[i];
           }
           */
            Mayor = datos[0];
            Menor = datos[0];
            for (int i = 1; i < datos.Count; i++)
            {
                if (datos[i] > Mayor)
                    Mayor = datos[i];
                else if (datos[i] < Menor)
                    Menor = datos[i];
            }
            Media = (Mayor + Menor) / 2;
            return Media;
        }

        public static List<int> Polaridad(List<double> datos, double media)
        {
            List<int> pol = new List<int>();

            for (int i = 0; i < datos.Count; i++)
            {
                if (datos[i] >= media)
                    pol.Add(1);
                else
                    pol.Add(2);
            }

            return pol;
        }

        public static string AB(List<int> expresionBooleana1, List<int> expresionBooleana2)
        {
            List<int> mov1 = new List<int>();
            List<int> mov2 = new List<int>();
            int c = 0;
            //int apuntador = 0;
            //Esta lista sirve para indicar que variables se van a eliminar
            //a la hora de la simplificación
            List<int> variablesEliminadas = new List<int>();

            for (int i = 0; i < expresionBooleana1.Count; i++)
            {
                //Si tienen los mismos valores entonces no se pueden cancelar
                if (expresionBooleana1[i] == expresionBooleana2[i])
                {
                    mov1.Add(0);
                    mov2.Add(0);
                    // C = c+1 es lo mismo que c++
                    c++;
                }
                //En este caso como tienen valores diferentes se van a cancelar
                else
                {
                    mov1.Add(expresionBooleana1[i]);
                    mov2.Add(expresionBooleana2[i]);
                    variablesEliminadas.Add(i);
                }
            }

            //Si hay una variable diferente se puede cancelar
            if (c == 3)
                return UnaVariable(mov1, mov2, expresionBooleana1, expresionBooleana2, variablesEliminadas[0]);
            else if (c == 0)
                return Iguales(expresionBooleana1, expresionBooleana2);
            else
                return VariasVariables(mov1, mov2, expresionBooleana1, expresionBooleana2, variablesEliminadas);
        }

        public static void Modificar(List<int> mov1, List<int> mov2, List<int> pol1, List<int> pol2)
        {
            for (int i = 0; i < pol1.Count; i++)
            {
                if (mov1[i] != 0)
                    pol1[i] = 0;
                if (mov2[i] != 0)
                    pol2[i] = 0;
            }
        }

        //Método por si se eliminan varias variables
        public static string VariasVariables(List<int> mov1, List<int> mov2, List<int> pol1, 
            List<int> pol2, List<int> variablesAEliminar)
        {
            string resultado = "";
            /*Si todas las variables quedan con signos diferentes eso quiere decir
             * que cumple la regla A + !A = 1
            */
            if (variablesAEliminar.Count == 4)
            {
                Modificar(mov1, mov2, pol1, pol2);
                return "1";
            }
            List<int> resnum = mov1;
            foreach(int apuntador in variablesAEliminar)
            {
                resnum[apuntador] = 1;
            }            
            for(int i =0; i< pol1.Count; i++)
            {
                if (resnum[i] != 1 && pol1[i] == 1)
                {
                    if (i == 0)
                        resultado = "A";
                    else if (i == 1)
                        resultado += "B";
                    else if (i == 2)
                        resultado += "C";
                    else if (i == 3)
                        resultado += "D";
                }
                else if (resnum[i] != 1 && pol1[i] == 2)
                {
                    if (i == 0)
                        resultado = "!A";
                    else if (i == 1)
                        resultado += "!B";
                    else if (i == 2)
                        resultado += "!C";
                    else if (i == 3)
                        resultado += "!D";
                }
            }
            Modificar(mov1, mov2, pol1, pol2);
            return resultado;
        }

        //Método por si se elimina una variables
        public static string UnaVariable(List<int> mov1, List<int> mov2, List<int> pol1, List<int> pol2, int apuntador)
        {
            string res = "";

            List<int> resnum = mov1;
            resnum[apuntador] = 1;
            /*
            for (int i = 0; i < resnum.Count; i++)
            {
                switch (i)
                {
                    case 0:
                        if (resnum[i] != 1 && pol1[i] == 1)
                            res = "A";
                        else if (resnum[i] != 1 && pol1[i] == 2)
                            res = "A'";
                        break;
                    case 1:
                        if (resnum[i] != 1 && pol1[i] == 1)
                            res = res + "B";
                        else if (resnum[i] != 1 && pol1[i] == 2)
                            res = res + "B'";
                        break;
                    case 2:
                        if (resnum[i] != 1 && pol1[i] == 1)
                            res = res + "C";
                        else if (resnum[i] != 1 && pol1[i] == 2)
                            res = res + "C'";
                        break;
                    case 3:
                        if (resnum[i] != 1 && pol1[i] == 1)
                            res = res + "D";
                        else if (resnum[i] != 1 && pol1[i] == 2)
                            res = res + "D'";
                        break;
                }
            }           
            */
            for (int i = 0; i < resnum.Count(); i++)
            {
                //Todos los casos tienen los mismos ifs entonces pongo el if primero
                //Como los dos casos son lo mismo en todos las opciones todo lo pongo 
                //en el mismo bloque pero modifico la condición para que acepte los 
                //dos
                if (resnum[i] != 1 && pol1[i] == 1 )
                {
                    if (i == 0)
                        res = "A";
                    else if (i == 1)
                        res += "B";
                    else if (i == 2)
                        res += "C";
                    else if (i == 3)
                        res += "D";
                }else if(resnum[i] != 1 && pol1[i] == 2)
                {
                    if(i == 0)
                        res = "!A";
                    else if (i == 1)
                        res += "!B";
                    else if (i == 2)
                        res += "!C";
                    else if (i == 3)
                        res += "!D";
                }
            }
            Modificar(mov1, mov2, pol1, pol2);
            return res;
        }

        public static string Iguales(List<int> pol1, List<int> pol2)
        {
            
            string res = "";
            
            //string res2 = "";
            

            /*
            for (int i = 0; i < pol1.Count; i++)
            {
                switch (i)
                {
                    case 0:
                        if (pol1[i] != 0 && pol1[i] == 1)
                            res1 = "A";
                        else if (pol1[i] != 0 && pol1[i] == 2)
                            res1 = "A'";

                        if (pol2[i] != 0 && pol2[i] == 1)
                            res2 = "A";
                        else if (pol2[i] != 0 && pol2[i] == 2)
                            res2 = "A'";
                        break;
                    case 1:
                        if (pol1[i] != 0 && pol1[i] == 1)
                            res1 = res1 + "B";
                        else if (pol1[i] != 0 && pol1[i] == 2)
                            res1 = res1 + "B'";

                        if (pol2[i] != 0 && pol2[i] == 1)
                            res2 = res2 + "B";
                        else if (pol2[i] != 0 && pol2[i] == 2)
                            res2 = res2 + "B'";
                        break;
                    case 2:
                        if (pol1[i] != 0 && pol1[i] == 1)
                            res1 = res1 + "C";
                        else if (pol1[i] != 0 && pol1[i] == 2)
                            res1 = res1 + "C'";

                        if (pol2[i] != 0 && pol2[i] == 1)
                            res2 = res2 + "C";
                        else if (pol2[i] != 0 && pol2[i] == 2)
                            res2 = res2 + "C'";
                        break;
                    case 3:
                        if (pol1[i] != 0 && pol1[i] == 1)
                            res1 = res1 + "D";
                        else if (pol1[i] != 0 && pol1[i] == 2)
                            res1 = res1 + "D'";

                        if (pol2[i] != 0 && pol2[i] == 1)
                            res2 = res2 + "D";
                        else if (pol2[i] != 0 && pol2[i] == 2)
                            res2 = res2 + "D'";
                        break;
                }
            }*/
            /*Igual que en el otro método, cambie todo por el mismo motivo
             * Otra cosa, si pol1[i] == 0, nunca va a ser igual a 1 o a 2, por eso quité eso
             * Otra cosa res = res + "A" se simplifica como res += "A"
              */

            for (int i = 0; i < pol1.Count(); i++)
            {
                if (pol1[i] == 1)
                {
                    if (i == 0)
                        res = "A";
                    else if (i == 1)
                        res += "B";
                    else if (i == 2)
                        res += "C";
                    else if (i == 3)
                        res += "D";
                }else if(pol1[i] == 2)
                {
                    if (i == 0)
                        res = "!A";
                    else if (i == 1)
                        res += "!B";
                    else if (i == 2)
                        res += "!C";
                    else if (i == 3)
                        res += "!D";
                }
                /*
                if (pol2[i] == 1 || pol2[i] == 2)
                {
                    if (i == 0)
                        res2 = "A";
                    else if (i == 1)
                        res2 += "B";
                    else if (i == 2)
                        res2 += "C";
                    else if (i == 3)
                        res2 += "D";
                }*/
            }
            //string res = res1 + " + " + res2;
            return res;
        }
    }
}