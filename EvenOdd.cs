using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assigement
{
    class EvenOdd
    {
        public static void Main(string[] args) {
            System.Console.WriteLine("***Check The Even&Odd Number***");

            int n = 0;
            System.Console.Write("Enter a Any number:");
            n = Convert.ToInt16(System.Console.ReadLine());
            if (n % 2 == 0)
            {
                System.Console.WriteLine("Number is Even:-" + n);
            }
            else {
                System.Console.WriteLine("Number is Odd:-"+n);
            }
            System.Console.ReadLine();
        }
    }
}
