using System;

namespace CritterProp {
  /// <summary>
  /// Critter Name
  /// Changing name to a property
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
            myCritter.talk();
            break;
          case 2:
            Console.WriteLine ("You have fed the critter");
            break;
          case 3:
            Console.WriteLine("You have played with the critter");
            break;
          case 4:
            Console.WriteLine("Current name: {0}", myCritter.name);
            Console.Write("Change name to: ");
            myCritter.name = Console.ReadLine();
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
    private string pName;
    
    public string name {
      get {
        return pName;
      } // end get
      set{
        if (value.Length > 8){
          Console.WriteLine("The name can't be more than 8 characters");
          pName = value;
          pName = pName.Substring(0,8);
          Console.WriteLine("Changing name to {0}", pName);
        } else {
          pName = value;
        } // end if
      } // end set
    } // end string property  
     
    
    public void talk(){
      Console.WriteLine("The Critter says: My name is {0}", name);
    } // end talk
    
  } // end class
  
} // end namespace
