using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem26
{
    class Program
    {
        static void Main(string[] args)
        {
            var cases = int.Parse(Console.ReadLine());
            int[] GCD = new int[cases];
            int[] LCM = new int[cases];

            for (int i = 0; i < cases; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);
                while (a != b)
                {
                    if (a > b) { a = a - b; }
                    else { b = b - a; }
                }
                if (a == b)
                {
                    GCD[i] = a;
                    LCM[i] = (int.Parse(input[0]) * int.Parse(input[1])) / GCD[i];
                }
            }
            
            for(int i = 0; i < cases; i++)
            {
                Console.Write("({0} {1}) ",GCD[i],LCM[i]);
            }
        }
    }
}
