using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem058
{
    class Program
    {
        static void Main(string[] args)
        {
            var cards = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();
            string[] rank = new string[cards];
            string[] suit = new string[cards];
            string[] suits = { "Clubs", "Spades", "Diamonds", "Hearts" };
            string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

            for(int i = 0; i < input.Length; i++)
            {
                int value = int.Parse(input[i]);
                suit[i] = suits[value / 13];
                rank[i] = ranks[value % 13];
            }

            for(int i = 0; i < cards; i++)
            {
                Console.Write("{0}-of-{1} ",rank[i],suit[i]);
            }
        }
    }
}
