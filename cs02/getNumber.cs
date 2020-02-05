using System;

namespace GetNumber
{
	/// <summary>
	/// Demonstrates retrieving a number from the console
	/// </summary>
	class GetNumber
	{
		static void Main(string[] args)
		{
      int num1;
      int num2;
      
      Console.Write("First Number: ");
      num1 = Convert.ToInt32(Console.ReadLine());    
      
      Console.Write("Second Number: ");
      num2 = Convert.ToInt32(Console.ReadLine());
      
      Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
      
      Console.WriteLine("Press \"enter\" to finish");
      Console.ReadLine();
		} // end main
	} // end class
} // end namespace
