using System;

namespace AreYouBill {
  /// <summary>
  /// Demonstrates the If Statement
  /// </summary>
  class AreYouBill {
    static void Main(string[] args) {
      string fullName;
      
      Console.Write("Please enter your full name: ");
      fullName = Console.ReadLine();

      //basic if statement
      if (fullName == "Bill Gates") {
        Console.WriteLine("Nice job on C#, Bill.");
      } // end if
      
      //if - else - statement
      if (fullName == "Bill Gates") {
        Console.WriteLine("C# is pretty cool");
      } else {
        Console.WriteLine("Sorry, I was looking for Bill");
      } // end if
      
      //if - else if structure
      if (fullName == "Bill Gates") {
        Console.WriteLine("C# is pretty cool");
      } else if (fullName == "James Gosling"){
        Console.WriteLine("Java is pretty cool");
      } else {
        Console.WriteLine("Nice to see you, {0}!", fullName);
      } // end if

      //hold for user response
      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine("Please press \"enter\" to continue");
      Console.ReadLine();
      
    } // end main
  } // end class
} // end namespace
