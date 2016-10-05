using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem33
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] inputBuffer = new byte[2048];
            Stream inputStream = Console.OpenStandardInput(inputBuffer.Length);
            Console.SetIn(new StreamReader(inputStream, Console.InputEncoding, false, inputBuffer.Length));

            string[] input = Console.ReadLine().Split(' ');
            string answer="";
            for (int i = 0; i < input.Length; i++)
            {
                int a = int.Parse(input[i]);
                string binary = Convert.ToString(a, 2).PadLeft(8, '0');
                Console.WriteLine(binary);
                int bitcounter = 0;
                for(int j = 0; j < 8; j++)
                {
                    if (binary[j] == '1') { bitcounter += 1; }
                }
                Console.WriteLine(bitcounter);



                if (bitcounter % 2 == 0)
                {
                    int b = Convert.ToInt32(binary, 2);
                    Console.WriteLine(b);
                    if (b >= 65 && b <= 90 || b >= 97 && b <= 122 || b >= 48 && b <= 57 || b == 46 || b == 32)
                    {
                        answer+= Char.ConvertFromUtf32(b);
                    }
                }


                else
                {
                    char[] binarray = binary.ToCharArray();
                    if (binarray[0] == '0') { binarray[0] = '1'; }
                    else if (binarray[0] == '1') { binarray[0] = '0'; }
                    string encoded = new string(binarray);
                    Console.WriteLine(encoded);

                    int b = Convert.ToInt32(encoded, 2);
                    if (b >= 65 && b <= 90 || b >= 97 && b <= 122 || b >= 48 && b <= 57 || b == 46 || b == 32)
                    {
                        answer += Char.ConvertFromUtf32(b);
                    }

                }
            }
            Console.WriteLine(answer);

        }
    }
}
