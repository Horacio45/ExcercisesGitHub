using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem43
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] inputBuffer = new byte[2048];
            Stream inputStream = Console.OpenStandardInput(inputBuffer.Length);
            Console.SetIn(new StreamReader(inputStream, Console.InputEncoding, false, inputBuffer.Length));

            var amount = int.Parse(Console.ReadLine());
            int[] dice = new int[amount];

            for(int i = 0; i < amount; i++)
            {
                double num = double.Parse(Console.ReadLine());
                num *= 6;
                dice[i] = (int)num + 1;
                
            }

            Console.WriteLine("{0}", string.Join(" ",dice));
        }
    }
}
