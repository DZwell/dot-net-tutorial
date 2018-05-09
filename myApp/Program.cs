using System;
using System.Collections.Generic;

namespace list_quickstart
{
  class Program
  {
    static void Main(string[] args)
    {
      WorkingWithStrings();
    }

    public static void WorkingWithStrings()
    {
      var names = new List<string> { "dzwell", "Ana", "Felipe" };

      names.Add("Maria");
      names.Add("Justo");
      names.Remove("Ana");

      foreach (var name in names)
      {
        Console.WriteLine($"Hello {name.ToLower()}!");
      }
      Console.WriteLine($"Name at index 0 is {names[0]}");
      Console.WriteLine($"There are {names.Count} people in the list");
    }
  }
}