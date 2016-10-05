using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem69
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] fib = new BigInteger[10000];
            fib[0] = 0;
            fib[1] = 1;
            for (int i = 2; i < 10000; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }

            var numbers = int.Parse(Console.ReadLine());
            int[] answers = new int[numbers];
            string[] input = Console.ReadLine().Split(' ');
            for(int i = 0; i < numbers; i++)
            {
                int num = int.Parse(input[i]);
                for(int j = 1; j < fib.Length; j++)
                {
                    if (fib[j] % num == 0) {  answers[i] = j; break; }
                }
            }
            Console.WriteLine("{0}",string.Join(" ",answers));
        }
    }
}
