using System;

namespace First_Library
{
    public class Calculator
    {
        public int Add(int a,int b)
        {
            return a + b;
        }
        public int Dif(int a, int b)
        {
            return a - b;
        }
        public int Mult(int a, int b)
        {
            return a * b;
        }
        public int Div(int a, int b)
        {
            return a / b;
        }

        public int Pow(int a, int b)
        {
            int c = 1;
            for(int i = 0; i < b; i++)
            {
               c *= a;
            }
            return c;
        }
    }
}
