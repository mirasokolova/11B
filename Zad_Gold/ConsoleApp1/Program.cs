using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> products = new Dictionary<string, int>();
            while (true)
            {
                string input = Console.ReadLine();


                if (input == "Stop")
                {
                    foreach(var product in products)
                    {
                        Console.WriteLine($"{product.Key} -> {product.Key}");
                    }
                    break;
                }
                string productName = input;
                int quantity = int.Parse(Console.ReadLine());
                if (!products.ContainsKey(productName))
                {
                    products.Add(productName, quantity);
                }
                else
                {
                    products[productName] += quantity;
                }
            
            }
        }
    }
}
