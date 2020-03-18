/* ExceptDemo.cs
   demonstrate exceptions
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

    try {
      Console.Write("Please enter a number: ");
      x = Convert.ToInt32(Console.ReadLine());

      Console.Write("Another number: ");
      y = Convert.ToInt32(Console.ReadLine());

      quotient = x / y;

    } catch (FormatException e) {
      Console.WriteLine("That was not a legal number. I'll change it to one");
      x = 1;
      y = 1;

    } catch (DivideByZeroException e){
      Console.WriteLine("You cannot divide by zero. Changing y to 1");
      y = 1;

    } catch (Exception e) {
      // some unknown exception happened!
      Console.WriteLine(e.ToString());

    } // end try

    Console.WriteLine("{0} / {1} = {2}", x, y, quotient);

  } // end constructor

} // end class def
