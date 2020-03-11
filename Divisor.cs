using System;
using System.Collections.Generic;
using System.Text;

namespace FactorialProject
{
    class Divisor
    {
        int x;
        public void GreatestCommonDivisor()
        {
            int m,n1,n2;            
            Console.WriteLine("Enter a number : ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second number : ");
            n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2) 
            {
                m = n1;
            }
            else
            {
                m = n2;
            }

            for (int i = m; i >= 1; i--)
            {


                if (n1 % i == 0 && n2 % i == 0)
                {

                    x = i;
                    break;
                }
                
            }
            Console.WriteLine("\nGCD = " + x);

        }
    }
}
    

