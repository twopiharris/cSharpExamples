using System;

namespace Adventure
{
	/// <summary>
	/// Class for storing a dungeon.  Mainly holds an array of rooms.
	/// Designed to be stored in a serial form.
	/// 3/11/02, Andy Harris
	/// </summary>
	
	[Serializable]
	public class Dungeon
	{
    private string pName;
    private int pNumRooms = 20;
    private Room[] pRooms;
    
		public string Name {
		  set {
		    pName = value;
		  } // end set
		  get {
		    return pName;
		  } // end get
		} // end name property

		public int NumRooms {
		  //no set - make it read-only
		  get {
		    return pNumRooms;
		  } // end get
		} // end numRooms property
		
    public Room[] Rooms{
      set {
        pRooms = value;
      } // end set
      get {
        return pRooms;
      } // end get
    } // end property
    
    public Dungeon(){
			Rooms = new Room[pNumRooms];
		} // end constructor
	}  // end class def
} // end namespace
