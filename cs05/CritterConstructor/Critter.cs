using System;

namespace CritterConstructor
{
	/// <summary>
	/// Critter with a constructor
	/// </summary>
	
    public class Critter {
      // your basic critter
    
      //instance variables
      private string pName;
      private int pFull = 10;
      private int pHappy = 10;
      private int pAge = 0;
    
      //constructor
      public Critter(string theName, int fullness, int happiness, int theAge){
        name = theName;
        pFull = fullness;
        pHappy = happiness;
        pAge = theAge;
      } // end constructor
    
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
        message = name + " says: \n";
      
        if (pHappy > 5) {
          message += "  I feel happy today! \n";
        } else if (pHappy > 2) {
          message += "  " + name + " doesn't feel so good...\n";
        } else if (pHappy > 0) {
          message += "  " + name + " is MAD... \n";
        } else {
          message += " ...nothing at all, but lays in a heap.\n";
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

}
