using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem061
{
    class Program
    {
        static void Main(string[] args)
        {
            var cases = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');
            List<long> primes = new List<long>();
            long[] answer = new long[cases];
            primes.Add(2);
            long nextprime = 3;
            while (primes.Count < 200000)
            {
                long sqrt = (long)Math.Sqrt(nextprime);
                bool isPrime = true;
                for(int i = 0; (long)primes[i] <= sqrt; i++)
                {
                    if (nextprime % primes[i] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primes.Add(nextprime);
                }
                nextprime += 2;
            }

            for(int i = 0; i < input.Length; i++)
            {
                int number = int.Parse(input[i]);

                answer[i] = primes[number-1];
            }            
            Console.WriteLine("{0}", string.Join(" ", answer));
        }
    }
}
