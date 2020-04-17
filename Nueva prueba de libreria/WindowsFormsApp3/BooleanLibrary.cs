﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class BooleanLibrary
    {
        public static bool AreReducible(List<int> expresion1, List<int> expresion2)
        {
            bool isComplete1 = true, isComplete2 = true;
            /*
                --completa: expresion sin ningún 0;
                --no completa: expresion con algún cero.
                --similares: expresiones no completas, en las que las variables con valor 0
                están en la misma posición en ambas.

                Condicion 1: expresiones completas, iguales, todas las variables positivas.
                Condicion 2: expresiones completas, en las cuales una cuenta con una variable negativa.
                Condicion 3: expresion completa y no completa, en la cual no tienen cantidades negativas.
                Condicion 4: expresiones similares, ambas positivas
                Condicion 5: expresiones similares, en las cuales una cuenta con una variable negativa.
            */

            //Comprobar que las expresiones sean completas
            foreach (int element in expresion1)
            {
                if (element == 0)
                    isComplete1 = false;
            }
            foreach (int element in expresion2)
            {
                if (element == 0)
                    isComplete2 = false;
            }
            //Expresiones completas
            if (isComplete1 && isComplete2)
            {
                //Comprobar si todas las variables son positivas                            
                if (BothPositive(expresion1, expresion2)) return true;
                //Comprobar si una variable es negativa
                else if (AlmostOneNegative(expresion1, expresion2)) return true;
            }

            //Una expresion completa y una incompleta en la cual no tienen cantidades negativas.
            else if ((isComplete1 && !isComplete2) || (!isComplete1 && isComplete2))
            {
                if (BothPositive(expresion1, expresion2)) return true;
            }

            //Si las expresiones son incompletas
            else if (!isComplete1 && !isComplete2)
            {
                bool similarity = true;
                for (int i = 0; i < 4; i++)
                    if ((expresion1[i] == 0 && expresion2[i] != 0) || (expresion1[i] != 0 && expresion2[i] == 0))
                        similarity = false;
                //Expresiones similares
                if (similarity)
                {
                    //Si ambas son positivas
                    if (BothPositive(expresion1, expresion2)) return true;
                    //Si hay una negativa
                    else if (AlmostOneNegative(expresion1, expresion2)) return true;
                }
            }
            return false;
        }

        public static bool AreReducible(BooleanExpresion be1, BooleanExpresion be2)
        {
            return AreReducible(be1.ValueList, be2.ValueList);
        }

        private static bool BothPositive(List<int> expresion1, List<int> expresion2)
        {
            bool condition = true;
            for (int i = 0; i < 4; i++)
                if (expresion1[i] == 2 || expresion2[i] == 2)
                    condition = false;
            return condition;
        }

        private static bool AlmostOneNegative(List<int> expresion1, List<int> expresion2)
        {
            int negatives = 0;
            for (int i = 0; i < 4; i++)
                if (expresion1[i] == 2 || expresion2[i] == 2)
                    negatives++;
            if (negatives == 1) return true;
            else return false;
        }

        public static BooleanExpresion Reduction(List<int> expresion1, List<int> expresion2)
        {
            bool isComplete1 = true, isComplete2 = true;
            BooleanExpresion be = new BooleanExpresion();
            //Comprobar que las expresiones sean completas
            foreach (int element in expresion1)
            {
                if (element == 0)
                    isComplete1 = false;
            }
            foreach (int element in expresion2)
            {
                if (element == 0)
                    isComplete2 = false;
            }
            //Expresiones completas
            if (isComplete1 && isComplete2)
            {
                //Comprobar si todas las variables son positivas                            
                if (BothPositive(expresion1, expresion2))
                {
                    be.ValueList = expresion1;
                    be.SetValues();
                    return be;
                }
                //Comprobar si una variable es negativa
                else if (AlmostOneNegative(expresion1, expresion2))
                {
                    List<int> list = new List<int> { 1, 1, 1, 1 };
                    for (int i = 0; i < 4; i++)
                        if (expresion1[i] == 2 || expresion2[i] == 2)
                            list[i] = 0;
                    be.ValueList = list;
                    be.SetValues();
                    return be;
                }
            }

            //Una expresion completa y una incompleta en la cual no tienen cantidades negativas.
            else if ((isComplete1 && !isComplete2) || (!isComplete1 && isComplete2))
            {
                if (BothPositive(expresion1, expresion2))
                {
                    if (isComplete1)
                    {
                        be.ValueList = expresion2;
                        be.SetValues();
                        return be;
                    }
                    else
                    {
                        be.ValueList = expresion1;
                        be.SetValues();
                        return be;
                    }
                }
            }

            //Si las expresiones son incompletas
            else if (!isComplete1 && !isComplete2)
            {
                //Si ambas son positivas
                if (BothPositive(expresion1, expresion2))
                {
                    be.ValueList = expresion1;
                    be.SetValues();
                    return be;
                }
                //Si hay una negativa
                else if (AlmostOneNegative(expresion1, expresion2))
                {
                    List<int> list = expresion1;
                    for (int i = 0; i < 4; i++)
                        if (expresion1[i] == 2 || expresion2[i] == 2)
                            list[i] = 0;
                    be.ValueList = list;
                    be.SetValues();
                    return be;
                }
            }


            return be;
        }

        public static BooleanExpresion Reduction(BooleanExpresion be1, BooleanExpresion be2)
        {
            return Reduction(be1.ValueList, be2.ValueList);
        }
    }
}
