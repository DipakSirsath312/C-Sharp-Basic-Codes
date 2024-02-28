using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assigement
{
    class SwitchCase
    {
        public static void Main(string[] args) {
            System.Console.WriteLine("***Calculator***");

            int a, b, c = 0, op;
            System.Console.WriteLine("1.Addition\n2.Subtraction\n3.Multiplication\n4.Division");
            System.Console.WriteLine("Enter The Operation Number:-");
            op = Convert.ToInt16(System.Console.ReadLine());
            System.Console.WriteLine("Enter The Two Numbers:-");
            a = Convert.ToInt16(System.Console.ReadLine());
            b = Convert.ToInt16(System.Console.ReadLine());
            switch (op) { 
                case 1:
                    c = a + b;
                    System.Console.WriteLine("Addition=" + c);
                    break;

                case 2:
                    c = a - b;
                    System.Console.WriteLine("Subtraction="+c);
                    break;

                case 3:
                    c = a * b;
                    System.Console.WriteLine("Multiplication="+c);
                    break;

                  
                case 4:
                    c = a / b;
                    System.Console.WriteLine("Division="+c);
                    break;

                default:
                    System.Console.WriteLine("Invailid operation number");
                    break;
            }
            System.Console.ReadLine();
        }
    }
}