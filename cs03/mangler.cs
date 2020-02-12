using System;

namespace StringMangler
{
	/// <summary>
	/// Demonstrates some of the methods of the String object
	/// by Andy Harris, 11/16/01
	/// </summary>
	class mangler
	{
		static void Main(string[] args)
		{
      string theString = "C# Programming for Absolute Beginners";
      Console.WriteLine("default: \t {0}", theString);
      Console.WriteLine("lowercase: \t {0}", theString.ToLower());
      Console.WriteLine("uppercase: \t {0}", theString.ToUpper());
      Console.WriteLine("replace: \t {0}", theString.Replace("#", "sharp"));
      Console.WriteLine("length: \t {0}", theString.Length);
      Console.WriteLine("\"for\" occurs at character {0}", theString.IndexOf("for"));
      
      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine("Please press enter key to quit");
      Console.ReadLine();

		} // end main
	} // end class
} // end namespace
