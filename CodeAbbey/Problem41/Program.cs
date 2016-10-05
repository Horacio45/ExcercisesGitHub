using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem41
{
    class Program
    {
        static void Main(string[] args)
        {
            var amount = int.Parse(Console.ReadLine());
            int[] medians = new int[amount];

            for(int i = 0; i < amount; i++)
            {
                string[] input = Console.ReadLine().Split(' '); //input from console

                int[] nums = Array.ConvertAll(input, int.Parse); //convert input to integers
                Array.Sort(nums); // sort numbers
                medians[i] = nums[1]; //add middle number to median array



                

            }

            Console.WriteLine("{0}", string.Join(" ", medians));
        }
    }
}
