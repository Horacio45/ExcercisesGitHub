using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem10
{
    class Program
    {
        static void Main(string[] args)
        {
            var amount = int.Parse(Console.ReadLine());
            int[] a = new int[amount];
            int[] b = new int[amount];

            for(int i = 0; i < amount; i++)
            {
                string[] nums = Console.ReadLine().Split(' ');
                int x1 = int.Parse(nums[0]);
                int y1 = int.Parse(nums[1]);
                int x2 = int.Parse(nums[2]);
                int y2 = int.Parse(nums[3]);
                a[i] = (y2 - y1) / (x2 - x1);
                b[i] = y1 - a[i] * x1;
            }



            for(int i = 0; i < amount; i++)
            {
                Console.Write("({0} {1}) ",a[i],b[i]);
            }
        }
    }
}
