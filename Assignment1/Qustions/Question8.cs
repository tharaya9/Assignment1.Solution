using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment1.qustions
{
    internal class Question8
    {
        static void Main(string[] args)
        {
            string text = "hello";
            string reversed = "";

            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversed += text[i];
            }

            Console.WriteLine(reversed);
        }
    }
}
