using System;

namespace classes {
  class Program {
    static void Main (string[] args) {
      var account = new BankAccount ("Me", 1000);
      Console.WriteLine ($"Account owner: {account.Owner}\nAccount number: {account.Number}\nBalance: {account.Balance}");
    }
  }
}