using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem47
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[26] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            string[] input = Console.ReadLine().Split(' ');
            int cases = int.Parse(input[0]);
            int k = int.Parse(input[1]);
            string[] answers = new string[cases];

            for(int i = 0; i < cases; i++)
            {
                string[] text = Console.ReadLine().ToUpper().Split(' ');
                
                
                for(int j = 0; j < text.Length; j++)
                {
                    string word = text[j];
                    string translation = "";
                    for(int l = 0; l < word.Length; l++)
                    {
                        for(int m = 0; m < alphabet.Length; m++)
                        {
                            if (word[l] == alphabet[m])
                            {
                                if (m - k >= 0)
                                {
                                    translation += alphabet[m - k];
                                }
                                else
                                {
                                    translation += alphabet[m + alphabet.Length - k];
                                }
                            }
                            
                        }
                         if (word[l] == '.')
                        {
                            translation += '.';
                        }
                    }
                    answers[i] += translation + " ";

                }
            }
            Console.WriteLine("{0}",string.Join(" ",answers));
        }
    }
}
