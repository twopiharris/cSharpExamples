/*
  ExceptDemo
  Demonstrate exceptions
*/

using System;

public class ExceptDemo {
  public static void Main(){
    new ExceptDemo();
  } // end main

  public ExceptDemo(){
    int x = 1;
    int y = 1;
    double quotient = 1;
    int remainder = 1;

    bool keepGoing = true;
    while (keepGoing){
      try {
        keepGoing = false;
        Console.Write("Please enter a number: ");
        x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Another number: ");
        y = Convert.ToInt32(Console.ReadLine());

        quotient = x / y;
        remainder = x % y;

      } catch (FormatException){
        Console.WriteLine("That isn't a number. Try again...");
        keepGoing = true;   
 
      } catch (DivideByZeroException){
        Console.WriteLine("you can't divide by zero. Try again");
        keepGoing = true;

      } catch (Exception e){
        Console.WriteLine(e);
        keepGoing = true;

      } // end try


    } // end while

    Console.WriteLine("{0} / {1} = {2} remainder {3}", x, y, quotient, remainder);

  } // end constructor

} // end class def


