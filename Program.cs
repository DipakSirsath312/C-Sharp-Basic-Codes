using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Condition_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Enter The Age:-");
           int age =Convert.ToInt16(System.Console.ReadLine());
            if(age>=18){
                System.Console.WriteLine("Allowed For Voting");
            }else{
                System.Console.WriteLine("Not Allowed For Voting ");
            }
            System.Console.Read();
        }
    }
}
