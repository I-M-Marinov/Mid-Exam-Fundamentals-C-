using System;
using System.Collections.Generic;
using System.Linq;

namespace P2.CoffeeLover
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> coffeeList = Console.ReadLine().Split().ToList();
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<string> commands = new List<string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                commands = Console.ReadLine().Split().ToList();

                if (commands[0] == "Include")
                {
                    coffeeList.Add(commands[1]);
                }
                else if (commands[0] == "Remove")
                {
                    if (int.Parse(commands[2]) > coffeeList.Count)
                    {
                        continue;
                    }

                    if (commands[1] == "first")
                    {
                        for (int j = 0; j < int.Parse(commands[2]); j++)
                        {
                            coffeeList.Remove(coffeeList[0]);
                            
                        }
                    }
                    else if (commands[1] == "last")
                    {
                        int initialListCount = coffeeList.Count;
                        for (int j = coffeeList.Count-1; j >= initialListCount-int.Parse(commands[2]); j--)
                        {
                            coffeeList.RemoveAt(j);
                        }
                    }
                    
                }
                else if (commands[0] == "Prefer")
                {
                    if (int.Parse(commands[1]) <= coffeeList.Count && int.Parse(commands[2]) <= coffeeList.Count)
                    {
                        string switchCoffeeOne = coffeeList[int.Parse(commands[1])];
                        coffeeList[int.Parse(commands[1])] = coffeeList[int.Parse(commands[2])];
                        coffeeList[int.Parse(commands[2])] = switchCoffeeOne;
                    }

                }
                else if (commands[0] == "Reverse")
                {
                    coffeeList.Reverse();
                }
            }

            Console.WriteLine("Coffees:");
            Console.WriteLine(string.Join(" ", coffeeList));
        }
    }
}
