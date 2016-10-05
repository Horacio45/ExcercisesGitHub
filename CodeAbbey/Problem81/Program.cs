using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem81
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] inputBuffer = new byte[2048];
            Stream inputStream = Console.OpenStandardInput(inputBuffer.Length);
            Console.SetIn(new StreamReader(inputStream, Console.InputEncoding, false, inputBuffer.Length));

            var cases = int.Parse(Console.ReadLine());
            int[] answers = new int[cases];


                string[] input = Console.ReadLine().Split(' ');
                for(int i = 0; i < input.Length; i++)
                {
                    int num = int.Parse(input[i]);
                    string binary = Convert.ToString(num, 2);
                    for(int j = 0; j < binary.Length; j++)
                    {
                        if (binary[j] == '1') { answers[i]+=1; }
                    }
                }
       
            Console.WriteLine("{0}",string.Join(" ",answers));
        }
    }
}
