using System;

namespace CritClone
{
	/// <summary>
	/// Another Critter Viewer
	/// This one demonstrates inheritance by making a clone
	/// Andy Harris, 12/21/01
	/// </summary>
	class CritViewer
	{
		static void Main(string[] args)
		{
			CritViewer cv = new CritViewer();
		} // end main
		
		public CritViewer(){
		  Clone myClone = new Clone();
		  myClone.name = "Dolly";
		  Console.WriteLine(myClone.talk());
		  
		  Console.WriteLine("Please press Enter to continue");
		  Console.ReadLine();
		} // end constructor
	} // end CritViewer class
} // end namespace
