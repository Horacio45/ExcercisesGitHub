using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem15
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] inputBuffer = new byte[2048];
            Stream inputStream = Console.OpenStandardInput(inputBuffer.Length);
            Console.SetIn(new StreamReader(inputStream, Console.InputEncoding, false, inputBuffer.Length));

            string[] arr = Console.ReadLine().Split(' ');
            int min = 0;
            int max = 0;
            for(int i = 0; i < 300; i++)
            {
                if (int.Parse(arr[i]) > max) { max = int.Parse(arr[i]); }

                if (int.Parse(arr[i]) < min) { min = int.Parse(arr[i]); }

            }

            Console.WriteLine("{0} {1}",max,min);
        }
    }
}
