using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment1.qustions
{
    internal class Question7
    {
        static void Main(string[] args)
        {
            int number = 123;
            int sum = 0;

            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            Console.WriteLine("Sum of digits: " + sum);
        }
    }
}
