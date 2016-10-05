using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problem50
{
    class Program
    {
        static void Main(string[] args)
        {
            var cases = int.Parse(Console.ReadLine());
            char[] answer = new char[cases];

            for(int i = 0; i < cases; i++)
            {
                string input = Console.ReadLine().ToLower();
                input= Regex.Replace(input, @"[^\w]", string.Empty); //trim all punctuation and spaces
                string reverse = new string(input.ToCharArray().Reverse().ToArray()); //declare a reverse of input
                if (input == reverse) { answer[i] = 'Y'; }   //  compare strings and add
                else { answer[i] = 'N'; }                    //  result to answer string
            }
            Console.WriteLine("{0}",string.Join(" ",answer));
        }
    }
}
