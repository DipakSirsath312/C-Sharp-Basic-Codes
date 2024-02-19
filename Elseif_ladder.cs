using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Condition_Statement
{
    class Elseif_ladder
    {
        static void Main(string[] args)
        {
            System.Console.Write("Enter The button Number:-");
            int Button = Convert.ToInt16(System.Console.ReadLine());
            if (Button == 1) {
                System.Console.WriteLine("Hello");
            }
            else if (Button == 2) {
                System.Console.WriteLine("Ram Ram Bhaiyo System phad denge");
            }
            else if (Button == 3) {
                System.Console.WriteLine("Namste");
            }
            else if (Button == 4) {
                System.Console.WriteLine("Jay Siyaram Bhau");
            }
            else if (Button == 5) {
                System.Console.WriteLine("Congrats You Hacked The NASA");
            }
            else if (Button == 6) {
                System.Console.WriteLine("To Kaise Hai Aap Log");
            }
            else{
                System.Console.WriteLine("Invailid Button");
            }
            System.Console.Read();
        }
    }
}
