using System;
using System.Collections.Generic;
using System.Text;

namespace FactorialProject
{
    class Factorial
    {
        public void CalculateFactorial()
        {
            int n;
            double x;
            x = 1;
            Console.WriteLine("Enter a number : ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = n; i > 0; i--)
            {
                x = x * i;
            }

            Console.WriteLine($"Factorial of: {n} is: {x}");
            Console.ReadKey();
        }
    }
}
