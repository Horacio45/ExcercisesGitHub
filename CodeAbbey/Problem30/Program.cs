using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem30
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();
            string reverse = "";
            for(int i = 1; i <= sentence.Length; i++)
            {
                int index = sentence.Length - i;
                reverse = reverse + sentence[index];
            }
            Console.WriteLine(reverse);
        }
    }
}
