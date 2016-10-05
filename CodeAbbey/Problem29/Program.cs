using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem29
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            string[] array = Console.ReadLine().Split(' ');
            int[] newarray = Array.ConvertAll(array, int.Parse);
            int[] index = new int[size];
            int temp;
            int swap;
            for(int i = 1; i <= size; i++)
            {
                index[i-1] = i;
            }

            for (int j = 0; j <= newarray.Length - 2; j++)
            {
                for (int i = 0; i <= newarray.Length - 2; i++)
                {
                    if (newarray[i] > newarray[i + 1])
                    {
                        temp = newarray[i + 1];
                        swap = index[i + 1];

                        newarray[i + 1] = newarray[i];
                        index[i + 1] = index[i];

                        newarray[i] = temp;
                        index[i] = swap;
                    }
                }
            }

            Console.WriteLine("{0}",string.Join(" ",index));
            Console.WriteLine("{0}",string.Join(" ",newarray));

        }
    }
}
