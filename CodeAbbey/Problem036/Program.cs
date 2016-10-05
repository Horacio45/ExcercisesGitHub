using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem036
{
    class Program
    {
        static void Main(string[] args)
        {
            var guesses = int.Parse(Console.ReadLine());
            int[] first = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] second = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] third = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] fourth = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> answer1 = new List<int>();
            List<int> answer2 = new List<int>();
            List<int> answer3 = new List<int>();
            List<int> answer4 = new List<int>();
            for (int i = 0; i < guesses; i++)
            {
                string[] input = Console.ReadLine().Split();
                int correct = int.Parse(input[1]);
                int number = int.Parse(input[0]);
                int num1 = number / 1000;
                int num2 = (number % 1000) / 100;
                int num3 = (number % 100) / 10;
                int num4 = number % 10;
                if(correct >= 1)
                {
                    answer1.Add(num1);
                    answer2.Add(num2);
                    answer3.Add(num3);
                    answer4.Add(num4);
                }
                else if (correct == 0)
                {
                    first = first.Where(val => val != num1).ToArray();
                    second = second.Where(val => val != num2).ToArray();
                    third = third.Where(val => val != num3).ToArray();
                    fourth = fourth.Where(val => val != num4).ToArray();

                    answer1.RemoveAll(item => item==num1);
                    answer2.RemoveAll(item => item == num2);
                    answer3.RemoveAll(item => item == num3);
                    answer4.RemoveAll(item => item == num4);

                }
            }
            Console.WriteLine("{0}",string.Join(" ",first));
            Console.WriteLine("{0}", string.Join(" ", second));
            Console.WriteLine("{0}", string.Join(" ", third));
            Console.WriteLine("{0}", string.Join(" ", fourth));
            Console.WriteLine("{0}", string.Join(" ", answer1));
            Console.WriteLine("{0}", string.Join(" ", answer2));
            Console.WriteLine("{0}", string.Join(" ", answer3));
            Console.WriteLine("{0}", string.Join(" ", answer4));

        }
    }
}
