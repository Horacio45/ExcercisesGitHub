using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem037
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            double p = double.Parse(input[0]);
            double r = (double.Parse(input[1])/100)/12;
            double l = double.Parse(input[2]);
            double r2 = r + 1;

            double c = (r * p * Math.Pow(r+1, l)) / (Math.Pow(r+1, l) - 1);
            
            Console.WriteLine(Math.Round(c));
            
        }
    }
}
