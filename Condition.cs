using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assigement
{
    class Condition
    {
        public static void Main(string[] args)
        {
            int age=0;
            System.Console.WriteLine("Enter The Age:");
            age = Convert.ToInt16(System.Console.ReadLine());
            if (age >= 18)
            {
                System.Console.WriteLine("Allowed For Voting");
            }
            else 
            {
                System.Console.WriteLine("Not Allowed For Voting");
            }
            System.Console.ReadLine();
        }
    }
}
