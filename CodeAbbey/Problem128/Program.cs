using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem128
{
    class Program
    {
        static void Main(string[] args)
        {
            var cases = int.Parse(Console.ReadLine());
            BigInteger[] C = new BigInteger[cases];
            for(int i = 0; i < cases; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                int N = int.Parse(input[0]);
                int K = int.Parse(input[1]);


                BigInteger Nfactorial = 1;
                for (int j = 1; j <= N; j++)
                {
                    Nfactorial =Nfactorial* j;

                }


                BigInteger Kfactorial = 1;
                for(int l = 1; l <= K; l++)
                {
                    Kfactorial =Kfactorial* l;
                }

                int z = N - K;
                BigInteger factorial = 1;
                for(int m = 1; m <= z; m++)
                {
                    factorial =factorial* m;
                }
                //Console.WriteLine(Nfactorial);
                //Console.WriteLine(Kfactorial);
                //Console.WriteLine(factorial);
                C[i] = (Nfactorial) / (Kfactorial * factorial);
                



                

                
            }
            Console.WriteLine("{0}",string.Join(" ",C));
        }
    }
}
