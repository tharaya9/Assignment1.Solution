using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment1.qustions
{
    internal class Question10
    {
        static void Main(string[] args)
        {
            int total = 0;

            for (int i = 2; i <= 100; i += 2)
            {
                total += i;
            }

            Console.WriteLine("Sum of even numbers: " + total);
        }
    }
}

