using System;
using System.Collections.Generic;

namespace Zad_DictionaryMagazin
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> products = new Dictionary<string, int>();
            while (true)
            {
                var input = Console.ReadLine().Split();
                if (input[0] == "Stop")
                {
                    foreach (var p in products)
                    {
                        Console.WriteLine($"{p.Key}=>{p.Value}");
                    }
                    break;
                }
               
                string product = input[0];
                int quantity = int.Parse(input[1]);
                if (! products.ContainsKey(product))
                {
                    products.Add(product, quantity);
                }
                else
                {
                    products[product] += quantity;
                }
                

            }
        }
    }
}
