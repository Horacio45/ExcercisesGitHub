using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem27
{
    class Program
    {
        static void Main(string[] args)
        {
            var amount = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');
            int[] nums = Array.ConvertAll(input, int.Parse);
            int passes = 0;
            int swaps = 0;
            bool check = true;
            while (check == true)
            {
                check = false;
                passes += 1;
                for (int i = 0; i < nums.Length - 1; i++)
                {                    
                        if (nums[i] > nums[i+1])

                        {
                            int swap = nums[i];
                            nums[i] = nums[i+1];
                            nums[i+1] = swap;
                            swaps+=1;
                            check = true;
                        }                                    
                }
                
            }
            Console.WriteLine("{0}",string.Join(" ",nums));
            Console.WriteLine("{0} {1}",passes,swaps);
        }
    }
}
