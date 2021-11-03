using First_Library;
using System;

namespace first_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator solve = new();

            Console.Write("Enter first number:  ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number:  ");
            int b = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"{a}+{b}="+solve.Add(a,b));
            Console.WriteLine($"{a}-{b}="+solve.Dif(a,b));
            Console.WriteLine($"{a}*{b}="+solve.Mult(a,b));
            Console.WriteLine($"{a}/{b}="+solve.Div(a,b));
            Console.WriteLine($"{a}^{b}="+solve.Pow(a,b));
        }
    }
}
