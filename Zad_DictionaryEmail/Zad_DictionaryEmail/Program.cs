using System;
using System.Collections.Generic;

namespace Zad_DictionaryEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> emailList = new Dictionary<string, string>();
            while (true)
            {
                var input = Console.ReadLine().Split();

                if (input[0] == "Stop")
                {
                    foreach (var item in emailList )
                    {

                        Console.WriteLine($"{ item.Key} –> {item.Value}");
                    }
                    break;
                }

                if (input[0] == "Add")

                {
                    string name = input[1];
                    string email = input[2];
                    if (!emailList.ContainsKey(name))
                    {
                        emailList.Add(name, email);
                    }
                    else
                    {
                        emailList[name] = email;
                    }
                }
                if (input[0] == "Sent")
                {
                    string name = input[1];
                    
                    if (emailList.ContainsKey(name))
                    {
                        Console.WriteLine($"{name}->{emailList[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exists.");

                    }
                }
                
                

            }
            
        }
    }
}
