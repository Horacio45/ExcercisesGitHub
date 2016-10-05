using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem57
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] inputBuffer = new byte[2048];
            Stream inputStream = Console.OpenStandardInput(inputBuffer.Length);
            Console.SetIn(new StreamReader(inputStream, Console.InputEncoding, false, inputBuffer.Length));

            var length = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');
            double[] value = Array.ConvertAll(input, double.Parse);
            double[] answer = new double[length];

            for(int i = 1; i < value.Length-1; i++)
            {
                answer[i] = (value[i-1] + value[i] + value[i + 1]) / 3;
            }
            answer[0] = value[0];
            answer[length-1] = value[length-1];

            Console.WriteLine("{0}",string.Join(" ",answer));

        }
    }
}
