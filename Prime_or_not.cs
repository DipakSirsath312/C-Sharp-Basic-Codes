using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment1_CSharp.net
{
    class Prime_or_not
    {
        static void Main(string[] args) {
            System.Console.WriteLine(" ***Check Prime Number Program***");
            int n = 0, i, f = 1;

            System.Console.Write("Enter Any Number:-");
            n = Convert.ToInt16(System.Console.ReadLine());

            if (n == 1)
            {
                f = 1;
            }
            else
            {
                for (i = 2; i < n; i++)

                    if (n % 1 == 0)
                    {

                        f = 0;
                        break;
                    }
                    else
                    {
                        for (i = 2; i < n; i++)
                        {
                            if (n % i == 0)
                            {

                                f = 0;
                                break;
                            }
                        }
                    }
                if (f == 1)
                {
                    System.Console.WriteLine("Number is a prime");
                }
                else
                {
                    System.Console.WriteLine("Number is a Not Prime");
                }
                System.Console.ReadLine();
            }

        }
    }
}
