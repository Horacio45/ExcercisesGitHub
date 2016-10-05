using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem038
{
    class Program
    {
        static void Main(string[] args)
        {
            var cases = int.Parse(Console.ReadLine());
            string[] answers = new string[cases];

            for (int i = 0; i < cases; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);
                int c = int.Parse(input[2]);

                double x1 = 0;
                double x2 = 0;

                int D = b * b - 4 * a * c;
                double d = Math.Sqrt(D);
                if (D >= 0)
                {
                    x1 = (-b + Math.Sqrt(D) )/ (2 * a);
                    x2 = (-b - Math.Sqrt(D)) / (2 * a);
                    
                    if (x1 > x2)
                    {
                        answers[i] = x1.ToString() +" "+ x2.ToString();
                    }
                    else { answers[i] = x2.ToString() + " " + x1.ToString(); }
                }
                else
                {
                    Complex imaginary =Complex.Sqrt (D);
                    imaginary = imaginary * imaginary;
                    Console.WriteLine(imaginary);
                    Complex real = imaginary.Real;
                    Console.WriteLine(real);
                    Complex imag = imaginary.Imaginary;
                    Console.WriteLine(imag);
                }

            }
            Console.WriteLine("{0}",string.Join("; ",answers));

        }
    }
}
