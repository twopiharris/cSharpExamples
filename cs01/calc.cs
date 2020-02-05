// calc.cs
// a basic calcualtor
// illustrates i/o, data types,

using System;

public class Calc {
  public static void Main(string[] args){
    new Calc();
  } // end Main

  public Calc(){
    Console.Write("X: ");
    string xString = Console.ReadLine();
    Console.Write("Y: ");
    string yString = Console.ReadLine();

    int x = Convert.ToInt32(xString);
    int y = Convert.ToInt32(yString);

    Console.WriteLine($"{x} + {y} = {x + y}");
    Console.WriteLine($"{x} - {y} = {x - y}");
    Console.WriteLine($"{x} * {y} = {x * y}");
    Console.WriteLine($"{x} / {y} = {x / y}");
    Console.WriteLine($"{x} % {y} = {x % y}");
    Console.WriteLine($"{x} / {y} = {Convert.ToDouble(x) / y}");
  } // end constructor
} // end class def

