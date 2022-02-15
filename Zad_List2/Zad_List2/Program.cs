using System;
using System.Collections.Generic;
using System.Linq;

namespace Zad_List2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            while (true)
            {
                string input = Console.ReadLine();
                if(input == "print")
                {

                }
                if (int.TryParse())
            }
        }
    }
}
