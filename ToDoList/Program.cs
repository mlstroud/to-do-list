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
        userSelection = GetUserInput().ToLower();
        ValidateInput(userSelection);
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

    public static void ValidateInput(string input)
    {
      switch (input)
      {
        case "add":
          AddItem();
          break;
        case "view":
          ViewList();
          break;
        default:
          Console.WriteLine("Sorry, that was not a valid option.");
          break;
      }
    }

    public static void AddItem()
    {
      Console.WriteLine("Please enter the description for your new task: ");
      string newTask = Console.ReadLine();

      Item item = new Item(newTask);
    }
  }
}