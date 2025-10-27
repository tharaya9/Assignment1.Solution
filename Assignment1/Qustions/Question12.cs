using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment1.qustions
{
    internal class Question12
    {
        static void Main(string[] args)
        {
            int[] arr = { 9, 2, 5, 1, 7 };

            Array.Sort(arr);

            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
