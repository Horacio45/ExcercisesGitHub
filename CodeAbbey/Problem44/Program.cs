using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem44
{
    class Program
    {
        static void Main(string[] args)
        {
            var cases = int.Parse(Console.ReadLine());
            int[] roll = new int[cases];

            for(int i = 0; i < cases; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                int dice1 = int.Parse(input[0])%6 + 1;
                int dice2 = int.Parse(input[1]) % 6 + 1;
                roll[i] = dice1 + dice2;

            }
            Console.WriteLine("{0}",string.Join(" ",roll));
        }
    }
}
