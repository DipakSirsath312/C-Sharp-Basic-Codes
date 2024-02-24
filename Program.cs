using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment1_CSharp.net
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("***Operation in Single Code***");
            int a, b,c;
            System.Console.Write("Eneter The First Number:-");
            a = Convert.ToInt16(System.Console.ReadLine());
            System.Console.Write("Eneter The second Number:-");
            b = Convert.ToInt16(System.Console.ReadLine());
           
            c = a + b;
            System.Console.WriteLine("Addition:-"+c);
            c = a - b;
            System.Console.WriteLine("Subtraction:-"+c);
            c = a * b;
            System.Console.WriteLine("Multiplication:-"+c); 
            c = a / b;
            System.Console.WriteLine("Division:-"+c);

            System.Console.ReadLine();
        }
    }
}
