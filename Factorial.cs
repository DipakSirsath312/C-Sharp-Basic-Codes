using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment1_CSharp.net
{
    class Factorial
    {
        static void Main(string[] args) {

            System.Console.WriteLine("***Find Factorial of Given Number***");

            int num, fact = 1;
            System.Console.Write("Enter The Any Number:");
            num = Convert.ToInt16(System.Console.ReadLine());
            while (num != 0)
            {
                fact = fact * num;
                num--;
            }
            System.Console.WriteLine("Factorial Number is:-" + fact);
            System.Console.ReadLine();
        }
    }
}
