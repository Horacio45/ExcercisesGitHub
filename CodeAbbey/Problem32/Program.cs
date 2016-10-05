using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem32
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int people = int.Parse (input[0]);
            int counter = int.Parse(input[1]);
            int c = int.Parse(input[1]);
            List<int> list = new List<int>();
            for(int i = 1; i <= people; i++)
            {
                list.Add(i);

            }
            int kills = 0;
            while(kills!= people - 1)
            {
                while (counter > list.Count)
                {
                    counter -= list.Count;
                }
                list.RemoveAt(counter-1);
                counter += c-1;
                kills++;
            }
            
            Console.WriteLine("{0}", string.Join(" ", list.ToArray()));
        }
    }
}
