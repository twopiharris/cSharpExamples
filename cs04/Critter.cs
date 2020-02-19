using System;

namespace Critter {
  /// <summary>
  /// Critter
  /// Demonstrates basic OOP principles including properties and methods
  /// Andy Harris, 12/13/01
  /// </summary>
  class Menu {
    static void Main(string[] args) {
      bool keepGoing = true;
      int choice;
      Critter myCritter = new Critter();
      myCritter.name = "George";
      
      while (keepGoing){
        myCritter.age();
        choice = showMenu();
        switch (choice){
          case 0:
            keepGoing = false;
            break;
          case 1:
            Console.WriteLine(myCritter.talk());
            break;
          case 2:
            myCritter.eat();
            Console.WriteLine ("You have fed the critter");
            break;
          case 3:
            myCritter.play();
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
    private int pFull = 10;
    private int pHappy = 10;
    private int pAge = 0;
    
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

    public string talk(){
      string message;
      message = "The critter says: \n";
      
      if (pHappy > 5) {
        message += "  Hi!  My name is " + name + "\n";
        message += "  I feel happy today! \n";
      } else if (pHappy > 2) {
        message += "  " + name + " doesn't feel so good...";
      } else if (pHappy > 0) {
        message += "  " + name + " is MAD...";
      } else {
        message += " ...nothing at all, but lays in a heap.";
      } // end if
      return message;
    } // end talk

    public void age(){
      //handles aging the critter
      pAge++;
      pFull--;
      pHappy--;
      
      if (pFull < 3) {
        //if hungry, accellerate unhappiness
        pHappy--;
      } // end if
    } // end age
    
    public void play(){
      pHappy += 3;
    } // play
    
    public void eat(){
      pFull += 4;  
    } // end eat
          
  } // end class
} // end namespace
