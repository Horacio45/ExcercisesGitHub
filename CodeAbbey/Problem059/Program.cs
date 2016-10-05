using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem059
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            char[] number = input[0].ToCharArray();
            int guesses = int.Parse(input[1]);
            string[] guess = Console.ReadLine().Split(' ');
            int[] cows = new int[guesses];
            int[] bulls = new int[guesses];

            for(int i = 0; i < guesses; i++)
            {
                char[] num = guess[i].ToCharArray();
                for(int j = 0; j < num.Length; j++)
                {
                    if (num[j] == number[j]) { bulls[i] += 1; }
                    else
                    {
                        for(int k = 0; k < num.Length; k++)
                        {
                            if (num[j] == number[k]) { cows[i]++; }
                        }
                    }
                }

            }  

            for(int i = 0; i < guesses; i++)
            {
                Console.Write("{0}-{1} ",bulls[i],cows[i]);
            }
            
        }
    }
}
