using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem67
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //var cases = int.Parse(Console.ReadLine());
            //int[] answer = new int[cases];
            //
            // for(int i = 0; i < cases; i++)
            // {
            //     string num = Console.ReadLine();
            //     string a = "0";
            //     string b = "1";
            //     int count = 0;
            //
            //     while (a != num)
            //     {
            //         string result = (BigInteger.Parse(a) + BigInteger.Parse(b)).ToString();
            //         a = b;
            //         b = result;
            //         count++;
            //     }
            //     answer[i] = count;
            // }

            BigInteger[] fib = new BigInteger[1000];
            fib[0] = 0;
            fib[1] = 1;
            for(int i = 2; i < 1000; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }

            var cases = int.Parse(Console.ReadLine());
            int[] answer = new int[cases];
            for(int i = 0; i < cases; i++)
            {
                BigInteger num = BigInteger.Parse(Console.ReadLine());
                for(int k = 0; k < fib.Length; k++)
                {
                    if(num == fib[k]) { answer[i] = k; }
                }
            }
            

            Console.WriteLine("{0}",string.Join(" ",answer));
        }
    }
}
