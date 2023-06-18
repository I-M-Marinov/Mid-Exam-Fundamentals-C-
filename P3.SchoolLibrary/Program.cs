using System;
using System.Collections.Generic;
using System.Linq;

namespace P3.SchoolLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> bookList = Console.ReadLine().Split("&").ToList();

            while (true)
            {
                List<string> commandList = Console.ReadLine().Split(" | ").ToList();

                if (commandList[0] == "Done")
                {
                    break;
                }

                if (commandList[0] == "Add Book")
                {
                    if (!bookList.Contains(commandList[1]))
                    {
                        bookList.Insert(0, commandList[1]);
                    }
                }
                else if (commandList[0] == "Take Book")
                {
                    if (bookList.Contains(commandList[1]))
                    {
                        bookList.Remove(commandList[1]);
                    }
                }
                else if (commandList[0] == "Swap Books")
                {
                    if (bookList.Contains(commandList[1]) && bookList.Contains(commandList[2]))
                    {
                        string swapBookOne = commandList[1];
                        string swapBookTwo = commandList[2];
                        int index1 = bookList.IndexOf(commandList[1]);
                        int index2 = bookList.IndexOf(commandList[2]);
                        bookList[index2] = swapBookOne;
                        bookList[index1] = swapBookTwo;
                    }
                }
                else if (commandList[0] == "Insert Book")
                {
                    if (!bookList.Contains(commandList[1]))
                    {
                        bookList.Add(commandList[1]);
                    }
                }
                else if (commandList[0] == "Check Book")
                {
                    if ((int.Parse(commandList[1]) >= 0 && (int.Parse(commandList[1]) < bookList.Count)))
                    {
                        string bookName = bookList[int.Parse(commandList[1])];
                        int bookIndex = bookList.IndexOf(bookName);
                        Console.WriteLine($"{bookList[bookIndex]}");
                    }
                }
            }
            Console.WriteLine(string.Join(", ", bookList));
        }
    }
}
