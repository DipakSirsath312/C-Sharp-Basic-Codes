using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment1_CSharp.net
{
    class Leap_Year
    {
        static void Main(string[] args) {
            System.Console.WriteLine("***Check its Leap Year or Not***");
            System.Console.Write("Enter The Year:-");
            int year = int.Parse(System.Console.ReadLine());
            if (year % 4 == 0)
            {
                System.Console.WriteLine("{0} is Leap Year", year);
            }
            else {
                System.Console.WriteLine("{0} is Not Leap Year",year);
            }
            System.Console.ReadLine();
        }
    }
}
