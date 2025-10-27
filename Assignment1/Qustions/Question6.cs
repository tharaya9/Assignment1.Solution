using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment1.qustions
{
    internal class Question6
    {
        static void Main(string[] args)
        {
            int num = 7;
            bool isPrime = true;

            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            Console.WriteLine(isPrime ? "Prime number" : "Not prime");
        }
    }
}
