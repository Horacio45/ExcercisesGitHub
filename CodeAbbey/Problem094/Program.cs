using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem094
{
    class Program
    {
        static void Main(string[] args)
        {
            var cases = int.Parse(Console.ReadLine());
            int[] answers = new int[cases];
            for(int i = 0; i < cases; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                for(int j = 0; j < input.Length; j++)
                {
                    int num = int.Parse(input[j]);
                    answers[i] += num * num;
                }
            }
            Console.WriteLine("{0}",string.Join(" ",answers));
        }
    }
}
