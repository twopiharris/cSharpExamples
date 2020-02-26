using System;

namespace CritOver
{
	/// <summary>
	/// Demonstrates overloaded constructors
	/// </summary>
	class CritViewer
	{
		static void Main(string[] args)
		{
			CritViewer cv = new CritViewer();
		} // end main
		
		public CritViewer(){
		  //Create some critters
		  Critter alpha = new Critter("alpha", 10, 10, 0);
		  Critter beta = new Critter("beta");
		  Critter charlie = new Critter();
		  
		  //Make 'em talk
		  Console.WriteLine(alpha.talk());
		  Console.WriteLine(beta.talk());
		  Console.WriteLine(charlie.talk());
		  Console.ReadLine();
		} // end constructor
	}
}
