using System;
using System.Collections.Generic;
using System.Text;

namespace FactorialProject
{
    class Hanoi
    {
        int num_discs;
        public void Introduction() 
        {
            Console.WriteLine("The Tower of Hanoi is a set of disks");
            Console.WriteLine("on a rod with the smaller disks on top");
            Console.WriteLine("The disks must be moved from rod 1 to rod 3");
            Console.WriteLine("You can only move one disk at a time and");
            Console.WriteLine("a larger disk cannot be placed on a smaller one");
            Console.WriteLine("           |           |             |         ");
            Console.WriteLine("          ---          |             |         ");
            Console.WriteLine("         ------        |             |         ");
            Console.WriteLine("      -----------      |             |         ");
            Console.WriteLine("_______________________________________________");
            Console.WriteLine("            A          B             C         ");
        }

        public void Towerofhanoi() 
        {
            num_discs = 0;
        }

        public void Towerofhanoi(int newvalue) 
        {
            num_discs = newvalue;
        }

        public int discnums 
        {
            get
            {
                return num_discs;
            }
            set
            {
                if (value > 0)
                    num_discs = value;
            }
        }

        public void movetower(int i, int from, int to, int other)
        {
            if (i > 0) 
            {
                movetower(i - 1, from, other, to);
                Console.WriteLine("Move disk {0} from tower {1} to tower {2}", i, from, to);
                movetower(i - 1, other, to, from);
            }
        }
    }
}
