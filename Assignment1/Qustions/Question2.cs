using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Assignment1.qustions
{
    internal class Question2
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1;
            Console.Write(a + " " + b + " ");
            for (int i = 2; i < 15; i++)
            {
                int next = a + b;
                Console.Write(next + " ");
                a = b;
                b = next;
            }
            Console.WriteLine();
        }
    }
}
