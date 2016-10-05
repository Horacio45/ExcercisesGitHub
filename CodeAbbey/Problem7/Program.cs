using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fahrenheit = Console.ReadLine().Split(' ');
            int a = int.Parse(fahrenheit[0]);
            for(int i = 1; i <= a; i++)
            {
                double F = double.Parse(fahrenheit[i]);
                Console.Write(Math.Round(((F-32)*5)/9)+" ");
            }
        }
    }
}
