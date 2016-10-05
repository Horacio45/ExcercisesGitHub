using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem16
{
    class Program
    {
        static void Main(string[] args)
        {
            var amount = int.Parse(Console.ReadLine());
            double[] average = new double[amount];

            for(int i = 0; i < amount; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                double[] nums = Array.ConvertAll(input, double.Parse);
                double a = nums.Length -1;
                double sum = nums.Sum();
                average[i] = Math.Round(sum / a);
                

            }

            Console.WriteLine("{0}",string.Join(" ",average));
        }
    }
}
