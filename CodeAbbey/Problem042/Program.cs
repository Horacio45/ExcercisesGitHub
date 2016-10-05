using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem042
{
    class Program
    {
        static void Main(string[] args)
        {
            var cases = int.Parse(Console.ReadLine());
            string[] answer = new string[cases];
            string[] nums = { "2", "3", "4", "5", "6", "7", "8", "9", };
            string[] royal = { "T", "J", "Q", "K", };

            for (int i = 0; i < cases; i++)
            {
                int Acounter=0;
                int score = 0;
                string[] input = Console.ReadLine().ToUpper().Split(' ');
                for (int j = 0; j < input.Length; j++)
                {                    
                    if (nums.Contains(input[j])) { score += int.Parse(input[j]); }
                    else if (royal.Contains(input[j])) { score += 10; }
                    else if (input[j] == "A")
                    {
                        Acounter += 1;
                        score += 11;
                    }
                }
                while (score > 21 && Acounter>0)
                {
                    score -= 10;
                    Acounter -= 1;
                }
                
                if (score <= 21) { answer[i] = score.ToString(); }
                else { answer[i] = "Bust"; }
            }

            Console.WriteLine("{0}",string.Join(" ",answer));
        }
    }
}
