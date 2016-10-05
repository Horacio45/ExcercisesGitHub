using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            string [] minimums = new string[num];
            for (int i = 0; i < num; i++)
            {
                string[] arr = Console.ReadLine().Split(' ');
                if (int.Parse(arr[0]) > int.Parse(arr[1])) { minimums[i] = arr[1]; }
                else { minimums[i] = arr[0]; }
            }

            for(int i = 0; i < num; i++)
            {
                Console.Write(minimums[i]+" ");
            }


        }
    }
}
