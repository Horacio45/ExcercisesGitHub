using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem35
{
    class Program
    {
        static void Main(string[] args)
        {
            var cases = int.Parse(Console.ReadLine());
            int[] years = new int[cases];

            for(int i = 0; i < cases; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                double s = int.Parse(input[0]);
                double r = int.Parse(input[1]) ;
                double p = 1+  (int.Parse(input[2])*0.01);
                years[i] = 0;
                while (s < r)
                {
                    s *=p;
                    years[i] += 1;
                    
                }
            }
            Console.WriteLine("{0}",string.Join(" ",years));
        }
    }
}
