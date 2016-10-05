using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem11
{
    class Program
    {
        static void Main(string[] args)
        {
            var amount = int.Parse(Console.ReadLine());
            int[] sum = new int[amount];
            
            for(int i = 0; i < amount; i++)
            {
                string[] nums = Console.ReadLine().Split(' ');
                var num = int.Parse(nums[0]) * int.Parse(nums[1]) + int.Parse(nums[2]);
                while (num != 0)
                {
                    sum[i] += num % 10;
                    num /= 10;
                }
            }

            for(int i = 0; i < amount; i++)
            {
                Console.Write("{0} ", sum[i]);
            }
        }
    }
}
