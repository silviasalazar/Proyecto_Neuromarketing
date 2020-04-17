﻿using System;

namespace Suma_de_expresiones_booleanas
{
    class Program
    {
        static void Main(string[] args)
        {
            BooleanExpresionList bel = new BooleanExpresionList();
            bel.Add(new BooleanExpresion(1,1,1,1));
            bel.Add(new BooleanExpresion(1,1,2,1));
            bel.Add(new BooleanExpresion(1,1,1,1));
            bel.Add(new BooleanExpresion(2,1,1,1));
            bel.Add(new BooleanExpresion(1,0,1,1));
            bel.Add(new BooleanExpresion(1,2,1,1));
            bel.Add(new BooleanExpresion(1,0,1,0));
            bel.Add(new BooleanExpresion(1,0,1,2));

            foreach(BooleanExpresion x in bel.Expresions){
                Console.Write(x.ToString() + " + "); 
            }
            Console.WriteLine();
            bel.IterativeSimplify();
            foreach(BooleanExpresion x in bel.Expresions){
                Console.Write(x.ToString() + " + "); 
            }
        }
    }
}