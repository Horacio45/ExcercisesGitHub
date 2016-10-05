using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem49
{
    class Program
    {
        static void Main(string[] args)
        {
            var cases = int.Parse(Console.ReadLine());
            int[] answer = new int[cases];
            for(int i = 0; i < cases; i++)
            {
                int score = 0;
                string[] match = Console.ReadLine().Split(' ');
                for(int j = 0; j < match.Length; j++)
                {                   
                    char[] game = match[j].ToCharArray();
                    if(game[0]=='R'&& game[1] == 'S' || game[0] == 'S' && game[1] == 'P' || game[0] == 'P' && game[1] == 'R') { score += -1; }
                    else if (game[0] == 'S' && game[1] == 'R' || game[0] == 'P' && game[1] == 'S' || game[0] == 'R' && game[1] == 'P') { score += 1; }

                }
                if (score < 0) { answer[i] = 1; }
                else if (score > 0) { answer[i] = 2; }
            }
            Console.WriteLine("{0}",string.Join(" ",answer));
        }
    }
}
