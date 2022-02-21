using System;
using System.Collections.Generic;

namespace Zad_Rechnik
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary11b2 = new Dictionary<int,string>();
            dictionary11b2.Add(14, "Maria");
            dictionary11b2.Add(15, "Martin");
            dictionary11b2.Add(16, "Martin Petrov");
            dictionary11b2.Add(17, "Martin Stoqnov");

            
            dictionary11b2[17] = "Metodi";
            
            
            if(!dictionary11b2.ContainsKey(17))
            {
                dictionary11b2.Add(17, "Mira");
            }
            else
            {
                dictionary11b2[17] = "Mira";
            }
            foreach (var student in dictionary11b2)
            {
                Console.WriteLine($"{student.Key} - {student.Value}");
            }


        }

        
    }
}
