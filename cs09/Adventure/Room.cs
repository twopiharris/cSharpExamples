using System;

namespace Adventure
{
	/// <summary>
	/// Basic Data class for Adventure Game.
	/// Dungeon uses an array of these
	/// No methods, just a bunch of properties
	/// Andy Harris, 3/11/02
	/// </summary>
	[Serializable]
	
	public class Room
	{

    private string pName;
    private string pDescription;
    private int pNorth;
    private int pEast;
    private int pSouth;
    private int pWest;

    //Properties
    public string Name {
      set {
        pName = value;
      } // end set
      get {
        return pName;
      } // end get
    } // end Name prop  
	    
    public string Description {
      set {
        pDescription = value;
      } // end set
      get {
        return pDescription;
      } // end get
    } // end Description prop  
	    
    public int North {
      set {
        pNorth = value;
      } // end set
      get {
        return pNorth;
      } // end get
    } // end North prop  
	    
    public int East {
      set {
        pEast = value;
      } // end set
      get {
        return pEast;
      } // end get
    } // end East prop  
	    
    public int South {
      set {
        pSouth = value;
      } // end set
      get {
        return pSouth;
      } // end get
    } // end South prop  
	    
    public int West {
      set {
        pWest = value;
      } // end set
      get {
        return pWest;
      } // end get
    } // end West prop  
	  
	  
	  //Constructor  
		public Room(string name,
		            string description,
		            int north,
		            int east,
		            int south,
		            int west) {
      Name = name;
      Description = description;
      North = north;
      East = east;
      South = south;
      West = west;
		} // end constructor
	} // end class def
} // end namespace
