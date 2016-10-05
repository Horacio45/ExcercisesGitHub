using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem52
{
    class Program
    {
        static void Main(string[] args)
        {
            var cases = int.Parse(Console.ReadLine());
            char[] answers = new char[cases];

            for (int i = 0; i < cases; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);
                int c = int.Parse(input[2]);

                int max = a;
                int side1 = b;
                int side2 = c;
                if (b > a)
                {
                    max = b; side1 = a;
                    if (c > b)
                    {
                        max = c; side2 = b;
                    }
                }
                else if (c > a) { max = c; side2 = a; }

                if (max < Math.Sqrt(side1 * side1 + side2 * side2)) { answers[i] = 'A'; }
                else if (max == Math.Sqrt(side1*side1 + side2*side2)){ answers[i] = 'R'; }
                else { answers[i] = 'O'; }
             }
            Console.WriteLine("{0}",string.Join(" ",answers));
        }
    }
}
