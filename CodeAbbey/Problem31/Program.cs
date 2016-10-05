using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem31
{
    class Program
    {
        static void Main(string[] args)
        {
            var cases = int.Parse(Console.ReadLine());
            string[] answer = new string[cases];

            for(int i = 0; i < cases; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                int k = int.Parse(input[0]);
                string c = input[1];
                List<char> word = new List<char>();
                for(int j = 0; j < input[1].Length; j++)
                {
                    word.Add(c[j]);
                }
                if (k > 0)
                {
                    for (int j = 0; j < k; j++)
                    {
                        word.Add(word[i]);
                        word.RemoveAt(i);
                    }
                }
                else if (k < 0)
                {
                    for(int j = 0; j > k; j-=1)
                    {
                        word[-1*j] = word[word.Count-1 + j];
                        word.RemoveAt(word.Count-1+ j);
                    }
                }
                answer[i] = string.Join("",word.ToArray());
                //if (k > 0)
                //{
                //    answer[i] = word.Substring(k);
                //    answer[i] += word.Substring(0, k);
                //}
                //else if(k<0)
                // {
                //    int a = word.Length + k;
                //   answer[i] = word.Substring(a);
                //    answer[i] += word.Substring(0, a);
                //}
               
            }
            Console.WriteLine("{0}",string.Join(" ",answer));
        }
    }
}
