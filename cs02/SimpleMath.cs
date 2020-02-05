using System;

namespace SimpleMath
{
	/// <summary>
	/// Demonstrates basic variable stuff
	/// Andy Harris, 11/09/01
	/// </summary>
	class DoMath
	{
		static void Main(string[] args)
		{
      int a = 1;
      int b = 2;
      float c = 2.4f;
      float d = 4.7f;
      Console.WriteLine("Math Demo");
      Console.WriteLine();
      Console.WriteLine();

      //addition with integers works as expected      
      Console.WriteLine("5 + 4 = {0}", 5 + 4);
      Console.WriteLine("{0} + {1} = {2}", a, b, a + b);

      //division by integers can cause problems
      Console.WriteLine("5 / 4 = {0}", 5 / 4);
      //don't forget modulus to include remainder of integer division
      Console.WriteLine("5 % 4 = {0}", 5 % 4);
      
      //dividing by floating point values works better
      Console.WriteLine("{0} / {1} = {2}", c, d, c/d);
      Console.WriteLine("5f / 4f = {0}", 5f / 4f);
      
      Console.WriteLine();
      Console.WriteLine();
      Console.Write("Please press \"enter\" to continue");
      Console.ReadLine();
      
		} // end main
	} // end class
} // end namespace
