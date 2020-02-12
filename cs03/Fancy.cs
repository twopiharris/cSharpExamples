using System;

namespace fancyBean
{
	/// <summary>
	/// Demonstrates a number of variations of the for loop
	/// Andy Harris, 11/29/01
	/// </summary>
	class fancyBean
	{
		static void Main(string[] args)
		{
			int i;
			string sentence = "Count those fancy beans";
			
			//counting by fives
      Console.WriteLine("Counting by fives:");
			for(i = 0; i < 100; i += 5){
        Console.Write(i + "\t");
      } // end for loop
      Console.WriteLine();
      Console.WriteLine();
			
			//count backwards
			Console.WriteLine("Counting backwards:");
			for(i = 10; i > 0; i--){
        Console.Write("{0} ", i);
      } // end for loop
      Console.WriteLine();
      Console.WriteLine();
      
      //demonstrate foreach loop
      Console.WriteLine("Getting words in a sentence");
      foreach (string word in sentence.Split()){
        Console.WriteLine(word);
      } // end foreach
      Console.WriteLine();
      Console.WriteLine();
			
      Console.WriteLine("Please press enter key to continue");
      Console.ReadLine();

		} // end main
	} // end class
} // end namespace
