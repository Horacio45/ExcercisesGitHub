using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Problem55
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] inputBuffer = new byte[2048];
            Stream inputStream = Console.OpenStandardInput(inputBuffer.Length);
            Console.SetIn(new StreamReader(inputStream, Console.InputEncoding, false, inputBuffer.Length));

            string[] input = Console.ReadLine().Split(' ');
            List<string> answer = new List<string>();
            for(int i = 0; i < input.Length; i++)
            {
                for(int j = i+1; j < input.Length; j++)
                {
                    if (input[i] == input[j])
                    {
                        answer.Add(input[j]);
                    }
                }
            }
            answer.Sort();
            Int32 l = 0;
            while (l< answer.Count - 1)
            {
                if (answer[l] == answer[l + 1])
                    answer.RemoveAt(l);
                else
                    l++;
            }
            Console.WriteLine("{0}",string.Join(" ",answer));
        }
    }
}
