using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem104
{
    class Program
    {
        static void Main(string[] args)
        {
            var cases = int.Parse(Console.ReadLine());
            double[] answer = new double[cases]; 

            for(int i = 0; i < cases; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                int x1 = int.Parse(input[0]);
                int y1 = int.Parse(input[1]);
                int x2 = int.Parse(input[2]);
                int y2 = int.Parse(input[3]);
                int x3 = int.Parse(input[4]);
                int y3 = int.Parse(input[5]);

                double a = Math.Sqrt((x2-x1) * (x2-x1) + (y2-y1) * (y2-y1));
                double b = Math.Sqrt((x3 - x2) * (x3 - x2) + (y3 - y2) * (y3 - y2));
                double c = Math.Sqrt((x3 - x1) * (x3 - x1) + (y3 - y1) * (y3 - y1));

                

                double s = (a + b + c) / 2;
                answer[i] = Math.Sqrt(s*(s - a)*(s - b)*(s - c));
            }
            Console.WriteLine("{0}",string.Join(" ",answer));


        }
    }
}
