using System;

namespace FactorialProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose sub-program to run\n");
            Console.WriteLine("(1) Factorial");
            Console.WriteLine("(2) Decimal Number Conversions");
            Console.WriteLine("(3) Greatest Common Disvisor");
            Console.WriteLine("(4) Fibonacci Sequence to n places");
            Console.WriteLine("(5) Tower of Hanoi solutions");
            Console.WriteLine("(6) Quit");

            int s = Convert.ToInt32(Console.ReadLine());

            switch (s)
            {
                case 1:
                    Factorial f = new Factorial();
                    f.CalculateFactorial();
                    break;
                case 2:
                    DecimalNumber dn = new DecimalNumber();
                    dn.DecimalToBinary();
                    break;
                case 3:
                    Divisor d = new Divisor();
                    d.GreatestCommonDivisor();
                    break;
                case 4:
                    int p;
                    Fibonacci fi = new Fibonacci();
                    Console.WriteLine("Enter places to calculate to :");
                    p = Convert.ToInt32(Console.ReadLine());
                    fi.Fibonacci_Iterative(p);
                    break;
                case 5:

                    Hanoi t = new Hanoi();
                    string c_numdisc;

                    Console.Clear();
                    t.Introduction();

                    Console.WriteLine("\nEnter the number of discs : ");
                    c_numdisc = Console.ReadLine();
                    t.discnums = Convert.ToInt32(c_numdisc);
                    t.movetower(t.discnums, 1, 3, 2);                                                            
                    break;
                case 6:
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }

            

            
            
        }

        
    }
}
