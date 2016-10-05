using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem25
{
    class Program
    {
        static void Main(string[] args)
        {
            var cases = int.Parse(Console.ReadLine());
            int[] answers = new int[cases];

            for(int i = 0; i < cases; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                int a = int.Parse(input[0]);
                int c = int.Parse(input[1]);
                int m = int.Parse(input[2]);
                int x0 = int.Parse(input[3]);
                int n = int.Parse(input[4]);

                int xnext = 0;
                
                for (int j = 0; j < n; j++)
                {
                    xnext = (a * x0 + c) % m;
                    x0 = xnext;
                    
                }
                answers[i] = xnext;
            }
            Console.WriteLine("{0}",string.Join(" ",answers));
        }
    }
}
