using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem22
{
    class Program
    {
        static void Main(string[] args)
        {
            // var cases = int.Parse(Console.ReadLine());
            // double[] answers = new double[cases];
            // for (int i = 0; i < cases; i++)
            // {
            //     string[] input = Console.ReadLine().Split(' ');
            //     double x = int.Parse(input[0]);
            //     double y = int.Parse(input[1]);
            //     double n = int.Parse(input[2]);
            //     double GCD = 0;
            //    double LCM = 0;
            //     double a = x;
            //     double b = y;
            //     while (a != b)
            //     {
            //         if (a > b) { a = a - b; }
            //         else { b = b - a; }
            //     }
            //     if (a == b)
            //     {
            //         GCD = a;
            //         LCM = (x * y) / GCD;
            //     }
            //     Console.WriteLine("{0} {1}",GCD,LCM);
            //     double LCMamount = LCM / x + LCM / y;
            //     Console.WriteLine(LCMamount);
            //     if (n > LCMamount)
            //     {
            //         double k = Math.Truncate(n / LCMamount)*LCM;
            //         double leftpages = n % LCMamount;
            //         Console.WriteLine(k);
            //         Console.WriteLine(leftpages);
            //     }
            //-------------------------------------------------------------------------------------------------------------------------------------------------
            //  double a = x / (x + y);
            //  double b = y / (x + y);
            //  double xAmount = n * b;
            //  double yAmount = n * a;
            //  if (x > y)
            //  {
            //      xAmount = Math.Floor(xAmount);
            //      yAmount = Math.Ceiling(yAmount);
            //  }
            //  else
            //  {
            //      xAmount = Math.Ceiling(xAmount);
            //      yAmount = Math.Floor(yAmount);
            //  }
            //
            //  if (xAmount * x > yAmount * y) { answers[i] = xAmount * x; }
            //  else { answers[i] = yAmount * y; }

            // }
            // ----------------------------------------------------------------------------------------------------
            int cases = int.Parse(Console.ReadLine());
            int[] answers = new int[cases];
            for(int i = 0; i < cases; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                int x = int.Parse(input[0]);
                int y = int.Parse(input[1]);
                int n = int.Parse(input[2]);
                int counter = 0;
                int seconds = 0;
                while (counter < n)
                {
                    seconds += 1;
                    if (seconds % x == 0) { counter += 1; }

                    if (seconds %y == 0) { counter += 1; }

                }
                answers[i] = seconds;
            }
            Console.WriteLine("{0}",string.Join(" ",answers));
        }
    }
}
