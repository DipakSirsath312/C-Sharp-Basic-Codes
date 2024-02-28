using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assigement
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter The Values:");
            int a = Convert.ToInt16(System.Console.ReadLine());
            int b = Convert.ToInt16(System.Console.ReadLine());
            int c = a + b;
            System.Console.WriteLine("Addition="+c);

            System.Console.ReadLine();
        }
        
    }
}
