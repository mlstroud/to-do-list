using System;
using ToDoList.Models;

namespace ToDoList
{
  public class Program
  {
    public static void Main()
    {
      string userSelection = "";

      while (userSelection != "quit")
      {
        Greet();
        userSelection = GetUserInput();
      }
    }

    public static void Greet()
    {
      Console.WriteLine("Welcome, would you like to add an item or view your list? (Add/View)");
      Console.WriteLine("--------------------------------------------------------------------");
    }

    public static string GetUserInput()
    {
      string userInput = Console.ReadLine();
      return userInput;
    }
  }
}