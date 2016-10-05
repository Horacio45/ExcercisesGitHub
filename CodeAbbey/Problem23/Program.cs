using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem23
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            string swap = "";
            int count = 0;
            long result = 0;
            long seed = 113;
            long limit = 10000007;

            for (int i = 0; i <=input.Length -3; i++)
                {
                    int a = int.Parse(input[i]);
                    int b = int.Parse(input[i + 1]);
                    if (int.Parse(input[i]) >int.Parse(input[i+1]))
                    {
                        swap = input[i + 1];
                        input[i + 1] = input[i];
                        input[i] = swap;
                        count++;
                    }
                }

            for (int i = 0; i < input.Length-1; i++)
            {
                long num = long.Parse(input[i]);

                result = (result + num) * seed;

                if (result >= limit)
                {
                    result = result % limit;
                }
            }

            Console.WriteLine("{0} {1}",count,result);
        }
    }
}
