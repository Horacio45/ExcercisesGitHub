using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem68
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
                double s = double.Parse(input[0]);
                double a = double.Parse(input[1]);
                double b = double.Parse(input[2]);

                answers[i] = (a / (a + b)) * s;
            }

            Console.WriteLine("{0}",string.Join(" ",answers));
        }
    }
}
