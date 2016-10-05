using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem12
{
    class Program
    {
        static void Main(string[] args)
        {
            var amount = int.Parse(Console.ReadLine());
            int[] D = new int[amount];
            int[] H = new int[amount];
            int[] M = new int[amount];
            int[] S = new int[amount];

            for(int i = 0; i < amount; i++)
            {
                string[] time = Console.ReadLine().Split(' ');
                int D1 = int.Parse(time[0])*86400;
                int H1 = int.Parse(time[1])*3600;
                int M1 = int.Parse(time[2])*60;
                int S1 = int.Parse(time[3]);
                int D2 = int.Parse(time[4])*86400;
                int H2 = int.Parse(time[5])*3600;
                int M2 = int.Parse(time[6])*60;
                int S2 = int.Parse(time[7]);
                int T=(D2 + H2 + M2 + S2) - (D1 + H1 + M1 + S1);
                D[i] = T / 86400;
                H[i] = (T % 86400)/3600;
                M[i] = ((T % 86400)%3600)/60;
                S[i] = T % 60;
            }

            for (int i = 0; i < amount; i++)
            {
                Console.Write("({0} {1} {2} {3}) ", D[i], H[i], M[i], S[i]);
            }
        }
    }
}
