using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assigement
{
    class Fibbonaci_Series
    {
        public static void Main(string[] args)
        {
        System.Console.WriteLine("Print The Fibbonaci Series");

        int a = 0,b = 1,c = 0,n = 0,i;
        System.Console.WriteLine("Enter A Number:");
        n = Convert.ToInt16(System.Console.ReadLine());

        System.Console.WriteLine(a + "\n" +b);
        for(i = 3; i<= n; i++)
        {
            c = a + b;
            System.Console.Write("\n"+c);
            
            a = b;
            b = c;
        }
        System.Console.Read();


        }
    }
}
