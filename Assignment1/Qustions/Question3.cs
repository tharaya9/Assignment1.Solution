using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment1.qustions
{
    internal class Question4
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 25, 3, 99, 4 };
            int max = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                    max = numbers[i];
            }

            Console.WriteLine("Largest number: " + max);
        }
    }
}
