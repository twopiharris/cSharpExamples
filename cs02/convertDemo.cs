using System;

namespace ConvertDemo 
{

  ///<summary>
  /// demonstrates various types of variable conversions
  /// Andy Harris, 11/09/01
  ///</summary>

  class ConvertDemo 
  {
    static void Main()
    {
      int myInt;
      double myDouble;
      string myString;

      myInt = 5;

      //copying an int to a double causes no problems
      myDouble = myInt;
      Console.WriteLine("myDouble is {0}.", myDouble);
      
      //copying a double to an int won't work!
      myDouble = 3.5;
      //myInt = myDouble;    //this line causes an error
      //Console.WriteLine(myInt);

      //You can explicitly cast, but you'll lose data
      myInt = (int)myDouble;
      Console.WriteLine("After casting, myInt = {0}.", myInt);

      myString = myDouble.ToString();
      myString = Convert.ToString(myDouble);
      Console.WriteLine("myDouble as a String: {0}", myString);

      Console.Write("Please enter a number: ");
      myString = Console.ReadLine();

      Console.WriteLine("myString converted to double: {0}", Convert.ToDouble(myString));
      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine("Please press enter to continue");
      Console.ReadLine();

    } // end main
  } // end class
} // end namespace



