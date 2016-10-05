using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem17
{
    class Program
    {
        static void Main(string[] args)
        {
            var amount = int.Parse(Console.ReadLine());
            long result = 0;
            long seed = 113;
            long limit = 10000007;
            string[] input=Console.ReadLine().Split(' ');
           

            for(int i = 0; i < amount; i++)
            {
                long num = long.Parse(input[i]);

                result = (result + num) * seed;
                
                if( result>= limit)
                {
                    result = result % limit;
                }
            }
            
            Console.WriteLine(result.ToString());
        }
    }
}
