using System;
using System.Collections.Generic;

namespace Zad_DictionaryUkazatel
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> ukazatel = new Dictionary<string, string>();
            while (true)
            {
                var input = Console.ReadLine().Split();
                if (input[0] == "Exit")
                {
                    foreach (var p in ukazatel)
                    {
                        Console.WriteLine($"{p.Key}=>{p.Value}");
                    }
                    break;
                }
                string name = input[0];
                string number = input[1];
                if(!ukazatel.ContainsKey(name))
                {
                    ukazatel.Add(name, number);
                }
                else
                {
                    ukazatel[name] = number;
                }
            }
        }
    }
}
