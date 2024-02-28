using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assigement
{
    class Armstrong
    {
        public static void main(string[] args)
        {
            System.Console.WriteLine("***Check The Number Armstrong***");

            int n = 0, j, sum = 0, temp = 0;
            System.Console.Write("Enter The Number:-");
            n = Convert.ToInt16(System.Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                j = n % 10;
                sum = sum + (j * j * j);
                n = n / 10;

            }
            if (temp == sum)
            {
                System.Console.WriteLine("Number Is Armstrong");
            }
            else
            {
                System.Console.WriteLine("Number Is Not Armstrong");
            }
            System.Console.ReadLine();
        }
    }
}