using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project6
{
    class Program
    {
        static void Main(string[] args)
        {
            var amount = int.Parse(Console.ReadLine());
            double[] rounded = new double[amount];
            for(int i = 0; i < amount; i++)
            {
                string[] arr = Console.ReadLine().Split(' ');
                double a = int.Parse(arr[0]);
                double b = int.Parse(arr[1]);
                rounded[i] = Math.Round(a / b, MidpointRounding.AwayFromZero);
                
            }
            for(int i = 0; i < amount; i++)
            {
                Console.Write(rounded[i]+" ");
            }
        }
    }
}
