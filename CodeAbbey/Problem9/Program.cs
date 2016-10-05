using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem9
{
    class Program
    {
        static void Main(string[] args)
        {
            var amount = int.Parse(Console.ReadLine());
            int[] triangle = new int[amount];

            for(int i = 0; i < amount; i++)
            {
                string[] sides = Console.ReadLine().Split(' ');
                var a = double.Parse(sides[0]);
                var b = double.Parse(sides[1]);
                var c = double.Parse(sides[2]);
                if (a + b >= c && a + c >= b && b + c >= a) { triangle[i] = 1; }
                else { triangle[i] = 0; }
            }
            
            for(int i = 0; i < amount; i++)
            {
                Console.Write("{0} ",triangle[i]);
            }
        }
    }
}
