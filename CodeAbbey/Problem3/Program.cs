using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            int[] sums = new int[num];
            
            for (int i = 0; i < num; i++)
            {
                string[] nums = Console.ReadLine().Split(' ');
                sums[i] = int.Parse(nums[0]) + int.Parse(nums[1]);
                
                
            }
            for(int i = 0; i < num; i++)
            {
                Console.Write(sums[i]+" ");
            }
        }
    }
}
