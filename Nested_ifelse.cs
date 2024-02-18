using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Condition_Statement
{
    class Nested_ifelse
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter The Two values:");
            int a = Convert.ToInt16(System.Console.ReadLine());
            int b = Convert.ToInt16(System.Console.ReadLine());
            if (a == b)
            {
                System.Console.WriteLine("Values Is Equal");
            }
            else {
                if (a > b)
                {
                    System.Console.WriteLine("A is Greater");
                }
                else {
                    System.Console.WriteLine("A is Less Than");
                }
            }
            System.Console.ReadLine();
        }
    }
}
