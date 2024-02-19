using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Condition_Statement
{
    class Switch_Case
    {
        static void Main(string[] args)
        {
            System.Console.Write("Enter The Button:-");
            int Button = Convert.ToInt16(System.Console.ReadLine());
            switch (Button) {
                case 1:
                    System.Console.WriteLine("Are Baba tu jare");
                    break;

                case 2:
                    System.Console.WriteLine("Your Are Selected");
                    break;

                case 3:
                    System.Console.WriteLine("Anuradha teri behen hai");
                    break;

                case 4:
                    System.Console.WriteLine("25 Din Mai Paisa Doubble");
                    break;

                case 5:
                    System.Console.WriteLine("Mast Plan hai");
                    break;

                case 6:
                    System.Console.WriteLine("Behen Dar gai,Behen Dar gai...");
                    break;

                case 7:
                    System.Console.WriteLine("Sath Nibhana Sathiya...Gopi Bahu Kitchen Mai Kon Tha!");
                    break;

                default:
                    System.Console.WriteLine("Number Dekh ke Dal Be");
                    break;           
            }
            System.Console.ReadLine();
        }
    }
}
