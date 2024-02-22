using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccessArray
{
    class ChangeArray
    {
        public static void Main(string[] args) {

            int[] numbers = {1,2,3};
            System.Console.WriteLine("Old value at Index 0:-"+numbers[1]);

            numbers[1]= 11;
            System.Console.WriteLine("New Value At Index 0:-"+numbers[1]);

            Console.ReadLine();
        }
    }
}
