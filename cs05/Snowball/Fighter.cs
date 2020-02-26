using System;

namespace Snowball
{
	/// <summary>
	/// Basic Snowball fighter
	/// </summary>
	public class Fighter
	{
    //instance variables
    private int pStrength;
    private int pSnowballs;
    private string pName;

    //properties
    public int strength {
      get {
        return pStrength;
      } // end get
      set {
        pStrength = value;
      } // end set
    } // end strength
    
    public int snowballs {
      get {
        return pSnowballs;
      } // end get
      set {
        pSnowballs = value;
      } // end set
    } // end snowballs
    
   public string name {
     get {
       return pName;
     } // end get
     set {
       pName = value;
     } // end set
   } // end name
 
  public Fighter(string theName)
		{
      //initialize
      snowballs = 3;
      strength = 3;
      name = theName;     
		} // end constructor

    public bool throwSnow(int range){
      //calculates likeliness of a hit at a given range
      //returns true if snowball hit
      
      bool hit = false;
      int myRoll;
      Random roller = new Random();
      if (snowballs <= 0) {
        Console.WriteLine ("{0} is out of snowballs!", name);
      } else {
        myRoll = roller.Next(10);
        if (myRoll > range) {
          hit = true;
	      } // end hit if
        snowballs--;
      } // end out of snowballs if
	    return hit;
	  } // end throwSnow method	
	} // end fighter
} // end namespace
