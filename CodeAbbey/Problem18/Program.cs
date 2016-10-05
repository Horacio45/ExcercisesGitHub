using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem18
{
    class Program
    {
        static void Main(string[] args)
        {
            var cases = int.Parse(Console.ReadLine());
            double[] answers = new double[cases];
            for(int i = 0; i < cases; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                int X = int.Parse(input[0]);
                int N = int.Parse(input[1]);
                double r = 1;
                for(int k = 0; k < N; k++)
                {
                    double d = X / r;
                    r = (r + d) / 2;

                }
                answers[i] = r;
            }
            Console.WriteLine("{0}",string.Join(" ",answers));
        }
    }
}
