using System;
using System.Collections.Generic;

namespace Travis
{
    internal static class Program
    {
        private static void Main()
        {
            var knownUsers = new List<string>() {"Alice", "Bob", "Claire", "Dan", "Emma", "Fred", "Georgie", "Harry"};
            var travisContinue = true;

            while (travisContinue)
            {
                Console.WriteLine("Hi my name is Travis");
                Console.Write("What is your name?: ");

                var answer = Console.ReadLine();
                if (!string.IsNullOrEmpty(answer)) 
                {
                    answer = answer.ToLower();
                    var name = FirstToUpper(answer);

                    if (knownUsers.Contains(name))
                    {
                        Console.WriteLine($"\nHello {name}!");
                        Console.Write("Would you like to be removed from the system <y/n>?: ");
                        var remove = Console.ReadLine();

                        if (!string.IsNullOrEmpty(remove))
                        {
                            if (remove == "y")
                            {
                                knownUsers.Remove(name);
                                Console.WriteLine($"\nYou have been removed {name}\n");
                            }
                            else if (remove == "n")
                                Console.WriteLine("\nNo problem, I didn't want you to leave anyway!\n");
                        }
                        else
                            travisContinue = false;
                    }
                    else
                    {
                        Console.WriteLine($"\nHmmm I don't think I know you yet {name}.");
                        Console.Write("Would you like to be added to the system <y/n>?: ");
                        var addName = Console.ReadLine();

                        if (!string.IsNullOrEmpty(addName))
                        {
                            if (addName == "y")
                            {
                                knownUsers.Add(name);
                                Console.WriteLine($"\n{name}, you have been added to the system.\n");
                                foreach (var temp in knownUsers)
                                {
                                    Console.WriteLine(temp);
                                }
                                Console.WriteLine("\n");
                            }
                            else if (addName == "n")
                            {
                                Console.WriteLine("\nNo Worries, see you around\n");
                            }
                        }
                        else
                        {
                            travisContinue = false;
                        }
                    }
                }
                else
                    travisContinue = false;
            }
        }

        private static string FirstToUpper(string text)
        {
            var firstLetter = text[0].ToString().ToUpper();
            return firstLetter + text.Substring(1);
        }
    }
}