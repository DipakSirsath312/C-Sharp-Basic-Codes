using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccessArray
{
    class MiniMaxi_Array
    {
        public static void Main(string[] args) {
            int[] numbers = { 51, 1, 3, 4, 98 };

            System.Console.WriteLine("Largest Element:-"+numbers.Max());
            System.Console.WriteLine("Smallest Element:-"+numbers.Min());

            System.Console.ReadLine();
        }
    }
}
