using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccessArray
{
    class Array_ForeachLoop
    {
        public static void Main(string[] args) {
            int[] numbers = {0, 1, 2, 4 };
            System.Console.WriteLine("Array Elements:-");
            foreach (int num in numbers) {
                System.Console.WriteLine(num);
            }
            System.Console.ReadLine();
        }
    }
}
