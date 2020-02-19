using System;

namespace CritterName {
  /// <summary>
  /// Critter Name
  /// Creating a simple class 
  /// Andy Harris, 12/13/01
  /// </summary>
  class Menu {
    static void Main(string[] args) {
      bool keepGoing = true;
      int choice;
      Critter myCritter = new Critter();
      myCritter.name = "George";
      
      while (keepGoing){
        choice = showMenu();
        switch (choice){
          case 0:
            keepGoing = false;
            break;
          case 1:
            Console.WriteLine("The critter says: my name is {0}", myCritter.name);
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
      } // end try
      return input;
    } // end showMenu
  } // end class
	
  class Critter {
    public string name;
  } // end class
  
} // end namespace
