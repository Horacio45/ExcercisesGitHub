using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem48
{
    class Program
    {
        static void Main(string[] args)
        {
            var amount = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');
            int[] answer = new int[amount];

            for (int i=0;i<amount;i++)
            {
                int x = int.Parse(input[i]);
                int counter = 0;
                while (x != 1)
                    {
                    counter++;
                        if (x % 2 == 0)
                        {
                            x /= 2;
                        }
                        else
                        {
                            x = (x * 3) + 1;
                        }
                    
                    }
                answer[i] = counter;
                
                
            }

            Console.WriteLine("{0}",string.Join(" ", answer));
        }
    }
}
