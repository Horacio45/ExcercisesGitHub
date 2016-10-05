using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem21
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] inputBuffer = new byte[2048];
            Stream inputStream = Console.OpenStandardInput(inputBuffer.Length);
            Console.SetIn(new StreamReader(inputStream, Console.InputEncoding, false, inputBuffer.Length));

            string[] input1 = Console.ReadLine().Split(' ');
            string[] input2 = Console.ReadLine().Split(' ');
            List<int> list = new List<int>();
            int M = int.Parse(input1[0]);
            int N = int.Parse(input1[1]);
            int[] counters = new int[N];
            for(int i = 0; i < N; i++)
            {
                counters[i] = 0;
            }

            for(int i = 0; i <M; i++)
            {
                list.Add(int.Parse(input2[i]));


                for(int k = 1; k<= N; k++)
                {
                    if (list[i] == k)
                    {
                        counters[k - 1]++;
                        

                    }
                }
            }
            Console.WriteLine("{0}",string.Join(" ",counters));
        }
    }
}
