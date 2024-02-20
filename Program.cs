using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayFunDemo
{
    class Program
    {
            int[] a = new int[5];
            void input()
            {
               Console.WriteLine("Enter the 5 Elements:");
                for (int i = 0; i < a.Length; i++)
                {
                 a[i] = Convert.ToInt16( Console.ReadLine() );
                }
            }
            void output()
            {
                Console.WriteLine("The Array Elements Are:");
                for (int i = 0; i < a.Length; i++)
                {
                 Console.WriteLine(a[i]);
                }
            }
            void arrayOperations()
            {
                Console.WriteLine("Max No=" + a.Max());
                Console.WriteLine("Min No=" + a.Min());
                Console.WriteLine("Sum =" + a.Sum());
                Console.WriteLine("Average=" + a.Average());
            }
        static void Main(string[] args)
        {
            Program obj = new Program();

            obj.input();
            obj.output();
            obj.arrayOperations();
            Console.Read();
        }
    }
}
