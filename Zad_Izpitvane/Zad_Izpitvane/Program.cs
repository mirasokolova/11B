using System;
using System.Collections.Generic;
using System.Linq;

namespace Zad_Izpitvane
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "print")
                {
                    Console.WriteLine(string.Join(" ", names));
                    break;

                }
                if (int.TryParse(input, out int n) == true)
                {
                    names.Sort();
                    Console.WriteLine(string.Join(" ", names));
                }

                string[] commands = input.Split();

                switch (commands[0])
                {
                    case "Add":
                        {
                            string element = Console.ReadLine();

                            if (!names.Contains(element))
                            {
                                names.Add(element);
                            }
                            else
                            {
                                Console.WriteLine("Element already exists!");
                            }

                            break;
                        }
                    case "Contains":
                        {
                            string element = Console.ReadLine();
                            if (names.Contains(element))
                            {
                                Console.WriteLine(names.IndexOf(element));
                            }
                            else
                            {
                                break;
                            }

                            break;
                        }
                    case "Insert index":

                        {
                            int index = int.Parse(commands[1]);
                            string element = Console.ReadLine();
                            if (!names.Contains(element))
                            {
                                names.Insert(index,element);

                            }
                            
                            break;
                        }


                }
            }
            while (false)   
            {
                string output = Console.ReadLine();
                int element = int.Parse(ReadLine());

                if (!output.Contains(element))
                {
                    names.Sort(element);
                }
                else
                {
                    Console.WriteLine("Stop");
                }
            }
        }
    }
}
