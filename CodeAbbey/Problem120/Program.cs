using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem120
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] inputBuffer = new byte[2048];
            Stream inputStream = Console.OpenStandardInput(inputBuffer.Length);
            Console.SetIn(new StreamReader(inputStream, Console.InputEncoding, false, inputBuffer.Length));

            var size = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');
            List<int> numbers = new List<int>();
            List<int> answers = new List<int>();

            for (int i = 0; i < size; i++)
            {
                numbers.Add(int.Parse(input[i]));
            }

            for (int i = 0; i < size-1; i++)
            {
                int newsize = size - i;
                int[] sub = new int[newsize];
                Array.Copy(numbers.ToArray(), sub, newsize);
                int max = int.MinValue;
                int maxpos = 0;
                for (int j = 0; j < sub.Length; j++)
                {
                    if (sub[j] > max) { max = sub[j]; maxpos = j; }


                }
                int swap = numbers[newsize-1];
                numbers[newsize-1] = max;
                numbers[maxpos] = swap;
                answers.Add(maxpos);

                
                
                
                
                
                
                
                
                
                //Console.WriteLine("{0}", string.Join(" ", sub));



            }
            Console.WriteLine("{0}",string.Join(" ",answers));

        }
    }
}
