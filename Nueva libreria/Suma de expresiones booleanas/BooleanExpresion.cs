using System.Collections.Generic;

namespace Suma_de_expresiones_booleanas
{
    class BooleanExpresion
    {
        public List<int> ValueList;
        public int A;
        public int B;
        public int C;
        public int D;
        public BooleanExpresion(){
            ValueList = new List<int>();
            A = 0;
            B = 0;
            C = 0;
            D = 0;
        }
        public BooleanExpresion(List<int> values){
            ValueList = values;
            A = 0;
            B = 0;
            C = 0;
            D = 0;
        }
        public BooleanExpresion(int a, int b, int c, int d){
            ValueList = new List<int>(){a,b,c,d};
            A = a;
            B = b;
            C = c;
            D = d;
        }    
        public void SetValues(){
            if(ValueList.Count == 4){
                if(ValueList[0] > -1 && ValueList[0] < 3){
                    A = ValueList[0];
                }
                if(ValueList[1] > -1 && ValueList[1] < 3){
                    B = ValueList[1];
                }
                if(ValueList[2] > -1 && ValueList[2] < 3){
                    C = ValueList[2];
                }
                if(ValueList[3] > -1 && ValueList[3] < 3){
                    D = ValueList[3];
                }
            }
        }
        public override string ToString(){
            string text = "";
            if(A == 1)
                text += "A";
            else if(A == 2)
                text += "!A";
            if(B == 1)
                text += "B";
            else if(B == 2)
                text += "!B";
            if(C == 1)
                text += "C";
            else if(C == 2)
                text += "!C";
            if(D == 1)
                text += "D";
            else if(D == 2)
                text += "!D";                              
            return text;
        }
    }
}
