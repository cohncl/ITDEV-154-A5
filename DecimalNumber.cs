using System;
using System.Collections.Generic;
using System.Text;

namespace FactorialProject
{
    class DecimalNumber
    {
        public void DecimalToBinary()
        {
            int value;
            string answer;
            while(true)
            {
                Console.Clear();
                Console.WriteLine("Enter you decimal number : ");
                value = Convert.ToInt32(Console.ReadLine());
                string binary = Convert.ToString(value, 2);
                Console.WriteLine("\nBinary : " + binary);
                string hexValue = value.ToString("X");
                Console.WriteLine("Hexadecimal : " + hexValue);
                string octal = Convert.ToString(value, 8);
                Console.WriteLine("Octal : " + octal);

                Console.WriteLine("\nPress 'y' to calculate again");
                answer = Console.ReadLine();

                if (answer != "y")
                    break;

            }

            
        }
    }
}
