using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem24
{
    class Program
    {
        static void Main(string[] args)
        {
            var cases = int.Parse(Console.ReadLine());
            int[] answers = new int[cases];
            string[] input = Console.ReadLine().Split(' ');
            for (int i = 0; i < cases; i++)
            {
                int num = int.Parse(input[i]);
                List<int> numbers = new List<int>();
                numbers.Add(num);
                while (numbers.Distinct().Count() == numbers.Count())
                {
                    num = num * num;
                    num = num / 100;
                    num = num % 10000;
                    numbers.Add(num);

                }

                    answers[i] = numbers.Count() - 1;


            }
            Console.WriteLine("{0}",string.Join(" ",answers));

        }
    }
}
