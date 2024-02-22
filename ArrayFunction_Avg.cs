using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccessArray
{
    class ArrayFunction_Avg
    {
        public static void Main(string[] args) {
            int[] numbers = { 9, 1, 5, 10, 7 };

            float sum = numbers.Sum();
            int count = numbers.Count();
            float average = sum / count;

            System.Console.WriteLine("Average:-"+average);
            System.Console.WriteLine("Average Using Average():-"+numbers.Average());

            System.Console.ReadLine();
        }
    }
}
