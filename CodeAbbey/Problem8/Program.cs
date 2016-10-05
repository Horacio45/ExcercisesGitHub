using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8
{
    class Program
    {
        static void Main(string[] args)
        {
            var amount = int.Parse(Console.ReadLine());
            int[] ans = new int[amount];
            for (int i = 0; i < amount; i++)
            {
                string[] arr = Console.ReadLine().Split(' ');
                var A = int.Parse(arr[0]);
                var B = int.Parse(arr[1]);
                var N = int.Parse(arr[2]);
                for(int k = 0; k < N; k++)
                {
                    ans[i] += A;
                    A = A + B;
                }

            }
            for(int i = 0; i < amount; i++)
            {
                Console.Write(ans[i]+" ");
            }
        }
    }
}
