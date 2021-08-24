using System;
using System.Linq;

namespace PO_Practice_8_23_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            string socks = String.Concat(Console.ReadLine().OrderBy(c => c));
            int pairs = 0;
            char current = ' ';

            foreach (char letter in socks)
            {
                if (current == letter)
                {
                    current = ' ';
                    pairs++;
                }
                else
                {
                    current = letter;
                }
            }

            Console.WriteLine(pairs);
        }
    }
}
