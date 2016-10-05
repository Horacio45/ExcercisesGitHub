using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem13
{
    class Program
    {
        static void Main(string[] args)
        {
            var amount = int.Parse(Console.ReadLine());
            int[] answer = new int[amount];
            string[] nums = Console.ReadLine().Split(' ');
            
            for(int i = 0; i < amount; i++)
            {
                List<int> list=new List<int>();
                var num = int.Parse(nums[i]);
                while (num != 0)
                {
                    list.Add(num%10);
                    num /= 10;
                }
                var length = list.Count;
                for(int k = 0; k < length; k++)
                {
                    answer[i] += list[k]*(length-k);
                }
            }

            for(int i = 0; i < amount; i++)
            {
                Console.Write("{0} ", answer[i]);
            }
        }
    }
}
