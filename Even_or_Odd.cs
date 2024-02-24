using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment1_CSharp.net
{
    class Even_or_Odd
    {
        static void Main(string[] args) {

            System.Console.WriteLine("***Check The Number Even And Odd***");
            
            System.Console.Write("Enter The Number:-");
            int num = Convert.ToInt16(System.Console.ReadLine());
            if(num%2==0){
                System.Console.WriteLine("Number is Even");
            }
            else{
                System.Console.WriteLine("Number is odd");
            }
            System.Console.ReadLine();
        }
    }
}
