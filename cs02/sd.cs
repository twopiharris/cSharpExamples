using System;

namespace SwitchDemo
{
	/// <summary>
	/// Demonstrates use of the Switch structure
	/// Andy Harris, 11/10/01
	/// </summary>
	class SwitchDemo
	{
		static void Main(string[] args)
		{
      string fullName;
      string greeting;

      //get name from user
      Console.Write("Please Enter your full name: ");
      fullName = Console.ReadLine();
      
      //check name
      switch (fullName){
        case "Bill Gates":
          greeting = "Great job on C#";
          break;
        case "James Gosling":
          greeting = "That Java thing is really cool";
          break;
        case "Alan Turing":
          greeting = "The Turing machine was pretty amazing";
          break;
        case "Grace Hopper":
          greeting = "Wow.  You discovered the first computer bug!";
          break;
        default:
          greeting = "We're waiting for your contribution to computer science, " + fullName;
          break;
      } // end switch

      //write response
      Console.WriteLine(greeting);
      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine("Press \"enter\" to continue");
      Console.ReadLine();
    } // end main
	} // end class
} // end namespace
