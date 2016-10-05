using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem14
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger num =BigInteger.Parse( Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');
            
            while (input[0] != "%")
               
               {
                BigInteger x =BigInteger.Parse( input[1]);
                
                if (input[0] == "+")
                {
                    num = num + x;
                }
                else if (input[0] == "*")
                {
                    num = num * x;
                }
                input = Console.ReadLine().Split(' ');
               }

            BigInteger answer = num % BigInteger.Parse(input[1]);
                 
                 Console.WriteLine(answer);
            

        }
    }
}
