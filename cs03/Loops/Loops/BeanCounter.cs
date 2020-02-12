using System;

namespace BeanCounter
{
	/// <summary>
	/// Repeats a simple task a number of times
	/// Demonstrates the basic for loop
	/// Andy Harris, 11/29/01
	/// </summary>
	class Counter
	{
		static void Main(string[] args)
		{
			int beanNumber;
			for (beanNumber = 1; beanNumber <= 10; beanNumber++){
			  Console.WriteLine("bean {0}", beanNumber);
			} // end for
			
      Console.WriteLine();
      Console.WriteLine("press enter key to quit");
      Console.ReadLine();
			
		} // end main
	} // end class
} // end namespace
