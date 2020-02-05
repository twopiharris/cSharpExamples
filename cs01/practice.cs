// practice.cs
// allow us to practice variables and data

using System;

public class Practice {
  public static void Main(string[] args){
    new Practice();
  } // end Main

  public Practice(){
    Console.WriteLine("Hello, World!");

    Console.Write("Please enter a value for x: ");
    string xString = Console.ReadLine();
    int x = Convert.ToInt32(xString);

    Console.Write("Please enter a value for y: ");
    int y = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"You entered {x} for x and {y} for y");

    Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
    Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
    Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
    Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
    Console.WriteLine("{0} % {1} = {2}", x, y, x % y);
    Console.WriteLine("{0} / {1} = {2}", x, y, x / (double)(y));

  } // end practice
} // class

