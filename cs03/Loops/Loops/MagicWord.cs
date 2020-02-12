using System;

namespace magicWord
{
	/// <summary>
	/// Demonstrate while loops by asking for the magic word 
	/// until user enters the correct answer
	/// Andy Harris, 11/25/01
	/// </summary>
	class MagicWord
	{
		static void Main(string[] args)
		{
			string theAnswer = "oogieboogie";
			string response = "";

      Console.WriteLine("You seek a magic treasure, but a bridge is in your path.");
      Console.WriteLine("A troll stands at the bridge and refuses to let you pass.");

			while (response != theAnswer){
			  Console.Write("The troll asks \"What's the magic word?\" ");
			  response = Console.ReadLine();
			  if (response != theAnswer){
			    Console.WriteLine("That's not it, Human!...  Try again.");
			  } // end if
			} // end while
			
			Console.WriteLine("The troll reluctantly lets you pass.");
			Console.WriteLine("You find the magic treasure.");
      Console.WriteLine();
      Console.WriteLine();
      
      Console.WriteLine("Please press enter to continue");
      Console.ReadLine();

		} // end main
	} // end class
} // end namespace
