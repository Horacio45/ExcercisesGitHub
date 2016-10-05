using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem19
{
    class Program
    {
        static void Main(string[] args)
        {
            var cases = int.Parse(Console.ReadLine());
            int[] answers = new int[cases];

            for (int i = 0; i < cases; i++)
            {
                string input = Console.ReadLine();
                string brackets = "";
                for(int j = 0; j <= input.Length-1; j++)
                {
                    if(input[j]=='['||input[j]==']'|| input[j] == '(' || input[j] == ')' ||
                        input[j] == '{' || input[j] == '}' || input[j] == '<' || input[j] == '>')
                    {
                        brackets += input[j];
                    }
                    
                }
                string previous = "";
                while(brackets.Length!=previous.Length)
                {
                    previous = brackets;
                    brackets = brackets
                        .Replace("()", string.Empty)
                        .Replace("[]", string.Empty)
                        .Replace("<>", string.Empty)
                        .Replace("{}", string.Empty);
                }
                if (brackets.Length == 0) { answers[i] = 1; }
                else { answers[i] = 0; }
            }
            Console.WriteLine("{0}",string.Join(" ",answers));
        }
    }
}
