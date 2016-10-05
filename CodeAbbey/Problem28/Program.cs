using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem28
{
    class Program
    {
        static void Main(string[] args)
        {
            var amount = int.Parse(Console.ReadLine());
            string[] answer = new string[amount];

            for(int i = 0; i < amount; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                double BMI = double.Parse(input[0]) / (double.Parse(input[1]) * double.Parse(input[1]));
                if (BMI < 18.5) { answer[i] = "under"; }
                else if(BMI>=18.5 && BMI < 25) { answer[i] = "normal"; }
                else if(BMI>= 25 && BMI < 30) { answer[i] = "over"; }
                else if (BMI >= 30) { answer[i] = "obese"; }
            }

            Console.Write("{0}", string.Join(" ", answer));
        }
    }
}
