using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem53
{
    class Program
    {

        static void Main(string[] args)
        {
            var cases = int.Parse(Console.ReadLine());
            char[] answers = new char[cases];
            for (int i = 0; i < cases; i++)
            {
                string[] input = Console.ReadLine().ToLower().Split(' ');
                char[] king = input[0].ToCharArray();
                char[] queen = input[1].ToCharArray();


                int Kx=0;
                switch (king[0])
                {
                    case 'a': Kx = 1; break;
                    case 'b': Kx = 2; break;
                    case 'c': Kx = 3; break;
                    case 'd': Kx = 4; break;
                    case 'e': Kx = 5; break;
                    case 'f': Kx = 6; break;
                    case 'g': Kx = 7; break;
                    case 'h': Kx = 8; break;

                }
                int Ky = king[1];

                int Qx=0;
                switch (queen[0])
                {
                    case 'a': Qx = 1; break;
                    case 'b': Qx = 2; break;
                    case 'c': Qx = 3; break;
                    case 'd': Qx = 4; break;
                    case 'e': Qx = 5; break;
                    case 'f': Qx = 6; break;
                    case 'g': Qx = 7; break;
                    case 'h': Qx = 8; break;

                }
                int Qy = queen[1];

                if (Kx == Qx || Ky == Qy) { answers[i] = 'Y'; }
                else if (Math.Abs(Qx - Kx) == Math.Abs(Qy - Ky)) { answers[i] = 'Y'; }
                else { answers[i] = 'N'; }
                
            }
            Console.WriteLine("{0}", string.Join(" ", answers));

        }
    }
}
