using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccessArray
{
    class ForLoopArray
    {
        public static void Main(string[] args) {
            int[] numbers = { 1, 2,4 };
            for (int i = 0; i < numbers.Length; i++) {
                System.Console.WriteLine("Element in index"+i+":"+numbers[i]);
            }
            System.Console.ReadLine();
        }
    }
}
