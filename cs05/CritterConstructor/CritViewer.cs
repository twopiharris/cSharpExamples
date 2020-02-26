using System;

namespace CritterConstructor
{
	/// <summary>
	/// CritViewer is a simple class designed simply to hold a critter
	/// Demonstrates self-instantiation
  /// Andy Harris, 12/21/01
	/// </summary>
	class CritViewer
	{
		static void Main(string[] args)
		{
			// the main method simply creates an instance of the 
			/// critviewer object
			CritViewer cv = new CritViewer();
		} // end main
		
		//This next method is the constructor for CritViewer
		public CritViewer(){
		  Critter myCritter = new Critter("alpha", 10, 10, 0);
		  Console.WriteLine("I'm in critViewer");
          Console.WriteLine(myCritter.talk());

          Console.WriteLine();
          Console.WriteLine("Please press Enter key to continue");
		  Console.ReadLine();
		} // end constructor
	} // end CritViewer Class
} // end namespace
