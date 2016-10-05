using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem046
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] victory1 = { 1,2,3 , 4,5,6 , 7,8,9 , 1,4,7 , 2,5,8 ,3,6,9 ,1,5,9 , 3,5,7 };

            var cases = int.Parse(Console.ReadLine());
            int[] answers = new int[cases];

            for (int i = 0; i < cases; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                List<int> xmoves = new List<int>();
                List<int> omoves = new List<int>();
                answers[i] = -1;
                for (int j = 0; j < input.Length; j++)
                {                    
                    if (j % 2 == 0)
                    {
                        xmoves.Add(int.Parse(input[j]));
                    }
                    else
                    {
                        omoves.Add(int.Parse(input[j]));
                    }

                    for(int k = 0; k < 8; k++)
                    {
                        int[] check = victory1.Skip(k*3).Take(3).ToArray();
                        if (!check.Except(xmoves).Any() == true) { answers[i] = j+1; break; }
                        else if (!check.Except(omoves).Any() == true) { answers[i] = j+1; break; }
                    }
                    if (answers[i] != -1) { break; }

                }
                if (answers[i] == -1) { answers[i] = 0; }
                
            }
            Console.WriteLine("{0}", string.Join(" ", answers));
        }
    }
}
