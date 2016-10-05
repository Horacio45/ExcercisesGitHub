using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem20
{
    class Program
    {
        static void Main(string[] args)
        {
            var amount = int.Parse(Console.ReadLine());
            int[] vowelsCount = new int[amount];
            var vowels = new HashSet<char> { 'a', 'o', 'u', 'i', 'e', 'y' };

            for(int i = 0; i < amount; i++)
            {
                string sentence = Console.ReadLine().ToLower();
                for(int k = 0; k < sentence.Length; k++)
                {
                    if (vowels.Contains(sentence[k]))
                    {
                        vowelsCount[i]++;
                    }
                }


            }

            Console.WriteLine("{0}", string.Join(" ", vowelsCount));
        }
    }
}
