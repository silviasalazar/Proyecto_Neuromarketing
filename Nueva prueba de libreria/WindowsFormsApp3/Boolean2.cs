using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public static class Booleanos2
    {
        public static double Media(List<double> datos)
        {
            double mayor = 0, menor = 0, media;            
            mayor = datos[0];
            menor = datos[0];
            for (int i = 1; i < datos.Count; i++)
            {
                if (datos[i] > mayor)
                    mayor = datos[i];
                else if (datos[i] < menor)
                    menor = datos[i];
            }
            media = (mayor + menor) / 2;
            return media;
        }

        public static double Media(List<List<double>> matrix)
        {
            double mayor = 0, menor = 0, media;   
            mayor = matrix[0][0];
            menor = matrix[0][0];
            foreach(List<double> row in matrix)
            {
                foreach(double cell in row)
                {
                    if (cell > mayor)
                        mayor = cell;
                    else if (cell < menor)
                        menor = cell;
                }                
            }
            media = (mayor + menor) / 2;
            return media;
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

        public static List<int> BooleanExpresionSum(List<int> expresion1, List<int> expresion2)
        {
            List<int> expresion = new List<int>();
            bool exp1Zeros = true, exp2Zeros = true;
            //Comprobar que no tengan ceros en el
            foreach (int element in expresion1)
            {
                if(element == 0)                
                    exp1Zeros = false;                
            }
            foreach (int element in expresion2)
            {
                if (element == 0)                
                    exp2Zeros = false;                
            }
            //Suma con expresiones sin ceros
            if(exp1Zeros && exp2Zeros)
            {
                int differents = 0, twos1 = 0, twos2 = 0;
                //Ver cuantos elementos diferentes hay entre las listas
                for (int i = 0; i < 4; i++)
                {
                    if (expresion1[i] != expresion2[i])
                        differents++;
                    if (expresion1[i] == 2)                    
                        twos1++;                    
                    else if (expresion2[i] == 2)                    
                        twos2++;                    
                }
                if (differents == 0)                
                    expresion = expresion1;           
                else if(differents == 1 && ((twos1 == 1 && twos2 == 0) || (twos1 == 0 && twos2 == 1)))
                {
                    List<int> temporalExp = new List<int>() { 0, 0, 0, 0 };
                    for (int i = 0; i < 4; i++)
                    {
                        if (expresion1[i] != expresion2[i])
                            temporalExp[i] = 0;
                        else
                            temporalExp[i] = expresion1[i];
                    }
                    expresion = temporalExp;
                }
            }            
            /*Suma con una expresion con un 0 y otra sin 0s
            *              
            */
            else if((exp1Zeros && !exp2Zeros) || (!exp1Zeros && exp2Zeros))
            {
                int differents = 0, twos1 = 0, twos2 = 0;
                //Ver cuantos elementos diferentes hay entre las listas
                for (int i = 0; i < 4; i++)
                {
                    if (expresion1[i] != expresion2[i])
                        differents++;
                    if (expresion1[i] == 2)
                        twos1++;
                    else if (expresion2[i] == 2)
                        twos2++;
                }
                if (differents == 0)
                    expresion = expresion1;
                List<int> temporalExp = new List<int>() { 0, 0, 0, 0 };
                for (int i = 0; i < 4; i++)
                {
                    if (expresion1[i] == 0 || expresion2[i] == 0)
                        temporalExp[i] = 0;
                    else if(expresion1[i] == expresion2[i])
                        temporalExp[i] = expresion1[i];                    
                }
                expresion = temporalExp;
            }
            return expresion;
        }

        public static string AB(List<int> expresionBooleana1, List<int> expresionBooleana2)
        {
            List<int> mov1 = new List<int>();
            List<int> mov2 = new List<int>();
            int c = 0;           
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

        private static void Modificar(List<int> mov1, List<int> mov2, List<int> pol1, List<int> pol2)
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
        private static string VariasVariables(List<int> mov1, List<int> mov2, List<int> pol1, 
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
        private static string UnaVariable(List<int> mov1, List<int> mov2, List<int> pol1, List<int> pol2, int apuntador)
        {
            string res = "";

            List<int> resnum = mov1;
            resnum[apuntador] = 1;            
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

        private static string Iguales(List<int> pol1, List<int> pol2)
        {            
            string res = ""; 
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
            }
            return res;
        }
    }
}