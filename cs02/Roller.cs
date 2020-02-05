using System;

namespace Roller
{
	/// <summary>
	/// Demonstrates creation of a random number
	/// Andy Harris, 11/10/01
	/// </summary>
	class Class1
	{
		static void Main(string[] args)
		{
      double raw;
      double big;
      double bigger;
      int die;
      Random generator = new Random();

      raw = generator.NextDouble();
      Console.WriteLine("raw: {0}", raw);

      big = raw * 6;
      Console.WriteLine("big: {0}", big);

      bigger = big + 1;
      Console.WriteLine("bigger: {0}", bigger);
      
      die = (int)big;
      Console.WriteLine("die: {0}", die);
      
      //do it all in one step
      die = (int)(generator.NextDouble() * 6) + 1;
      Console.WriteLine("another die: {0}", die);


      // or, just use next to get an int.
      die = generator.Next(1, 7);
      Console.WriteLine("yet another: {0}", die);

      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine("Please press enter key to quit");
      Console.ReadLine();
    }
	}
}
