using System;

namespace CritterMenu {
  /// <summary>
  /// Critter Menu
  /// Build a basic menu structure
  /// Andy Harris, 12/13/01
  /// </summary>
  class Menu {
    static void Main(string[] args) {
      bool keepGoing = true;
      int choice;
      
      while (keepGoing){
        choice = showMenu();
        switch (choice){
          case 0:
            keepGoing = false;
            break;
          case 1:
            Console.WriteLine("you talk to the critter");
            break;
          case 2:
            Console.WriteLine ("You have fed the critter");
            break;
          case 3:
            Console.WriteLine("You have played with the critter");
            break;
          case 4:
            Console.WriteLine("You have renamed the critter");
            break;
          default:
            Console.WriteLine("That was not a valid input");
            break;
        } // end switch
      } // end while loop                  
    } // end main
		
    static int showMenu(){
      int input = 1;
      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine("0) Exit");
      Console.WriteLine("1) Listen to Critter");
      Console.WriteLine("2) Feed Critter");
      Console.WriteLine("3) Play with Critter");
      Console.WriteLine("4) Rename Critter");
      try {
        input = Convert.ToInt32(Console.ReadLine());
      } catch (FormatException) {
        Console.WriteLine("Incorrect input");
        input = 1;
      } // end try
      return input;
    } // end showMenu
  } // end class
} // end namespace
