using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Condition_Statement
{
    class If_Else
    {
        static void Main(string[] args)
        {
            System.Console.Write("Enter The Any Number:-");
            int n = Convert.ToInt16(System.Console.ReadLine());
            if (n % 2 == 0){
                System.Console.WriteLine("Number Is Even");
            }else {
                System.Console.WriteLine("Number Is Odd");
            }
            System.Console.Read();
        }
    }
}
