using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            int[] minimums = new int[num];
            for (int i = 0; i < num; i++)
            {
                string[] arr = Console.ReadLine().Split(' ');
                int min = int.Parse(arr[0]);
                if (min>int.Parse(arr[1])) { min = int.Parse(arr[1]); }
                if (min>int.Parse(arr[2])){ min = int.Parse(arr[2]); }
                minimums[i] = min;
            }

            for (int i = 0; i < num; i++)
            {
                Console.Write(minimums[i] + " ");
            }
        }
    }
}
