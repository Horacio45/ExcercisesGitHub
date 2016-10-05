using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            string[] arr = Console.ReadLine().Split(' ');
            var sum = 0;
            for(int i = 0; i < num; i++)
            {
                
                sum += int.Parse(arr[i]);
            }
            Console.WriteLine(sum);
        }
    }
}
